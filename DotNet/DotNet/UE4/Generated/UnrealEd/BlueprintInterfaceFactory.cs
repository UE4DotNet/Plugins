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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Blueprint Interface Factory</summary>
    public unsafe partial class BlueprintInterfaceFactory : Factory  {
        static BlueprintInterfaceFactory() {
            StaticClass = Main.GetClass("BlueprintInterfaceFactory");
        }
        internal unsafe BlueprintInterfaceFactory_fields* BlueprintInterfaceFactory_ptr => (BlueprintInterfaceFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintInterfaceFactory(IntPtr p) => UObject.Make<BlueprintInterfaceFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintInterfaceFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintInterfaceFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
