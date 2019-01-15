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
using UE4.UMG;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Functional UIScreenshot Test</summary>
    public unsafe partial class FunctionalUIScreenshotTest : ScreenshotFunctionalTestBase  {
        ///<summary>Widget Class</summary>
        public unsafe SubclassOf<UserWidget> WidgetClass {
            get {return FunctionalUIScreenshotTest_ptr->WidgetClass;}
            set {FunctionalUIScreenshotTest_ptr->WidgetClass = value;}
        }
        ///<summary>Spawned Widget</summary>
        public unsafe UserWidget SpawnedWidget {
            get {return FunctionalUIScreenshotTest_ptr->SpawnedWidget;}
            set {FunctionalUIScreenshotTest_ptr->SpawnedWidget = value;}
        }
         //TODO: enum EWidgetTestAppearLocation WidgetLocation
        ///<summary>Screenshot RT</summary>
        public unsafe TextureRenderTarget2D ScreenshotRT {
            get {return FunctionalUIScreenshotTest_ptr->ScreenshotRT;}
            set {FunctionalUIScreenshotTest_ptr->ScreenshotRT = value;}
        }
        static FunctionalUIScreenshotTest() {
            StaticClass = Main.GetClass("FunctionalUIScreenshotTest");
        }
        internal unsafe FunctionalUIScreenshotTest_fields* FunctionalUIScreenshotTest_ptr => (FunctionalUIScreenshotTest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FunctionalUIScreenshotTest(IntPtr p) => UObject.Make<FunctionalUIScreenshotTest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FunctionalUIScreenshotTest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FunctionalUIScreenshotTest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
