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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct GarbageCollectionSettings_fields {
        [FieldOffset(80)] public float TimeBetweenPurgingPendingKillObjects;
        [FieldOffset(84)] public bool FlushStreamingOnGC;
        [FieldOffset(84)] public bool AllowParallelGC;
        [FieldOffset(84)] public bool IncrementalBeginDestroyEnabled;
        [FieldOffset(84)] public bool CreateGCClusters;
        [FieldOffset(84)] public bool MergeGCClusters;
        [FieldOffset(84)] public bool ActorClusteringEnabled;
        [FieldOffset(84)] public bool BlueprintClusteringEnabled;
        [FieldOffset(84)] public bool UseDisregardForGCOnDedicatedServers;
        [FieldOffset(88)] public int MinGCClusterSize;
        [FieldOffset(92)] public int NumRetriesBeforeForcingGC;
        [FieldOffset(96)] public int MaxObjectsNotConsideredByGC;
        [FieldOffset(100)] public int SizeOfPermanentObjectPool;
        [FieldOffset(104)] public int MaxObjectsInGame;
        [FieldOffset(108)] public int MaxObjectsInEditor;
    }
    internal unsafe struct GarbageCollectionSettings_methods {
    }
    internal unsafe struct GarbageCollectionSettings_events {
    }
}
