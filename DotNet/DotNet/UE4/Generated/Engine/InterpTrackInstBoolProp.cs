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
    ///<summary>Interp Track Inst Bool Prop</summary>
    public unsafe partial class InterpTrackInstBoolProp : InterpTrackInstProperty  {
        ///<summary>Mask that indicates which bit the boolean property actually uses of the value pointed to by BoolProp.</summary>
        public unsafe BoolProperty BoolProperty {
            get {return InterpTrackInstBoolProp_ptr->BoolProperty;}
            set {InterpTrackInstBoolProp_ptr->BoolProperty = value;}
        }
        public bool ResetBool {
            get {return Main.GetGetBoolPropertyByName(this, "ResetBool"); }
            set {Main.SetGetBoolPropertyByName(this, "ResetBool", value); }
        }
        static InterpTrackInstBoolProp() {
            StaticClass = Main.GetClass("InterpTrackInstBoolProp");
        }
        internal unsafe InterpTrackInstBoolProp_fields* InterpTrackInstBoolProp_ptr => (InterpTrackInstBoolProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstBoolProp(IntPtr p) => UObject.Make<InterpTrackInstBoolProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstBoolProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstBoolProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
