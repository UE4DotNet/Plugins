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
using UE4.InputCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=1152 )]
    internal unsafe struct WidgetInteractionComponent_fields {
        [FieldOffset(624)] byte OnHoveredWidgetChanged; //TODO: multicast delegate FOnHoveredWidgetChanged OnHoveredWidgetChanged
        [FieldOffset(656)] public int VirtualUserIndex;
        [FieldOffset(660)] public float PointerIndex;
        [FieldOffset(664)] public byte TraceChannel;
        [FieldOffset(668)] public float InteractionDistance;
        [FieldOffset(672)] byte InteractionSource; //TODO: enum EWidgetInteractionSource InteractionSource
        [FieldOffset(673)] public bool bEnableHitTesting;
        [FieldOffset(674)] public bool bShowDebug;
        [FieldOffset(676)] public LinearColor DebugColor;
        [FieldOffset(816)] public HitResult CustomHitResult;
        [FieldOffset(960)] public Vector2D LocalHitLocation;
        [FieldOffset(968)] public Vector2D LastLocalHitLocation;
        [FieldOffset(976)]  public IntPtr  HoveredWidgetComponent;
        [FieldOffset(984)] public HitResult LastHitResult;
        [FieldOffset(1128)] public bool bIsHoveredWidgetInteractable;
        [FieldOffset(1129)] public bool bIsHoveredWidgetFocusable;
        [FieldOffset(1130)] public bool bIsHoveredWidgetHitTestVisible;
        [FieldOffset(1136)]  public IntPtr  ArrowComponent;
    }
    internal unsafe struct WidgetInteractionComponent_methods {
        internal struct Get2DHitLocation_method {
            static internal IntPtr Get2DHitLocation_ptr;
            static Get2DHitLocation_method() {
                Get2DHitLocation_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "Get2DHitLocation");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Get2DHitLocation_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetHoveredWidgetComponent_method {
            static internal IntPtr GetHoveredWidgetComponent_ptr;
            static GetHoveredWidgetComponent_method() {
                GetHoveredWidgetComponent_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "GetHoveredWidgetComponent");
            }

            internal static unsafe WidgetComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetHoveredWidgetComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetLastHitResult_method {
            static internal IntPtr GetLastHitResult_ptr;
            static GetLastHitResult_method() {
                GetLastHitResult_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "GetLastHitResult");
            }

            internal static unsafe void Invoke(IntPtr obj, HitResult ReturnValue) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = ReturnValue;
                Main.GetProcessEvent(obj, GetLastHitResult_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsOverFocusableWidget_method {
            static internal IntPtr IsOverFocusableWidget_ptr;
            static IsOverFocusableWidget_method() {
                IsOverFocusableWidget_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "IsOverFocusableWidget");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsOverFocusableWidget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsOverHitTestVisibleWidget_method {
            static internal IntPtr IsOverHitTestVisibleWidget_ptr;
            static IsOverHitTestVisibleWidget_method() {
                IsOverHitTestVisibleWidget_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "IsOverHitTestVisibleWidget");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsOverHitTestVisibleWidget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsOverInteractableWidget_method {
            static internal IntPtr IsOverInteractableWidget_ptr;
            static IsOverInteractableWidget_method() {
                IsOverInteractableWidget_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "IsOverInteractableWidget");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsOverInteractableWidget_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct PressAndReleaseKey_method {
            static internal IntPtr PressAndReleaseKey_ptr;
            static PressAndReleaseKey_method() {
                PressAndReleaseKey_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "PressAndReleaseKey");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, PressAndReleaseKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct PressKey_method {
            static internal IntPtr PressKey_ptr;
            static PressKey_method() {
                PressKey_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "PressKey");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key, bool bRepeat) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                *((bool*)(b+32)) = bRepeat;
                Main.GetProcessEvent(obj, PressKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+33));
            }
        }
        internal struct PressPointerKey_method {
            static internal IntPtr PressPointerKey_ptr;
            static PressPointerKey_method() {
                PressPointerKey_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "PressPointerKey");
            }

            internal static unsafe void Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, PressPointerKey_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ReleaseKey_method {
            static internal IntPtr ReleaseKey_ptr;
            static ReleaseKey_method() {
                ReleaseKey_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "ReleaseKey");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, ReleaseKey_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct ReleasePointerKey_method {
            static internal IntPtr ReleasePointerKey_ptr;
            static ReleasePointerKey_method() {
                ReleasePointerKey_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "ReleasePointerKey");
            }

            internal static unsafe void Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, ReleasePointerKey_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ScrollWheel_method {
            static internal IntPtr ScrollWheel_ptr;
            static ScrollWheel_method() {
                ScrollWheel_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "ScrollWheel");
            }

            internal static unsafe void Invoke(IntPtr obj, float ScrollDelta) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = ScrollDelta;
                Main.GetProcessEvent(obj, ScrollWheel_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SendKeyChar_method {
            static internal IntPtr SendKeyChar_ptr;
            static SendKeyChar_method() {
                SendKeyChar_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "SendKeyChar");
            }

            internal static unsafe bool Invoke(IntPtr obj, string Characters, bool bRepeat) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                var Characters_handle = GCHandle.Alloc(Characters, GCHandleType.Pinned);
                *(IntPtr*)(b+0) = Characters_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+0) = Characters.Length;
                *(int*)(b+IntPtr.Size+4+0) = Characters.Length;
                *((bool*)(b+16)) = bRepeat;
                Main.GetProcessEvent(obj, SendKeyChar_ptr, new IntPtr(p)); ;
                Characters_handle.Free();
                return *((bool*)(b+17));
            }
        }
        internal struct SetCustomHitResult_method {
            static internal IntPtr SetCustomHitResult_ptr;
            static SetCustomHitResult_method() {
                SetCustomHitResult_ptr = Main.GetMethodUFunction(WidgetInteractionComponent.StaticClass, "SetCustomHitResult");
            }

            internal static unsafe void Invoke(IntPtr obj, HitResult HitResult) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((HitResult*)(b+0)) = HitResult;
                Main.GetProcessEvent(obj, SetCustomHitResult_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct WidgetInteractionComponent_events {
    }
}
