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
using UE4.FunctionalTesting.Native;

namespace UE4.FunctionalTesting {
    ///<summary>No UI</summary>
    public unsafe partial class ScreenshotFunctionalTest : ScreenshotFunctionalTestBase  {
        public bool bCameraCutOnScreenshotPrep {
            get {return Main.GetGetBoolPropertyByName(this, "bCameraCutOnScreenshotPrep"); }
            set {Main.SetGetBoolPropertyByName(this, "bCameraCutOnScreenshotPrep", value); }
        }
        static ScreenshotFunctionalTest() {
            StaticClass = Main.GetClass("ScreenshotFunctionalTest");
        }
        internal unsafe ScreenshotFunctionalTest_fields* ScreenshotFunctionalTest_ptr => (ScreenshotFunctionalTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScreenshotFunctionalTest(IntPtr p) => UObject.Make<ScreenshotFunctionalTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScreenshotFunctionalTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScreenshotFunctionalTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
