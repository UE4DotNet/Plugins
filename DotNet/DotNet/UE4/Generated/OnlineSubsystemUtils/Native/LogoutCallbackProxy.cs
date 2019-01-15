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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct LogoutCallbackProxy_fields {
        [FieldOffset(64)] byte OnSuccess; //TODO: multicast delegate FOnlineLogoutResult OnSuccess
        [FieldOffset(80)] byte OnFailure; //TODO: multicast delegate FOnlineLogoutResult OnFailure
    }
    internal unsafe struct LogoutCallbackProxy_methods {
        internal struct Logout_method {
            static internal IntPtr Logout_ptr;
            static Logout_method() {
                Logout_ptr = Main.GetMethodUFunction(LogoutCallbackProxy.StaticClass, "Logout");
            }

            internal static unsafe LogoutCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                Main.GetProcessEvent(LogoutCallbackProxy.DefaultObject, Logout_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct LogoutCallbackProxy_events {
    }
}
