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
using UE4.Engine;

namespace UE4.AndroidPermission {
    ///<summary>Android Permission Function Library</summary>
    public unsafe partial class AndroidPermissionFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>try to acquire permissions and return a singleton callback proxy object containing OnPermissionsGranted delegate</summary>
        public static AndroidPermissionCallbackProxy AcquirePermissions(byte permissions /*TODO: array TArray */)  => 
            AndroidPermissionFunctionLibrary_methods.AcquirePermissions_method.Invoke(permissions);

        ///<summary>check if the permission is already granted</summary>
        public static bool CheckPermission(string permission)  => 
            AndroidPermissionFunctionLibrary_methods.CheckPermission_method.Invoke(permission);
        static AndroidPermissionFunctionLibrary() {
            StaticClass = Main.GetClass("AndroidPermissionFunctionLibrary");
        }
        internal unsafe AndroidPermissionFunctionLibrary_fields* AndroidPermissionFunctionLibrary_ptr => (AndroidPermissionFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AndroidPermissionFunctionLibrary(IntPtr p) => UObject.Make<AndroidPermissionFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AndroidPermissionFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AndroidPermissionFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
