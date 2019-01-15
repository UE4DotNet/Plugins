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
    [StructLayout( LayoutKind.Explicit, Size=1040 )]
    internal unsafe struct DecalActor_fields {
        [FieldOffset(1008)]  public IntPtr  Decal;
        [FieldOffset(1016)]  public IntPtr  ArrowComponent;
        [FieldOffset(1024)]  public IntPtr  SpriteComponent;
    }
    internal unsafe struct DecalActor_methods {
        internal struct CreateDynamicMaterialInstance_method {
            static internal IntPtr CreateDynamicMaterialInstance_ptr;
            static CreateDynamicMaterialInstance_method() {
                CreateDynamicMaterialInstance_ptr = Main.GetMethodUFunction(DecalActor.StaticClass, "CreateDynamicMaterialInstance");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CreateDynamicMaterialInstance_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetDecalMaterial_method {
            static internal IntPtr GetDecalMaterial_ptr;
            static GetDecalMaterial_method() {
                GetDecalMaterial_ptr = Main.GetMethodUFunction(DecalActor.StaticClass, "GetDecalMaterial");
            }

            internal static unsafe MaterialInterface Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDecalMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetDecalMaterial_method {
            static internal IntPtr SetDecalMaterial_ptr;
            static SetDecalMaterial_method() {
                SetDecalMaterial_ptr = Main.GetMethodUFunction(DecalActor.StaticClass, "SetDecalMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface NewDecalMaterial) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewDecalMaterial;
                Main.GetProcessEvent(obj, SetDecalMaterial_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct DecalActor_events {
    }
}
