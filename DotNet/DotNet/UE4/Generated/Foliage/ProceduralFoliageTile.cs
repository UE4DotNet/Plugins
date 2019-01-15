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
    ///<summary>Procedurally determines where to spawn foliage meshes within a discrete area.</summary>
    ///<remarks>
    ///Generally, a procedural foliage simulation as a whole is composed of multiple tiles.
    ///Tiles are able to overlap one another as well to create a seamless appearance.
    ///
    ///Note that the tile is not responsible for actually spawning any instances, it only determines where they should be placed.
    ///Following a simulation, call ExtractDesiredInstances for information about where each instance should spawn.
    ///
    ///Note also that, barring any core changes to the ordering of TSet, foliage generation is deterministic
    ///(i.e. given the same inputs, the result of the simulation will always be the same).
    ///</remarks>
    public unsafe partial class ProceduralFoliageTile : UObject  {
        ///<summary>Foliage Spawner</summary>
        public unsafe ProceduralFoliageSpawner FoliageSpawner {
            get {return ProceduralFoliageTile_ptr->FoliageSpawner;}
            set {ProceduralFoliageTile_ptr->FoliageSpawner = value;}
        }
         //TODO: array not UObject TArray InstancesArray
        static ProceduralFoliageTile() {
            StaticClass = Main.GetClass("ProceduralFoliageTile");
        }
        internal unsafe ProceduralFoliageTile_fields* ProceduralFoliageTile_ptr => (ProceduralFoliageTile_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProceduralFoliageTile(IntPtr p) => UObject.Make<ProceduralFoliageTile>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProceduralFoliageTile DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProceduralFoliageTile New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
