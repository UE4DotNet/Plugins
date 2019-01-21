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
    [StructLayout( LayoutKind.Explicit, Size=752 )]
    internal unsafe struct ImageTrackerComponent_fields {
        [FieldOffset(624)] byte OnSetImageTargetSucceeded; //TODO: multicast delegate FSetImageTargetSucceeded OnSetImageTargetSucceeded
        [FieldOffset(640)] byte OnSetImageTargetFailed; //TODO: multicast delegate FSetImageTargetFailed OnSetImageTargetFailed
        [FieldOffset(656)] byte OnImageTargetFound; //TODO: multicast delegate FImageTargetFound OnImageTargetFound
        [FieldOffset(672)] byte OnImageTargetLost; //TODO: multicast delegate FImageTargetLost OnImageTargetLost
        [FieldOffset(688)] byte OnImageTargetUnreliableTracking; //TODO: multicast delegate FImageTargetUnreliableTracking OnImageTargetUnreliableTracking
        [FieldOffset(704)]  public IntPtr  TargetImageTexture;
        [FieldOffset(712)] byte Name; //TODO: string FString Name
        [FieldOffset(728)] public float LongerDimension;
        [FieldOffset(732)] public bool bIsStationary;
        [FieldOffset(733)] public bool bUseUnreliablePose;
    }
    internal unsafe struct ImageTrackerComponent_methods {
        internal struct SetTargetAsync_method {
            static internal IntPtr SetTargetAsync_ptr;
            static SetTargetAsync_method() {
                SetTargetAsync_ptr = Main.GetMethodUFunction(ImageTrackerComponent.StaticClass, "SetTargetAsync");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture2D ImageTarget) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = ImageTarget;
                Main.GetProcessEvent(obj, SetTargetAsync_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ImageTrackerComponent_events {
    }
}
