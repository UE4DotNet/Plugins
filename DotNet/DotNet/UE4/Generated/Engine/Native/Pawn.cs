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
    [StructLayout( LayoutKind.Explicit, Size=1104 )]
    internal unsafe struct Pawn_fields {
        [FieldOffset(1016)] public bool bUseControllerRotationPitch;
        [FieldOffset(1016)] public bool bUseControllerRotationYaw;
        [FieldOffset(1016)] public bool bUseControllerRotationRoll;
        [FieldOffset(1016)] public bool bCanAffectNavigationGeneration;
        [FieldOffset(1020)] public float BaseEyeHeight;
        [FieldOffset(1024)] public byte AutoPossessPlayer;
        [FieldOffset(1025)] byte AutoPossessAI; //TODO: enum EAutoPossessAI AutoPossessAI
        [FieldOffset(1032)] public IntPtr AIControllerClass;
        [FieldOffset(1040)]  public IntPtr  PlayerState;
        [FieldOffset(1048)] public byte RemoteViewPitch;
        [FieldOffset(1056)]  public IntPtr  LastHitBy;
        [FieldOffset(1064)]  public IntPtr  Controller;
        [FieldOffset(1076)] public Vector ControlInputVector;
        [FieldOffset(1088)] public Vector LastControlInputVector;
    }
    internal unsafe struct Pawn_methods {
        internal struct AddControllerPitchInput_method {
            static internal IntPtr AddControllerPitchInput_ptr;
            static AddControllerPitchInput_method() {
                AddControllerPitchInput_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "AddControllerPitchInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, AddControllerPitchInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddControllerRollInput_method {
            static internal IntPtr AddControllerRollInput_ptr;
            static AddControllerRollInput_method() {
                AddControllerRollInput_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "AddControllerRollInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, AddControllerRollInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddControllerYawInput_method {
            static internal IntPtr AddControllerYawInput_ptr;
            static AddControllerYawInput_method() {
                AddControllerYawInput_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "AddControllerYawInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, AddControllerYawInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddMovementInput_method {
            static internal IntPtr AddMovementInput_ptr;
            static AddMovementInput_method() {
                AddMovementInput_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "AddMovementInput");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector WorldDirection, float ScaleValue, bool bForce) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldDirection;
                *((float*)(b+12)) = ScaleValue;
                *((bool*)(b+16)) = bForce;
                Main.GetProcessEvent(obj, AddMovementInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ConsumeMovementInputVector_method {
            static internal IntPtr ConsumeMovementInputVector_ptr;
            static ConsumeMovementInputVector_method() {
                ConsumeMovementInputVector_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "ConsumeMovementInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ConsumeMovementInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct DetachFromControllerPendingDestroy_method {
            static internal IntPtr DetachFromControllerPendingDestroy_ptr;
            static DetachFromControllerPendingDestroy_method() {
                DetachFromControllerPendingDestroy_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "DetachFromControllerPendingDestroy");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, DetachFromControllerPendingDestroy_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetBaseAimRotation_method {
            static internal IntPtr GetBaseAimRotation_ptr;
            static GetBaseAimRotation_method() {
                GetBaseAimRotation_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetBaseAimRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBaseAimRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct GetController_method {
            static internal IntPtr GetController_ptr;
            static GetController_method() {
                GetController_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetController");
            }

            internal static unsafe Controller Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetControlRotation_method {
            static internal IntPtr GetControlRotation_ptr;
            static GetControlRotation_method() {
                GetControlRotation_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetControlRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetControlRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct GetLastMovementInputVector_method {
            static internal IntPtr GetLastMovementInputVector_ptr;
            static GetLastMovementInputVector_method() {
                GetLastMovementInputVector_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetLastMovementInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLastMovementInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetMovementBaseActor_method {
            static internal IntPtr GetMovementBaseActor_ptr;
            static GetMovementBaseActor_method() {
                GetMovementBaseActor_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetMovementBaseActor");
            }

            internal static unsafe Actor Invoke(Pawn Pawn) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Pawn;
                Main.GetProcessEvent(Pawn.DefaultObject, GetMovementBaseActor_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetMovementComponent_method {
            static internal IntPtr GetMovementComponent_ptr;
            static GetMovementComponent_method() {
                GetMovementComponent_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetMovementComponent");
            }

            internal static unsafe PawnMovementComponent Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMovementComponent_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetNavAgentLocation_method {
            static internal IntPtr GetNavAgentLocation_ptr;
            static GetNavAgentLocation_method() {
                GetNavAgentLocation_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetNavAgentLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNavAgentLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetPendingMovementInputVector_method {
            static internal IntPtr GetPendingMovementInputVector_ptr;
            static GetPendingMovementInputVector_method() {
                GetPendingMovementInputVector_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "GetPendingMovementInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPendingMovementInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct IsControlled_method {
            static internal IntPtr IsControlled_ptr;
            static IsControlled_method() {
                IsControlled_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "IsControlled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsControlled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsLocallyControlled_method {
            static internal IntPtr IsLocallyControlled_ptr;
            static IsLocallyControlled_method() {
                IsLocallyControlled_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "IsLocallyControlled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsLocallyControlled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsMoveInputIgnored_method {
            static internal IntPtr IsMoveInputIgnored_ptr;
            static IsMoveInputIgnored_method() {
                IsMoveInputIgnored_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "IsMoveInputIgnored");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsMoveInputIgnored_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlayerControlled_method {
            static internal IntPtr IsPlayerControlled_ptr;
            static IsPlayerControlled_method() {
                IsPlayerControlled_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "IsPlayerControlled");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlayerControlled_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct K2_GetMovementInputVector_method {
            static internal IntPtr K2_GetMovementInputVector_ptr;
            static K2_GetMovementInputVector_method() {
                K2_GetMovementInputVector_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "K2_GetMovementInputVector");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, K2_GetMovementInputVector_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct LaunchPawn_method {
            static internal IntPtr LaunchPawn_ptr;
            static LaunchPawn_method() {
                LaunchPawn_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "LaunchPawn");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector LaunchVelocity, bool bXYOverride, bool bZOverride) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = LaunchVelocity;
                *((bool*)(b+12)) = bXYOverride;
                *((bool*)(b+13)) = bZOverride;
                Main.GetProcessEvent(obj, LaunchPawn_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PawnMakeNoise_method {
            static internal IntPtr PawnMakeNoise_ptr;
            static PawnMakeNoise_method() {
                PawnMakeNoise_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "PawnMakeNoise");
            }

            internal static unsafe void Invoke(IntPtr obj, float Loudness, Vector NoiseLocation, bool bUseNoiseMakerLocation, Actor NoiseMaker) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Loudness;
                *((Vector*)(b+4)) = NoiseLocation;
                *((bool*)(b+16)) = bUseNoiseMakerLocation;
                *((IntPtr*)(b+24)) = NoiseMaker;
                Main.GetProcessEvent(obj, PawnMakeNoise_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCanAffectNavigationGeneration_method {
            static internal IntPtr SetCanAffectNavigationGeneration_ptr;
            static SetCanAffectNavigationGeneration_method() {
                SetCanAffectNavigationGeneration_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "SetCanAffectNavigationGeneration");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue, bool bForceUpdate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                *((bool*)(b+1)) = bForceUpdate;
                Main.GetProcessEvent(obj, SetCanAffectNavigationGeneration_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SpawnDefaultController_method {
            static internal IntPtr SpawnDefaultController_ptr;
            static SpawnDefaultController_method() {
                SpawnDefaultController_ptr = Main.GetMethodUFunction(Pawn.StaticClass, "SpawnDefaultController");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, SpawnDefaultController_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Pawn_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceivePossessed_event {
            private static DelegateHolder<NativeFuncDelegate> ReceivePossessed_link;
            private static unsafe void ReceivePossessed_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Pawn>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceivePossessed(UObject.Make<Controller>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceivePossessed_link = new DelegateHolder<NativeFuncDelegate>(ReceivePossessed_process_event);
                var uf = Main.GetUFunction("ReceivePossessed");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceivePossessed_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct ReceiveUnpossessed_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveUnpossessed_link;
            private static unsafe void ReceiveUnpossessed_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Pawn>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveUnpossessed(UObject.Make<Controller>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                ReceiveUnpossessed_link = new DelegateHolder<NativeFuncDelegate>(ReceiveUnpossessed_process_event);
                var uf = Main.GetUFunction("ReceiveUnpossessed");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveUnpossessed_link.Delegate));
            }
        }
    }
}
