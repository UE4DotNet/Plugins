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

using UE4.Engine;

namespace UE4.FunctionalTesting.Native {
    [StructLayout( LayoutKind.Explicit, Size=1464 )]
    internal unsafe struct FunctionalAITest_fields {
        [FieldOffset(1312)] public NativeArray SpawnSets;
        [FieldOffset(1328)] public float SpawnLocationRandomizationRange;
        [FieldOffset(1336)] public NativeArray SpawnedPawns;
        [FieldOffset(1352)] public NativeArray PendingDelayedSpawns;
        [FieldOffset(1368)] public int CurrentSpawnSetIndex;
        [FieldOffset(1376)] byte CurrentSpawnSetName; //TODO: string FString CurrentSpawnSetName
        [FieldOffset(1392)] byte OnAISpawned; //TODO: multicast delegate FFunctionalTestAISpawned OnAISpawned
        [FieldOffset(1408)] byte OnAllAISPawned; //TODO: multicast delegate FFunctionalTestEventSignature OnAllAISPawned
        [FieldOffset(1424)] public Vector NavMeshDebugOrigin;
        [FieldOffset(1436)] public Vector NavMeshDebugExtent;
        [FieldOffset(1448)] public bool bWaitForNavMesh;
        [FieldOffset(1448)] public bool bDebugNavMeshOnTimeout;
    }
    internal unsafe struct FunctionalAITest_methods {
        internal struct IsOneOfSpawnedPawns_method {
            static internal IntPtr IsOneOfSpawnedPawns_ptr;
            static IsOneOfSpawnedPawns_method() {
                IsOneOfSpawnedPawns_ptr = Main.GetMethodUFunction(FunctionalAITest.StaticClass, "IsOneOfSpawnedPawns");
            }

            internal static unsafe bool Invoke(IntPtr obj, Actor Actor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Actor;
                Main.GetProcessEvent(obj, IsOneOfSpawnedPawns_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
    }
    internal unsafe struct FunctionalAITest_events {
    }
}
