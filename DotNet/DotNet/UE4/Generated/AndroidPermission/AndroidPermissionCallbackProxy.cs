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
using UE4.AndroidPermission.Native;

namespace UE4.AndroidPermission {
    ///<summary>Android Permission Callback Proxy</summary>
    public unsafe partial class AndroidPermissionCallbackProxy : UObject  {
         //TODO: multicast delegate FAndroidPermissionDynamicDelegate OnPermissionsGrantedDynamicDelegate
        static AndroidPermissionCallbackProxy() {
            StaticClass = Main.GetClass("AndroidPermissionCallbackProxy");
        }
        internal unsafe AndroidPermissionCallbackProxy_fields* AndroidPermissionCallbackProxy_ptr => (AndroidPermissionCallbackProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AndroidPermissionCallbackProxy(IntPtr p) => UObject.Make<AndroidPermissionCallbackProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AndroidPermissionCallbackProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AndroidPermissionCallbackProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
