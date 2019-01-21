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

using UE4.SlateCore;
using UE4.Slate;
using UE4.Engine;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct UserWidget_fields {
        [FieldOffset(408)] public LinearColor ColorAndOpacity;
        [FieldOffset(424)] byte ColorAndOpacityDelegate; //TODO: delegate FGetLinearColor ColorAndOpacityDelegate
        [FieldOffset(448)] public SlateColor ForegroundColor;
        [FieldOffset(488)] byte ForegroundColorDelegate; //TODO: delegate FGetSlateColor ForegroundColorDelegate
        [FieldOffset(508)] public Margin Padding;
        [FieldOffset(528)] public NativeArray ActiveSequencePlayers;
        [FieldOffset(544)] public NativeArray StoppedSequencePlayers;
        [FieldOffset(560)] public NativeArray NamedSlotBindings;
        [FieldOffset(576)]  public IntPtr  WidgetTree;
        [FieldOffset(584)] public Vector2D DesignTimeSize;
        [FieldOffset(592)] byte DesignSizeMode; //TODO: enum EDesignPreviewSizeMode DesignSizeMode
        [FieldOffset(600)] byte PaletteCategory; //TODO: text FText PaletteCategory
        [FieldOffset(624)]  public IntPtr  PreviewBackground;
        [FieldOffset(632)] public int Priority;
        [FieldOffset(636)] public bool bIsFocusable;
        [FieldOffset(636)] public bool bStopAction;
        [FieldOffset(636)] public bool bHasScriptImplementedTick;
        [FieldOffset(636)] public bool bHasScriptImplementedPaint;
        [FieldOffset(636)] public bool bCookedWidgetTree;
        [FieldOffset(637)] byte TickFrequency; //TODO: enum EWidgetTickFrequency TickFrequency
        [FieldOffset(640)]  public IntPtr  InputComponent;
    }
    internal unsafe struct UserWidget_methods {
        internal struct AddToPlayerScreen_method {
            static internal IntPtr AddToPlayerScreen_ptr;
            static AddToPlayerScreen_method() {
                AddToPlayerScreen_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "AddToPlayerScreen");
            }

            internal static unsafe bool Invoke(IntPtr obj, int ZOrder) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ZOrder;
                Main.GetProcessEvent(obj, AddToPlayerScreen_ptr, new IntPtr(p)); ;
                return *((bool*)(b+4));
            }
        }
        internal struct AddToViewport_method {
            static internal IntPtr AddToViewport_ptr;
            static AddToViewport_method() {
                AddToViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "AddToViewport");
            }

            internal static unsafe void Invoke(IntPtr obj, int ZOrder) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = ZOrder;
                Main.GetProcessEvent(obj, AddToViewport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct CancelLatentActions_method {
            static internal IntPtr CancelLatentActions_ptr;
            static CancelLatentActions_method() {
                CancelLatentActions_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "CancelLatentActions");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, CancelLatentActions_ptr, new IntPtr(p)); ;
            }
        }
        internal struct GetAlignmentInViewport_method {
            static internal IntPtr GetAlignmentInViewport_ptr;
            static GetAlignmentInViewport_method() {
                GetAlignmentInViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "GetAlignmentInViewport");
            }

            internal static unsafe Vector2D Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAlignmentInViewport_ptr, new IntPtr(p)); ;
                return *((Vector2D*)(b+0));
            }
        }
        internal struct GetAnchorsInViewport_method {
            static internal IntPtr GetAnchorsInViewport_ptr;
            static GetAnchorsInViewport_method() {
                GetAnchorsInViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "GetAnchorsInViewport");
            }

            internal static unsafe Anchors Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnchorsInViewport_ptr, new IntPtr(p)); ;
                return *((Anchors*)(b+0));
            }
        }
        internal struct GetAnimationCurrentTime_method {
            static internal IntPtr GetAnimationCurrentTime_ptr;
            static GetAnimationCurrentTime_method() {
                GetAnimationCurrentTime_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "GetAnimationCurrentTime");
            }

            internal static unsafe float Invoke(IntPtr obj, WidgetAnimation InAnimation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                Main.GetProcessEvent(obj, GetAnimationCurrentTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct GetIsVisible_method {
            static internal IntPtr GetIsVisible_ptr;
            static GetIsVisible_method() {
                GetIsVisible_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "GetIsVisible");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetIsVisible_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct GetOwningPlayerPawn_method {
            static internal IntPtr GetOwningPlayerPawn_ptr;
            static GetOwningPlayerPawn_method() {
                GetOwningPlayerPawn_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "GetOwningPlayerPawn");
            }

            internal static unsafe Pawn Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetOwningPlayerPawn_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct IsAnimationPlaying_method {
            static internal IntPtr IsAnimationPlaying_ptr;
            static IsAnimationPlaying_method() {
                IsAnimationPlaying_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "IsAnimationPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj, WidgetAnimation InAnimation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                Main.GetProcessEvent(obj, IsAnimationPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsAnimationPlayingForward_method {
            static internal IntPtr IsAnimationPlayingForward_ptr;
            static IsAnimationPlayingForward_method() {
                IsAnimationPlayingForward_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "IsAnimationPlayingForward");
            }

            internal static unsafe bool Invoke(IntPtr obj, WidgetAnimation InAnimation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                Main.GetProcessEvent(obj, IsAnimationPlayingForward_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct IsAnyAnimationPlaying_method {
            static internal IntPtr IsAnyAnimationPlaying_ptr;
            static IsAnyAnimationPlaying_method() {
                IsAnyAnimationPlaying_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "IsAnyAnimationPlaying");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsAnyAnimationPlaying_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsInViewport_method {
            static internal IntPtr IsInViewport_ptr;
            static IsInViewport_method() {
                IsInViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "IsInViewport");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsInViewport_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct IsListeningForInputAction_method {
            static internal IntPtr IsListeningForInputAction_ptr;
            static IsListeningForInputAction_method() {
                IsListeningForInputAction_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "IsListeningForInputAction");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name ActionName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ActionName;
                Main.GetProcessEvent(obj, IsListeningForInputAction_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsPlayingAnimation_method {
            static internal IntPtr IsPlayingAnimation_ptr;
            static IsPlayingAnimation_method() {
                IsPlayingAnimation_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "IsPlayingAnimation");
            }

            internal static unsafe bool Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, IsPlayingAnimation_ptr, new IntPtr(p)); ;
                return *((bool*)(b+0));
            }
        }
        internal struct ListenForInputAction_method {
            static internal IntPtr ListenForInputAction_ptr;
            static ListenForInputAction_method() {
                ListenForInputAction_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "ListenForInputAction");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ActionName, byte EventType, bool bConsume, byte Callback /*TODO: delegate FOnInputAction */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ActionName;
                *(b+12) = EventType;
                *((bool*)(b+13)) = bConsume;
                throw new NotImplementedException(); //TODO: delegate FOnInputAction Callback
                Main.GetProcessEvent(obj, ListenForInputAction_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnInputAction Callback
            }
        }
        internal struct PauseAnimation_method {
            static internal IntPtr PauseAnimation_ptr;
            static PauseAnimation_method() {
                PauseAnimation_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "PauseAnimation");
            }

            internal static unsafe float Invoke(IntPtr obj, WidgetAnimation InAnimation) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                Main.GetProcessEvent(obj, PauseAnimation_ptr, new IntPtr(p)); ;
                return *((float*)(b+8));
            }
        }
        internal struct PlayAnimation_method {
            static internal IntPtr PlayAnimation_ptr;
            static PlayAnimation_method() {
                PlayAnimation_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "PlayAnimation");
            }

            internal static unsafe void Invoke(IntPtr obj, WidgetAnimation InAnimation, float StartAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                *((float*)(b+8)) = StartAtTime;
                *((int*)(b+12)) = NumLoopsToPlay;
                *(b+16) = PlayMode;
                *((float*)(b+20)) = PlaybackSpeed;
                Main.GetProcessEvent(obj, PlayAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlayAnimationTo_method {
            static internal IntPtr PlayAnimationTo_ptr;
            static PlayAnimationTo_method() {
                PlayAnimationTo_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "PlayAnimationTo");
            }

            internal static unsafe void Invoke(IntPtr obj, WidgetAnimation InAnimation, float StartAtTime, float EndAtTime, int NumLoopsToPlay, byte PlayMode, float PlaybackSpeed) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                *((float*)(b+8)) = StartAtTime;
                *((float*)(b+12)) = EndAtTime;
                *((int*)(b+16)) = NumLoopsToPlay;
                *(b+20) = PlayMode;
                *((float*)(b+24)) = PlaybackSpeed;
                Main.GetProcessEvent(obj, PlayAnimationTo_ptr, new IntPtr(p)); ;
            }
        }
        internal struct PlaySound_method {
            static internal IntPtr PlaySound_ptr;
            static PlaySound_method() {
                PlaySound_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "PlaySound");
            }

            internal static unsafe void Invoke(IntPtr obj, SoundBase SoundToPlay) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = SoundToPlay;
                Main.GetProcessEvent(obj, PlaySound_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RegisterInputComponent_method {
            static internal IntPtr RegisterInputComponent_ptr;
            static RegisterInputComponent_method() {
                RegisterInputComponent_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "RegisterInputComponent");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RegisterInputComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct RemoveFromViewport_method {
            static internal IntPtr RemoveFromViewport_ptr;
            static RemoveFromViewport_method() {
                RemoveFromViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "RemoveFromViewport");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, RemoveFromViewport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ReverseAnimation_method {
            static internal IntPtr ReverseAnimation_ptr;
            static ReverseAnimation_method() {
                ReverseAnimation_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "ReverseAnimation");
            }

            internal static unsafe void Invoke(IntPtr obj, WidgetAnimation InAnimation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                Main.GetProcessEvent(obj, ReverseAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAlignmentInViewport_method {
            static internal IntPtr SetAlignmentInViewport_ptr;
            static SetAlignmentInViewport_method() {
                SetAlignmentInViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetAlignmentInViewport");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Alignment) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Alignment;
                Main.GetProcessEvent(obj, SetAlignmentInViewport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnchorsInViewport_method {
            static internal IntPtr SetAnchorsInViewport_ptr;
            static SetAnchorsInViewport_method() {
                SetAnchorsInViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetAnchorsInViewport");
            }

            internal static unsafe void Invoke(IntPtr obj, Anchors Anchors) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Anchors*)(b+0)) = Anchors;
                Main.GetProcessEvent(obj, SetAnchorsInViewport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetColorAndOpacity_method {
            static internal IntPtr SetColorAndOpacity_ptr;
            static SetColorAndOpacity_method() {
                SetColorAndOpacity_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetColorAndOpacity");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor InColorAndOpacity) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = InColorAndOpacity;
                Main.GetProcessEvent(obj, SetColorAndOpacity_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetDesiredSizeInViewport_method {
            static internal IntPtr SetDesiredSizeInViewport_ptr;
            static SetDesiredSizeInViewport_method() {
                SetDesiredSizeInViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetDesiredSizeInViewport");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Size) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Size;
                Main.GetProcessEvent(obj, SetDesiredSizeInViewport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetForegroundColor_method {
            static internal IntPtr SetForegroundColor_ptr;
            static SetForegroundColor_method() {
                SetForegroundColor_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetForegroundColor");
            }

            internal static unsafe void Invoke(IntPtr obj, SlateColor InForegroundColor) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((SlateColor*)(b+0)) = InForegroundColor;
                Main.GetProcessEvent(obj, SetForegroundColor_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInputActionBlocking_method {
            static internal IntPtr SetInputActionBlocking_ptr;
            static SetInputActionBlocking_method() {
                SetInputActionBlocking_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetInputActionBlocking");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bShouldBlock) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bShouldBlock;
                Main.GetProcessEvent(obj, SetInputActionBlocking_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetInputActionPriority_method {
            static internal IntPtr SetInputActionPriority_ptr;
            static SetInputActionPriority_method() {
                SetInputActionPriority_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetInputActionPriority");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewPriority) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewPriority;
                Main.GetProcessEvent(obj, SetInputActionPriority_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetNumLoopsToPlay_method {
            static internal IntPtr SetNumLoopsToPlay_ptr;
            static SetNumLoopsToPlay_method() {
                SetNumLoopsToPlay_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetNumLoopsToPlay");
            }

            internal static unsafe void Invoke(IntPtr obj, WidgetAnimation InAnimation, int NumLoopsToPlay) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                *((int*)(b+8)) = NumLoopsToPlay;
                Main.GetProcessEvent(obj, SetNumLoopsToPlay_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetOwningPlayer_method {
            static internal IntPtr SetOwningPlayer_ptr;
            static SetOwningPlayer_method() {
                SetOwningPlayer_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetOwningPlayer");
            }

            internal static unsafe void Invoke(IntPtr obj, PlayerController LocalPlayerController) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = LocalPlayerController;
                Main.GetProcessEvent(obj, SetOwningPlayer_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPadding_method {
            static internal IntPtr SetPadding_ptr;
            static SetPadding_method() {
                SetPadding_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetPadding");
            }

            internal static unsafe void Invoke(IntPtr obj, Margin InPadding) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Margin*)(b+0)) = InPadding;
                Main.GetProcessEvent(obj, SetPadding_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaybackSpeed_method {
            static internal IntPtr SetPlaybackSpeed_ptr;
            static SetPlaybackSpeed_method() {
                SetPlaybackSpeed_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetPlaybackSpeed");
            }

            internal static unsafe void Invoke(IntPtr obj, WidgetAnimation InAnimation, float PlaybackSpeed) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                *((float*)(b+8)) = PlaybackSpeed;
                Main.GetProcessEvent(obj, SetPlaybackSpeed_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPositionInViewport_method {
            static internal IntPtr SetPositionInViewport_ptr;
            static SetPositionInViewport_method() {
                SetPositionInViewport_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "SetPositionInViewport");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector2D Position, bool bRemoveDPIScale) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector2D*)(b+0)) = Position;
                *((bool*)(b+8)) = bRemoveDPIScale;
                Main.GetProcessEvent(obj, SetPositionInViewport_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAllAnimations_method {
            static internal IntPtr StopAllAnimations_ptr;
            static StopAllAnimations_method() {
                StopAllAnimations_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "StopAllAnimations");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopAllAnimations_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAnimation_method {
            static internal IntPtr StopAnimation_ptr;
            static StopAnimation_method() {
                StopAnimation_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "StopAnimation");
            }

            internal static unsafe void Invoke(IntPtr obj, WidgetAnimation InAnimation) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InAnimation;
                Main.GetProcessEvent(obj, StopAnimation_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAnimationsAndLatentActions_method {
            static internal IntPtr StopAnimationsAndLatentActions_ptr;
            static StopAnimationsAndLatentActions_method() {
                StopAnimationsAndLatentActions_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "StopAnimationsAndLatentActions");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopAnimationsAndLatentActions_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopListeningForAllInputActions_method {
            static internal IntPtr StopListeningForAllInputActions_ptr;
            static StopListeningForAllInputActions_method() {
                StopListeningForAllInputActions_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "StopListeningForAllInputActions");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopListeningForAllInputActions_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopListeningForInputAction_method {
            static internal IntPtr StopListeningForInputAction_ptr;
            static StopListeningForInputAction_method() {
                StopListeningForInputAction_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "StopListeningForInputAction");
            }

            internal static unsafe void Invoke(IntPtr obj, Name ActionName, byte EventType) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = ActionName;
                *(b+12) = EventType;
                Main.GetProcessEvent(obj, StopListeningForInputAction_ptr, new IntPtr(p)); ;
            }
        }
        internal struct UnregisterInputComponent_method {
            static internal IntPtr UnregisterInputComponent_ptr;
            static UnregisterInputComponent_method() {
                UnregisterInputComponent_ptr = Main.GetMethodUFunction(UserWidget.StaticClass, "UnregisterInputComponent");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UnregisterInputComponent_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct UserWidget_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct Construct_event {
            private static DelegateHolder<NativeFuncDelegate> Construct_link;
            private static unsafe void Construct_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_Construct();
            }
            internal static void Setup() {
                Construct_link = new DelegateHolder<NativeFuncDelegate>(Construct_process_event);
                var uf = Main.GetUFunction("Construct");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Construct_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct Destruct_event {
            private static DelegateHolder<NativeFuncDelegate> Destruct_link;
            private static unsafe void Destruct_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_Destruct();
            }
            internal static void Setup() {
                Destruct_link = new DelegateHolder<NativeFuncDelegate>(Destruct_process_event);
                var uf = Main.GetUFunction("Destruct");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Destruct_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct IsInteractable_event {
            private static DelegateHolder<NativeFuncDelegate> IsInteractable_link;
            private static unsafe void IsInteractable_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_IsInteractable(*(bool*)(b+0));
            }
            internal static void Setup() {
                IsInteractable_link = new DelegateHolder<NativeFuncDelegate>(IsInteractable_process_event);
                var uf = Main.GetUFunction("IsInteractable");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(IsInteractable_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnAddedToFocusPath_event {
            private static DelegateHolder<NativeFuncDelegate> OnAddedToFocusPath_link;
            private static unsafe void OnAddedToFocusPath_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnAddedToFocusPath(*(FocusEvent*)(b+0));
            }
            internal static void Setup() {
                OnAddedToFocusPath_link = new DelegateHolder<NativeFuncDelegate>(OnAddedToFocusPath_process_event);
                var uf = Main.GetUFunction("OnAddedToFocusPath");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnAddedToFocusPath_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=320 )]
        internal unsafe struct OnAnalogValueChanged_event {
            private static DelegateHolder<NativeFuncDelegate> OnAnalogValueChanged_link;
            private static unsafe void OnAnalogValueChanged_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnAnalogValueChanged(*(Geometry*)(b+0), *(AnalogInputEvent*)(b+56), *(EventReply*)(b+128));
            }
            internal static void Setup() {
                OnAnalogValueChanged_link = new DelegateHolder<NativeFuncDelegate>(OnAnalogValueChanged_process_event);
                var uf = Main.GetUFunction("OnAnalogValueChanged");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnAnalogValueChanged_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        internal unsafe struct OnDragCancelled_event {
            private static DelegateHolder<NativeFuncDelegate> OnDragCancelled_link;
            private static unsafe void OnDragCancelled_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnDragCancelled(*(PointerEvent*)(b+0), UObject.Make<DragDropOperation>(*(IntPtr*)(b+120)));
            }
            internal static void Setup() {
                OnDragCancelled_link = new DelegateHolder<NativeFuncDelegate>(OnDragCancelled_process_event);
                var uf = Main.GetUFunction("OnDragCancelled");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnDragCancelled_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        internal unsafe struct OnDragDetected_event {
            private static DelegateHolder<NativeFuncDelegate> OnDragDetected_link;
            private static unsafe void OnDragDetected_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnDragDetected(*(Geometry*)(b+0), *(PointerEvent*)(b+56), UObject.Make<DragDropOperation>(*(IntPtr*)(b+176)));
            }
            internal static void Setup() {
                OnDragDetected_link = new DelegateHolder<NativeFuncDelegate>(OnDragDetected_process_event);
                var uf = Main.GetUFunction("OnDragDetected");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnDragDetected_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        internal unsafe struct OnDragEnter_event {
            private static DelegateHolder<NativeFuncDelegate> OnDragEnter_link;
            private static unsafe void OnDragEnter_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnDragEnter(*(Geometry*)(b+0), *(PointerEvent*)(b+56), UObject.Make<DragDropOperation>(*(IntPtr*)(b+176)));
            }
            internal static void Setup() {
                OnDragEnter_link = new DelegateHolder<NativeFuncDelegate>(OnDragEnter_process_event);
                var uf = Main.GetUFunction("OnDragEnter");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnDragEnter_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        internal unsafe struct OnDragLeave_event {
            private static DelegateHolder<NativeFuncDelegate> OnDragLeave_link;
            private static unsafe void OnDragLeave_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnDragLeave(*(PointerEvent*)(b+0), UObject.Make<DragDropOperation>(*(IntPtr*)(b+120)));
            }
            internal static void Setup() {
                OnDragLeave_link = new DelegateHolder<NativeFuncDelegate>(OnDragLeave_process_event);
                var uf = Main.GetUFunction("OnDragLeave");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnDragLeave_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=192 )]
        internal unsafe struct OnDragOver_event {
            private static DelegateHolder<NativeFuncDelegate> OnDragOver_link;
            private static unsafe void OnDragOver_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnDragOver(*(Geometry*)(b+0), *(PointerEvent*)(b+56), UObject.Make<DragDropOperation>(*(IntPtr*)(b+176)), *(bool*)(b+184));
            }
            internal static void Setup() {
                OnDragOver_link = new DelegateHolder<NativeFuncDelegate>(OnDragOver_process_event);
                var uf = Main.GetUFunction("OnDragOver");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnDragOver_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=192 )]
        internal unsafe struct OnDrop_event {
            private static DelegateHolder<NativeFuncDelegate> OnDrop_link;
            private static unsafe void OnDrop_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnDrop(*(Geometry*)(b+0), *(PointerEvent*)(b+56), UObject.Make<DragDropOperation>(*(IntPtr*)(b+176)), *(bool*)(b+184));
            }
            internal static void Setup() {
                OnDrop_link = new DelegateHolder<NativeFuncDelegate>(OnDrop_process_event);
                var uf = Main.GetUFunction("OnDrop");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnDrop_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnFocusLost_event {
            private static DelegateHolder<NativeFuncDelegate> OnFocusLost_link;
            private static unsafe void OnFocusLost_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnFocusLost(*(FocusEvent*)(b+0));
            }
            internal static void Setup() {
                OnFocusLost_link = new DelegateHolder<NativeFuncDelegate>(OnFocusLost_process_event);
                var uf = Main.GetUFunction("OnFocusLost");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnFocusLost_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=256 )]
        internal unsafe struct OnFocusReceived_event {
            private static DelegateHolder<NativeFuncDelegate> OnFocusReceived_link;
            private static unsafe void OnFocusReceived_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnFocusReceived(*(Geometry*)(b+0), *(FocusEvent*)(b+56), *(EventReply*)(b+64));
            }
            internal static void Setup() {
                OnFocusReceived_link = new DelegateHolder<NativeFuncDelegate>(OnFocusReceived_process_event);
                var uf = Main.GetUFunction("OnFocusReceived");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnFocusReceived_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnInitialized_event {
            private static DelegateHolder<NativeFuncDelegate> OnInitialized_link;
            private static unsafe void OnInitialized_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnInitialized();
            }
            internal static void Setup() {
                OnInitialized_link = new DelegateHolder<NativeFuncDelegate>(OnInitialized_process_event);
                var uf = Main.GetUFunction("OnInitialized");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnInitialized_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=280 )]
        internal unsafe struct OnKeyChar_event {
            private static DelegateHolder<NativeFuncDelegate> OnKeyChar_link;
            private static unsafe void OnKeyChar_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnKeyChar(*(Geometry*)(b+0), *(CharacterEvent*)(b+56), *(EventReply*)(b+88));
            }
            internal static void Setup() {
                OnKeyChar_link = new DelegateHolder<NativeFuncDelegate>(OnKeyChar_process_event);
                var uf = Main.GetUFunction("OnKeyChar");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnKeyChar_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=312 )]
        internal unsafe struct OnKeyDown_event {
            private static DelegateHolder<NativeFuncDelegate> OnKeyDown_link;
            private static unsafe void OnKeyDown_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnKeyDown(*(Geometry*)(b+0), *(KeyEvent*)(b+56), *(EventReply*)(b+120));
            }
            internal static void Setup() {
                OnKeyDown_link = new DelegateHolder<NativeFuncDelegate>(OnKeyDown_process_event);
                var uf = Main.GetUFunction("OnKeyDown");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnKeyDown_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=312 )]
        internal unsafe struct OnKeyUp_event {
            private static DelegateHolder<NativeFuncDelegate> OnKeyUp_link;
            private static unsafe void OnKeyUp_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnKeyUp(*(Geometry*)(b+0), *(KeyEvent*)(b+56), *(EventReply*)(b+120));
            }
            internal static void Setup() {
                OnKeyUp_link = new DelegateHolder<NativeFuncDelegate>(OnKeyUp_process_event);
                var uf = Main.GetUFunction("OnKeyUp");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnKeyUp_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=320 )]
        internal unsafe struct OnMotionDetected_event {
            private static DelegateHolder<NativeFuncDelegate> OnMotionDetected_link;
            private static unsafe void OnMotionDetected_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMotionDetected(*(Geometry*)(b+0), *(MotionEvent*)(b+56), *(EventReply*)(b+128));
            }
            internal static void Setup() {
                OnMotionDetected_link = new DelegateHolder<NativeFuncDelegate>(OnMotionDetected_process_event);
                var uf = Main.GetUFunction("OnMotionDetected");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMotionDetected_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnMouseButtonDoubleClick_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseButtonDoubleClick_link;
            private static unsafe void OnMouseButtonDoubleClick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseButtonDoubleClick(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnMouseButtonDoubleClick_link = new DelegateHolder<NativeFuncDelegate>(OnMouseButtonDoubleClick_process_event);
                var uf = Main.GetUFunction("OnMouseButtonDoubleClick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseButtonDoubleClick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnMouseButtonDown_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseButtonDown_link;
            private static unsafe void OnMouseButtonDown_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseButtonDown(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnMouseButtonDown_link = new DelegateHolder<NativeFuncDelegate>(OnMouseButtonDown_process_event);
                var uf = Main.GetUFunction("OnMouseButtonDown");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseButtonDown_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnMouseButtonUp_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseButtonUp_link;
            private static unsafe void OnMouseButtonUp_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseButtonUp(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnMouseButtonUp_link = new DelegateHolder<NativeFuncDelegate>(OnMouseButtonUp_process_event);
                var uf = Main.GetUFunction("OnMouseButtonUp");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseButtonUp_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnMouseCaptureLost_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseCaptureLost_link;
            private static unsafe void OnMouseCaptureLost_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseCaptureLost();
            }
            internal static void Setup() {
                OnMouseCaptureLost_link = new DelegateHolder<NativeFuncDelegate>(OnMouseCaptureLost_process_event);
                var uf = Main.GetUFunction("OnMouseCaptureLost");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseCaptureLost_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        internal unsafe struct OnMouseEnter_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseEnter_link;
            private static unsafe void OnMouseEnter_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseEnter(*(Geometry*)(b+0), *(PointerEvent*)(b+56));
            }
            internal static void Setup() {
                OnMouseEnter_link = new DelegateHolder<NativeFuncDelegate>(OnMouseEnter_process_event);
                var uf = Main.GetUFunction("OnMouseEnter");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseEnter_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        internal unsafe struct OnMouseLeave_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseLeave_link;
            private static unsafe void OnMouseLeave_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseLeave(*(PointerEvent*)(b+0));
            }
            internal static void Setup() {
                OnMouseLeave_link = new DelegateHolder<NativeFuncDelegate>(OnMouseLeave_process_event);
                var uf = Main.GetUFunction("OnMouseLeave");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseLeave_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnMouseMove_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseMove_link;
            private static unsafe void OnMouseMove_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseMove(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnMouseMove_link = new DelegateHolder<NativeFuncDelegate>(OnMouseMove_process_event);
                var uf = Main.GetUFunction("OnMouseMove");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseMove_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnMouseWheel_event {
            private static DelegateHolder<NativeFuncDelegate> OnMouseWheel_link;
            private static unsafe void OnMouseWheel_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnMouseWheel(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnMouseWheel_link = new DelegateHolder<NativeFuncDelegate>(OnMouseWheel_process_event);
                var uf = Main.GetUFunction("OnMouseWheel");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnMouseWheel_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        internal unsafe struct OnPaint_event {
            private static DelegateHolder<NativeFuncDelegate> OnPaint_link;
            private static unsafe void OnPaint_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnPaint(*(PaintContext*)(b+0));
            }
            internal static void Setup() {
                OnPaint_link = new DelegateHolder<NativeFuncDelegate>(OnPaint_process_event);
                var uf = Main.GetUFunction("OnPaint");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPaint_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=312 )]
        internal unsafe struct OnPreviewKeyDown_event {
            private static DelegateHolder<NativeFuncDelegate> OnPreviewKeyDown_link;
            private static unsafe void OnPreviewKeyDown_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnPreviewKeyDown(*(Geometry*)(b+0), *(KeyEvent*)(b+56), *(EventReply*)(b+120));
            }
            internal static void Setup() {
                OnPreviewKeyDown_link = new DelegateHolder<NativeFuncDelegate>(OnPreviewKeyDown_process_event);
                var uf = Main.GetUFunction("OnPreviewKeyDown");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPreviewKeyDown_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnPreviewMouseButtonDown_event {
            private static DelegateHolder<NativeFuncDelegate> OnPreviewMouseButtonDown_link;
            private static unsafe void OnPreviewMouseButtonDown_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnPreviewMouseButtonDown(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnPreviewMouseButtonDown_link = new DelegateHolder<NativeFuncDelegate>(OnPreviewMouseButtonDown_process_event);
                var uf = Main.GetUFunction("OnPreviewMouseButtonDown");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPreviewMouseButtonDown_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnRemovedFromFocusPath_event {
            private static DelegateHolder<NativeFuncDelegate> OnRemovedFromFocusPath_link;
            private static unsafe void OnRemovedFromFocusPath_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnRemovedFromFocusPath(*(FocusEvent*)(b+0));
            }
            internal static void Setup() {
                OnRemovedFromFocusPath_link = new DelegateHolder<NativeFuncDelegate>(OnRemovedFromFocusPath_process_event);
                var uf = Main.GetUFunction("OnRemovedFromFocusPath");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnRemovedFromFocusPath_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnTouchEnded_event {
            private static DelegateHolder<NativeFuncDelegate> OnTouchEnded_link;
            private static unsafe void OnTouchEnded_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnTouchEnded(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnTouchEnded_link = new DelegateHolder<NativeFuncDelegate>(OnTouchEnded_process_event);
                var uf = Main.GetUFunction("OnTouchEnded");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnTouchEnded_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnTouchForceChanged_event {
            private static DelegateHolder<NativeFuncDelegate> OnTouchForceChanged_link;
            private static unsafe void OnTouchForceChanged_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnTouchForceChanged(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnTouchForceChanged_link = new DelegateHolder<NativeFuncDelegate>(OnTouchForceChanged_process_event);
                var uf = Main.GetUFunction("OnTouchForceChanged");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnTouchForceChanged_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnTouchGesture_event {
            private static DelegateHolder<NativeFuncDelegate> OnTouchGesture_link;
            private static unsafe void OnTouchGesture_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnTouchGesture(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnTouchGesture_link = new DelegateHolder<NativeFuncDelegate>(OnTouchGesture_process_event);
                var uf = Main.GetUFunction("OnTouchGesture");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnTouchGesture_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnTouchMoved_event {
            private static DelegateHolder<NativeFuncDelegate> OnTouchMoved_link;
            private static unsafe void OnTouchMoved_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnTouchMoved(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnTouchMoved_link = new DelegateHolder<NativeFuncDelegate>(OnTouchMoved_process_event);
                var uf = Main.GetUFunction("OnTouchMoved");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnTouchMoved_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=368 )]
        internal unsafe struct OnTouchStarted_event {
            private static DelegateHolder<NativeFuncDelegate> OnTouchStarted_link;
            private static unsafe void OnTouchStarted_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnTouchStarted(*(Geometry*)(b+0), *(PointerEvent*)(b+56), *(EventReply*)(b+176));
            }
            internal static void Setup() {
                OnTouchStarted_link = new DelegateHolder<NativeFuncDelegate>(OnTouchStarted_process_event);
                var uf = Main.GetUFunction("OnTouchStarted");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnTouchStarted_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct PreConstruct_event {
            private static DelegateHolder<NativeFuncDelegate> PreConstruct_link;
            private static unsafe void PreConstruct_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_PreConstruct(*(bool*)(b+0));
            }
            internal static void Setup() {
                PreConstruct_link = new DelegateHolder<NativeFuncDelegate>(PreConstruct_process_event);
                var uf = Main.GetUFunction("PreConstruct");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(PreConstruct_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=60 )]
        internal unsafe struct Tick_event {
            private static DelegateHolder<NativeFuncDelegate> Tick_link;
            private static unsafe void Tick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;

                obj.on_Tick(*(Geometry*)(b+0), *(float*)(b+56));
            }
            internal static void Setup() {
                Tick_link = new DelegateHolder<NativeFuncDelegate>(Tick_process_event);
                var uf = Main.GetUFunction("Tick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Tick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnAnimationFinished_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnAnimationFinished_link;
            private static unsafe void OnAnimationFinished_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnAnimationFinished(UObject.Make<WidgetAnimation>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                OnAnimationFinished_link = new DelegateHolder<NativeFuncDelegate>(OnAnimationFinished_process_event);
                var uf = Main.GetUFunction("OnAnimationFinished");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnAnimationFinished_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnAnimationStarted_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnAnimationStarted_link;
            private static unsafe void OnAnimationStarted_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<UserWidget>(context);
                var b = (byte*) theStack->Locals;
                obj.on_OnAnimationStarted(UObject.Make<WidgetAnimation>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                OnAnimationStarted_link = new DelegateHolder<NativeFuncDelegate>(OnAnimationStarted_process_event);
                var uf = Main.GetUFunction("OnAnimationStarted");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnAnimationStarted_link.Delegate));
            }
        }
    }
}
