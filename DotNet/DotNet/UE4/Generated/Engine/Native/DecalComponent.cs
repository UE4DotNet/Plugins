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
    [StructLayout( LayoutKind.Explicit, Size=688 )]
    internal unsafe struct DecalComponent_fields {
        [FieldOffset(624)]  public IntPtr  DecalMaterial;
        [FieldOffset(632)] public int SortOrder;
        [FieldOffset(636)] public float FadeScreenSize;
        [FieldOffset(640)] public float FadeStartDelay;
        [FieldOffset(644)] public float FadeDuration;
        [FieldOffset(648)] public float FadeInDuration;
        [FieldOffset(652)] public float FadeInStartDelay;
        [FieldOffset(656)] public bool bDestroyOwnerAfterFade;
        [FieldOffset(660)] public Vector DecalSize;
    }
    internal unsafe struct DecalComponent_methods {
        internal struct CreateDynamicMaterialInstance_method {
            static internal IntPtr CreateDynamicMaterialInstance_ptr;
            static CreateDynamicMaterialInstance_method() {
                CreateDynamicMaterialInstance_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "CreateDynamicMaterialInstance");
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
                GetDecalMaterial_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "GetDecalMaterial");
            }

            internal static unsafe MaterialInterface Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDecalMaterial_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetFadeDuration_method {
            static internal IntPtr GetFadeDuration_ptr;
            static GetFadeDuration_method() {
                GetFadeDuration_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "GetFadeDuration");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFadeDuration_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetFadeInDuration_method {
            static internal IntPtr GetFadeInDuration_ptr;
            static GetFadeInDuration_method() {
                GetFadeInDuration_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "GetFadeInDuration");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFadeInDuration_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetFadeInStartDelay_method {
            static internal IntPtr GetFadeInStartDelay_ptr;
            static GetFadeInStartDelay_method() {
                GetFadeInStartDelay_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "GetFadeInStartDelay");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFadeInStartDelay_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetFadeStartDelay_method {
            static internal IntPtr GetFadeStartDelay_ptr;
            static GetFadeStartDelay_method() {
                GetFadeStartDelay_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "GetFadeStartDelay");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFadeStartDelay_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct SetDecalMaterial_method {
            static internal IntPtr SetDecalMaterial_ptr;
            static SetDecalMaterial_method() {
                SetDecalMaterial_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "SetDecalMaterial");
            }

            internal static unsafe void Invoke(IntPtr obj, MaterialInterface NewDecalMaterial) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewDecalMaterial;
                Main.GetProcessEvent(obj, SetDecalMaterial_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFadeIn_method {
            static internal IntPtr SetFadeIn_ptr;
            static SetFadeIn_method() {
                SetFadeIn_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "SetFadeIn");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartDelay, float Duaration) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartDelay;
                *((float*)(b+4)) = Duaration;
                Main.GetProcessEvent(obj, SetFadeIn_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFadeOut_method {
            static internal IntPtr SetFadeOut_ptr;
            static SetFadeOut_method() {
                SetFadeOut_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "SetFadeOut");
            }

            internal static unsafe void Invoke(IntPtr obj, float StartDelay, float Duration, bool DestroyOwnerAfterFade) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = StartDelay;
                *((float*)(b+4)) = Duration;
                *((bool*)(b+8)) = DestroyOwnerAfterFade;
                Main.GetProcessEvent(obj, SetFadeOut_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetFadeScreenSize_method {
            static internal IntPtr SetFadeScreenSize_ptr;
            static SetFadeScreenSize_method() {
                SetFadeScreenSize_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "SetFadeScreenSize");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewFadeScreenSize) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewFadeScreenSize;
                Main.GetProcessEvent(obj, SetFadeScreenSize_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSortOrder_method {
            static internal IntPtr SetSortOrder_ptr;
            static SetSortOrder_method() {
                SetSortOrder_ptr = Main.GetMethodUFunction(DecalComponent.StaticClass, "SetSortOrder");
            }

            internal static unsafe void Invoke(IntPtr obj, int Value) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = Value;
                Main.GetProcessEvent(obj, SetSortOrder_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct DecalComponent_events {
    }
}
