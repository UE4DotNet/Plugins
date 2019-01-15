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
    ///<summary>Particle Module Sub UVMovie</summary>
    public unsafe partial class ParticleModuleSubUVMovie : ParticleModuleSubUV  {
        public bool bUseEmitterTime {
            get {return Main.GetGetBoolPropertyByName(this, "bUseEmitterTime"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseEmitterTime", value); }
        }
        ///<summary>The frame rate the SubUV images should be 'flipped' thru at.</summary>
        public unsafe RawDistributionFloat FrameRate {
            get {return ParticleModuleSubUVMovie_ptr->FrameRate;}
            set {ParticleModuleSubUVMovie_ptr->FrameRate = value;}
        }
        ///<summary>The starting image index for the SubUV (1 = the first frame).</summary>
        ///<remarks>
        ///Assumes order of Left->Right, Top->Bottom
        ///If greater than the last frame, it will clamp to the last one.
        ///If 0, then randomly selects a starting frame.
        ///</remarks>
        public unsafe int StartingFrame {
            get {return ParticleModuleSubUVMovie_ptr->StartingFrame;}
            set {ParticleModuleSubUVMovie_ptr->StartingFrame = value;}
        }
        static ParticleModuleSubUVMovie() {
            StaticClass = Main.GetClass("ParticleModuleSubUVMovie");
        }
        internal unsafe ParticleModuleSubUVMovie_fields* ParticleModuleSubUVMovie_ptr => (ParticleModuleSubUVMovie_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSubUVMovie(IntPtr p) => UObject.Make<ParticleModuleSubUVMovie>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSubUVMovie DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSubUVMovie New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
