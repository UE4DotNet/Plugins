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
using UE4.Foliage.Native;
using UE4.Engine;

namespace UE4.Foliage {
    ///<summary>Foliage Instanced Static Mesh Component</summary>
    public unsafe partial class FoliageInstancedStaticMeshComponent : HierarchicalInstancedStaticMeshComponent  {
         //TODO: multicast delegate FInstancePointDamageSignature OnInstanceTakePointDamage
         //TODO: multicast delegate FInstanceRadialDamageSignature OnInstanceTakeRadialDamage
         //TODO: numeric uint64 FoliageHiddenEditorViews
        static FoliageInstancedStaticMeshComponent() {
            StaticClass = Main.GetClass("FoliageInstancedStaticMeshComponent");
        }
        internal unsafe FoliageInstancedStaticMeshComponent_fields* FoliageInstancedStaticMeshComponent_ptr => (FoliageInstancedStaticMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FoliageInstancedStaticMeshComponent(IntPtr p) => UObject.Make<FoliageInstancedStaticMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FoliageInstancedStaticMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FoliageInstancedStaticMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
