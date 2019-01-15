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

namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct AchievementWriteCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FAchievementWriteDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FAchievementWriteDelegate OnFailure
    }
    internal unsafe struct AchievementWriteCallbackProxy_methods {
        internal struct WriteAchievementProgress_method {
            static internal IntPtr WriteAchievementProgress_ptr;
            static WriteAchievementProgress_method() {
                WriteAchievementProgress_ptr = Main.GetMethodUFunction(AchievementWriteCallbackProxy.StaticClass, "WriteAchievementProgress");
            }

            internal static unsafe AchievementWriteCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, Name AchievementName, float Progress, int UserTag) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                *((Name*)(b+16)) = AchievementName;
                *((float*)(b+28)) = Progress;
                *((int*)(b+32)) = UserTag;
                Main.GetProcessEvent(AchievementWriteCallbackProxy.DefaultObject, WriteAchievementProgress_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+40));
            }
        }
    }
    internal unsafe struct AchievementWriteCallbackProxy_events {
    }
}
