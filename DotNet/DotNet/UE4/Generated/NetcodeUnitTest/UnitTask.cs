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
using UE4.NetcodeUnitTest.Native;

namespace UE4.NetcodeUnitTest {
    ///<summary>
    ///UnitTask's are used to implement supporting code for UnitTest's, for handling complex behind-the-scenes setup prior to test execution
    ///(e.
    ///</summary>
    ///<remarks>
    ///g. primarily for implementing game-specific server/client environment setup), which is shared between many unit tests,
    ///and which is better to abstract-away from visibility in unit tests themselves, for code clarity.
    ///
    ///For example, some games require authentication negotiation before the game client can connect to a server,
    ///and this is the type of task that UnitTask's are designed for.
    ///
    ///Unit tasks that are added to a unit test, must complete execution before the unit test itself can execute.
    ///</remarks>
    public unsafe partial class UnitTask : UObject  {
        static UnitTask() {
            StaticClass = Main.GetClass("UnitTask");
        }
        internal unsafe UnitTask_fields* UnitTask_ptr => (UnitTask_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTask(IntPtr p) => UObject.Make<UnitTask>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTask DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTask New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
