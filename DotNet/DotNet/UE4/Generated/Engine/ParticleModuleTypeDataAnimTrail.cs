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
    ///<summary>Particle Module Type Data Anim Trail</summary>
    public unsafe partial class ParticleModuleTypeDataAnimTrail : ParticleModuleTypeDataBase  {
        public bool bDeadTrailsOnDeactivate {
            get {return Main.GetGetBoolPropertyByName(this, "bDeadTrailsOnDeactivate"); }
            set {Main.SetGetBoolPropertyByName(this, "bDeadTrailsOnDeactivate", value); }
        }
        public bool bEnablePreviousTangentRecalculation {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePreviousTangentRecalculation"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePreviousTangentRecalculation", value); }
        }
        public bool bTangentRecalculationEveryFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bTangentRecalculationEveryFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bTangentRecalculationEveryFrame", value); }
        }
        ///<summary>The (estimated) covered distance to tile the 2nd UV set at.</summary>
        ///<remarks>If 0.0, a second UV set will not be passed in.</remarks>
        public unsafe float TilingDistance {
            get {return ParticleModuleTypeDataAnimTrail_ptr->TilingDistance;}
            set {ParticleModuleTypeDataAnimTrail_ptr->TilingDistance = value;}
        }
        ///<summary>The distance step size for tessellation.</summary>
        ///<remarks># Tessellation Points = TruncToInt((Distance Between Spawned Particles) / DistanceTessellationStepSize)). If 0 then there is no distance tessellation.</remarks>
        public unsafe float DistanceTessellationStepSize {
            get {return ParticleModuleTypeDataAnimTrail_ptr->DistanceTessellationStepSize;}
            set {ParticleModuleTypeDataAnimTrail_ptr->DistanceTessellationStepSize = value;}
        }
        ///<summary>The tangent scalar for tessellation.</summary>
        ///<remarks>This is the degree change in the tangent direction [0...180] required to warrant an additional tessellation point. If 0 then there is no tangent tessellation.</remarks>
        public unsafe float TangentTessellationStepSize {
            get {return ParticleModuleTypeDataAnimTrail_ptr->TangentTessellationStepSize;}
            set {ParticleModuleTypeDataAnimTrail_ptr->TangentTessellationStepSize = value;}
        }
        ///<summary>The width step size for tessellation.</summary>
        ///<remarks>This is the number of world units change in the width required to warrant an additional tessellation point. If 0 then there is no width tessellation.</remarks>
        public unsafe float WidthTessellationStepSize {
            get {return ParticleModuleTypeDataAnimTrail_ptr->WidthTessellationStepSize;}
            set {ParticleModuleTypeDataAnimTrail_ptr->WidthTessellationStepSize = value;}
        }
        static ParticleModuleTypeDataAnimTrail() {
            StaticClass = Main.GetClass("ParticleModuleTypeDataAnimTrail");
        }
        internal unsafe ParticleModuleTypeDataAnimTrail_fields* ParticleModuleTypeDataAnimTrail_ptr => (ParticleModuleTypeDataAnimTrail_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleTypeDataAnimTrail(IntPtr p) => UObject.Make<ParticleModuleTypeDataAnimTrail>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleTypeDataAnimTrail DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleTypeDataAnimTrail New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
