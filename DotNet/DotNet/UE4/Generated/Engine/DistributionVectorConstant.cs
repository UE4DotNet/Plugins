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
    ///<summary>Distribution Vector Constant</summary>
    public unsafe partial class DistributionVectorConstant : DistributionVector  {
        ///<summary>This FVector will be returned for all input times.</summary>
        public unsafe Vector Constant {
            get {return DistributionVectorConstant_ptr->Constant;}
            set {DistributionVectorConstant_ptr->Constant = value;}
        }
        public bool bLockAxes {
            get {return Main.GetGetBoolPropertyByName(this, "bLockAxes"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockAxes", value); }
        }
        ///<summary>Locked Axes</summary>
        public unsafe byte LockedAxes {
            get {return DistributionVectorConstant_ptr->LockedAxes;}
            set {DistributionVectorConstant_ptr->LockedAxes = value;}
        }
        static DistributionVectorConstant() {
            StaticClass = Main.GetClass("DistributionVectorConstant");
        }
        internal unsafe DistributionVectorConstant_fields* DistributionVectorConstant_ptr => (DistributionVectorConstant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionVectorConstant(IntPtr p) => UObject.Make<DistributionVectorConstant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionVectorConstant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionVectorConstant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
