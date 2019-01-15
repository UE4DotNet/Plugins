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
    ///<summary>Particle Module Location Direct</summary>
    public unsafe partial class ParticleModuleLocationDirect : ParticleModuleLocationBase  {
        ///<summary>The location of the particle at a give time.</summary>
        ///<remarks>
        ///Retrieved using the particle RelativeTime.
        ///IMPORTANT: the particle location is set to this value, thereby over-writing any previous module impacts.
        ///</remarks>
        public unsafe RawDistributionVector Location {
            get {return ParticleModuleLocationDirect_ptr->Location;}
            set {ParticleModuleLocationDirect_ptr->Location = value;}
        }
        ///<summary>An offset to apply to the position retrieved from the Location calculation.</summary>
        ///<remarks>
        ///The offset is retrieved using the EmitterTime.
        ///The offset will remain constant over the life of the particle.
        ///</remarks>
        public unsafe RawDistributionVector LocationOffset {
            get {return ParticleModuleLocationDirect_ptr->LocationOffset;}
            set {ParticleModuleLocationDirect_ptr->LocationOffset = value;}
        }
        ///<summary>Scales the velocity of the object at a given point in the time-line.</summary>
        public unsafe RawDistributionVector ScaleFactor {
            get {return ParticleModuleLocationDirect_ptr->ScaleFactor;}
            set {ParticleModuleLocationDirect_ptr->ScaleFactor = value;}
        }
        ///<summary>Currently unused.</summary>
        public unsafe RawDistributionVector Direction {
            get {return ParticleModuleLocationDirect_ptr->Direction;}
            set {ParticleModuleLocationDirect_ptr->Direction = value;}
        }
        static ParticleModuleLocationDirect() {
            StaticClass = Main.GetClass("ParticleModuleLocationDirect");
        }
        internal unsafe ParticleModuleLocationDirect_fields* ParticleModuleLocationDirect_ptr => (ParticleModuleLocationDirect_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleLocationDirect(IntPtr p) => UObject.Make<ParticleModuleLocationDirect>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleLocationDirect DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleLocationDirect New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
