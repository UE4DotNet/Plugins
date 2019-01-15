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
    ///<summary>Env Query Test Distance</summary>
    public unsafe partial class EnvQueryTest_Distance : EnvQueryTest  {
        ///<summary>testing mode</summary>
        public unsafe byte TestMode {
            get {return EnvQueryTest_Distance_ptr->TestMode;}
            set {EnvQueryTest_Distance_ptr->TestMode = value;}
        }
        ///<summary>context</summary>
        public unsafe SubclassOf<EnvQueryContext> DistanceTo {
            get {return EnvQueryTest_Distance_ptr->DistanceTo;}
            set {EnvQueryTest_Distance_ptr->DistanceTo = value;}
        }
        static EnvQueryTest_Distance() {
            StaticClass = Main.GetClass("EnvQueryTest_Distance");
        }
        internal unsafe EnvQueryTest_Distance_fields* EnvQueryTest_Distance_ptr => (EnvQueryTest_Distance_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_Distance(IntPtr p) => UObject.Make<EnvQueryTest_Distance>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_Distance DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_Distance New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
