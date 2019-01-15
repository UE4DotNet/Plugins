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
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Base class for screenshot functional test</summary>
    public unsafe partial class ScreenshotFunctionalTestBase : FunctionalTest  {
         //TODO: string FString Notes
        ///<summary>Screenshot Camera</summary>
        public unsafe CameraComponent ScreenshotCamera {
            get {return ScreenshotFunctionalTestBase_ptr->ScreenshotCamera;}
        }
        ///<summary>Screenshot Options</summary>
        public unsafe AutomationScreenshotOptions ScreenshotOptions {
            get {return ScreenshotFunctionalTestBase_ptr->ScreenshotOptions;}
        }
        static ScreenshotFunctionalTestBase() {
            StaticClass = Main.GetClass("ScreenshotFunctionalTestBase");
        }
        internal unsafe ScreenshotFunctionalTestBase_fields* ScreenshotFunctionalTestBase_ptr => (ScreenshotFunctionalTestBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScreenshotFunctionalTestBase(IntPtr p) => UObject.Make<ScreenshotFunctionalTestBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScreenshotFunctionalTestBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScreenshotFunctionalTestBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
