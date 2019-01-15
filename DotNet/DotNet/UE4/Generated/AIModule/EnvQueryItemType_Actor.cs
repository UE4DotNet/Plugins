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
    ///<summary>Env Query Item Type Actor</summary>
    public unsafe partial class EnvQueryItemType_Actor : EnvQueryItemType_ActorBase  {
        static EnvQueryItemType_Actor() {
            StaticClass = Main.GetClass("EnvQueryItemType_Actor");
        }
        internal unsafe EnvQueryItemType_Actor_fields* EnvQueryItemType_Actor_ptr => (EnvQueryItemType_Actor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryItemType_Actor(IntPtr p) => UObject.Make<EnvQueryItemType_Actor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryItemType_Actor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryItemType_Actor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
