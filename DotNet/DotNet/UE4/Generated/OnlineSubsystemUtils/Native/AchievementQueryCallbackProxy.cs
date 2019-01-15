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
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct AchievementQueryCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
    }
    internal unsafe struct AchievementQueryCallbackProxy_methods {
        internal struct CacheAchievementDescriptions_method {
            static internal IntPtr CacheAchievementDescriptions_ptr;
            static CacheAchievementDescriptions_method() {
                CacheAchievementDescriptions_ptr = Main.GetMethodUFunction(AchievementQueryCallbackProxy.StaticClass, "CacheAchievementDescriptions");
            }

            internal static unsafe AchievementQueryCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                Main.GetProcessEvent(AchievementQueryCallbackProxy.DefaultObject, CacheAchievementDescriptions_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
        internal struct CacheAchievements_method {
            static internal IntPtr CacheAchievements_ptr;
            static CacheAchievements_method() {
                CacheAchievements_ptr = Main.GetMethodUFunction(AchievementQueryCallbackProxy.StaticClass, "CacheAchievements");
            }

            internal static unsafe AchievementQueryCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                Main.GetProcessEvent(AchievementQueryCallbackProxy.DefaultObject, CacheAchievements_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct AchievementQueryCallbackProxy_events {
    }
}
