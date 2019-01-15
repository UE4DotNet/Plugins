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
    ///<summary>Particle Module Beam Modifier</summary>
    public unsafe partial class ParticleModuleBeamModifier : ParticleModuleBeamBase  {
        ///<summary>Whether this module modifies the Source or the Target.</summary>
        public unsafe byte ModifierType {
            get {return ParticleModuleBeamModifier_ptr->ModifierType;}
            set {ParticleModuleBeamModifier_ptr->ModifierType = value;}
        }
        ///<summary>The options associated with the position.</summary>
        public unsafe BeamModifierOptions PositionOptions {
            get {return ParticleModuleBeamModifier_ptr->PositionOptions;}
            set {ParticleModuleBeamModifier_ptr->PositionOptions = value;}
        }
        ///<summary>The value to use when modifying the position.</summary>
        public unsafe RawDistributionVector Position {
            get {return ParticleModuleBeamModifier_ptr->Position;}
            set {ParticleModuleBeamModifier_ptr->Position = value;}
        }
        ///<summary>The options associated with the Tangent.</summary>
        public unsafe BeamModifierOptions TangentOptions {
            get {return ParticleModuleBeamModifier_ptr->TangentOptions;}
            set {ParticleModuleBeamModifier_ptr->TangentOptions = value;}
        }
        ///<summary>The value to use when modifying the Tangent.</summary>
        public unsafe RawDistributionVector Tangent {
            get {return ParticleModuleBeamModifier_ptr->Tangent;}
            set {ParticleModuleBeamModifier_ptr->Tangent = value;}
        }
        public bool bAbsoluteTangent {
            get {return Main.GetGetBoolPropertyByName(this, "bAbsoluteTangent"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbsoluteTangent", value); }
        }
        ///<summary>The options associated with the Strength.</summary>
        public unsafe BeamModifierOptions StrengthOptions {
            get {return ParticleModuleBeamModifier_ptr->StrengthOptions;}
            set {ParticleModuleBeamModifier_ptr->StrengthOptions = value;}
        }
        ///<summary>The value to use when modifying the Strength.</summary>
        public unsafe RawDistributionFloat Strength {
            get {return ParticleModuleBeamModifier_ptr->Strength;}
            set {ParticleModuleBeamModifier_ptr->Strength = value;}
        }
        static ParticleModuleBeamModifier() {
            StaticClass = Main.GetClass("ParticleModuleBeamModifier");
        }
        internal unsafe ParticleModuleBeamModifier_fields* ParticleModuleBeamModifier_ptr => (ParticleModuleBeamModifier_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleBeamModifier(IntPtr p) => UObject.Make<ParticleModuleBeamModifier>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleBeamModifier DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleBeamModifier New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
