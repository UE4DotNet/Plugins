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
    ///<summary>Base class for all unit tests depending upon a MinimalClient connecting to a server.</summary>
    ///<remarks>
    ///The MinimalClient handles creation/cleanup of an entire new UWorld, UNetDriver and UNetConnection, for fast unit testing.
    ///
    ///NOTE: See NUTEnum.h, for important flags for configuring unit tests and the minimal client.
    ///
    ///In subclasses, implement the unit test within the ExecuteClientUnitTest function (remembering to call parent)
    ///</remarks>
    public unsafe partial class ClientUnitTest : ProcessUnitTest  {
        ///<summary>The object which handles implementation of the minimal client</summary>
        public unsafe MinimalClient MinClient {
            get {return ClientUnitTest_ptr->MinClient;}
            set {ClientUnitTest_ptr->MinClient = value;}
        }
        static ClientUnitTest() {
            StaticClass = Main.GetClass("ClientUnitTest");
        }
        internal unsafe ClientUnitTest_fields* ClientUnitTest_ptr => (ClientUnitTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ClientUnitTest(IntPtr p) => UObject.Make<ClientUnitTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ClientUnitTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ClientUnitTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
