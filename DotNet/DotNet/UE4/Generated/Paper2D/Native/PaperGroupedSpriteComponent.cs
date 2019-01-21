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


namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=1600 )]
    internal unsafe struct PaperGroupedSpriteComponent_fields {
        [FieldOffset(1544)] public NativeArray InstanceMaterials;
        [FieldOffset(1560)] public NativeArray PerInstanceSpriteData;
    }
    internal unsafe struct PaperGroupedSpriteComponent_methods {
        internal struct AddInstance_method {
            static internal IntPtr AddInstance_ptr;
            static AddInstance_method() {
                AddInstance_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "AddInstance");
            }

            internal static unsafe int Invoke(IntPtr obj, Transform Transform, PaperSprite Sprite, bool bWorldSpace, LinearColor Color) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Transform*)(b+0)) = Transform;
                *((IntPtr*)(b+48)) = Sprite;
                *((bool*)(b+56)) = bWorldSpace;
                *((LinearColor*)(b+60)) = Color;
                Main.GetProcessEvent(obj, AddInstance_ptr, new IntPtr(p)); ;
                return *((int*)(b+76));
            }
        }
        internal struct ClearInstances_method {
            static internal IntPtr ClearInstances_ptr;
            static ClearInstances_method() {
                ClearInstances_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "ClearInstances");
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
                GetInstanceCount_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "GetInstanceCount");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInstanceCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetInstanceTransform_method {
            static internal IntPtr GetInstanceTransform_ptr;
            static GetInstanceTransform_method() {
                GetInstanceTransform_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "GetInstanceTransform");
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
                RemoveInstance_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "RemoveInstance");
            }

            internal static unsafe bool Invoke(IntPtr obj, int InstanceIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InstanceIndex;
                Main.GetProcessEvent(obj, RemoveInstance_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct SortInstancesAlongAxis_method {
            static internal IntPtr SortInstancesAlongAxis_ptr;
            static SortInstancesAlongAxis_method() {
                SortInstancesAlongAxis_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "SortInstancesAlongAxis");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector WorldSpaceSortAxis) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldSpaceSortAxis;
                Main.GetProcessEvent(obj, SortInstancesAlongAxis_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UpdateInstanceColor_method {
            static internal IntPtr UpdateInstanceColor_ptr;
            static UpdateInstanceColor_method() {
                UpdateInstanceColor_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "UpdateInstanceColor");
            }

            internal static unsafe bool Invoke(IntPtr obj, int InstanceIndex, LinearColor NewInstanceColor, bool bMarkRenderStateDirty) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InstanceIndex;
                *((LinearColor*)(b+4)) = NewInstanceColor;
                *((bool*)(b+20)) = bMarkRenderStateDirty;
                Main.GetProcessEvent(obj, UpdateInstanceColor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+21));
            }
        }
        internal struct UpdateInstanceTransform_method {
            static internal IntPtr UpdateInstanceTransform_ptr;
            static UpdateInstanceTransform_method() {
                UpdateInstanceTransform_ptr = Main.GetMethodUFunction(PaperGroupedSpriteComponent.StaticClass, "UpdateInstanceTransform");
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
    internal unsafe struct PaperGroupedSpriteComponent_events {
    }
}
