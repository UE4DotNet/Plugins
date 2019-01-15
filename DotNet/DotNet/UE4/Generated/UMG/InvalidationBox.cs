// Copyright 2018 by JCoder58.  See License.txt for license
// Auto-generated --- Do not modify.
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UE4.Core;
using UE4.CoreUObject;
using UE4.CoreUObject.Native;
using UE4.InputCore;
using UE4.Native;

#pragma warning disable CS0108
using UE4.UMG.Native;

namespace UE4.UMG {
    ///<summary>
    ///Invalidate
    ///* Single Child
    ///</summary>
    ///<remarks>* Caching / Performance</remarks>
    public unsafe partial class InvalidationBox : ContentWidget  {

        ///<summary>Get Can Cache</summary>
        public bool GetCanCache()  => 
            InvalidationBox_methods.GetCanCache_method.Invoke(ObjPointer);

        ///<summary>Invalidate Cache</summary>
        public void InvalidateCache()  => 
            InvalidationBox_methods.InvalidateCache_method.Invoke(ObjPointer);

        ///<summary>Set Can Cache</summary>
        public void SetCanCache(bool CanCache)  => 
            InvalidationBox_methods.SetCanCache_method.Invoke(ObjPointer, CanCache);
        public bool bCanCache {
            get {return Main.GetGetBoolPropertyByName(this, "bCanCache"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanCache", value); }
        }
        public bool CacheRelativeTransforms {
            get {return Main.GetGetBoolPropertyByName(this, "CacheRelativeTransforms"); }
        }
        static InvalidationBox() {
            StaticClass = Main.GetClass("InvalidationBox");
        }
        internal unsafe InvalidationBox_fields* InvalidationBox_ptr => (InvalidationBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InvalidationBox(IntPtr p) => UObject.Make<InvalidationBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InvalidationBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InvalidationBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
