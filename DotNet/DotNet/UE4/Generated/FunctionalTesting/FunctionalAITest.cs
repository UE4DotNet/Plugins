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
using UE4.FunctionalTesting.Native;
using UE4.Engine;

namespace UE4.FunctionalTesting {
    ///<summary>Functional AITest</summary>
    public unsafe partial class FunctionalAITest : FunctionalTest  {

        ///<summary>Is One Of Spawned Pawns</summary>
        public bool IsOneOfSpawnedPawns(Actor Actor)  => 
            FunctionalAITest_methods.IsOneOfSpawnedPawns_method.Invoke(ObjPointer, Actor);
         //TODO: array not UObject TArray SpawnSets
        ///<summary>Spawn Location Randomization Range</summary>
        public unsafe float SpawnLocationRandomizationRange {
            get {return FunctionalAITest_ptr->SpawnLocationRandomizationRange;}
        }
        ///<summary>Spawned Pawns</summary>
        public ObjectArrayField<Pawn> SpawnedPawns{ get {
            if(SpawnedPawns_store == null) SpawnedPawns_store = new ObjectArrayField<Pawn> (&FunctionalAITest_ptr->SpawnedPawns);
            return SpawnedPawns_store;
        } }
        private ObjectArrayField<Pawn> SpawnedPawns_store;

         //TODO: array not UObject TArray PendingDelayedSpawns
        ///<summary>Current Spawn Set Index</summary>
        public unsafe int CurrentSpawnSetIndex {
            get {return FunctionalAITest_ptr->CurrentSpawnSetIndex;}
        }
         //TODO: string FString CurrentSpawnSetName
         //TODO: multicast delegate FFunctionalTestAISpawned OnAISpawned
         //TODO: multicast delegate FFunctionalTestEventSignature OnAllAISPawned
        ///<summary>navmesh debug: log navoctree modifiers around this point</summary>
        public unsafe Vector NavMeshDebugOrigin {
            get {return FunctionalAITest_ptr->NavMeshDebugOrigin;}
            set {FunctionalAITest_ptr->NavMeshDebugOrigin = value;}
        }
        ///<summary>navmesh debug: extent around NavMeshDebugOrigin</summary>
        public unsafe Vector NavMeshDebugExtent {
            get {return FunctionalAITest_ptr->NavMeshDebugExtent;}
            set {FunctionalAITest_ptr->NavMeshDebugExtent = value;}
        }
        public bool bWaitForNavMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bWaitForNavMesh"); }
        }
        public bool bDebugNavMeshOnTimeout {
            get {return Main.GetGetBoolPropertyByName(this, "bDebugNavMeshOnTimeout"); }
            set {Main.SetGetBoolPropertyByName(this, "bDebugNavMeshOnTimeout", value); }
        }
        static FunctionalAITest() {
            StaticClass = Main.GetClass("FunctionalAITest");
        }
        internal unsafe FunctionalAITest_fields* FunctionalAITest_ptr => (FunctionalAITest_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FunctionalAITest(IntPtr p) => UObject.Make<FunctionalAITest>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FunctionalAITest DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FunctionalAITest New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
