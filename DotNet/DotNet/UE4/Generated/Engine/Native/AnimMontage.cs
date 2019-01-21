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
    [StructLayout( LayoutKind.Explicit, Size=752 )]
    internal unsafe struct AnimMontage_fields {
        [FieldOffset(400)] public AlphaBlend BlendIn;
        [FieldOffset(464)] public AlphaBlend BlendOut;
        [FieldOffset(524)] public float BlendOutTriggerTime;
        [FieldOffset(528)] public Name SyncGroup;
        [FieldOffset(540)] public int SyncSlotIndex;
        [FieldOffset(544)] public MarkerSyncData MarkerData;
        [FieldOffset(576)] public NativeArray CompositeSections;
        [FieldOffset(592)] public NativeArray SlotAnimTracks;
        [FieldOffset(624)] public bool bEnableRootMotionTranslation;
        [FieldOffset(625)] public bool bEnableRootMotionRotation;
        [FieldOffset(626)] public bool bEnableAutoBlendOut;
        [FieldOffset(627)] public byte RootMotionRootLock;
        [FieldOffset(632)]  public IntPtr  PreviewBasePose;
        [FieldOffset(664)] public NativeArray BranchingPointMarkers;
        [FieldOffset(680)] public NativeArray BranchingPointStateNotifyIndices;
        [FieldOffset(696)] public TimeStretchCurve TimeStretchCurve;
        [FieldOffset(736)] public Name TimeStretchCurveName;
    }
    internal unsafe struct AnimMontage_methods {
        internal struct GetDefaultBlendOutTime_method {
            static internal IntPtr GetDefaultBlendOutTime_ptr;
            static GetDefaultBlendOutTime_method() {
                GetDefaultBlendOutTime_ptr = Main.GetMethodUFunction(AnimMontage.StaticClass, "GetDefaultBlendOutTime");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetDefaultBlendOutTime_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
    }
    internal unsafe struct AnimMontage_events {
    }
}
