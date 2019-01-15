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
    ///<summary>Particle Module Attractor Line</summary>
    public unsafe partial class ParticleModuleAttractorLine : ParticleModuleAttractorBase  {
        ///<summary>The first endpoint of the line.</summary>
        public unsafe Vector EndPoint0 {
            get {return ParticleModuleAttractorLine_ptr->EndPoint0;}
            set {ParticleModuleAttractorLine_ptr->EndPoint0 = value;}
        }
        ///<summary>The second endpoint of the line.</summary>
        public unsafe Vector EndPoint1 {
            get {return ParticleModuleAttractorLine_ptr->EndPoint1;}
            set {ParticleModuleAttractorLine_ptr->EndPoint1 = value;}
        }
        ///<summary>The range of the line attractor.</summary>
        public unsafe RawDistributionFloat Range {
            get {return ParticleModuleAttractorLine_ptr->Range;}
            set {ParticleModuleAttractorLine_ptr->Range = value;}
        }
        ///<summary>The strength of the line attractor.</summary>
        public unsafe RawDistributionFloat Strength {
            get {return ParticleModuleAttractorLine_ptr->Strength;}
            set {ParticleModuleAttractorLine_ptr->Strength = value;}
        }
        static ParticleModuleAttractorLine() {
            StaticClass = Main.GetClass("ParticleModuleAttractorLine");
        }
        internal unsafe ParticleModuleAttractorLine_fields* ParticleModuleAttractorLine_ptr => (ParticleModuleAttractorLine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleAttractorLine(IntPtr p) => UObject.Make<ParticleModuleAttractorLine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleAttractorLine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleAttractorLine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
