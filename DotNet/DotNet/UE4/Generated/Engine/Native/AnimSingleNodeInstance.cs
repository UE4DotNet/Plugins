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
    [StructLayout( LayoutKind.Explicit, Size=976 )]
    internal unsafe struct AnimSingleNodeInstance_fields {
        [FieldOffset(936)]  public IntPtr  CurrentAsset;
        [FieldOffset(944)] byte PostEvaluateAnimEvent; //TODO: delegate FPostEvaluateAnimEvent PostEvaluateAnimEvent
    }
    internal unsafe struct AnimSingleNodeInstance_methods {
        internal struct GetAnimationAsset_method {
            static internal IntPtr GetAnimationAsset_ptr;
            static GetAnimationAsset_method() {
                GetAnimationAsset_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "GetAnimationAsset");
            }

            internal static unsafe AnimationAsset Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetAnimationAsset_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct GetLength_method {
            static internal IntPtr GetLength_ptr;
            static GetLength_method() {
                GetLength_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "GetLength");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
        internal struct PlayAnim_method {
            static internal IntPtr PlayAnim_ptr;
            static PlayAnim_method() {
                PlayAnim_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "PlayAnim");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bIsLooping, float InPlayRate, float InStartPosition) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bIsLooping;
                *((float*)(b+4)) = InPlayRate;
                *((float*)(b+8)) = InStartPosition;
                Main.GetProcessEvent(obj, PlayAnim_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetAnimationAsset_method {
            static internal IntPtr SetAnimationAsset_ptr;
            static SetAnimationAsset_method() {
                SetAnimationAsset_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetAnimationAsset");
            }

            internal static unsafe void Invoke(IntPtr obj, AnimationAsset NewAsset, bool bIsLooping, float InPlayRate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewAsset;
                *((bool*)(b+8)) = bIsLooping;
                *((float*)(b+12)) = InPlayRate;
                Main.GetProcessEvent(obj, SetAnimationAsset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetBlendSpaceInput_method {
            static internal IntPtr SetBlendSpaceInput_ptr;
            static SetBlendSpaceInput_method() {
                SetBlendSpaceInput_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetBlendSpaceInput");
            }

            internal static unsafe void Invoke(IntPtr obj, Vector InBlendInput) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = InBlendInput;
                Main.GetProcessEvent(obj, SetBlendSpaceInput_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetLooping_method {
            static internal IntPtr SetLooping_ptr;
            static SetLooping_method() {
                SetLooping_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetLooping");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bIsLooping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bIsLooping;
                Main.GetProcessEvent(obj, SetLooping_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlaying_method {
            static internal IntPtr SetPlaying_ptr;
            static SetPlaying_method() {
                SetPlaying_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetPlaying");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bIsPlaying) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bIsPlaying;
                Main.GetProcessEvent(obj, SetPlaying_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPlayRate_method {
            static internal IntPtr SetPlayRate_ptr;
            static SetPlayRate_method() {
                SetPlayRate_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetPlayRate");
            }

            internal static unsafe void Invoke(IntPtr obj, float InPlayRate) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InPlayRate;
                Main.GetProcessEvent(obj, SetPlayRate_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPosition_method {
            static internal IntPtr SetPosition_ptr;
            static SetPosition_method() {
                SetPosition_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetPosition");
            }

            internal static unsafe void Invoke(IntPtr obj, float InPosition, bool bFireNotifies) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InPosition;
                *((bool*)(b+4)) = bFireNotifies;
                Main.GetProcessEvent(obj, SetPosition_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPositionWithPreviousTime_method {
            static internal IntPtr SetPositionWithPreviousTime_ptr;
            static SetPositionWithPreviousTime_method() {
                SetPositionWithPreviousTime_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetPositionWithPreviousTime");
            }

            internal static unsafe void Invoke(IntPtr obj, float InPosition, float InPreviousTime, bool bFireNotifies) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InPosition;
                *((float*)(b+4)) = InPreviousTime;
                *((bool*)(b+8)) = bFireNotifies;
                Main.GetProcessEvent(obj, SetPositionWithPreviousTime_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPreviewCurveOverride_method {
            static internal IntPtr SetPreviewCurveOverride_ptr;
            static SetPreviewCurveOverride_method() {
                SetPreviewCurveOverride_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetPreviewCurveOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, Name PoseName, float Value, bool bRemoveIfZero) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = PoseName;
                *((float*)(b+12)) = Value;
                *((bool*)(b+16)) = bRemoveIfZero;
                Main.GetProcessEvent(obj, SetPreviewCurveOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetReverse_method {
            static internal IntPtr SetReverse_ptr;
            static SetReverse_method() {
                SetReverse_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "SetReverse");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInReverse) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInReverse;
                Main.GetProcessEvent(obj, SetReverse_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopAnim_method {
            static internal IntPtr StopAnim_ptr;
            static StopAnim_method() {
                StopAnim_ptr = Main.GetMethodUFunction(AnimSingleNodeInstance.StaticClass, "StopAnim");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopAnim_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct AnimSingleNodeInstance_events {
    }
}
