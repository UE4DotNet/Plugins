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
using UE4.PhysXVehicles.Native;
using UE4.Engine;

namespace UE4.PhysXVehicles {
    ///<summary>Represents a type of tire surface used to specify friction values against physical materials.</summary>
    public unsafe partial class TireConfig : DataAsset  {
        ///<summary>Scale the tire friction for this tire type</summary>
        public unsafe float FrictionScale {
            get {return TireConfig_ptr->FrictionScale;}
            set {TireConfig_ptr->FrictionScale = value;}
        }
         //TODO: array not UObject TArray TireFrictionScales
        static TireConfig() {
            StaticClass = Main.GetClass("TireConfig");
        }
        internal unsafe TireConfig_fields* TireConfig_ptr => (TireConfig_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TireConfig(IntPtr p) => UObject.Make<TireConfig>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TireConfig DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TireConfig New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
