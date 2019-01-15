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
    [StructLayout( LayoutKind.Explicit, Size=1144 )]
    internal unsafe struct Controller_fields {
        [FieldOffset(1016)]  public IntPtr  PlayerState;
        [FieldOffset(1032)] byte OnInstigatedAnyDamage; //TODO: multicast delegate FInstigatedAnyDamageSignature OnInstigatedAnyDamage
        [FieldOffset(1048)] public Name StateName;
        [FieldOffset(1064)]  public IntPtr  Pawn;
        [FieldOffset(1080)]  public IntPtr  Character;
        [FieldOffset(1088)]  public IntPtr  TransformComponent;
        [FieldOffset(1120)] public Rotator ControlRotation;
        [FieldOffset(1132)] public bool bAttachToPawn;
        [FieldOffset(1132)] public bool bIsPlayerController;
    }
    internal unsafe struct Controller_methods {
        internal struct CastToPlayerController_method {
            static internal IntPtr CastToPlayerController_ptr;
            static CastToPlayerController_method() {
                CastToPlayerController_ptr = Main.GetMethodUFunction(Controller.StaticClass, "CastToPlayerController");
            }

            internal static unsafe PlayerController Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CastToPlayerController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetControlRotation_method {
            static internal IntPtr GetControlRotation_ptr;
            static GetControlRotation_method() {
                GetControlRotation_ptr = Main.GetMethodUFunction(Controller.StaticClass, "GetControlRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetControlRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct GetDesiredRotation_method {
            static internal IntPtr GetDesiredRotation_ptr;
            static GetDesiredRotation_method() {
                GetDesiredRotation_ptr = Main.GetMethodUFunction(Controller.StaticClass, "GetDesiredRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDesiredRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct GetViewTarget_method {
            static internal IntPtr GetViewTarget_ptr;
            static GetViewTarget_method() {
                GetViewTarget_ptr = Main.GetMethodUFunction(Controller.StaticClass, "GetViewTarget");
            }

            internal static unsafe Actor Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewTarget_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct IsLocalController_method {
            static internal IntPtr IsLocalController_ptr;
            static IsLocalController_method() {
                IsLocalController_ptr = Main.GetMethodUFunction(Controller.StaticClass, "IsLocalController");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLocalController_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsLocalPlayerController_method {
            static internal IntPtr IsLocalPlayerController_ptr;
            static IsLocalPlayerController_method() {
                IsLocalPlayerController_ptr = Main.GetMethodUFunction(Controller.StaticClass, "IsLocalPlayerController");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLocalPlayerController_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsLookInputIgnored_method {
            static internal IntPtr IsLookInputIgnored_ptr;
            static IsLookInputIgnored_method() {
                IsLookInputIgnored_ptr = Main.GetMethodUFunction(Controller.StaticClass, "IsLookInputIgnored");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLookInputIgnored_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsMoveInputIgnored_method {
            static internal IntPtr IsMoveInputIgnored_ptr;
            static IsMoveInputIgnored_method() {
                IsMoveInputIgnored_ptr = Main.GetMethodUFunction(Controller.StaticClass, "IsMoveInputIgnored");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsMoveInputIgnored_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlayerController_method {
            static internal IntPtr IsPlayerController_ptr;
            static IsPlayerController_method() {
                IsPlayerController_ptr = Main.GetMethodUFunction(Controller.StaticClass, "IsPlayerController");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlayerController_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_GetPawn_method {
            static internal IntPtr K2_GetPawn_ptr;
            static K2_GetPawn_method() {
                K2_GetPawn_ptr = Main.GetMethodUFunction(Controller.StaticClass, "K2_GetPawn");
            }

            internal static unsafe Pawn Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetPawn_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct LineOfSightTo_method {
            static internal IntPtr LineOfSightTo_ptr;
            static LineOfSightTo_method() {
                LineOfSightTo_ptr = Main.GetMethodUFunction(Controller.StaticClass, "LineOfSightTo");
            }

            internal static unsafe bool Invoke(IntPtr obj, Actor Other, Vector ViewPoint, bool bAlternateChecks) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Other;
                *((Vector*)(b+8)) = ViewPoint;
                *((bool*)(b+20)) = bAlternateChecks;
                Main.GetProcessEvent(obj, LineOfSightTo_ptr, new IntPtr(p)); ;
                return *((bool*)(b+21));
            }
        }
        internal struct Possess_method {
            static internal IntPtr Possess_ptr;
            static Possess_method() {
                Possess_ptr = Main.GetMethodUFunction(Controller.StaticClass, "Possess");
            }

            internal static unsafe void Invoke(IntPtr obj, Pawn InPawn) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InPawn;
                Main.GetProcessEvent(obj, Possess_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetIgnoreInputFlags_method {
            static internal IntPtr ResetIgnoreInputFlags_ptr;
            static ResetIgnoreInputFlags_method() {
                ResetIgnoreInputFlags_ptr = Main.GetMethodUFunction(Controller.StaticClass, "ResetIgnoreInputFlags");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetIgnoreInputFlags_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetIgnoreLookInput_method {
            static internal IntPtr ResetIgnoreLookInput_ptr;
            static ResetIgnoreLookInput_method() {
                ResetIgnoreLookInput_ptr = Main.GetMethodUFunction(Controller.StaticClass, "ResetIgnoreLookInput");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetIgnoreLookInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResetIgnoreMoveInput_method {
            static internal IntPtr ResetIgnoreMoveInput_ptr;
            static ResetIgnoreMoveInput_method() {
                ResetIgnoreMoveInput_ptr = Main.GetMethodUFunction(Controller.StaticClass, "ResetIgnoreMoveInput");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetIgnoreMoveInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetControlRotation_method {
            static internal IntPtr SetControlRotation_ptr;
            static SetControlRotation_method() {
                SetControlRotation_ptr = Main.GetMethodUFunction(Controller.StaticClass, "SetControlRotation");
            }

            internal static unsafe void Invoke(IntPtr obj, Rotator NewRotation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Rotator*)(b+0)) = NewRotation;
                Main.GetProcessEvent(obj, SetControlRotation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIgnoreLookInput_method {
            static internal IntPtr SetIgnoreLookInput_ptr;
            static SetIgnoreLookInput_method() {
                SetIgnoreLookInput_ptr = Main.GetMethodUFunction(Controller.StaticClass, "SetIgnoreLookInput");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewLookInput) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewLookInput;
                Main.GetProcessEvent(obj, SetIgnoreLookInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetIgnoreMoveInput_method {
            static internal IntPtr SetIgnoreMoveInput_ptr;
            static SetIgnoreMoveInput_method() {
                SetIgnoreMoveInput_ptr = Main.GetMethodUFunction(Controller.StaticClass, "SetIgnoreMoveInput");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewMoveInput) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewMoveInput;
                Main.GetProcessEvent(obj, SetIgnoreMoveInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInitialLocationAndRotation_method {
            static internal IntPtr SetInitialLocationAndRotation_ptr;
            static SetInitialLocationAndRotation_method() {
                SetInitialLocationAndRotation_ptr = Main.GetMethodUFunction(Controller.StaticClass, "SetInitialLocationAndRotation");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector NewLocation, Rotator NewRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = NewLocation;
                *((Rotator*)(b+12)) = NewRotation;
                Main.GetProcessEvent(obj, SetInitialLocationAndRotation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopMovement_method {
            static internal IntPtr StopMovement_ptr;
            static StopMovement_method() {
                StopMovement_ptr = Main.GetMethodUFunction(Controller.StaticClass, "StopMovement");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopMovement_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnPossess_method {
            static internal IntPtr UnPossess_ptr;
            static UnPossess_method() {
                UnPossess_ptr = Main.GetMethodUFunction(Controller.StaticClass, "UnPossess");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UnPossess_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Controller_events {
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        internal unsafe struct ReceiveInstigatedAnyDamage_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveInstigatedAnyDamage_link;
            private static unsafe void ReceiveInstigatedAnyDamage_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Controller>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveInstigatedAnyDamage(*(float*)(b+0), UObject.Make<DamageType>(*(IntPtr*)(b+8)), UObject.Make<Actor>(*(IntPtr*)(b+16)), UObject.Make<Actor>(*(IntPtr*)(b+24)));
            }
            internal static void Setup() {
                ReceiveInstigatedAnyDamage_link = new DelegateHolder<NativeFuncDelegate>(ReceiveInstigatedAnyDamage_process_event);
                var uf = Main.GetUFunction("ReceiveInstigatedAnyDamage");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveInstigatedAnyDamage_link.Delegate));
            }
        }
    }
}
