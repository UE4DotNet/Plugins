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
    ///<summary>Distribution Float Uniform</summary>
    public unsafe partial class DistributionFloatUniform : DistributionFloat  {
        ///<summary>Low end of output float distribution.</summary>
        public unsafe float Min {
            get {return DistributionFloatUniform_ptr->Min;}
            set {DistributionFloatUniform_ptr->Min = value;}
        }
        ///<summary>High end of output float distribution.</summary>
        public unsafe float Max {
            get {return DistributionFloatUniform_ptr->Max;}
            set {DistributionFloatUniform_ptr->Max = value;}
        }
        static DistributionFloatUniform() {
            StaticClass = Main.GetClass("DistributionFloatUniform");
        }
        internal unsafe DistributionFloatUniform_fields* DistributionFloatUniform_ptr => (DistributionFloatUniform_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionFloatUniform(IntPtr p) => UObject.Make<DistributionFloatUniform>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionFloatUniform DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionFloatUniform New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
