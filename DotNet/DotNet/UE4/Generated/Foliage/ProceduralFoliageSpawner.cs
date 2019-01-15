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

namespace UE4.Foliage {
    ///<summary>Procedural Foliage Spawner</summary>
    public unsafe partial class ProceduralFoliageSpawner : UObject  {

        ///<summary>Simulate</summary>
        public void Simulate(int NumSteps)  => 
            ProceduralFoliageSpawner_methods.Simulate_method.Invoke(ObjPointer, NumSteps);
        ///<summary>The seed used for generating the randomness of the simulation.</summary>
        public unsafe int RandomSeed {
            get {return ProceduralFoliageSpawner_ptr->RandomSeed;}
        }
        ///<summary>Length of the tile (in cm) along one axis. The total area of the tile will be TileSize*TileSize.</summary>
        public unsafe float TileSize {
            get {return ProceduralFoliageSpawner_ptr->TileSize;}
        }
        ///<summary>The number of unique tiles to generate. The final simulation is a procedurally determined combination of the various unique tiles.</summary>
        public unsafe int NumUniqueTiles {
            get {return ProceduralFoliageSpawner_ptr->NumUniqueTiles;}
        }
        ///<summary>Minimum size of the quad tree used during the simulation. Reduce if too many instances are in splittable leaf quads (as warned in the log).</summary>
        public unsafe float MinimumQuadTreeSize {
            get {return ProceduralFoliageSpawner_ptr->MinimumQuadTreeSize;}
        }
         //TODO: array not UObject TArray FoliageTypes
        public bool bNeedsSimulation {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedsSimulation"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedsSimulation", value); }
        }
        static ProceduralFoliageSpawner() {
            StaticClass = Main.GetClass("ProceduralFoliageSpawner");
        }
        internal unsafe ProceduralFoliageSpawner_fields* ProceduralFoliageSpawner_ptr => (ProceduralFoliageSpawner_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProceduralFoliageSpawner(IntPtr p) => UObject.Make<ProceduralFoliageSpawner>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProceduralFoliageSpawner DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProceduralFoliageSpawner New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
