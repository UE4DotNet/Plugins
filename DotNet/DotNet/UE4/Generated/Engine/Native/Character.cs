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
    [StructLayout( LayoutKind.Explicit, Size=2064 )]
    internal unsafe struct Character_fields {
        [FieldOffset(1104)]  public IntPtr  Mesh;
        [FieldOffset(1112)]  public IntPtr  CharacterMovement;
        [FieldOffset(1120)]  public IntPtr  CapsuleComponent;
        [FieldOffset(1128)]  public IntPtr  ArrowComponent;
        [FieldOffset(1136)] public BasedMovementInfo BasedMovement;
        [FieldOffset(1184)] public BasedMovementInfo ReplicatedBasedMovement;
        [FieldOffset(1232)] public float AnimRootMotionTranslationScale;
        [FieldOffset(1236)] public Vector BaseTranslationOffset;
        [FieldOffset(1248)] public Quat BaseRotationOffset;
        [FieldOffset(1264)] public float ReplicatedServerLastTransformUpdateTimeStamp;
        [FieldOffset(1268)] public float ReplayLastTransformUpdateTimeStamp;
        [FieldOffset(1272)] public byte ReplicatedMovementMode;
        [FieldOffset(1273)] public bool bInBaseReplication;
        [FieldOffset(1276)] public float CrouchedEyeHeight;
        [FieldOffset(1280)] public bool bIsCrouched;
        [FieldOffset(1280)] public bool bProxyIsJumpForceApplied;
        [FieldOffset(1280)] public bool bPressedJump;
        [FieldOffset(1280)] public bool bClientUpdating;
        [FieldOffset(1280)] public bool bClientWasFalling;
        [FieldOffset(1280)] public bool bClientResimulateRootMotion;
        [FieldOffset(1280)] public bool bClientResimulateRootMotionSources;
        [FieldOffset(1280)] public bool bSimGravityDisabled;
        [FieldOffset(1281)] public bool bClientCheckEncroachmentOnNetUpdate;
        [FieldOffset(1281)] public bool bServerMoveIgnoreRootMotion;
        [FieldOffset(1281)] public bool bWasJumping;
        [FieldOffset(1284)] public float JumpKeyHoldTime;
        [FieldOffset(1288)] public float JumpForceTimeRemaining;
        [FieldOffset(1292)] public float ProxyJumpForceStartedTime;
        [FieldOffset(1296)] public float JumpMaxHoldTime;
        [FieldOffset(1300)] public int JumpMaxCount;
        [FieldOffset(1304)] public int JumpCurrentCount;
        [FieldOffset(1312)] byte OnReachedJumpApex; //TODO: multicast delegate FCharacterReachedApexSignature OnReachedJumpApex
        [FieldOffset(1344)] byte MovementModeChangedDelegate; //TODO: multicast delegate FMovementModeChangedSignature MovementModeChangedDelegate
        [FieldOffset(1360)] byte OnCharacterMovementUpdated; //TODO: multicast delegate FCharacterMovementUpdatedSignature OnCharacterMovementUpdated
        [FieldOffset(1376)] public RootMotionSourceGroup SavedRootMotion;
        [FieldOffset(1632)] public RootMotionMovementParams ClientRootMotionParams;
        [FieldOffset(1696)] public NativeArray RootMotionRepMoves;
        [FieldOffset(1712)] public RepRootMotionMontage RepRootMotion;
    }
    internal unsafe struct Character_methods {
        internal struct CacheInitialMeshOffset_method {
            static internal IntPtr CacheInitialMeshOffset_ptr;
            static CacheInitialMeshOffset_method() {
                CacheInitialMeshOffset_ptr = Main.GetMethodUFunction(Character.StaticClass, "CacheInitialMeshOffset");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector MeshRelativeLocation, Rotator MeshRelativeRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = MeshRelativeLocation;
                *((Rotator*)(b+12)) = MeshRelativeRotation;
                Main.GetProcessEvent(obj, CacheInitialMeshOffset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CanJump_method {
            static internal IntPtr CanJump_ptr;
            static CanJump_method() {
                CanJump_ptr = Main.GetMethodUFunction(Character.StaticClass, "CanJump");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CanJump_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Crouch_method {
            static internal IntPtr Crouch_ptr;
            static Crouch_method() {
                Crouch_ptr = Main.GetMethodUFunction(Character.StaticClass, "Crouch");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bClientSimulation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bClientSimulation;
                Main.GetProcessEvent(obj, Crouch_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAnimRootMotionTranslationScale_method {
            static internal IntPtr GetAnimRootMotionTranslationScale_ptr;
            static GetAnimRootMotionTranslationScale_method() {
                GetAnimRootMotionTranslationScale_ptr = Main.GetMethodUFunction(Character.StaticClass, "GetAnimRootMotionTranslationScale");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnimRootMotionTranslationScale_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetBaseRotationOffsetRotator_method {
            static internal IntPtr GetBaseRotationOffsetRotator_ptr;
            static GetBaseRotationOffsetRotator_method() {
                GetBaseRotationOffsetRotator_ptr = Main.GetMethodUFunction(Character.StaticClass, "GetBaseRotationOffsetRotator");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBaseRotationOffsetRotator_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct GetBaseTranslationOffset_method {
            static internal IntPtr GetBaseTranslationOffset_ptr;
            static GetBaseTranslationOffset_method() {
                GetBaseTranslationOffset_ptr = Main.GetMethodUFunction(Character.StaticClass, "GetBaseTranslationOffset");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBaseTranslationOffset_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetCurrentMontage_method {
            static internal IntPtr GetCurrentMontage_ptr;
            static GetCurrentMontage_method() {
                GetCurrentMontage_ptr = Main.GetMethodUFunction(Character.StaticClass, "GetCurrentMontage");
            }

            internal static unsafe AnimMontage Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentMontage_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct IsJumpProvidingForce_method {
            static internal IntPtr IsJumpProvidingForce_ptr;
            static IsJumpProvidingForce_method() {
                IsJumpProvidingForce_ptr = Main.GetMethodUFunction(Character.StaticClass, "IsJumpProvidingForce");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsJumpProvidingForce_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlayingNetworkedRootMotionMontage_method {
            static internal IntPtr IsPlayingNetworkedRootMotionMontage_ptr;
            static IsPlayingNetworkedRootMotionMontage_method() {
                IsPlayingNetworkedRootMotionMontage_ptr = Main.GetMethodUFunction(Character.StaticClass, "IsPlayingNetworkedRootMotionMontage");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlayingNetworkedRootMotionMontage_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsPlayingRootMotion_method {
            static internal IntPtr IsPlayingRootMotion_ptr;
            static IsPlayingRootMotion_method() {
                IsPlayingRootMotion_ptr = Main.GetMethodUFunction(Character.StaticClass, "IsPlayingRootMotion");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlayingRootMotion_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct Jump_method {
            static internal IntPtr Jump_ptr;
            static Jump_method() {
                Jump_ptr = Main.GetMethodUFunction(Character.StaticClass, "Jump");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Jump_ptr, new IntPtr(p)); ;
            }
        }
        internal struct LaunchCharacter_method {
            static internal IntPtr LaunchCharacter_ptr;
            static LaunchCharacter_method() {
                LaunchCharacter_ptr = Main.GetMethodUFunction(Character.StaticClass, "LaunchCharacter");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector LaunchVelocity, bool bXYOverride, bool bZOverride) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = LaunchVelocity;
                *((bool*)(b+12)) = bXYOverride;
                *((bool*)(b+13)) = bZOverride;
                Main.GetProcessEvent(obj, LaunchCharacter_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayAnimMontage_method {
            static internal IntPtr PlayAnimMontage_ptr;
            static PlayAnimMontage_method() {
                PlayAnimMontage_ptr = Main.GetMethodUFunction(Character.StaticClass, "PlayAnimMontage");
            }

            internal static unsafe float Invoke(IntPtr obj, AnimMontage AnimMontage, float InPlayRate, Name StartSectionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimMontage;
                *((float*)(b+8)) = InPlayRate;
                *((Name*)(b+12)) = StartSectionName;
                Main.GetProcessEvent(obj, PlayAnimMontage_ptr, new IntPtr(p)); ;
                return *((float*)(b+24));
            }
        }
        internal struct StopAnimMontage_method {
            static internal IntPtr StopAnimMontage_ptr;
            static StopAnimMontage_method() {
                StopAnimMontage_ptr = Main.GetMethodUFunction(Character.StaticClass, "StopAnimMontage");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimMontage AnimMontage) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimMontage;
                Main.GetProcessEvent(obj, StopAnimMontage_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopJumping_method {
            static internal IntPtr StopJumping_ptr;
            static StopJumping_method() {
                StopJumping_ptr = Main.GetMethodUFunction(Character.StaticClass, "StopJumping");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopJumping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnCrouch_method {
            static internal IntPtr UnCrouch_ptr;
            static UnCrouch_method() {
                UnCrouch_ptr = Main.GetMethodUFunction(Character.StaticClass, "UnCrouch");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bClientSimulation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bClientSimulation;
                Main.GetProcessEvent(obj, UnCrouch_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct Character_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_OnEndCrouch_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnEndCrouch_link;
            private static unsafe void K2_OnEndCrouch_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnEndCrouch(*(float*)(b+0), *(float*)(b+4));
            }
            internal static void Setup() {
                K2_OnEndCrouch_link = new DelegateHolder<NativeFuncDelegate>(K2_OnEndCrouch_process_event);
                var uf = Main.GetUFunction("K2_OnEndCrouch");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnEndCrouch_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct K2_OnMovementModeChanged_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnMovementModeChanged_link;
            private static unsafe void K2_OnMovementModeChanged_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnMovementModeChanged(*(b+0), *(b+1), *(b+2), *(b+3));
            }
            internal static void Setup() {
                K2_OnMovementModeChanged_link = new DelegateHolder<NativeFuncDelegate>(K2_OnMovementModeChanged_process_event);
                var uf = Main.GetUFunction("K2_OnMovementModeChanged");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnMovementModeChanged_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct K2_OnStartCrouch_event {
            private static DelegateHolder<NativeFuncDelegate> K2_OnStartCrouch_link;
            private static unsafe void K2_OnStartCrouch_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_OnStartCrouch(*(float*)(b+0), *(float*)(b+4));
            }
            internal static void Setup() {
                K2_OnStartCrouch_link = new DelegateHolder<NativeFuncDelegate>(K2_OnStartCrouch_process_event);
                var uf = Main.GetUFunction("K2_OnStartCrouch");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_OnStartCrouch_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        internal unsafe struct K2_UpdateCustomMovement_event {
            private static DelegateHolder<NativeFuncDelegate> K2_UpdateCustomMovement_link;
            private static unsafe void K2_UpdateCustomMovement_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;

                obj.on_K2_UpdateCustomMovement(*(float*)(b+0));
            }
            internal static void Setup() {
                K2_UpdateCustomMovement_link = new DelegateHolder<NativeFuncDelegate>(K2_UpdateCustomMovement_process_event);
                var uf = Main.GetUFunction("K2_UpdateCustomMovement");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(K2_UpdateCustomMovement_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        internal unsafe struct OnLanded_event {
            private static DelegateHolder<NativeFuncDelegate> OnLanded_link;
            private static unsafe void OnLanded_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnLanded(*(HitResult*)(b+0));
            }
            internal static void Setup() {
                OnLanded_link = new DelegateHolder<NativeFuncDelegate>(OnLanded_process_event);
                var uf = Main.GetUFunction("OnLanded");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnLanded_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct OnLaunched_event {
            private static DelegateHolder<NativeFuncDelegate> OnLaunched_link;
            private static unsafe void OnLaunched_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnLaunched(*(Vector*)(b+0), *(bool*)(b+12), *(bool*)(b+13));
            }
            internal static void Setup() {
                OnLaunched_link = new DelegateHolder<NativeFuncDelegate>(OnLaunched_process_event);
                var uf = Main.GetUFunction("OnLaunched");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnLaunched_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct CanJumpInternal_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> CanJumpInternal_link;
            private static unsafe void CanJumpInternal_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_CanJumpInternal(*(bool*)result);
            }
            internal static void Setup() {
                CanJumpInternal_link = new DelegateHolder<NativeFuncDelegate>(CanJumpInternal_process_event);
                var uf = Main.GetUFunction("CanJumpInternal");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(CanJumpInternal_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnJumped_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnJumped_link;
            private static unsafe void OnJumped_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnJumped();
            }
            internal static void Setup() {
                OnJumped_link = new DelegateHolder<NativeFuncDelegate>(OnJumped_process_event);
                var uf = Main.GetUFunction("OnJumped");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnJumped_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        internal unsafe struct OnWalkingOffLedge_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnWalkingOffLedge_link;
            private static unsafe void OnWalkingOffLedge_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<Character>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnWalkingOffLedge(*(Vector*)(b+0), *(Vector*)(b+12), *(Vector*)(b+24), *(float*)(b+36));
            }
            internal static void Setup() {
                OnWalkingOffLedge_link = new DelegateHolder<NativeFuncDelegate>(OnWalkingOffLedge_process_event);
                var uf = Main.GetUFunction("OnWalkingOffLedge");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnWalkingOffLedge_link.Delegate));
            }
        }
    }
}
