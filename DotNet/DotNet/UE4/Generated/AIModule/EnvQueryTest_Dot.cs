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
    ///<summary>Env Query Test Dot</summary>
    public unsafe partial class EnvQueryTest_Dot : EnvQueryTest  {
        ///<summary>defines direction of first line used by test</summary>
        public unsafe EnvDirection LineA {
            get {return EnvQueryTest_Dot_ptr->LineA;}
            set {EnvQueryTest_Dot_ptr->LineA = value;}
        }
        ///<summary>defines direction of second line used by test</summary>
        public unsafe EnvDirection LineB {
            get {return EnvQueryTest_Dot_ptr->LineB;}
            set {EnvQueryTest_Dot_ptr->LineB = value;}
        }
         //TODO: enum EEnvTestDot TestMode
        public bool bAbsoluteValue {
            get {return Main.GetGetBoolPropertyByName(this, "bAbsoluteValue"); }
            set {Main.SetGetBoolPropertyByName(this, "bAbsoluteValue", value); }
        }
        static EnvQueryTest_Dot() {
            StaticClass = Main.GetClass("EnvQueryTest_Dot");
        }
        internal unsafe EnvQueryTest_Dot_fields* EnvQueryTest_Dot_ptr => (EnvQueryTest_Dot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_Dot(IntPtr p) => UObject.Make<EnvQueryTest_Dot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_Dot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_Dot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
