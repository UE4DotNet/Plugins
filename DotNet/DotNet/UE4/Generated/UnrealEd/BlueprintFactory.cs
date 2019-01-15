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
    ///<summary>Blueprint Factory</summary>
    public unsafe partial class BlueprintFactory : Factory  {
        ///<summary>The parent class of the created blueprint</summary>
        public unsafe SubclassOf<UObject> ParentClass {
            get {return BlueprintFactory_ptr->ParentClass;}
            set {BlueprintFactory_ptr->ParentClass = value;}
        }
        static BlueprintFactory() {
            StaticClass = Main.GetClass("BlueprintFactory");
        }
        internal unsafe BlueprintFactory_fields* BlueprintFactory_ptr => (BlueprintFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintFactory(IntPtr p) => UObject.Make<BlueprintFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
