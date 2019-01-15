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
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>An invisible volume used to manually define/create a HLOD cluster.</summary>
    public unsafe partial class HierarchicalLODVolume : Volume  {
        public bool bIncludeOverlappingActors {
            get {return Main.GetGetBoolPropertyByName(this, "bIncludeOverlappingActors"); }
            set {Main.SetGetBoolPropertyByName(this, "bIncludeOverlappingActors", value); }
        }
        static HierarchicalLODVolume() {
            StaticClass = Main.GetClass("HierarchicalLODVolume");
        }
        internal unsafe HierarchicalLODVolume_fields* HierarchicalLODVolume_ptr => (HierarchicalLODVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HierarchicalLODVolume(IntPtr p) => UObject.Make<HierarchicalLODVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HierarchicalLODVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HierarchicalLODVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
