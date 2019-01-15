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
    ///<summary>Distribution Vector Uniform</summary>
    public unsafe partial class DistributionVectorUniform : DistributionVector  {
        ///<summary>Upper end of FVector magnitude range.</summary>
        public unsafe Vector Max {
            get {return DistributionVectorUniform_ptr->Max;}
            set {DistributionVectorUniform_ptr->Max = value;}
        }
        ///<summary>Lower end of FVector magnitude range.</summary>
        public unsafe Vector Min {
            get {return DistributionVectorUniform_ptr->Min;}
            set {DistributionVectorUniform_ptr->Min = value;}
        }
        public bool bLockAxes {
            get {return Main.GetGetBoolPropertyByName(this, "bLockAxes"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockAxes", value); }
        }
        ///<summary>Locked Axes</summary>
        public unsafe byte LockedAxes {
            get {return DistributionVectorUniform_ptr->LockedAxes;}
            set {DistributionVectorUniform_ptr->LockedAxes = value;}
        }
        ///<summary>Mirror Flags</summary>
        public unsafe byte MirrorFlags {
            get {return DistributionVectorUniform_ptr->MirrorFlags;}
            set {DistributionVectorUniform_ptr->MirrorFlags = value;}
        }
        public bool bUseExtremes {
            get {return Main.GetGetBoolPropertyByName(this, "bUseExtremes"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseExtremes", value); }
        }
        static DistributionVectorUniform() {
            StaticClass = Main.GetClass("DistributionVectorUniform");
        }
        internal unsafe DistributionVectorUniform_fields* DistributionVectorUniform_ptr => (DistributionVectorUniform_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionVectorUniform(IntPtr p) => UObject.Make<DistributionVectorUniform>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionVectorUniform DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionVectorUniform New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
