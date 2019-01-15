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
    ///<summary>Particle Module Sub UV</summary>
    public unsafe partial class ParticleModuleSubUV : ParticleModuleSubUVBase  {
        ///<summary>SubUV animation asset to use.</summary>
        ///<remarks>
        ///When specified, optimal bounding geometry for each SubUV frame will be used when rendering the sprites for this emitter instead of full quads.
        ///This reduction in overdraw can reduce the GPU cost of rendering the emitter by 2x or 3x, depending on how much unused space was in the texture.
        ///The bounding geometry is generated off of the texture alpha setup in the SubUV Animation asset, so that has to match what the material is using for opacity, or clipping will occur.
        ///When specified, SubImages_Horizontal and SubImages_Vertical will come from the asset instead of the Required Module.
        ///</remarks>
        public unsafe SubUVAnimation Animation {
            get {return ParticleModuleSubUV_ptr->Animation;}
            set {ParticleModuleSubUV_ptr->Animation = value;}
        }
        ///<summary>The index of the sub-image that should be used for the particle.</summary>
        ///<remarks>The value is retrieved using the RelativeTime of the particles.</remarks>
        public unsafe RawDistributionFloat SubImageIndex {
            get {return ParticleModuleSubUV_ptr->SubImageIndex;}
            set {ParticleModuleSubUV_ptr->SubImageIndex = value;}
        }
        public bool bUseRealTime {
            get {return Main.GetGetBoolPropertyByName(this, "bUseRealTime"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseRealTime", value); }
        }
        static ParticleModuleSubUV() {
            StaticClass = Main.GetClass("ParticleModuleSubUV");
        }
        internal unsafe ParticleModuleSubUV_fields* ParticleModuleSubUV_ptr => (ParticleModuleSubUV_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSubUV(IntPtr p) => UObject.Make<ParticleModuleSubUV>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSubUV DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSubUV New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
