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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Implements the settings for garbage collection.</summary>
    public unsafe partial class GarbageCollectionSettings : DeveloperSettings  {
        ///<summary>Time in seconds (game time) we should wait between purging object references to objects that are pending kill.</summary>
        public unsafe float TimeBetweenPurgingPendingKillObjects {
            get {return GarbageCollectionSettings_ptr->TimeBetweenPurgingPendingKillObjects;}
            set {GarbageCollectionSettings_ptr->TimeBetweenPurgingPendingKillObjects = value;}
        }
        public bool FlushStreamingOnGC {
            get {return Main.GetGetBoolPropertyByName(this, "FlushStreamingOnGC"); }
            set {Main.SetGetBoolPropertyByName(this, "FlushStreamingOnGC", value); }
        }
        public bool AllowParallelGC {
            get {return Main.GetGetBoolPropertyByName(this, "AllowParallelGC"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowParallelGC", value); }
        }
        public bool IncrementalBeginDestroyEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "IncrementalBeginDestroyEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "IncrementalBeginDestroyEnabled", value); }
        }
        public bool CreateGCClusters {
            get {return Main.GetGetBoolPropertyByName(this, "CreateGCClusters"); }
            set {Main.SetGetBoolPropertyByName(this, "CreateGCClusters", value); }
        }
        public bool MergeGCClusters {
            get {return Main.GetGetBoolPropertyByName(this, "MergeGCClusters"); }
            set {Main.SetGetBoolPropertyByName(this, "MergeGCClusters", value); }
        }
        public bool ActorClusteringEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "ActorClusteringEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "ActorClusteringEnabled", value); }
        }
        public bool BlueprintClusteringEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "BlueprintClusteringEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "BlueprintClusteringEnabled", value); }
        }
        public bool UseDisregardForGCOnDedicatedServers {
            get {return Main.GetGetBoolPropertyByName(this, "UseDisregardForGCOnDedicatedServers"); }
            set {Main.SetGetBoolPropertyByName(this, "UseDisregardForGCOnDedicatedServers", value); }
        }
        ///<summary>Minimum GC cluster size.</summary>
        public unsafe int MinGCClusterSize {
            get {return GarbageCollectionSettings_ptr->MinGCClusterSize;}
            set {GarbageCollectionSettings_ptr->MinGCClusterSize = value;}
        }
        ///<summary>Maximum number of times GC can be skipped if worker threads are currently modifying UObject state. 0 = never force GC</summary>
        public unsafe int NumRetriesBeforeForcingGC {
            get {return GarbageCollectionSettings_ptr->NumRetriesBeforeForcingGC;}
            set {GarbageCollectionSettings_ptr->NumRetriesBeforeForcingGC = value;}
        }
        ///<summary>Maximum Object Count Not Considered By GC. Works only in cooked builds.</summary>
        public unsafe int MaxObjectsNotConsideredByGC {
            get {return GarbageCollectionSettings_ptr->MaxObjectsNotConsideredByGC;}
            set {GarbageCollectionSettings_ptr->MaxObjectsNotConsideredByGC = value;}
        }
        ///<summary>Size Of Permanent Object Pool (bytes). Works only in cooked builds.</summary>
        public unsafe int SizeOfPermanentObjectPool {
            get {return GarbageCollectionSettings_ptr->SizeOfPermanentObjectPool;}
            set {GarbageCollectionSettings_ptr->SizeOfPermanentObjectPool = value;}
        }
        ///<summary>Maximum number of UObjects that can exist in cooked game. Keep this as small as possible.</summary>
        public unsafe int MaxObjectsInGame {
            get {return GarbageCollectionSettings_ptr->MaxObjectsInGame;}
            set {GarbageCollectionSettings_ptr->MaxObjectsInGame = value;}
        }
        ///<summary>Maximum number of UObjects that can exist in the editor game. Make sure this can hold enough objects for the editor and commadlets within reasonable limit.</summary>
        public unsafe int MaxObjectsInEditor {
            get {return GarbageCollectionSettings_ptr->MaxObjectsInEditor;}
            set {GarbageCollectionSettings_ptr->MaxObjectsInEditor = value;}
        }
        static GarbageCollectionSettings() {
            StaticClass = Main.GetClass("GarbageCollectionSettings");
        }
        internal unsafe GarbageCollectionSettings_fields* GarbageCollectionSettings_ptr => (GarbageCollectionSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GarbageCollectionSettings(IntPtr p) => UObject.Make<GarbageCollectionSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GarbageCollectionSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GarbageCollectionSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
