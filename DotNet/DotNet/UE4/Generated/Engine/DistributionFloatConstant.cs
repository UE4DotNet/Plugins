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
    ///<summary>Distribution Float Constant</summary>
    public unsafe partial class DistributionFloatConstant : DistributionFloat  {
        ///<summary>This float will be returned for all values of time.</summary>
        public unsafe float Constant {
            get {return DistributionFloatConstant_ptr->Constant;}
            set {DistributionFloatConstant_ptr->Constant = value;}
        }
        static DistributionFloatConstant() {
            StaticClass = Main.GetClass("DistributionFloatConstant");
        }
        internal unsafe DistributionFloatConstant_fields* DistributionFloatConstant_ptr => (DistributionFloatConstant_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionFloatConstant(IntPtr p) => UObject.Make<DistributionFloatConstant>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionFloatConstant DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionFloatConstant New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
