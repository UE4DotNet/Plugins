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
using UE4.AIModule.Native;

namespace UE4.AIModule {
    ///<summary>Env Query Generator Projected Points</summary>
    public unsafe partial class EnvQueryGenerator_ProjectedPoints : EnvQueryGenerator  {
        ///<summary>trace params</summary>
        public unsafe EnvTraceData ProjectionData {
            get {return EnvQueryGenerator_ProjectedPoints_ptr->ProjectionData;}
            set {EnvQueryGenerator_ProjectedPoints_ptr->ProjectionData = value;}
        }
        static EnvQueryGenerator_ProjectedPoints() {
            StaticClass = Main.GetClass("EnvQueryGenerator_ProjectedPoints");
        }
        internal unsafe EnvQueryGenerator_ProjectedPoints_fields* EnvQueryGenerator_ProjectedPoints_ptr => (EnvQueryGenerator_ProjectedPoints_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_ProjectedPoints(IntPtr p) => UObject.Make<EnvQueryGenerator_ProjectedPoints>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_ProjectedPoints DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_ProjectedPoints New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
