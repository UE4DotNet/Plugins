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
    ///<summary>Procedural Foliage Component</summary>
    public unsafe partial class ProceduralFoliageComponent : ActorComponent  {
        ///<summary>The procedural foliage spawner used to generate foliage instances within this volume.</summary>
        public unsafe ProceduralFoliageSpawner FoliageSpawner {
            get {return ProceduralFoliageComponent_ptr->FoliageSpawner;}
            set {ProceduralFoliageComponent_ptr->FoliageSpawner = value;}
        }
        ///<summary>The amount of overlap between simulation tiles (in cm).</summary>
        public unsafe float TileOverlap {
            get {return ProceduralFoliageComponent_ptr->TileOverlap;}
            set {ProceduralFoliageComponent_ptr->TileOverlap = value;}
        }
        public bool bAllowLandscape {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowLandscape"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowLandscape", value); }
        }
        public bool bAllowBSP {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowBSP"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowBSP", value); }
        }
        public bool bAllowStaticMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowStaticMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowStaticMesh", value); }
        }
        public bool bAllowTranslucent {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowTranslucent"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowTranslucent", value); }
        }
        public bool bAllowFoliage {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowFoliage"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowFoliage", value); }
        }
        public bool bShowDebugTiles {
            get {return Main.GetGetBoolPropertyByName(this, "bShowDebugTiles"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowDebugTiles", value); }
        }
        ///<summary>Spawning Volume</summary>
        public unsafe Volume SpawningVolume {
            get {return ProceduralFoliageComponent_ptr->SpawningVolume;}
            set {ProceduralFoliageComponent_ptr->SpawningVolume = value;}
        }
        ///<summary>Procedural Guid</summary>
        public unsafe FGuid ProceduralGuid {
            get {return ProceduralFoliageComponent_ptr->ProceduralGuid;}
            set {ProceduralFoliageComponent_ptr->ProceduralGuid = value;}
        }
        static ProceduralFoliageComponent() {
            StaticClass = Main.GetClass("ProceduralFoliageComponent");
        }
        internal unsafe ProceduralFoliageComponent_fields* ProceduralFoliageComponent_ptr => (ProceduralFoliageComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProceduralFoliageComponent(IntPtr p) => UObject.Make<ProceduralFoliageComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProceduralFoliageComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProceduralFoliageComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
