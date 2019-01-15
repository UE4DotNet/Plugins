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
    ///<summary>Env Query Item Type Point</summary>
    public unsafe partial class EnvQueryItemType_Point : EnvQueryItemType_VectorBase  {
        static EnvQueryItemType_Point() {
            StaticClass = Main.GetClass("EnvQueryItemType_Point");
        }
        internal unsafe EnvQueryItemType_Point_fields* EnvQueryItemType_Point_ptr => (EnvQueryItemType_Point_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryItemType_Point(IntPtr p) => UObject.Make<EnvQueryItemType_Point>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryItemType_Point DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryItemType_Point New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
