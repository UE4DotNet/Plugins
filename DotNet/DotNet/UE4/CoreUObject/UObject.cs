using System;
using System.Collections.Generic;
using System.Diagnostics;
using UE4.Core;
using UE4.Engine;

namespace UE4.CoreUObject {
    /// <summary>
    /// A UObject is a holder for a UE4 UObject* to manage its
    /// lifetime in the CLR.
    /// </summary>
    public partial class UObject {
        private static readonly object UObjectLock = new object();
        private static readonly Dictionary<IntPtr, WeakReference<UObject>> UObjectMap = new Dictionary<IntPtr, WeakReference<UObject>>();

        public static Package TransientPackage => Main.GetTransientPackage();

        /// <summary>
        /// Changes the C# type of a native object.  The old object should not be used after this call
        /// </summary>
        /// <typeparam name="T">New type of object</typeparam>
        /// <param name="o">object to change</param>
        /// <returns></returns>
        public static T CastTo<T>( UObject o ) where T : UObject, new() {
            T newO;
            bool isNew;
            lock (UObjectLock) 
                (newO, isNew) =  CastToInternal<T>( o );
            if (isNew)
                newO.Construct();
            return newO;
        }

        private static (T obj, bool isNew) CastToInternal<T>( UObject o ) where T : UObject, new() {
            var uObjectPtr = o.ObjPointer;
            RemoveObject( o );
            return MakeInternal<T>( uObjectPtr );
        }

        protected static UObject CastTo( UObject o, Type type ) {
            UObject newO;
            lock (UObjectLock) {
                var uObjectPtr = o.ObjPointer;
                RemoveObject( o );
                newO = MakeInternal( uObjectPtr, type );
            }
            newO.Construct();
            return newO;
        }

        protected static void RemoveObject( UObject o ) {
            var uObjectPtr = o.ObjPointer;
            if (UObjectMap.TryGetValue( uObjectPtr, out WeakReference<UObject> uObjectRef )) {
                if (uObjectRef.TryGetTarget( out UObject uObject )) {
                    Debug.Assert( uObject.ObjPointer == uObjectPtr );
                    UObjectMap.Remove( uObjectPtr );
                } else
                    // UObject has been garbage collected, so remove and add new one.
                    UObjectMap.Remove( uObjectPtr );
            }
        }

        internal static T Make<T>( IntPtr uObjectPtr ) where T : UObject, new() {
            T newO;
            bool isNew;
            lock (UObjectLock) 
                (newO, isNew) = MakeInternal<T>( uObjectPtr );
            if (isNew)
                newO.Construct();
            return newO;
        }


        internal unsafe static T MakeFromByte<T>( byte* b ) where T : UObject, new() =>
           Make<T>( new IntPtr( b ) );

        public static implicit operator IntPtr( UObject o ) => o != null ? o.ObjPointer : IntPtr.Zero;

        internal static UObject Make( IntPtr uObjectPtr, Type type ) {
            UObject newO;
            lock (UObjectLock)
                newO = MakeInternal( uObjectPtr, type );
            newO.Construct();
            return newO;
        }

        private static UObject MakeInternal( IntPtr uObjectPtr, Type type ) {
            if (UObjectMap.TryGetValue( uObjectPtr, out WeakReference<UObject> uObjectRef )) {
                if (uObjectRef.TryGetTarget( out UObject uObject )) {
                    Debug.Assert( uObject.ObjPointer == uObjectPtr );
                    return uObject;
                }

                // UObject has been garbage collected, so remove and add new one.
                UObjectMap.Remove( uObjectPtr );
            }

            var newUObject = (UObject) Activator.CreateInstance(type);
            newUObject.Set( uObjectPtr );
            uObjectRef = new WeakReference<UObject>( newUObject );
            UObjectMap.Add( uObjectPtr, uObjectRef );
            Main.ShareObject( uObjectPtr );
            return newUObject;
        }

//        private static void AddToSharedObjects( IntPtr uObjectPtr ) {
//            Debug.Assert( uObjectPtr != IntPtr.Zero );
//            var instance = Main.GameInstance;
//            if (instance != null) {
//                if (instance.ObjectsSharedWithDotNet.Count == 0 ||
//                    instance.FirstFreeShared >= instance.ObjectsSharedWithDotNet.Count) {
//                    instance.ObjectsSharedWithDotNet.Add( uObjectPtr );
//                    instance.FirstFreeShared = instance.ObjectsSharedWithDotNet.Count;
//#if DEBUG
//                    if (instance.ObjectsSharedWithDotNet.Count >= instance.MaxSharedPointerCount) {
//                        Log.Warning( $"Possible resize in DotNetGameInstance.ObjectsSharedWithDotNet.  Expected {instance.MaxSharedPointerCount} pointers, have {instance.ObjectsSharedWithDotNet.Count} pointers." );
//                        Log.Warning( "For best performance, override DotNetGameInstance.MaxSharedPointerCount and set to the maximum number of pointers" );
//                    }
//#endif
//                } else {
//                    Debug.Assert( instance.ObjectsSharedWithDotNet[instance.FirstFreeShared] == IntPtr.Zero );
//                    instance.ObjectsSharedWithDotNet[instance.FirstFreeShared] = uObjectPtr;
//                    while (++instance.FirstFreeShared < instance.ObjectsSharedWithDotNet.Count)
//                        if (instance.ObjectsSharedWithDotNet[instance.FirstFreeShared] == IntPtr.Zero) {
//                            break;
//                        }
//                }
//            } else {

//            }
//        }

