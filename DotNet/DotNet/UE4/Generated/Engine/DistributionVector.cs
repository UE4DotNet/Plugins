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
    ///<summary>Distribution Vector</summary>
    public unsafe partial class DistributionVector : Distribution  {
        public bool bCanBeBaked {
            get {return Main.GetGetBoolPropertyByName(this, "bCanBeBaked"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanBeBaked", value); }
        }
        public bool bIsDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bIsDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsDirty", value); }
        }
        public bool bBakedDataSuccesfully {
            get {return Main.GetGetBoolPropertyByName(this, "bBakedDataSuccesfully"); }
            set {Main.SetGetBoolPropertyByName(this, "bBakedDataSuccesfully", value); }
        }
        static DistributionVector() {
            StaticClass = Main.GetClass("DistributionVector");
        }
        internal unsafe DistributionVector_fields* DistributionVector_ptr => (DistributionVector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionVector(IntPtr p) => UObject.Make<DistributionVector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionVector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionVector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
