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
using UE4.NUTUnrealEngine4.Native;
using UE4.NetcodeUnitTest;

namespace UE4.NUTUnrealEngine4 {
    ///<summary>
    ///Implements UTT GameplayDebuggingComponent/ServerReplicateData crash
    ///Command:
    ///    UTT -b 61 127.
    ///</summary>
    ///<remarks>
    ///0.0.1
    ///
    ///Documentation from Luigi:
    ///- TEST VULNERABILITY: ServerReplicateData array overflow
    ///####
    ///07 May 2014
    ///ServerReplicateData array overflow
    ///
    ///The ServerReplicateMessageToAIDebugView function used for some
    ///debugging features is affected by an array overflow with the
    ///InMessages: ActivateDataView and DeactivateDataView.
    ///
    ///This is the same function that was affected by the bug 55 reported
    ///the 27 March, anyway remember that it's NOT used in shipping builds.
    ///</remarks>
    public unsafe partial class UTT61_DebugReplicateData : ClientUnitTest  {
        static UTT61_DebugReplicateData() {
            StaticClass = Main.GetClass("UTT61_DebugReplicateData");
        }
        internal unsafe UTT61_DebugReplicateData_fields* UTT61_DebugReplicateData_ptr => (UTT61_DebugReplicateData_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UTT61_DebugReplicateData(IntPtr p) => UObject.Make<UTT61_DebugReplicateData>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UTT61_DebugReplicateData DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UTT61_DebugReplicateData New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
