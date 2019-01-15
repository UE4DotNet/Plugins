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
using UE4.Engine;

namespace UE4.NetcodeUnitTest {
    ///<summary>An actor net channel override, for hooking ReceivedBunch, to aid in detecting/blocking of remote actors, of a specific class</summary>
    public unsafe partial class UnitTestActorChannel : ActorChannel  {
        static UnitTestActorChannel() {
            StaticClass = Main.GetClass("UnitTestActorChannel");
        }
        internal unsafe UnitTestActorChannel_fields* UnitTestActorChannel_ptr => (UnitTestActorChannel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTestActorChannel(IntPtr p) => UObject.Make<UnitTestActorChannel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTestActorChannel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTestActorChannel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
