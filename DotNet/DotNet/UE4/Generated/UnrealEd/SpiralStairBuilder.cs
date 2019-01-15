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
    ///<summary>Spiral Stair Builder</summary>
    public unsafe partial class SpiralStairBuilder : EditorBrushBuilder  {
        ///<summary>The radius of the inner curve of the stair</summary>
        public unsafe int InnerRadius {
            get {return SpiralStairBuilder_ptr->InnerRadius;}
            set {SpiralStairBuilder_ptr->InnerRadius = value;}
        }
        ///<summary>The width of each step</summary>
        public unsafe int StepWidth {
            get {return SpiralStairBuilder_ptr->StepWidth;}
            set {SpiralStairBuilder_ptr->StepWidth = value;}
        }
        ///<summary>The height of each step</summary>
        public unsafe int StepHeight {
            get {return SpiralStairBuilder_ptr->StepHeight;}
            set {SpiralStairBuilder_ptr->StepHeight = value;}
        }
        ///<summary>The thickness of each step</summary>
        public unsafe int StepThickness {
            get {return SpiralStairBuilder_ptr->StepThickness;}
            set {SpiralStairBuilder_ptr->StepThickness = value;}
        }
        ///<summary>The number of steps in one whole spiral rotation</summary>
        public unsafe int NumStepsPer360 {
            get {return SpiralStairBuilder_ptr->NumStepsPer360;}
            set {SpiralStairBuilder_ptr->NumStepsPer360 = value;}
        }
        ///<summary>The total number of steps</summary>
        public unsafe int NumSteps {
            get {return SpiralStairBuilder_ptr->NumSteps;}
            set {SpiralStairBuilder_ptr->NumSteps = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return SpiralStairBuilder_ptr->GroupName;}
            set {SpiralStairBuilder_ptr->GroupName = value;}
        }
        public bool SlopedCeiling {
            get {return Main.GetGetBoolPropertyByName(this, "SlopedCeiling"); }
            set {Main.SetGetBoolPropertyByName(this, "SlopedCeiling", value); }
        }
        public bool SlopedFloor {
            get {return Main.GetGetBoolPropertyByName(this, "SlopedFloor"); }
            set {Main.SetGetBoolPropertyByName(this, "SlopedFloor", value); }
        }
        public bool CounterClockwise {
            get {return Main.GetGetBoolPropertyByName(this, "CounterClockwise"); }
            set {Main.SetGetBoolPropertyByName(this, "CounterClockwise", value); }
        }
        static SpiralStairBuilder() {
            StaticClass = Main.GetClass("SpiralStairBuilder");
        }
        internal unsafe SpiralStairBuilder_fields* SpiralStairBuilder_ptr => (SpiralStairBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SpiralStairBuilder(IntPtr p) => UObject.Make<SpiralStairBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SpiralStairBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SpiralStairBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
