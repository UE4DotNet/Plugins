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
    ///<summary>Particle Module Kill Box</summary>
    public unsafe partial class ParticleModuleKillBox : ParticleModuleKillBase  {
        ///<summary>The lower left corner of the box.</summary>
        public unsafe RawDistributionVector LowerLeftCorner {
            get {return ParticleModuleKillBox_ptr->LowerLeftCorner;}
            set {ParticleModuleKillBox_ptr->LowerLeftCorner = value;}
        }
        ///<summary>The upper right corner of the box.</summary>
        public unsafe RawDistributionVector UpperRightCorner {
            get {return ParticleModuleKillBox_ptr->UpperRightCorner;}
            set {ParticleModuleKillBox_ptr->UpperRightCorner = value;}
        }
        public bool bAbsolute {
            get {return Main.GetGetBoolPropertyByName(this, "bAbsolute"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbsolute", value); }
        }
        public bool bKillInside {
            get {return Main.GetGetBoolPropertyByName(this, "bKillInside"); }
            set {Main.SetGetBoolPropertyByName(this, "bKillInside", value); }
        }
        public bool bAxisAlignedAndFixedSize {
            get {return Main.GetGetBoolPropertyByName(this, "bAxisAlignedAndFixedSize"); }
            set {Main.SetGetBoolPropertyByName(this, "bAxisAlignedAndFixedSize", value); }
        }
        static ParticleModuleKillBox() {
            StaticClass = Main.GetClass("ParticleModuleKillBox");
        }
        internal unsafe ParticleModuleKillBox_fields* ParticleModuleKillBox_ptr => (ParticleModuleKillBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleModuleKillBox(IntPtr p) => UObject.Make<ParticleModuleKillBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleModuleKillBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleModuleKillBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
