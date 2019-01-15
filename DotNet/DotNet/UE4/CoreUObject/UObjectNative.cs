using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.Engine;
using UE4.Native;

namespace UE4.CoreUObject {
    internal delegate IntPtr LoadObjectDelegate( IntPtr klass, IntPtr outer, [MarshalAs( UnmanagedType.LPWStr )]string name, [MarshalAs( UnmanagedType.LPWStr )]string fileName, uint flags, IntPtr packageMap, bool bAllowObjectReconciliation );
    internal delegate IntPtr LoadClassDelegate( IntPtr klass, IntPtr outer, [MarshalAs( UnmanagedType.LPWStr )]string name, [MarshalAs( UnmanagedType.LPWStr )]string fileName, uint flags, IntPtr packageMap );
    internal delegate void RegisterComponentDelegate( IntPtr component );
    internal delegate IntPtr GetPropertyFromNameDelegate( IntPtr obj, Name name );
    internal delegate bool GetBoolPropertyValueDelegate( IntPtr container, IntPtr prop );
    internal delegate void SetBoolPropertyValueDelegate( IntPtr container, IntPtr prop, bool value );
    internal delegate float GetFloatPropertyValueDelegate( IntPtr container, IntPtr prop );
    internal delegate void SetFloatPropertyValueDelegate( IntPtr container, IntPtr prop, float value );

    [StructLayout( LayoutKind.Sequential, Pack = 0 )]
    internal struct UObjectNative {
        uint StartGuardian;
        uint SizeOfShared;
        int FNameID;

        internal IntPtr LoadObject;
        internal IntPtr LoadClass;
        internal IntPtr RegisterComponent;
        internal IntPtr UnregisterComponent;
        internal IntPtr GetPropertyFromName;
        internal IntPtr GetBoolPropertyValue;
        internal IntPtr SetBoolPropertyValue;
        internal IntPtr GetFloatPropertyValue;
        internal IntPtr SetFloatPropertyValue;

        uint EndGuardian;

        public void Validate() {
            var size = Marshal.SizeOf<UObjectNative>();
            Debug.Assert( StartGuardian == 0x12345678 &&
                EndGuardian == 0x87654321 &&
                SizeOfShared == size
                );
        }
    }

    public partial class UObject {
        public static UObject LoadObjectFromClass( Class objectClass, UObject outer, string name, string fileName = null, LoadFlags flags = LoadFlags.LOAD_None, PackageMap sandbox = null, bool bAllowObjectReconciliation = true ) {
            return Local.LoadObject( objectClass, outer, name, fileName, (uint) flags, sandbox, bAllowObjectReconciliation );
        }

        public static Class LoadClass( Class ofClass, UObject outer, string name, string fileName = null, LoadFlags flags = LoadFlags.LOAD_None, PackageMap sandbox = null) {
            return Local.LoadClass( ofClass, outer, name, fileName, (uint) flags, sandbox );
        }

        internal static void RegisterComponent( ActorComponent component ) =>
            Local.RegisterComponent( component );

        internal static void UnregisterComponent( ActorComponent component ) =>
            Local.UnregisterComponent( component );

        public T GetPropertyFor<T>( Name name ) where T : Property, new() {
            var prop = Local.GetPropertyFromName(this.ObjPointer, name);
            return Make<T>( prop );
        }

        internal static bool GetBoolPropertyValue( UObject container, BoolProperty prop ) =>
            Local.GetBoolPropertyValue( container, prop );

        internal static void SetBoolPropertyValue( UObject container, BoolProperty prop, bool value ) =>
            Local.SetBoolPropertyValue( container, prop, value );

        internal static float GetFloatPropertyValue( UObject container, FloatProperty prop ) =>
            Local.GetFloatPropertyValue( container, prop );

        internal static void SetFloatPropertyValue( UObject container, FloatProperty prop, float value ) =>
            Local.SetFloatPropertyValue( container, prop, value );


        private unsafe struct Local {
            public static UObjectNative* NativeFunctions;

            public static LoadObjectDelegate LoadObject;
            public static LoadClassDelegate LoadClass;
            public static RegisterComponentDelegate RegisterComponent;
            public static RegisterComponentDelegate UnregisterComponent;
            public static GetPropertyFromNameDelegate GetPropertyFromName;
            public static GetBoolPropertyValueDelegate GetBoolPropertyValue;
            public static SetBoolPropertyValueDelegate SetBoolPropertyValue;
            public static GetFloatPropertyValueDelegate GetFloatPropertyValue;
            public static SetFloatPropertyValueDelegate SetFloatPropertyValue;

            static Local() {
                NativeFunctions = (UObjectNative*) Interfaces.Get( Core.Name.Make( "UObject" ) ).ToPointer();
                Debug.Assert( NativeFunctions != null );
                NativeFunctions->Validate();
                LoadObject = Marshal.GetDelegateForFunctionPointer<LoadObjectDelegate>( NativeFunctions->LoadObject );
                LoadClass = Marshal.GetDelegateForFunctionPointer<LoadClassDelegate>( NativeFunctions->LoadClass );
                RegisterComponent = Marshal.GetDelegateForFunctionPointer<RegisterComponentDelegate>( NativeFunctions->RegisterComponent );
                UnregisterComponent = Marshal.GetDelegateForFunctionPointer<RegisterComponentDelegate>( NativeFunctions->UnregisterComponent );
                GetPropertyFromName = Marshal.GetDelegateForFunctionPointer<GetPropertyFromNameDelegate>( NativeFunctions->GetPropertyFromName );
                GetBoolPropertyValue = Marshal.GetDelegateForFunctionPointer<GetBoolPropertyValueDelegate>( NativeFunctions->GetBoolPropertyValue );
                SetBoolPropertyValue = Marshal.GetDelegateForFunctionPointer<SetBoolPropertyValueDelegate>( NativeFunctions->SetBoolPropertyValue );
                GetFloatPropertyValue = Marshal.GetDelegateForFunctionPointer<GetFloatPropertyValueDelegate>( NativeFunctions->GetFloatPropertyValue );
                SetFloatPropertyValue = Marshal.GetDelegateForFunctionPointer<SetFloatPropertyValueDelegate>( NativeFunctions->SetFloatPropertyValue );
            }
        }

    }
}
