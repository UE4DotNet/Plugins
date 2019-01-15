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
    ///<summary>Env Query Generator Current Location</summary>
    public unsafe partial class EnvQueryGenerator_CurrentLocation : EnvQueryGenerator  {
        ///<summary>context</summary>
        public unsafe SubclassOf<EnvQueryContext> QueryContext {
            get {return EnvQueryGenerator_CurrentLocation_ptr->QueryContext;}
            set {EnvQueryGenerator_CurrentLocation_ptr->QueryContext = value;}
        }
        static EnvQueryGenerator_CurrentLocation() {
            StaticClass = Main.GetClass("EnvQueryGenerator_CurrentLocation");
        }
        internal unsafe EnvQueryGenerator_CurrentLocation_fields* EnvQueryGenerator_CurrentLocation_ptr => (EnvQueryGenerator_CurrentLocation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryGenerator_CurrentLocation(IntPtr p) => UObject.Make<EnvQueryGenerator_CurrentLocation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryGenerator_CurrentLocation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryGenerator_CurrentLocation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
