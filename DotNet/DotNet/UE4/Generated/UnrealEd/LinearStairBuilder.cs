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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Linear Stair Builder</summary>
    public unsafe partial class LinearStairBuilder : EditorBrushBuilder  {
        ///<summary>The length of each step</summary>
        public unsafe int StepLength {
            get {return LinearStairBuilder_ptr->StepLength;}
            set {LinearStairBuilder_ptr->StepLength = value;}
        }
        ///<summary>The height of each step</summary>
        public unsafe int StepHeight {
            get {return LinearStairBuilder_ptr->StepHeight;}
            set {LinearStairBuilder_ptr->StepHeight = value;}
        }
        ///<summary>The width of each step</summary>
        public unsafe int StepWidth {
            get {return LinearStairBuilder_ptr->StepWidth;}
            set {LinearStairBuilder_ptr->StepWidth = value;}
        }
        ///<summary>The number of steps</summary>
        public unsafe int NumSteps {
            get {return LinearStairBuilder_ptr->NumSteps;}
            set {LinearStairBuilder_ptr->NumSteps = value;}
        }
        ///<summary>The distance below the first step</summary>
        public unsafe int AddToFirstStep {
            get {return LinearStairBuilder_ptr->AddToFirstStep;}
            set {LinearStairBuilder_ptr->AddToFirstStep = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return LinearStairBuilder_ptr->GroupName;}
            set {LinearStairBuilder_ptr->GroupName = value;}
        }
        static LinearStairBuilder() {
            StaticClass = Main.GetClass("LinearStairBuilder");
        }
        internal unsafe LinearStairBuilder_fields* LinearStairBuilder_ptr => (LinearStairBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LinearStairBuilder(IntPtr p) => UObject.Make<LinearStairBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LinearStairBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LinearStairBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
