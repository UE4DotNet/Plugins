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
    ///<summary>Particle Module Size Scale</summary>
    public unsafe partial class ParticleModuleSizeScale : ParticleModuleSizeBase  {
        ///<summary>The amount the BaseSize should be scaled before being used as the size of the particle.</summary>
        ///<remarks>
        ///The value is retrieved using the RelativeTime of the particle during its update.
        ///NOTE: this module overrides any size adjustments made prior to this module in that frame.
        ///</remarks>
        public unsafe RawDistributionVector SizeScale {
            get {return ParticleModuleSizeScale_ptr->SizeScale;}
            set {ParticleModuleSizeScale_ptr->SizeScale = value;}
        }
        public bool EnableX {
            get {return Main.GetGetBoolPropertyByName(this, "EnableX"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableX", value); }
        }
        public bool EnableY {
            get {return Main.GetGetBoolPropertyByName(this, "EnableY"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableY", value); }
        }
        public bool EnableZ {
            get {return Main.GetGetBoolPropertyByName(this, "EnableZ"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableZ", value); }
        }
        static ParticleModuleSizeScale() {
            StaticClass = Main.GetClass("ParticleModuleSizeScale");
        }
        internal unsafe ParticleModuleSizeScale_fields* ParticleModuleSizeScale_ptr => (ParticleModuleSizeScale_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleSizeScale(IntPtr p) => UObject.Make<ParticleModuleSizeScale>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleSizeScale DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleSizeScale New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
