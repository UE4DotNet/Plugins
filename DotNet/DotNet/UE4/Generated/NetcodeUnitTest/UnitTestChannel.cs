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
    ///<summary>
    ///A net channel for overriding the implementation of traditional net channels,
    ///for e.
    ///</summary>
    ///<remarks>g. blocking control channel messages, to enable minimal clients</remarks>
    public unsafe partial class UnitTestChannel : Channel  {
        static UnitTestChannel() {
            StaticClass = Main.GetClass("UnitTestChannel");
        }
        internal unsafe UnitTestChannel_fields* UnitTestChannel_ptr => (UnitTestChannel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTestChannel(IntPtr p) => UObject.Make<UnitTestChannel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTestChannel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTestChannel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
