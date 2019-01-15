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
    [StructLayout( LayoutKind.Explicit, Size=9904 )]
    internal unsafe struct PlayerCameraManager_fields {
        [FieldOffset(1008)]  public IntPtr  PCOwner;
        [FieldOffset(1016)]  public IntPtr  TransformComponent;
        [FieldOffset(1036)] public float DefaultFOV;
        [FieldOffset(1044)] public float DefaultOrthoWidth;
        [FieldOffset(1052)] public float DefaultAspectRatio;
        [FieldOffset(1120)] public CameraCacheEntry CameraCache;
        [FieldOffset(2528)] public CameraCacheEntry LastFrameCameraCache;
        [FieldOffset(3936)] public TViewTarget ViewTarget;
        [FieldOffset(5360)] public TViewTarget PendingViewTarget;
        [FieldOffset(6816)] public CameraCacheEntry CameraCachePrivate;
        [FieldOffset(8224)] public CameraCacheEntry LastFrameCameraCachePrivate;
        [FieldOffset(9632)] public NativeArray ModifierList;
        [FieldOffset(9648)] public NativeArray DefaultModifiers;
        [FieldOffset(9664)] public float FreeCamDistance;
        [FieldOffset(9668)] public Vector FreeCamOffset;
        [FieldOffset(9680)] public Vector ViewTargetOffset;
        [FieldOffset(9712)] public NativeArray CameraLensEffects;
        [FieldOffset(9728)]  public IntPtr  CachedCameraShakeMod;
        [FieldOffset(9736)]  public IntPtr  AnimInstPool;
        [FieldOffset(9800)] public NativeArray PostProcessBlendCache;
        [FieldOffset(9832)] public NativeArray ActiveAnims;
        [FieldOffset(9848)] public NativeArray FreeAnims;
        [FieldOffset(9864)]  public IntPtr  AnimCameraActor;
        [FieldOffset(9872)] public bool bIsOrthographic;
        [FieldOffset(9872)] public bool bDefaultConstrainAspectRatio;
        [FieldOffset(9872)] public bool bClientSimulatingViewTarget;
        [FieldOffset(9872)] public bool bUseClientSideCameraUpdates;
        [FieldOffset(9873)] public bool bGameCameraCutThisFrame;
        [FieldOffset(9876)] public float ViewPitchMin;
        [FieldOffset(9880)] public float ViewPitchMax;
        [FieldOffset(9884)] public float ViewYawMin;
        [FieldOffset(9888)] public float ViewYawMax;
        [FieldOffset(9892)] public float ViewRollMin;
        [FieldOffset(9896)] public float ViewRollMax;
    }
    internal unsafe struct PlayerCameraManager_methods {
        internal struct AddCameraLensEffect_method {
            static internal IntPtr AddCameraLensEffect_ptr;
            static AddCameraLensEffect_method() {
                AddCameraLensEffect_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "AddCameraLensEffect");
            }

            internal static unsafe EmitterCameraLensEffectBase Invoke(IntPtr obj, SubclassOf<EmitterCameraLensEffectBase> LensEffectEmitterClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = LensEffectEmitterClass;
                Main.GetProcessEvent(obj, AddCameraLensEffect_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct AddNewCameraModifier_method {
            static internal IntPtr AddNewCameraModifier_ptr;
            static AddNewCameraModifier_method() {
                AddNewCameraModifier_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "AddNewCameraModifier");
            }

            internal static unsafe CameraModifier Invoke(IntPtr obj, SubclassOf<CameraModifier> ModifierClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ModifierClass;
                Main.GetProcessEvent(obj, AddNewCameraModifier_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct ClearCameraLensEffects_method {
            static internal IntPtr ClearCameraLensEffects_ptr;
            static ClearCameraLensEffects_method() {
                ClearCameraLensEffects_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "ClearCameraLensEffects");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearCameraLensEffects_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FindCameraModifierByClass_method {
            static internal IntPtr FindCameraModifierByClass_ptr;
            static FindCameraModifierByClass_method() {
                FindCameraModifierByClass_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "FindCameraModifierByClass");
            }

            internal static unsafe CameraModifier Invoke(IntPtr obj, SubclassOf<CameraModifier> ModifierClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ModifierClass;
                Main.GetProcessEvent(obj, FindCameraModifierByClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct GetCameraLocation_method {
            static internal IntPtr GetCameraLocation_ptr;
            static GetCameraLocation_method() {
                GetCameraLocation_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "GetCameraLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCameraLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetCameraRotation_method {
            static internal IntPtr GetCameraRotation_ptr;
            static GetCameraRotation_method() {
                GetCameraRotation_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "GetCameraRotation");
            }

            internal static unsafe Rotator Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCameraRotation_ptr, new IntPtr(p)); ;
                return *((Rotator*)(b+0));
            }
        }
        internal struct GetFOVAngle_method {
            static internal IntPtr GetFOVAngle_ptr;
            static GetFOVAngle_method() {
                GetFOVAngle_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "GetFOVAngle");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFOVAngle_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct GetOwningPlayerController_method {
            static internal IntPtr GetOwningPlayerController_ptr;
            static GetOwningPlayerController_method() {
                GetOwningPlayerController_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "GetOwningPlayerController");
            }

            internal static unsafe PlayerController Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningPlayerController_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct PlayCameraAnim_method {
            static internal IntPtr PlayCameraAnim_ptr;
            static PlayCameraAnim_method() {
                PlayCameraAnim_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "PlayCameraAnim");
            }

            internal static unsafe CameraAnimInst Invoke(IntPtr obj, CameraAnim Anim, float Rate, float Scale, float BlendInTime, float BlendOutTime, bool bLoop, bool bRandomStartTime, float Duration, byte PlaySpace, Rotator UserPlaySpaceRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Anim;
                *((float*)(b+8)) = Rate;
                *((float*)(b+12)) = Scale;
                *((float*)(b+16)) = BlendInTime;
                *((float*)(b+20)) = BlendOutTime;
                *((bool*)(b+24)) = bLoop;
                *((bool*)(b+25)) = bRandomStartTime;
                *((float*)(b+28)) = Duration;
                *(b+32) = PlaySpace;
                *((Rotator*)(b+36)) = UserPlaySpaceRot;
                Main.GetProcessEvent(obj, PlayCameraAnim_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+48));
            }
        }
        internal struct PlayCameraShake_method {
            static internal IntPtr PlayCameraShake_ptr;
            static PlayCameraShake_method() {
                PlayCameraShake_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "PlayCameraShake");
            }

            internal static unsafe CameraShake Invoke(IntPtr obj, SubclassOf<CameraShake> ShakeClass, float Scale, byte PlaySpace, Rotator UserPlaySpaceRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ShakeClass;
                *((float*)(b+8)) = Scale;
                *(b+12) = PlaySpace;
                *((Rotator*)(b+16)) = UserPlaySpaceRot;
                Main.GetProcessEvent(obj, PlayCameraShake_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+32));
            }
        }
        internal struct RemoveCameraLensEffect_method {
            static internal IntPtr RemoveCameraLensEffect_ptr;
            static RemoveCameraLensEffect_method() {
                RemoveCameraLensEffect_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "RemoveCameraLensEffect");
            }

            internal static unsafe void Invoke(IntPtr obj, EmitterCameraLensEffectBase Emitter) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Emitter;
                Main.GetProcessEvent(obj, RemoveCameraLensEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveCameraModifier_method {
            static internal IntPtr RemoveCameraModifier_ptr;
            static RemoveCameraModifier_method() {
                RemoveCameraModifier_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "RemoveCameraModifier");
            }

            internal static unsafe bool Invoke(IntPtr obj, CameraModifier ModifierToRemove) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ModifierToRemove;
                Main.GetProcessEvent(obj, RemoveCameraModifier_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetManualCameraFade_method {
            static internal IntPtr SetManualCameraFade_ptr;
            static SetManualCameraFade_method() {
                SetManualCameraFade_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "SetManualCameraFade");
            }

            internal static unsafe void Invoke(IntPtr obj, float InFadeAmount, LinearColor Color, bool bInFadeAudio) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InFadeAmount;
                *((LinearColor*)(b+4)) = Color;
                *((bool*)(b+20)) = bInFadeAudio;
                Main.GetProcessEvent(obj, SetManualCameraFade_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StartCameraFade_method {
            static internal IntPtr StartCameraFade_ptr;
            static StartCameraFade_method() {
                StartCameraFade_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StartCameraFade");
            }

            internal static unsafe void Invoke(IntPtr obj, float FromAlpha, float ToAlpha, float Duration, LinearColor Color, bool bShouldFadeAudio, bool bHoldWhenFinished) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = FromAlpha;
                *((float*)(b+4)) = ToAlpha;
                *((float*)(b+8)) = Duration;
                *((LinearColor*)(b+12)) = Color;
                *((bool*)(b+28)) = bShouldFadeAudio;
                *((bool*)(b+29)) = bHoldWhenFinished;
                Main.GetProcessEvent(obj, StartCameraFade_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAllCameraAnims_method {
            static internal IntPtr StopAllCameraAnims_ptr;
            static StopAllCameraAnims_method() {
                StopAllCameraAnims_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StopAllCameraAnims");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bImmediate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bImmediate;
                Main.GetProcessEvent(obj, StopAllCameraAnims_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAllCameraShakes_method {
            static internal IntPtr StopAllCameraShakes_ptr;
            static StopAllCameraShakes_method() {
                StopAllCameraShakes_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StopAllCameraShakes");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bImmediately) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bImmediately;
                Main.GetProcessEvent(obj, StopAllCameraShakes_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAllInstancesOfCameraAnim_method {
            static internal IntPtr StopAllInstancesOfCameraAnim_ptr;
            static StopAllInstancesOfCameraAnim_method() {
                StopAllInstancesOfCameraAnim_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StopAllInstancesOfCameraAnim");
            }

            internal static unsafe void Invoke(IntPtr obj, CameraAnim Anim, bool bImmediate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Anim;
                *((bool*)(b+8)) = bImmediate;
                Main.GetProcessEvent(obj, StopAllInstancesOfCameraAnim_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAllInstancesOfCameraShake_method {
            static internal IntPtr StopAllInstancesOfCameraShake_ptr;
            static StopAllInstancesOfCameraShake_method() {
                StopAllInstancesOfCameraShake_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StopAllInstancesOfCameraShake");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<CameraShake> Shake, bool bImmediately) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Shake;
                *((bool*)(b+8)) = bImmediately;
                Main.GetProcessEvent(obj, StopAllInstancesOfCameraShake_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopCameraAnimInst_method {
            static internal IntPtr StopCameraAnimInst_ptr;
            static StopCameraAnimInst_method() {
                StopCameraAnimInst_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StopCameraAnimInst");
            }

            internal static unsafe void Invoke(IntPtr obj, CameraAnimInst AnimInst, bool bImmediate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimInst;
                *((bool*)(b+8)) = bImmediate;
                Main.GetProcessEvent(obj, StopCameraAnimInst_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopCameraFade_method {
            static internal IntPtr StopCameraFade_ptr;
            static StopCameraFade_method() {
                StopCameraFade_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StopCameraFade");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopCameraFade_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopCameraShake_method {
            static internal IntPtr StopCameraShake_ptr;
            static StopCameraShake_method() {
                StopCameraShake_ptr = Main.GetMethodUFunction(PlayerCameraManager.StaticClass, "StopCameraShake");
            }

            internal static unsafe void Invoke(IntPtr obj, CameraShake ShakeInstance, bool bImmediately) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ShakeInstance;
                *((bool*)(b+8)) = bImmediately;
                Main.GetProcessEvent(obj, StopCameraShake_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PlayerCameraManager_events {
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        internal unsafe struct BlueprintUpdateCamera_event {
            private static DelegateHolder<NativeFuncDelegate> BlueprintUpdateCamera_link;
            private static unsafe void BlueprintUpdateCamera_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<PlayerCameraManager>(context);
                var b = (byte*) theStack->Locals;

                obj.on_BlueprintUpdateCamera(UObject.Make<Actor>(*(IntPtr*)(b+0)), *(Vector*)(b+8), *(Rotator*)(b+20), *(float*)(b+32), *(bool*)(b+36));
            }
            internal static void Setup() {
                BlueprintUpdateCamera_link = new DelegateHolder<NativeFuncDelegate>(BlueprintUpdateCamera_process_event);
                var uf = Main.GetUFunction("BlueprintUpdateCamera");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(BlueprintUpdateCamera_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnPhotographyMultiPartCaptureEnd_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnPhotographyMultiPartCaptureEnd_link;
            private static unsafe void OnPhotographyMultiPartCaptureEnd_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<PlayerCameraManager>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnPhotographyMultiPartCaptureEnd();
            }
            internal static void Setup() {
                OnPhotographyMultiPartCaptureEnd_link = new DelegateHolder<NativeFuncDelegate>(OnPhotographyMultiPartCaptureEnd_process_event);
                var uf = Main.GetUFunction("OnPhotographyMultiPartCaptureEnd");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPhotographyMultiPartCaptureEnd_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnPhotographyMultiPartCaptureStart_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnPhotographyMultiPartCaptureStart_link;
            private static unsafe void OnPhotographyMultiPartCaptureStart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<PlayerCameraManager>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnPhotographyMultiPartCaptureStart();
            }
            internal static void Setup() {
                OnPhotographyMultiPartCaptureStart_link = new DelegateHolder<NativeFuncDelegate>(OnPhotographyMultiPartCaptureStart_process_event);
                var uf = Main.GetUFunction("OnPhotographyMultiPartCaptureStart");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPhotographyMultiPartCaptureStart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnPhotographySessionEnd_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnPhotographySessionEnd_link;
            private static unsafe void OnPhotographySessionEnd_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<PlayerCameraManager>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnPhotographySessionEnd();
            }
            internal static void Setup() {
                OnPhotographySessionEnd_link = new DelegateHolder<NativeFuncDelegate>(OnPhotographySessionEnd_process_event);
                var uf = Main.GetUFunction("OnPhotographySessionEnd");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPhotographySessionEnd_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnPhotographySessionStart_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnPhotographySessionStart_link;
            private static unsafe void OnPhotographySessionStart_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<PlayerCameraManager>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnPhotographySessionStart();
            }
            internal static void Setup() {
                OnPhotographySessionStart_link = new DelegateHolder<NativeFuncDelegate>(OnPhotographySessionStart_process_event);
                var uf = Main.GetUFunction("OnPhotographySessionStart");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPhotographySessionStart_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        internal unsafe struct PhotographyCameraModify_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> PhotographyCameraModify_link;
            private static unsafe void PhotographyCameraModify_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<PlayerCameraManager>(context);
                var b = (byte*) theStack->Locals;
                *(Vector*)result.ToPointer() = obj.on_PhotographyCameraModify(*(Vector*)(b+0), *(Vector*)(b+12), *(Vector*)(b+24), *(Vector*)result);
            }
            internal static void Setup() {
                PhotographyCameraModify_link = new DelegateHolder<NativeFuncDelegate>(PhotographyCameraModify_process_event);
                var uf = Main.GetUFunction("PhotographyCameraModify");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(PhotographyCameraModify_link.Delegate));
            }
        }
    }
}
