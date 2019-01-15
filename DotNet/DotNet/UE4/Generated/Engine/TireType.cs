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
    ///<summary>DEPRECATED - Only used to allow conversion to new TireConfig in PhysXVehicles plugin</summary>
    public unsafe partial class TireType : DataAsset  {
        ///<summary>Friction Scale</summary>
        public unsafe float FrictionScale {
            get {return TireType_ptr->FrictionScale;}
            set {TireType_ptr->FrictionScale = value;}
        }
        static TireType() {
            StaticClass = Main.GetClass("TireType");
        }
        internal unsafe TireType_fields* TireType_ptr => (TireType_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TireType(IntPtr p) => UObject.Make<TireType>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TireType DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TireType New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
