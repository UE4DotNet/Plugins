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
    ///<summary>A commandlet for running unit tests, without having to launch the game client.</summary>
    ///<remarks>
    ///Uses a heavily stripped down game client, with allowances for Slate, and some hacks for enabling proper netcode usage.
    ///
    ///Usage:
    ///    "UE4Editor.exe shootergame -run=NetcodeUnitTest.UnitTestCommandlet"
    ///
    ///Parameters:
    ///    -UnitTest=UnitTestName
    ///            - Launches only the specified unit test
    ///
    ///    -UnitTestNoAutoClose
    ///            - Sets the default option for the 'AutoClose' button to False
    ///
    ///    -UnitTestServerParms="CommandlineParameters"
    ///            - Adds additional commandline parameters to unit test server instances (useful for e.g. unsuppressing specific logs)
    ///
    ///    -UnitTestClientParms="CommandlineParameters"
    ///            - Adds additional commandline parameters to unit test client instances
    ///
    ///    -UnitTestClientDebug
    ///            - Launches unit test clients with a valid render interface (so you can interact with the client window), and a larger window
    ///
    ///    -UnitTestCap=x
    ///            - Caps the maximum number of unit tests that can run at the same time
    ///</remarks>
    public unsafe partial class UnitTestCommandlet : Commandlet  {
        static UnitTestCommandlet() {
            StaticClass = Main.GetClass("UnitTestCommandlet");
        }
        internal unsafe UnitTestCommandlet_fields* UnitTestCommandlet_ptr => (UnitTestCommandlet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UnitTestCommandlet(IntPtr p) => UObject.Make<UnitTestCommandlet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UnitTestCommandlet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UnitTestCommandlet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
