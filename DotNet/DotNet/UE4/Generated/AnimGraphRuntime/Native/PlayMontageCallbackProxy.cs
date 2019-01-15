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

namespace UE4.AnimGraphRuntime.Native {
    [StructLayout( LayoutKind.Explicit, Size=184 )]
    internal unsafe struct PlayMontageCallbackProxy_fields {
        [FieldOffset(56)] byte OnCompleted; //TODO: multicast delegate FOnMontagePlayDelegate OnCompleted
        [FieldOffset(72)] byte OnBlendOut; //TODO: multicast delegate FOnMontagePlayDelegate OnBlendOut
        [FieldOffset(88)] byte OnInterrupted; //TODO: multicast delegate FOnMontagePlayDelegate OnInterrupted
        [FieldOffset(104)] byte OnNotifyBegin; //TODO: multicast delegate FOnMontagePlayDelegate OnNotifyBegin
        [FieldOffset(120)] byte OnNotifyEnd; //TODO: multicast delegate FOnMontagePlayDelegate OnNotifyEnd
    }
    internal unsafe struct PlayMontageCallbackProxy_methods {
        internal struct CreateProxyObjectForPlayMontage_method {
            static internal IntPtr CreateProxyObjectForPlayMontage_ptr;
            static CreateProxyObjectForPlayMontage_method() {
                CreateProxyObjectForPlayMontage_ptr = Main.GetMethodUFunction(PlayMontageCallbackProxy.StaticClass, "CreateProxyObjectForPlayMontage");
            }

            internal static unsafe PlayMontageCallbackProxy Invoke(SkeletalMeshComponent InSkeletalMeshComponent, AnimMontage MontageToPlay, float PlayRate, float StartingPosition, Name StartingSection) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = InSkeletalMeshComponent;
                *((IntPtr*)(b+8)) = MontageToPlay;
                *((float*)(b+16)) = PlayRate;
                *((float*)(b+20)) = StartingPosition;
                *((Name*)(b+24)) = StartingSection;
                Main.GetProcessEvent(PlayMontageCallbackProxy.DefaultObject, CreateProxyObjectForPlayMontage_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+40));
            }
        }
    }
    internal unsafe struct PlayMontageCallbackProxy_events {
    }
}
