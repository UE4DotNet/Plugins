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
    ///<summary>Distribution Float</summary>
    public unsafe partial class DistributionFloat : Distribution  {
        public bool bCanBeBaked {
            get {return Main.GetGetBoolPropertyByName(this, "bCanBeBaked"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanBeBaked", value); }
        }
        public bool bBakedDataSuccesfully {
            get {return Main.GetGetBoolPropertyByName(this, "bBakedDataSuccesfully"); }
            set {Main.SetGetBoolPropertyByName(this, "bBakedDataSuccesfully", value); }
        }
        static DistributionFloat() {
            StaticClass = Main.GetClass("DistributionFloat");
        }
        internal unsafe DistributionFloat_fields* DistributionFloat_ptr => (DistributionFloat_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionFloat(IntPtr p) => UObject.Make<DistributionFloat>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionFloat DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionFloat New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
