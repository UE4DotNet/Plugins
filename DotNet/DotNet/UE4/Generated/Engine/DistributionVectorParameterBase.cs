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
    ///<summary>Distribution Vector Parameter Base</summary>
    public unsafe partial class DistributionVectorParameterBase : DistributionVectorConstant  {
        ///<summary>Parameter Name</summary>
        public unsafe Name ParameterName {
            get {return DistributionVectorParameterBase_ptr->ParameterName;}
            set {DistributionVectorParameterBase_ptr->ParameterName = value;}
        }
        ///<summary>Min Input</summary>
        public unsafe Vector MinInput {
            get {return DistributionVectorParameterBase_ptr->MinInput;}
            set {DistributionVectorParameterBase_ptr->MinInput = value;}
        }
        ///<summary>Max Input</summary>
        public unsafe Vector MaxInput {
            get {return DistributionVectorParameterBase_ptr->MaxInput;}
            set {DistributionVectorParameterBase_ptr->MaxInput = value;}
        }
        ///<summary>Min Output</summary>
        public unsafe Vector MinOutput {
            get {return DistributionVectorParameterBase_ptr->MinOutput;}
            set {DistributionVectorParameterBase_ptr->MinOutput = value;}
        }
        ///<summary>Max Output</summary>
        public unsafe Vector MaxOutput {
            get {return DistributionVectorParameterBase_ptr->MaxOutput;}
            set {DistributionVectorParameterBase_ptr->MaxOutput = value;}
        }
        ///<summary>Param Modes</summary>
        public unsafe byte ParamModes {
            get {return DistributionVectorParameterBase_ptr->ParamModes;}
            set {DistributionVectorParameterBase_ptr->ParamModes = value;}
        }
        static DistributionVectorParameterBase() {
            StaticClass = Main.GetClass("DistributionVectorParameterBase");
        }
        internal unsafe DistributionVectorParameterBase_fields* DistributionVectorParameterBase_ptr => (DistributionVectorParameterBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DistributionVectorParameterBase(IntPtr p) => UObject.Make<DistributionVectorParameterBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DistributionVectorParameterBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DistributionVectorParameterBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
