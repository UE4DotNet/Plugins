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
    ///<summary>Distribution Float Parameter Base</summary>
    public unsafe partial class DistributionFloatParameterBase : DistributionFloatConstant  {
        ///<summary>todo document</summary>
        public unsafe Name ParameterName {
            get {return DistributionFloatParameterBase_ptr->ParameterName;}
            set {DistributionFloatParameterBase_ptr->ParameterName = value;}
        }
        ///<summary>todo document</summary>
        public unsafe float MinInput {
            get {return DistributionFloatParameterBase_ptr->MinInput;}
            set {DistributionFloatParameterBase_ptr->MinInput = value;}
        }
        ///<summary>todo document</summary>
        public unsafe float MaxInput {
            get {return DistributionFloatParameterBase_ptr->MaxInput;}
            set {DistributionFloatParameterBase_ptr->MaxInput = value;}
        }
        ///<summary>todo document</summary>
        public unsafe float MinOutput {
            get {return DistributionFloatParameterBase_ptr->MinOutput;}
            set {DistributionFloatParameterBase_ptr->MinOutput = value;}
        }
        ///<summary>todo document</summary>
        public unsafe float MaxOutput {
            get {return DistributionFloatParameterBase_ptr->MaxOutput;}
            set {DistributionFloatParameterBase_ptr->MaxOutput = value;}
        }
        ///<summary>todo document</summary>
        public unsafe byte ParamMode {
            get {return DistributionFloatParameterBase_ptr->ParamMode;}
            set {DistributionFloatParameterBase_ptr->ParamMode = value;}
        }
        static DistributionFloatParameterBase() {
            StaticClass = Main.GetClass("DistributionFloatParameterBase");
        }
        internal unsafe DistributionFloatParameterBase_fields* DistributionFloatParameterBase_ptr => (DistributionFloatParameterBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionFloatParameterBase(IntPtr p) => UObject.Make<DistributionFloatParameterBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionFloatParameterBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionFloatParameterBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
