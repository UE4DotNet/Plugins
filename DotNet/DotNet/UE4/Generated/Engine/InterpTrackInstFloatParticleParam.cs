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
    ///<summary>Interp Track Inst Float Particle Param</summary>
    public unsafe partial class InterpTrackInstFloatParticleParam : InterpTrackInst  {
        ///<summary>Saved value for restoring state when exiting Matinee.</summary>
        public unsafe float ResetFloat {
            get {return InterpTrackInstFloatParticleParam_ptr->ResetFloat;}
            set {InterpTrackInstFloatParticleParam_ptr->ResetFloat = value;}
        }
        static InterpTrackInstFloatParticleParam() {
            StaticClass = Main.GetClass("InterpTrackInstFloatParticleParam");
        }
        internal unsafe InterpTrackInstFloatParticleParam_fields* InterpTrackInstFloatParticleParam_ptr => (InterpTrackInstFloatParticleParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstFloatParticleParam(IntPtr p) => UObject.Make<InterpTrackInstFloatParticleParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstFloatParticleParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstFloatParticleParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
