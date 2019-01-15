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
    ///<summary>Interp Track Float Particle Param</summary>
    public unsafe partial class InterpTrackFloatParticleParam : InterpTrackFloatBase  {
        ///<summary>Name of property in the Emitter which this track mill modify over time.</summary>
        public unsafe Name ParamName {
            get {return InterpTrackFloatParticleParam_ptr->ParamName;}
            set {InterpTrackFloatParticleParam_ptr->ParamName = value;}
        }
        static InterpTrackFloatParticleParam() {
            StaticClass = Main.GetClass("InterpTrackFloatParticleParam");
        }
        internal unsafe InterpTrackFloatParticleParam_fields* InterpTrackFloatParticleParam_ptr => (InterpTrackFloatParticleParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackFloatParticleParam(IntPtr p) => UObject.Make<InterpTrackFloatParticleParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackFloatParticleParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackFloatParticleParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
