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
    internal unsafe struct ShowLoginUICallbackProxy_fields {
        [FieldOffset(64)] byte OnSuccess; //TODO: multicast delegate FOnlineShowLoginUIResult OnSuccess
        [FieldOffset(80)] byte OnFailure; //TODO: multicast delegate FOnlineShowLoginUIResult OnFailure
    }
    internal unsafe struct ShowLoginUICallbackProxy_methods {
        internal struct ShowExternalLoginUI_method {
            static internal IntPtr ShowExternalLoginUI_ptr;
            static ShowExternalLoginUI_method() {
                ShowExternalLoginUI_ptr = Main.GetMethodUFunction(ShowLoginUICallbackProxy.StaticClass, "ShowExternalLoginUI");
            }

            internal static unsafe ShowLoginUICallbackProxy Invoke(UObject WorldContextObject, PlayerController InPlayerController) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = InPlayerController;
                Main.GetProcessEvent(ShowLoginUICallbackProxy.DefaultObject, ShowExternalLoginUI_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct ShowLoginUICallbackProxy_events {
    }
}
