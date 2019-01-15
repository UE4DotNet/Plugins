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
    ///<summary>Env Query Context Querier</summary>
    public unsafe partial class EnvQueryContext_Querier : EnvQueryContext  {
        static EnvQueryContext_Querier() {
            StaticClass = Main.GetClass("EnvQueryContext_Querier");
        }
        internal unsafe EnvQueryContext_Querier_fields* EnvQueryContext_Querier_ptr => (EnvQueryContext_Querier_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryContext_Querier(IntPtr p) => UObject.Make<EnvQueryContext_Querier>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryContext_Querier DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryContext_Querier New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