        //private static void RemoveFromShared(IntPtr uObjectPtr) {
        //    var instance = Main.GameInstance;
        //    var i = instance.ObjectsSharedWithDotNet.Count - 1;
        //    for (; i >= 0; i--) {
        //        if (instance.ObjectsSharedWithDotNet[i] == uObjectPtr)
        //            break;
        //    }
        //    Debug.Assert( i >= 0 && uObjectPtr != IntPtr.Zero );
        //    instance.ObjectsSharedWithDotNet[i] = IntPtr.Zero;
        //    if (i < instance.FirstFreeShared)
        //        instance.FirstFreeShared = i;
        //}

        private static (T obj,bool isNew) MakeInternal<T>( IntPtr uObjectPtr ) where T : UObject, new() {
            if (UObjectMap.TryGetValue( uObjectPtr, out WeakReference<UObject> uObjectRef )) {
                if (uObjectRef.TryGetTarget( out UObject uObject )) {
                    Debug.Assert( uObject.ObjPointer == uObjectPtr );
                    if (typeof( T ) == uObject.GetType())
                        return ((T) uObject, false);
                    if (uObject.GetType().IsSubclassOf(typeof(T)))
                        return ((T) uObject, false);
                    if (typeof( T ).IsSubclassOf( uObject.GetType() ))
                        return CastToInternal<T>( uObject );
                    //Types don't match, discard this and get the new type
                }

                // UObject has been garbage collected, so remove and add new one.
                UObjectMap.Remove( uObjectPtr );
                Main.ReleaseObject( uObjectPtr );
            }

            T newUObject = new T();
            Main.ShareObject( uObjectPtr );
            newUObject.Set( uObjectPtr );
            uObjectRef = new WeakReference<UObject>( newUObject );
            UObjectMap.Add( uObjectPtr, uObjectRef );
            return (newUObject, true);
        }


        internal static void Release( UObject obj ) {
            lock (UObjectLock) {
                if (UObjectMap.TryGetValue( obj.ObjPointer, out WeakReference<UObject> uObjectRef )) {
                    if (uObjectRef.TryGetTarget( out UObject uObject )) {
                        if (uObject == obj)
                            UObjectMap.Remove( obj.ObjPointer );
                    } else
                        UObjectMap.Remove( obj.ObjPointer );
                }
                Main.ReleaseObject( obj.ObjPointer );
            }
        }

        internal static IntPtr NewObject( Class klass, UObject outer, Name name ) =>
            Main.NewObject( klass, outer ?? TransientPackage, name );

        internal static unsafe IReadOnlyCollection<T> ToUObjectCollection<T>( byte* arrayPtr ) where T : UObject, new() =>
            new UObjectCollection<T>( arrayPtr );

        internal static unsafe IReadOnlyCollection<T> ToUnmangedCollection<T>( byte* arrayPtr ) where T : unmanaged =>
            new UnmanagedCollection<T>( arrayPtr );

        internal static unsafe IReadOnlyCollection<string> ToStringCollection( byte* arrayPtr ) =>
            new FStringCollection( arrayPtr );

        protected unsafe ObjectArrayField<T> MakeObjectArrayField<T>( NativeArray* array ) where T : UObject, new() {
            return new ObjectArrayField<T>( array );
        }  

        public static T NotImplemented<T>() {
            throw new NotImplementedException();
        }

        internal void Set( IntPtr objPointer ) {
            ObjPointer = objPointer;
        }

        public virtual void Construct() { }

        public override int GetHashCode() =>  ObjPointer.GetHashCode();

        protected string GetName() {
            if (String.IsNullOrEmpty(_Name))
                _Name = KismetSystemLibrary.GetObjectName( this );
            return _Name;
        }

        public override string ToString() => GetName();

        public virtual string Name => GetName();

        protected static readonly Name _None;
        public static Name None => _None;

        ~UObject() {
            Release( this );
        }

        public IntPtr ObjPointer { get; private set; }

        private string _Name;
    }
}

