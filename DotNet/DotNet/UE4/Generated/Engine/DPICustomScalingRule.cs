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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>
    ///Custom Scaling Rules for Slate and UMG Widgets can be implemented by sub-classing from this class
    ///and setting this rule to be used in your project settings.
    ///</summary>
    public unsafe partial class DPICustomScalingRule : UObject  {
        static DPICustomScalingRule() {
            StaticClass = Main.GetClass("DPICustomScalingRule");
        }
        internal unsafe DPICustomScalingRule_fields* DPICustomScalingRule_ptr => (DPICustomScalingRule_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DPICustomScalingRule(IntPtr p) => UObject.Make<DPICustomScalingRule>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DPICustomScalingRule DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DPICustomScalingRule New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
