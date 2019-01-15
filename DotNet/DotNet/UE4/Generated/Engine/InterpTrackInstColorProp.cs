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
    ///<summary>Interp Track Inst Color Prop</summary>
    public unsafe partial class InterpTrackInstColorProp : InterpTrackInstProperty  {
        ///<summary>Saved value for restoring state when exiting Matinee.</summary>
        public unsafe Color ResetColor {
            get {return InterpTrackInstColorProp_ptr->ResetColor;}
            set {InterpTrackInstColorProp_ptr->ResetColor = value;}
        }
        static InterpTrackInstColorProp() {
            StaticClass = Main.GetClass("InterpTrackInstColorProp");
        }
        internal unsafe InterpTrackInstColorProp_fields* InterpTrackInstColorProp_ptr => (InterpTrackInstColorProp_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstColorProp(IntPtr p) => UObject.Make<InterpTrackInstColorProp>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstColorProp DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstColorProp New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
