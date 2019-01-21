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

namespace UE4.MagicLeap.Native {
    [StructLayout( LayoutKind.Explicit, Size=896 )]
    internal unsafe struct MagicLeapARPinComponent_fields {
        [FieldOffset(624)] byte ObjectUID; //TODO: string FString ObjectUID
        [FieldOffset(640)] byte AutoPinType; //TODO: enum EAutoPinType AutoPinType
        [FieldOffset(641)] public bool bShouldPinActor;
        [FieldOffset(648)] byte OnPersistentEntityPinned; //TODO: multicast delegate FPersistentEntityPinned OnPersistentEntityPinned
        [FieldOffset(664)] public FGuid PinnedCFUID;
        [FieldOffset(680)]  public IntPtr  PinnedSceneComponent;
    }
    internal unsafe struct MagicLeapARPinComponent_methods {
        internal struct GetPinnedPinID_method {
            static internal IntPtr GetPinnedPinID_ptr;
            static GetPinnedPinID_method() {
                GetPinnedPinID_ptr = Main.GetMethodUFunction(MagicLeapARPinComponent.StaticClass, "GetPinnedPinID");
            }

            internal static unsafe (FGuid, bool) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPinnedPinID_ptr, new IntPtr(p)); ;
                return (*((FGuid*)(b+0)),*((bool*)(b+16)));
            }
        }
        internal struct IsPinned_method {
            static internal IntPtr IsPinned_ptr;
            static IsPinned_method() {
                IsPinned_ptr = Main.GetMethodUFunction(MagicLeapARPinComponent.StaticClass, "IsPinned");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPinned_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct PinActor_method {
            static internal IntPtr PinActor_ptr;
            static PinActor_method() {
                PinActor_ptr = Main.GetMethodUFunction(MagicLeapARPinComponent.StaticClass, "PinActor");
            }

            internal static unsafe bool Invoke(IntPtr obj, Actor ActorToPin) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ActorToPin;
                Main.GetProcessEvent(obj, PinActor_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct PinRestoredOrSynced_method {
            static internal IntPtr PinRestoredOrSynced_ptr;
            static PinRestoredOrSynced_method() {
                PinRestoredOrSynced_ptr = Main.GetMethodUFunction(MagicLeapARPinComponent.StaticClass, "PinRestoredOrSynced");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, PinRestoredOrSynced_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct PinSceneComponent_method {
            static internal IntPtr PinSceneComponent_ptr;
            static PinSceneComponent_method() {
                PinSceneComponent_ptr = Main.GetMethodUFunction(MagicLeapARPinComponent.StaticClass, "PinSceneComponent");
            }

            internal static unsafe bool Invoke(IntPtr obj, SceneComponent ComponentToPin) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ComponentToPin;
                Main.GetProcessEvent(obj, PinSceneComponent_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct UnPin_method {
            static internal IntPtr UnPin_ptr;
            static UnPin_method() {
                UnPin_ptr = Main.GetMethodUFunction(MagicLeapARPinComponent.StaticClass, "UnPin");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UnPin_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct MagicLeapARPinComponent_events {
    }
}
