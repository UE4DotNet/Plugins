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
    ///<summary>Interp Track Fade</summary>
    public unsafe partial class InterpTrackFade : InterpTrackFloatBase  {
        public bool bPersistFade {
            get {return Main.GetGetBoolPropertyByName(this, "bPersistFade"); }
            set {Main.SetGetBoolPropertyByName(this, "bPersistFade", value); }
        }
        public bool bFadeAudio {
            get {return Main.GetGetBoolPropertyByName(this, "bFadeAudio"); }
            set {Main.SetGetBoolPropertyByName(this, "bFadeAudio", value); }
        }
        ///<summary>Color to fade to.</summary>
        public unsafe LinearColor FadeColor {
            get {return InterpTrackFade_ptr->FadeColor;}
            set {InterpTrackFade_ptr->FadeColor = value;}
        }
        static InterpTrackFade() {
            StaticClass = Main.GetClass("InterpTrackFade");
        }
        internal unsafe InterpTrackFade_fields* InterpTrackFade_ptr => (InterpTrackFade_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackFade(IntPtr p) => UObject.Make<InterpTrackFade>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackFade DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackFade New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
