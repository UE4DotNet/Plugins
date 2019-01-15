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
    ///<summary>Interp Track Inst Linear Color Prop</summary>
    public unsafe partial class InterpTrackInstLinearColorProp : InterpTrackInstProperty  {
        ///<summary>Saved value for restoring state when exiting Matinee.</summary>
        public unsafe LinearColor ResetColor {
            get {return InterpTrackInstLinearColorProp_ptr->ResetColor;}
            set {InterpTrackInstLinearColorProp_ptr->ResetColor = value;}
        }
        static InterpTrackInstLinearColorProp() {
            StaticClass = Main.GetClass("InterpTrackInstLinearColorProp");
        }
        internal unsafe InterpTrackInstLinearColorProp_fields* InterpTrackInstLinearColorProp_ptr => (InterpTrackInstLinearColorProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstLinearColorProp(IntPtr p) => UObject.Make<InterpTrackInstLinearColorProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstLinearColorProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstLinearColorProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
