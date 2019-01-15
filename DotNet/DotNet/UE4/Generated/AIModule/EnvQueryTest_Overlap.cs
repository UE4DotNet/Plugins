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
    ///<summary>Env Query Test Overlap</summary>
    public unsafe partial class EnvQueryTest_Overlap : EnvQueryTest  {
        ///<summary>Overlap data</summary>
        public unsafe EnvOverlapData OverlapData {
            get {return EnvQueryTest_Overlap_ptr->OverlapData;}
            set {EnvQueryTest_Overlap_ptr->OverlapData = value;}
        }
        static EnvQueryTest_Overlap() {
            StaticClass = Main.GetClass("EnvQueryTest_Overlap");
        }
        internal unsafe EnvQueryTest_Overlap_fields* EnvQueryTest_Overlap_ptr => (EnvQueryTest_Overlap_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_Overlap(IntPtr p) => UObject.Make<EnvQueryTest_Overlap>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_Overlap DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_Overlap New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
