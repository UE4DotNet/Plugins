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
using UE4.MagicLeapPrivileges.Native;

namespace UE4.MagicLeapPrivileges {
    ///<summary>Class which provides functions to check and request the priviliges the app has at runtime.</summary>
    public unsafe partial class MagicLeapPrivileges : UObject  {

        ///<summary>Check whether the application has the specified privilege.</summary>
        ///<remarks>
        ///This does not solicit consent from the end-user.
        ///@param Privilege The privilege to check.
        ///@return True if the privilege is granted, false otherwise.
        ///</remarks>
        public bool CheckPrivilege(EMagicLeapPrivilege Privilege)  => 
            MagicLeapPrivileges_methods.CheckPrivilege_method.Invoke(ObjPointer, Privilege);

        ///<summary>Request the specified privilege.</summary>
        ///<remarks>
        ///This may possibly solicit consent from the end-user.
        ///@param Privilege The privilege to request.
        ///@return True if the privilege is granted, false otherwise.
        ///</remarks>
        public bool RequestPrivilege(EMagicLeapPrivilege Privilege)  => 
            MagicLeapPrivileges_methods.RequestPrivilege_method.Invoke(ObjPointer, Privilege);
        static MagicLeapPrivileges() {
            StaticClass = Main.GetClass("MagicLeapPrivileges");
        }
        internal unsafe MagicLeapPrivileges_fields* MagicLeapPrivileges_ptr => (MagicLeapPrivileges_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapPrivileges(IntPtr p) => UObject.Make<MagicLeapPrivileges>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapPrivileges DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapPrivileges New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
