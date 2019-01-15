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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct AchievementBlueprintLibrary_fields {
    }
    internal unsafe struct AchievementBlueprintLibrary_methods {
        internal struct GetCachedAchievementDescription_method {
            static internal IntPtr GetCachedAchievementDescription_ptr;
            static GetCachedAchievementDescription_method() {
                GetCachedAchievementDescription_ptr = Main.GetMethodUFunction(AchievementBlueprintLibrary.StaticClass, "GetCachedAchievementDescription");
            }

            internal static unsafe (bool, byte /*TODO: text FText*/, byte /*TODO: text FText*/, byte /*TODO: text FText*/, bool) Invoke(UObject WorldContextObject, PlayerController PlayerController, Name AchievementID) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                *((Name*)(b+16)) = AchievementID;
                Main.GetProcessEvent(AchievementBlueprintLibrary.DefaultObject, GetCachedAchievementDescription_ptr, new IntPtr(p)); ;
                 //TODO: text FText Title
                 //TODO: text FText LockedDescription
                 //TODO: text FText UnlockedDescription
                return (*((bool*)(b+28)),UObject.NotImplemented<byte>() /*TODO: text FText*/,UObject.NotImplemented<byte>() /*TODO: text FText*/,UObject.NotImplemented<byte>() /*TODO: text FText*/,*((bool*)(b+104)));
            }
        }
        internal struct GetCachedAchievementProgress_method {
            static internal IntPtr GetCachedAchievementProgress_ptr;
            static GetCachedAchievementProgress_method() {
                GetCachedAchievementProgress_ptr = Main.GetMethodUFunction(AchievementBlueprintLibrary.StaticClass, "GetCachedAchievementProgress");
            }

            internal static unsafe (bool, float) Invoke(UObject WorldContextObject, PlayerController PlayerController, Name AchievementID) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                *((Name*)(b+16)) = AchievementID;
                Main.GetProcessEvent(AchievementBlueprintLibrary.DefaultObject, GetCachedAchievementProgress_ptr, new IntPtr(p)); ;
                return (*((bool*)(b+28)),*((float*)(b+32)));
            }
        }
    }
    internal unsafe struct AchievementBlueprintLibrary_events {
    }
}
