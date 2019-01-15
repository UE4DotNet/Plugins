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
    ///<summary>Interp Track Inst Float Prop</summary>
    public unsafe partial class InterpTrackInstFloatProp : InterpTrackInstProperty  {
        ///<summary>Saved value for restoring state when exiting Matinee.</summary>
        public unsafe float ResetFloat {
            get {return InterpTrackInstFloatProp_ptr->ResetFloat;}
            set {InterpTrackInstFloatProp_ptr->ResetFloat = value;}
        }
        static InterpTrackInstFloatProp() {
            StaticClass = Main.GetClass("InterpTrackInstFloatProp");
        }
        internal unsafe InterpTrackInstFloatProp_fields* InterpTrackInstFloatProp_ptr => (InterpTrackInstFloatProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstFloatProp(IntPtr p) => UObject.Make<InterpTrackInstFloatProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstFloatProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstFloatProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
