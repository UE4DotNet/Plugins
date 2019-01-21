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

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=480 )]
    internal unsafe struct RetainerBox_fields {
        [FieldOffset(424)] public bool RenderOnInvalidation;
        [FieldOffset(425)] public bool RenderOnPhase;
        [FieldOffset(428)] public int Phase;
        [FieldOffset(432)] public int PhaseCount;
        [FieldOffset(440)]  public IntPtr  EffectMaterial;
        [FieldOffset(448)] public Name TextureParameter;
    }
    internal unsafe struct RetainerBox_methods {
        internal struct GetEffectMaterial_method {
            static internal IntPtr GetEffectMaterial_ptr;
            static GetEffectMaterial_method() {
                GetEffectMaterial_ptr = Main.GetMethodUFunction(RetainerBox.StaticClass, "GetEffectMaterial");
            }

            internal static unsafe MaterialInstanceDynamic Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetEffectMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct RequestRender_method {
            static internal IntPtr RequestRender_ptr;
            static RequestRender_method() {
                RequestRender_ptr = Main.GetMethodUFunction(RetainerBox.StaticClass, "RequestRender");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RequestRender_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetEffectMaterial_method {
            static internal IntPtr SetEffectMaterial_ptr;
            static SetEffectMaterial_method() {
                SetEffectMaterial_ptr = Main.GetMethodUFunction(RetainerBox.StaticClass, "SetEffectMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface EffectMaterial) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = EffectMaterial;
                Main.GetProcessEvent(obj, SetEffectMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderingPhase_method {
            static internal IntPtr SetRenderingPhase_ptr;
            static SetRenderingPhase_method() {
                SetRenderingPhase_ptr = Main.GetMethodUFunction(RetainerBox.StaticClass, "SetRenderingPhase");
            }

            internal static unsafe void Invoke(IntPtr obj, int RenderPhase, int TotalPhases) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = RenderPhase;
                *((int*)(b+4)) = TotalPhases;
                Main.GetProcessEvent(obj, SetRenderingPhase_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetTextureParameter_method {
            static internal IntPtr SetTextureParameter_ptr;
            static SetTextureParameter_method() {
                SetTextureParameter_ptr = Main.GetMethodUFunction(RetainerBox.StaticClass, "SetTextureParameter");
            }

            internal static unsafe void Invoke(IntPtr obj, Name TextureParameter) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = TextureParameter;
                Main.GetProcessEvent(obj, SetTextureParameter_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct RetainerBox_events {
    }
}
