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
    [StructLayout( LayoutKind.Explicit, Size=1936 )]
    internal unsafe struct InstancedStaticMeshComponent_fields {
        [FieldOffset(1760)] public NativeArray PerInstanceSMData;
        [FieldOffset(1776)] public int InstancingRandomSeed;
        [FieldOffset(1780)] public int InstanceStartCullDistance;
        [FieldOffset(1784)] public int InstanceEndCullDistance;
        [FieldOffset(1792)] public NativeArray InstanceReorderTable;
        [FieldOffset(1912)] public int NumPendingLightmaps;
        [FieldOffset(1920)] public NativeArray CachedMappings;
    }
    internal unsafe struct InstancedStaticMeshComponent_methods {
        internal struct AddInstance_method {
            static internal IntPtr AddInstance_ptr;
            static AddInstance_method() {
                AddInstance_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "AddInstance");
            }

            internal static unsafe int Invoke(IntPtr obj, Transform InstanceTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = InstanceTransform;
                Main.GetProcessEvent(obj, AddInstance_ptr, new IntPtr(p)); ;
                return *((int*)(b+48));
            }
        }
        internal struct AddInstanceWorldSpace_method {
            static internal IntPtr AddInstanceWorldSpace_ptr;
            static AddInstanceWorldSpace_method() {
                AddInstanceWorldSpace_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "AddInstanceWorldSpace");
            }

            internal static unsafe int Invoke(IntPtr obj, Transform WorldTransform) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = WorldTransform;
                Main.GetProcessEvent(obj, AddInstanceWorldSpace_ptr, new IntPtr(p)); ;
                return *((int*)(b+48));
            }
        }
        internal struct ClearInstances_method {
            static internal IntPtr ClearInstances_ptr;
            static ClearInstances_method() {
                ClearInstances_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "ClearInstances");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearInstances_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetInstanceCount_method {
            static internal IntPtr GetInstanceCount_ptr;
            static GetInstanceCount_method() {
                GetInstanceCount_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "GetInstanceCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInstanceCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetInstancesOverlappingBox_method {
            static internal IntPtr GetInstancesOverlappingBox_ptr;
            static GetInstancesOverlappingBox_method() {
                GetInstancesOverlappingBox_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "GetInstancesOverlappingBox");
            }

            internal static unsafe IReadOnlyCollection<int> Invoke(IntPtr obj, Box Box, bool bBoxInWorldSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Box*)(b+0)) = Box;
                *((bool*)(b+28)) = bBoxInWorldSpace;
                Main.GetProcessEvent(obj, GetInstancesOverlappingBox_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<int>(b+32);
            }
        }
        internal struct GetInstancesOverlappingSphere_method {
            static internal IntPtr GetInstancesOverlappingSphere_ptr;
            static GetInstancesOverlappingSphere_method() {
                GetInstancesOverlappingSphere_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "GetInstancesOverlappingSphere");
            }

            internal static unsafe IReadOnlyCollection<int> Invoke(IntPtr obj, Vector Center, float Radius, bool bSphereInWorldSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = Center;
                *((float*)(b+12)) = Radius;
                *((bool*)(b+16)) = bSphereInWorldSpace;
                Main.GetProcessEvent(obj, GetInstancesOverlappingSphere_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<int>(b+24);
            }
        }
        internal struct GetInstanceTransform_method {
            static internal IntPtr GetInstanceTransform_ptr;
            static GetInstanceTransform_method() {
                GetInstanceTransform_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "GetInstanceTransform");
            }

            internal static unsafe (Transform, bool) Invoke(IntPtr obj, int InstanceIndex, bool bWorldSpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InstanceIndex;
                *((bool*)(b+64)) = bWorldSpace;
                Main.GetProcessEvent(obj, GetInstanceTransform_ptr, new IntPtr(p)); ;
                return (*((Transform*)(b+16)),*((bool*)(b+65)));
            }
        }
        internal struct RemoveInstance_method {
            static internal IntPtr RemoveInstance_ptr;
            static RemoveInstance_method() {
                RemoveInstance_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "RemoveInstance");
            }

            internal static unsafe bool Invoke(IntPtr obj, int InstanceIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InstanceIndex;
                Main.GetProcessEvent(obj, RemoveInstance_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct SetCullDistances_method {
            static internal IntPtr SetCullDistances_ptr;
            static SetCullDistances_method() {
                SetCullDistances_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "SetCullDistances");
            }

            internal static unsafe void Invoke(IntPtr obj, int StartCullDistance, int EndCullDistance) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = StartCullDistance;
                *((int*)(b+4)) = EndCullDistance;
                Main.GetProcessEvent(obj, SetCullDistances_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UpdateInstanceTransform_method {
            static internal IntPtr UpdateInstanceTransform_ptr;
            static UpdateInstanceTransform_method() {
                UpdateInstanceTransform_ptr = Main.GetMethodUFunction(InstancedStaticMeshComponent.StaticClass, "UpdateInstanceTransform");
            }

            internal static unsafe bool Invoke(IntPtr obj, int InstanceIndex, Transform NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InstanceIndex;
                *((Transform*)(b+16)) = NewInstanceTransform;
                *((bool*)(b+64)) = bWorldSpace;
                *((bool*)(b+65)) = bMarkRenderStateDirty;
                *((bool*)(b+66)) = bTeleport;
                Main.GetProcessEvent(obj, UpdateInstanceTransform_ptr, new IntPtr(p)); ;
                return *((bool*)(b+67));
            }
        }
    }
    internal unsafe struct InstancedStaticMeshComponent_events {
    }
}
