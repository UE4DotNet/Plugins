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

using UE4.InputCore;
using UE4.UMG;

namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1880 )]
    internal unsafe struct PlayerController_fields {
        [FieldOffset(1144)]  public IntPtr  Player;
        [FieldOffset(1152)]  public IntPtr  AcknowledgedPawn;
        [FieldOffset(1160)]  public IntPtr  ControllingDirTrackInst;
        [FieldOffset(1168)]  public IntPtr  MyHUD;
        [FieldOffset(1176)]  public IntPtr  PlayerCameraManager;
        [FieldOffset(1184)] public IntPtr PlayerCameraManagerClass;
        [FieldOffset(1192)] public bool bAutoManageActiveCameraTarget;
        [FieldOffset(1196)] public Rotator TargetViewRotation;
        [FieldOffset(1220)] public float SmoothTargetViewRotationSpeed;
        [FieldOffset(1232)] public NativeArray HiddenActors;
        [FieldOffset(1248)] public NativeArray HiddenPrimitiveComponents;
        [FieldOffset(1268)] public float LastSpectatorStateSynchTime;
        [FieldOffset(1272)] public Vector LastSpectatorSyncLocation;
        [FieldOffset(1284)] public Rotator LastSpectatorSyncRotation;
        [FieldOffset(1296)] public int ClientCap;
        [FieldOffset(1304)]  public IntPtr  CheatManager;
        [FieldOffset(1312)] public IntPtr CheatClass;
        [FieldOffset(1320)]  public IntPtr  PlayerInput;
        [FieldOffset(1328)] public NativeArray ActiveForceFeedbackEffects;
        [FieldOffset(1472)] public bool bPlayerIsWaiting;
        [FieldOffset(1476)] public byte NetPlayerIndex;
        [FieldOffset(1536)]  public IntPtr  PendingSwapConnection;
        [FieldOffset(1544)]  public IntPtr  NetConnection;
        [FieldOffset(1564)] public float InputYawScale;
        [FieldOffset(1568)] public float InputPitchScale;
        [FieldOffset(1572)] public float InputRollScale;
        [FieldOffset(1576)] public bool bShowMouseCursor;
        [FieldOffset(1576)] public bool bEnableClickEvents;
        [FieldOffset(1576)] public bool bEnableTouchEvents;
        [FieldOffset(1576)] public bool bEnableMouseOverEvents;
        [FieldOffset(1576)] public bool bEnableTouchOverEvents;
        [FieldOffset(1576)] public bool bForceFeedbackEnabled;
        [FieldOffset(1580)] public float ForceFeedbackScale;
        [FieldOffset(1584)] public NativeArray ClickEventKeys;
        [FieldOffset(1600)] public byte DefaultMouseCursor;
        [FieldOffset(1601)] public byte CurrentMouseCursor;
        [FieldOffset(1602)] public byte DefaultClickTraceChannel;
        [FieldOffset(1603)] public byte CurrentClickTraceChannel;
        [FieldOffset(1604)] public float HitResultTraceDistance;
        [FieldOffset(1608)] byte SeamlessTravelCount; //TODO: numeric uint16 SeamlessTravelCount
        [FieldOffset(1610)] byte LastCompletedSeamlessTravelCount; //TODO: numeric uint16 LastCompletedSeamlessTravelCount
        [FieldOffset(1728)]  public IntPtr  InactiveStateInputComponent;
        [FieldOffset(1736)] public bool bShouldPerformFullTickWhenPaused;
        [FieldOffset(1760)]  public IntPtr  CurrentTouchInterface;
        [FieldOffset(1848)]  public IntPtr  SpectatorPawn;
        [FieldOffset(1860)] public bool bIsLocalPlayerController;
        [FieldOffset(1864)] public Vector SpawnLocation;
    }
    internal unsafe struct PlayerController_methods {
        internal struct ActivateTouchInterface_method {
            static internal IntPtr ActivateTouchInterface_ptr;
            static ActivateTouchInterface_method() {
                ActivateTouchInterface_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ActivateTouchInterface");
            }

            internal static unsafe void Invoke(IntPtr obj, TouchInterface NewTouchInterface) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewTouchInterface;
                Main.GetProcessEvent(obj, ActivateTouchInterface_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddPitchInput_method {
            static internal IntPtr AddPitchInput_ptr;
            static AddPitchInput_method() {
                AddPitchInput_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "AddPitchInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, AddPitchInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddRollInput_method {
            static internal IntPtr AddRollInput_ptr;
            static AddRollInput_method() {
                AddRollInput_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "AddRollInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, AddRollInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct AddYawInput_method {
            static internal IntPtr AddYawInput_ptr;
            static AddYawInput_method() {
                AddYawInput_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "AddYawInput");
            }

            internal static unsafe void Invoke(IntPtr obj, float Val) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Val;
                Main.GetProcessEvent(obj, AddYawInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CanRestartPlayer_method {
            static internal IntPtr CanRestartPlayer_ptr;
            static CanRestartPlayer_method() {
                CanRestartPlayer_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "CanRestartPlayer");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CanRestartPlayer_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct ClearAudioListenerAttenuationOverride_method {
            static internal IntPtr ClearAudioListenerAttenuationOverride_ptr;
            static ClearAudioListenerAttenuationOverride_method() {
                ClearAudioListenerAttenuationOverride_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClearAudioListenerAttenuationOverride");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearAudioListenerAttenuationOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearAudioListenerOverride_method {
            static internal IntPtr ClearAudioListenerOverride_ptr;
            static ClearAudioListenerOverride_method() {
                ClearAudioListenerOverride_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClearAudioListenerOverride");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearAudioListenerOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientClearCameraLensEffects_method {
            static internal IntPtr ClientClearCameraLensEffects_ptr;
            static ClientClearCameraLensEffects_method() {
                ClientClearCameraLensEffects_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientClearCameraLensEffects");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClientClearCameraLensEffects_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientPlayCameraAnim_method {
            static internal IntPtr ClientPlayCameraAnim_ptr;
            static ClientPlayCameraAnim_method() {
                ClientPlayCameraAnim_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientPlayCameraAnim");
            }

            internal static unsafe void Invoke(IntPtr obj, CameraAnim AnimToPlay, float Scale, float Rate, float BlendInTime, float BlendOutTime, bool bLoop, bool bRandomStartTime, byte Space, Rotator CustomPlaySpace) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AnimToPlay;
                *((float*)(b+8)) = Scale;
                *((float*)(b+12)) = Rate;
                *((float*)(b+16)) = BlendInTime;
                *((float*)(b+20)) = BlendOutTime;
                *((bool*)(b+24)) = bLoop;
                *((bool*)(b+25)) = bRandomStartTime;
                *(b+26) = Space;
                *((Rotator*)(b+28)) = CustomPlaySpace;
                Main.GetProcessEvent(obj, ClientPlayCameraAnim_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientPlayCameraShake_method {
            static internal IntPtr ClientPlayCameraShake_ptr;
            static ClientPlayCameraShake_method() {
                ClientPlayCameraShake_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientPlayCameraShake");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<CameraShake> Shake, float Scale, byte PlaySpace, Rotator UserPlaySpaceRot) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Shake;
                *((float*)(b+8)) = Scale;
                *(b+12) = PlaySpace;
                *((Rotator*)(b+16)) = UserPlaySpaceRot;
                Main.GetProcessEvent(obj, ClientPlayCameraShake_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientPlayForceFeedback_method {
            static internal IntPtr ClientPlayForceFeedback_ptr;
            static ClientPlayForceFeedback_method() {
                ClientPlayForceFeedback_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientPlayForceFeedback");
            }

            internal static unsafe void Invoke(IntPtr obj, ForceFeedbackEffect ForceFeedbackEffect, bool bLooping, bool bIgnoreTimeDilation, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ForceFeedbackEffect;
                *((bool*)(b+8)) = bLooping;
                *((bool*)(b+9)) = bIgnoreTimeDilation;
                *((Name*)(b+12)) = Tag;
                Main.GetProcessEvent(obj, ClientPlayForceFeedback_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientSetHUD_method {
            static internal IntPtr ClientSetHUD_ptr;
            static ClientSetHUD_method() {
                ClientSetHUD_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientSetHUD");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<HUD> NewHUDClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewHUDClass;
                Main.GetProcessEvent(obj, ClientSetHUD_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientSpawnCameraLensEffect_method {
            static internal IntPtr ClientSpawnCameraLensEffect_ptr;
            static ClientSpawnCameraLensEffect_method() {
                ClientSpawnCameraLensEffect_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientSpawnCameraLensEffect");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<EmitterCameraLensEffectBase> LensEffectEmitterClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = LensEffectEmitterClass;
                Main.GetProcessEvent(obj, ClientSpawnCameraLensEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientStopCameraShake_method {
            static internal IntPtr ClientStopCameraShake_ptr;
            static ClientStopCameraShake_method() {
                ClientStopCameraShake_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientStopCameraShake");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<CameraShake> Shake, bool bImmediately) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Shake;
                *((bool*)(b+8)) = bImmediately;
                Main.GetProcessEvent(obj, ClientStopCameraShake_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClientStopForceFeedback_method {
            static internal IntPtr ClientStopForceFeedback_ptr;
            static ClientStopForceFeedback_method() {
                ClientStopForceFeedback_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ClientStopForceFeedback");
            }

            internal static unsafe void Invoke(IntPtr obj, ForceFeedbackEffect ForceFeedbackEffect, Name Tag) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ForceFeedbackEffect;
                *((Name*)(b+8)) = Tag;
                Main.GetProcessEvent(obj, ClientStopForceFeedback_ptr, new IntPtr(p)); ;
            }
        }
        internal struct DeprojectMousePositionToWorld_method {
            static internal IntPtr DeprojectMousePositionToWorld_ptr;
            static DeprojectMousePositionToWorld_method() {
                DeprojectMousePositionToWorld_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "DeprojectMousePositionToWorld");
            }

            internal static unsafe (Vector, Vector, bool) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, DeprojectMousePositionToWorld_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Vector*)(b+12)),*((bool*)(b+24)));
            }
        }
        internal struct DeprojectScreenPositionToWorld_method {
            static internal IntPtr DeprojectScreenPositionToWorld_ptr;
            static DeprojectScreenPositionToWorld_method() {
                DeprojectScreenPositionToWorld_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "DeprojectScreenPositionToWorld");
            }

            internal static unsafe (Vector, Vector, bool) Invoke(IntPtr obj, float ScreenX, float ScreenY) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = ScreenX;
                *((float*)(b+4)) = ScreenY;
                Main.GetProcessEvent(obj, DeprojectScreenPositionToWorld_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+8)),*((Vector*)(b+20)),*((bool*)(b+32)));
            }
        }
        internal struct GetFocalLocation_method {
            static internal IntPtr GetFocalLocation_ptr;
            static GetFocalLocation_method() {
                GetFocalLocation_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetFocalLocation");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetFocalLocation_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
        internal struct GetHitResultUnderCursor_method {
            static internal IntPtr GetHitResultUnderCursor_ptr;
            static GetHitResultUnderCursor_method() {
                GetHitResultUnderCursor_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetHitResultUnderCursor");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, byte TraceChannel, bool bTraceComplex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = TraceChannel;
                *((bool*)(b+1)) = bTraceComplex;
                Main.GetProcessEvent(obj, GetHitResultUnderCursor_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+4)),*((bool*)(b+148)));
            }
        }
        internal struct GetHitResultUnderCursorByChannel_method {
            static internal IntPtr GetHitResultUnderCursorByChannel_ptr;
            static GetHitResultUnderCursorByChannel_method() {
                GetHitResultUnderCursorByChannel_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetHitResultUnderCursorByChannel");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, byte TraceChannel, bool bTraceComplex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = TraceChannel;
                *((bool*)(b+1)) = bTraceComplex;
                Main.GetProcessEvent(obj, GetHitResultUnderCursorByChannel_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+4)),*((bool*)(b+148)));
            }
        }
        internal struct GetHitResultUnderCursorForObjects_method {
            static internal IntPtr GetHitResultUnderCursorForObjects_ptr;
            static GetHitResultUnderCursorForObjects_method() {
                GetHitResultUnderCursorForObjects_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetHitResultUnderCursorForObjects");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+16)) = bTraceComplex;
                Main.GetProcessEvent(obj, GetHitResultUnderCursorForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                return (*((HitResult*)(b+20)),*((bool*)(b+164)));
            }
        }
        internal struct GetHitResultUnderFinger_method {
            static internal IntPtr GetHitResultUnderFinger_ptr;
            static GetHitResultUnderFinger_method() {
                GetHitResultUnderFinger_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetHitResultUnderFinger");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, byte FingerIndex, byte TraceChannel, bool bTraceComplex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = FingerIndex;
                *(b+1) = TraceChannel;
                *((bool*)(b+2)) = bTraceComplex;
                Main.GetProcessEvent(obj, GetHitResultUnderFinger_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+4)),*((bool*)(b+148)));
            }
        }
        internal struct GetHitResultUnderFingerByChannel_method {
            static internal IntPtr GetHitResultUnderFingerByChannel_ptr;
            static GetHitResultUnderFingerByChannel_method() {
                GetHitResultUnderFingerByChannel_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetHitResultUnderFingerByChannel");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, byte FingerIndex, byte TraceChannel, bool bTraceComplex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = FingerIndex;
                *(b+1) = TraceChannel;
                *((bool*)(b+2)) = bTraceComplex;
                Main.GetProcessEvent(obj, GetHitResultUnderFingerByChannel_ptr, new IntPtr(p)); ;
                return (*((HitResult*)(b+4)),*((bool*)(b+148)));
            }
        }
        internal struct GetHitResultUnderFingerForObjects_method {
            static internal IntPtr GetHitResultUnderFingerForObjects_ptr;
            static GetHitResultUnderFingerForObjects_method() {
                GetHitResultUnderFingerForObjects_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetHitResultUnderFingerForObjects");
            }

            internal static unsafe (HitResult, bool) Invoke(IntPtr obj, byte FingerIndex, byte ObjectTypes /*TODO: array TArray */, bool bTraceComplex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = FingerIndex;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((bool*)(b+24)) = bTraceComplex;
                Main.GetProcessEvent(obj, GetHitResultUnderFingerForObjects_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                return (*((HitResult*)(b+28)),*((bool*)(b+172)));
            }
        }
        internal struct GetHUD_method {
            static internal IntPtr GetHUD_ptr;
            static GetHUD_method() {
                GetHUD_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetHUD");
            }

            internal static unsafe HUD Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetHUD_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetInputAnalogKeyState_method {
            static internal IntPtr GetInputAnalogKeyState_ptr;
            static GetInputAnalogKeyState_method() {
                GetInputAnalogKeyState_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetInputAnalogKeyState");
            }

            internal static unsafe float Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, GetInputAnalogKeyState_ptr, new IntPtr(p)); ;
                return *((float*)(b+32));
            }
        }
        internal struct GetInputAnalogStickState_method {
            static internal IntPtr GetInputAnalogStickState_ptr;
            static GetInputAnalogStickState_method() {
                GetInputAnalogStickState_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetInputAnalogStickState");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj, byte WhichStick) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = WhichStick;
                Main.GetProcessEvent(obj, GetInputAnalogStickState_ptr, new IntPtr(p)); ;
                return (*((float*)(b+4)),*((float*)(b+8)));
            }
        }
        internal struct GetInputKeyTimeDown_method {
            static internal IntPtr GetInputKeyTimeDown_ptr;
            static GetInputKeyTimeDown_method() {
                GetInputKeyTimeDown_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetInputKeyTimeDown");
            }

            internal static unsafe float Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, GetInputKeyTimeDown_ptr, new IntPtr(p)); ;
                return *((float*)(b+32));
            }
        }
        internal struct GetInputMotionState_method {
            static internal IntPtr GetInputMotionState_ptr;
            static GetInputMotionState_method() {
                GetInputMotionState_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetInputMotionState");
            }

            internal static unsafe (Vector, Vector, Vector, Vector) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInputMotionState_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+0)),*((Vector*)(b+12)),*((Vector*)(b+24)),*((Vector*)(b+36)));
            }
        }
        internal struct GetInputMouseDelta_method {
            static internal IntPtr GetInputMouseDelta_ptr;
            static GetInputMouseDelta_method() {
                GetInputMouseDelta_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetInputMouseDelta");
            }

            internal static unsafe (float, float) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetInputMouseDelta_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)));
            }
        }
        internal struct GetInputTouchState_method {
            static internal IntPtr GetInputTouchState_ptr;
            static GetInputTouchState_method() {
                GetInputTouchState_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetInputTouchState");
            }

            internal static unsafe (float, float, bool) Invoke(IntPtr obj, byte FingerIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = FingerIndex;
                Main.GetProcessEvent(obj, GetInputTouchState_ptr, new IntPtr(p)); ;
                return (*((float*)(b+4)),*((float*)(b+8)),*((bool*)(b+12)));
            }
        }
        internal struct GetInputVectorKeyState_method {
            static internal IntPtr GetInputVectorKeyState_ptr;
            static GetInputVectorKeyState_method() {
                GetInputVectorKeyState_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetInputVectorKeyState");
            }

            internal static unsafe Vector Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, GetInputVectorKeyState_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+32));
            }
        }
        internal struct GetMousePosition_method {
            static internal IntPtr GetMousePosition_ptr;
            static GetMousePosition_method() {
                GetMousePosition_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetMousePosition");
            }

            internal static unsafe (float, float, bool) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetMousePosition_ptr, new IntPtr(p)); ;
                return (*((float*)(b+0)),*((float*)(b+4)),*((bool*)(b+8)));
            }
        }
        internal struct GetSpectatorPawn_method {
            static internal IntPtr GetSpectatorPawn_ptr;
            static GetSpectatorPawn_method() {
                GetSpectatorPawn_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetSpectatorPawn");
            }

            internal static unsafe SpectatorPawn Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSpectatorPawn_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetViewportSize_method {
            static internal IntPtr GetViewportSize_ptr;
            static GetViewportSize_method() {
                GetViewportSize_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "GetViewportSize");
            }

            internal static unsafe (int, int) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetViewportSize_ptr, new IntPtr(p)); ;
                return (*((int*)(b+0)),*((int*)(b+4)));
            }
        }
        internal struct IsInputKeyDown_method {
            static internal IntPtr IsInputKeyDown_ptr;
            static IsInputKeyDown_method() {
                IsInputKeyDown_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "IsInputKeyDown");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, IsInputKeyDown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct PlayDynamicForceFeedback_method {
            static internal IntPtr PlayDynamicForceFeedback_ptr;
            static PlayDynamicForceFeedback_method() {
                PlayDynamicForceFeedback_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "PlayDynamicForceFeedback");
            }

            internal static unsafe void Invoke(IntPtr obj, float Intensity, float Duration, bool bAffectsLeftLarge, bool bAffectsLeftSmall, bool bAffectsRightLarge, bool bAffectsRightSmall, byte Action, LatentActionInfo LatentInfo) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Intensity;
                *((float*)(b+4)) = Duration;
                *((bool*)(b+8)) = bAffectsLeftLarge;
                *((bool*)(b+9)) = bAffectsLeftSmall;
                *((bool*)(b+10)) = bAffectsRightLarge;
                *((bool*)(b+11)) = bAffectsRightSmall;
                *(b+12) = Action;
                *((LatentActionInfo*)(b+16)) = LatentInfo;
                Main.GetProcessEvent(obj, PlayDynamicForceFeedback_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayHapticEffect_method {
            static internal IntPtr PlayHapticEffect_ptr;
            static PlayHapticEffect_method() {
                PlayHapticEffect_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "PlayHapticEffect");
            }

            internal static unsafe void Invoke(IntPtr obj, HapticFeedbackEffect_Base HapticEffect, EControllerHand Hand, float Scale, bool bLoop) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = HapticEffect;
                *(b+8) = (byte)Hand;
                *((float*)(b+12)) = Scale;
                *((bool*)(b+16)) = bLoop;
                Main.GetProcessEvent(obj, PlayHapticEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ProjectWorldLocationToScreen_method {
            static internal IntPtr ProjectWorldLocationToScreen_ptr;
            static ProjectWorldLocationToScreen_method() {
                ProjectWorldLocationToScreen_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "ProjectWorldLocationToScreen");
            }

            internal static unsafe (Vector2D, bool) Invoke(IntPtr obj, Vector WorldLocation, bool bPlayerViewportRelative) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = WorldLocation;
                *((bool*)(b+20)) = bPlayerViewportRelative;
                Main.GetProcessEvent(obj, ProjectWorldLocationToScreen_ptr, new IntPtr(p)); ;
                return (*((Vector2D*)(b+12)),*((bool*)(b+21)));
            }
        }
        internal struct SetAudioListenerAttenuationOverride_method {
            static internal IntPtr SetAudioListenerAttenuationOverride_ptr;
            static SetAudioListenerAttenuationOverride_method() {
                SetAudioListenerAttenuationOverride_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetAudioListenerAttenuationOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent AttachToComponent, Vector AttenuationLocationOVerride) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AttachToComponent;
                *((Vector*)(b+8)) = AttenuationLocationOVerride;
                Main.GetProcessEvent(obj, SetAudioListenerAttenuationOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAudioListenerOverride_method {
            static internal IntPtr SetAudioListenerOverride_ptr;
            static SetAudioListenerOverride_method() {
                SetAudioListenerOverride_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetAudioListenerOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, SceneComponent AttachToComponent, Vector Location, Rotator Rotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = AttachToComponent;
                *((Vector*)(b+8)) = Location;
                *((Rotator*)(b+20)) = Rotation;
                Main.GetProcessEvent(obj, SetAudioListenerOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCinematicMode_method {
            static internal IntPtr SetCinematicMode_ptr;
            static SetCinematicMode_method() {
                SetCinematicMode_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetCinematicMode");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInCinematicMode;
                *((bool*)(b+1)) = bHidePlayer;
                *((bool*)(b+2)) = bAffectsHUD;
                *((bool*)(b+3)) = bAffectsMovement;
                *((bool*)(b+4)) = bAffectsTurning;
                Main.GetProcessEvent(obj, SetCinematicMode_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetControllerLightColor_method {
            static internal IntPtr SetControllerLightColor_ptr;
            static SetControllerLightColor_method() {
                SetControllerLightColor_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetControllerLightColor");
            }

            internal static unsafe void Invoke(IntPtr obj, Color Color) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Color*)(b+0)) = Color;
                Main.GetProcessEvent(obj, SetControllerLightColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDisableHaptics_method {
            static internal IntPtr SetDisableHaptics_ptr;
            static SetDisableHaptics_method() {
                SetDisableHaptics_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetDisableHaptics");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewDisabled) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewDisabled;
                Main.GetProcessEvent(obj, SetDisableHaptics_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHapticsByValue_method {
            static internal IntPtr SetHapticsByValue_ptr;
            static SetHapticsByValue_method() {
                SetHapticsByValue_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetHapticsByValue");
            }

            internal static unsafe void Invoke(IntPtr obj, float Frequency, float Amplitude, EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = Frequency;
                *((float*)(b+4)) = Amplitude;
                *(b+8) = (byte)Hand;
                Main.GetProcessEvent(obj, SetHapticsByValue_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMouseCursorWidget_method {
            static internal IntPtr SetMouseCursorWidget_ptr;
            static SetMouseCursorWidget_method() {
                SetMouseCursorWidget_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetMouseCursorWidget");
            }

            internal static unsafe void Invoke(IntPtr obj, byte Cursor, UserWidget CursorWidget) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *(b+0) = Cursor;
                *((IntPtr*)(b+8)) = CursorWidget;
                Main.GetProcessEvent(obj, SetMouseCursorWidget_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMouseLocation_method {
            static internal IntPtr SetMouseLocation_ptr;
            static SetMouseLocation_method() {
                SetMouseLocation_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetMouseLocation");
            }

            internal static unsafe void Invoke(IntPtr obj, int X, int Y) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = X;
                *((int*)(b+4)) = Y;
                Main.GetProcessEvent(obj, SetMouseLocation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetViewTargetWithBlend_method {
            static internal IntPtr SetViewTargetWithBlend_ptr;
            static SetViewTargetWithBlend_method() {
                SetViewTargetWithBlend_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetViewTargetWithBlend");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor NewViewTarget, float BlendTime, byte BlendFunc, float BlendExp, bool bLockOutgoing) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewViewTarget;
                *((float*)(b+8)) = BlendTime;
                *(b+12) = BlendFunc;
                *((float*)(b+16)) = BlendExp;
                *((bool*)(b+20)) = bLockOutgoing;
                Main.GetProcessEvent(obj, SetViewTargetWithBlend_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetVirtualJoystickVisibility_method {
            static internal IntPtr SetVirtualJoystickVisibility_ptr;
            static SetVirtualJoystickVisibility_method() {
                SetVirtualJoystickVisibility_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "SetVirtualJoystickVisibility");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bVisible) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bVisible;
                Main.GetProcessEvent(obj, SetVirtualJoystickVisibility_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopHapticEffect_method {
            static internal IntPtr StopHapticEffect_ptr;
            static StopHapticEffect_method() {
                StopHapticEffect_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "StopHapticEffect");
            }

            internal static unsafe void Invoke(IntPtr obj, EControllerHand Hand) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)Hand;
                Main.GetProcessEvent(obj, StopHapticEffect_ptr, new IntPtr(p)); ;
            }
        }
        internal struct WasInputKeyJustPressed_method {
            static internal IntPtr WasInputKeyJustPressed_ptr;
            static WasInputKeyJustPressed_method() {
                WasInputKeyJustPressed_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "WasInputKeyJustPressed");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, WasInputKeyJustPressed_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
        internal struct WasInputKeyJustReleased_method {
            static internal IntPtr WasInputKeyJustReleased_ptr;
            static WasInputKeyJustReleased_method() {
                WasInputKeyJustReleased_ptr = Main.GetMethodUFunction(PlayerController.StaticClass, "WasInputKeyJustReleased");
            }

            internal static unsafe bool Invoke(IntPtr obj, Key Key) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Key*)(b+0)) = Key;
                Main.GetProcessEvent(obj, WasInputKeyJustReleased_ptr, new IntPtr(p)); ;
                return *((bool*)(b+32));
            }
        }
    }
    internal unsafe struct PlayerController_events {
    }
}
