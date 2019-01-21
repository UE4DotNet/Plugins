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
    [StructLayout( LayoutKind.Explicit, Size=2176 )]
    internal unsafe struct HierarchicalInstancedStaticMeshComponent_fields {
        [FieldOffset(1936)] public NativeArray SortedInstances;
        [FieldOffset(1952)] public int NumBuiltInstances;
        [FieldOffset(1960)] public Box BuiltInstanceBounds;
        [FieldOffset(1988)] public Box UnbuiltInstanceBounds;
        [FieldOffset(2016)] public NativeArray UnbuiltInstanceBoundsList;
        [FieldOffset(2032)] public bool bEnableDensityScaling;
        [FieldOffset(2044)] public int OcclusionLayerNumNodes;
        [FieldOffset(2048)] public BoxSphereBounds CacheMeshExtendedBounds;
        [FieldOffset(2080)] public bool bDisableCollision;
        [FieldOffset(2084)] public int InstanceCountToRender;
    }
    internal unsafe struct HierarchicalInstancedStaticMeshComponent_methods {
        internal struct RemoveInstances_method {
            static internal IntPtr RemoveInstances_ptr;
            static RemoveInstances_method() {
                RemoveInstances_ptr = Main.GetMethodUFunction(HierarchicalInstancedStaticMeshComponent.StaticClass, "RemoveInstances");
            }

            internal static unsafe bool Invoke(IntPtr obj, byte InstancesToRemove /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray InstancesToRemove
                Main.GetProcessEvent(obj, RemoveInstances_ptr, new IntPtr(p)); ;
                 //TODO: array TArray InstancesToRemove
                return *((bool*)(b+16));
            }
        }
    }
    internal unsafe struct HierarchicalInstancedStaticMeshComponent_events {
    }
}
