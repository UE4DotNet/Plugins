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
    [StructLayout( LayoutKind.Explicit, Size=704 )]
    internal unsafe struct LightComponentBase_fields {
        [FieldOffset(624)] public FGuid LightGuid;
        [FieldOffset(644)] public float Intensity;
        [FieldOffset(648)] public Color LightColor;
        [FieldOffset(652)] public bool bAffectsWorld;
        [FieldOffset(652)] public bool CastShadows;
        [FieldOffset(652)] public bool CastStaticShadows;
        [FieldOffset(652)] public bool CastDynamicShadows;
        [FieldOffset(652)] public bool bAffectTranslucentLighting;
        [FieldOffset(652)] public bool bTransmission;
        [FieldOffset(652)] public bool bCastVolumetricShadow;
        [FieldOffset(656)] public float IndirectLightingIntensity;
        [FieldOffset(660)] public float VolumetricScatteringIntensity;
        [FieldOffset(664)]  public IntPtr  StaticEditorTexture;
        [FieldOffset(672)] public float StaticEditorTextureScale;
        [FieldOffset(680)]  public IntPtr  DynamicEditorTexture;
        [FieldOffset(688)] public float DynamicEditorTextureScale;
    }
    internal unsafe struct LightComponentBase_methods {
        internal struct GetLightColor_method {
            static internal IntPtr GetLightColor_ptr;
            static GetLightColor_method() {
                GetLightColor_ptr = Main.GetMethodUFunction(LightComponentBase.StaticClass, "GetLightColor");
            }

            internal static unsafe LinearColor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLightColor_ptr, new IntPtr(p)); ;
                return *((LinearColor*)(b+0));
            }
        }
        internal struct SetCastShadows_method {
            static internal IntPtr SetCastShadows_ptr;
            static SetCastShadows_method() {
                SetCastShadows_ptr = Main.GetMethodUFunction(LightComponentBase.StaticClass, "SetCastShadows");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetCastShadows_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCastVolumetricShadow_method {
            static internal IntPtr SetCastVolumetricShadow_ptr;
            static SetCastVolumetricShadow_method() {
                SetCastVolumetricShadow_ptr = Main.GetMethodUFunction(LightComponentBase.StaticClass, "SetCastVolumetricShadow");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetCastVolumetricShadow_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct LightComponentBase_events {
    }
}
