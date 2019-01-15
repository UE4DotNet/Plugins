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
    ///<summary>Curved Stair Builder</summary>
    public unsafe partial class CurvedStairBuilder : EditorBrushBuilder  {
        ///<summary>The radius of the inner curve of the stair</summary>
        public unsafe int InnerRadius {
            get {return CurvedStairBuilder_ptr->InnerRadius;}
            set {CurvedStairBuilder_ptr->InnerRadius = value;}
        }
        ///<summary>The height of each step</summary>
        public unsafe int StepHeight {
            get {return CurvedStairBuilder_ptr->StepHeight;}
            set {CurvedStairBuilder_ptr->StepHeight = value;}
        }
        ///<summary>The width of each step</summary>
        public unsafe int StepWidth {
            get {return CurvedStairBuilder_ptr->StepWidth;}
            set {CurvedStairBuilder_ptr->StepWidth = value;}
        }
        ///<summary>The angle of the total arc described by this stair</summary>
        public unsafe int AngleOfCurve {
            get {return CurvedStairBuilder_ptr->AngleOfCurve;}
            set {CurvedStairBuilder_ptr->AngleOfCurve = value;}
        }
        ///<summary>The number of steps</summary>
        public unsafe int NumSteps {
            get {return CurvedStairBuilder_ptr->NumSteps;}
            set {CurvedStairBuilder_ptr->NumSteps = value;}
        }
        ///<summary>The distance below the first step</summary>
        public unsafe int AddToFirstStep {
            get {return CurvedStairBuilder_ptr->AddToFirstStep;}
            set {CurvedStairBuilder_ptr->AddToFirstStep = value;}
        }
        ///<summary>Group Name</summary>
        public unsafe Name GroupName {
            get {return CurvedStairBuilder_ptr->GroupName;}
            set {CurvedStairBuilder_ptr->GroupName = value;}
        }
        public bool CounterClockwise {
            get {return Main.GetGetBoolPropertyByName(this, "CounterClockwise"); }
            set {Main.SetGetBoolPropertyByName(this, "CounterClockwise", value); }
        }
        static CurvedStairBuilder() {
            StaticClass = Main.GetClass("CurvedStairBuilder");
        }
        internal unsafe CurvedStairBuilder_fields* CurvedStairBuilder_ptr => (CurvedStairBuilder_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurvedStairBuilder(IntPtr p) => UObject.Make<CurvedStairBuilder>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurvedStairBuilder DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurvedStairBuilder New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
