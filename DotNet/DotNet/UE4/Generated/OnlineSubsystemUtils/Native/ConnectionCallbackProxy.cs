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
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct ConnectionCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FOnlineConnectionResult OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FOnlineConnectionResult OnFailure
    }
    internal unsafe struct ConnectionCallbackProxy_methods {
        internal struct ConnectToService_method {
            static internal IntPtr ConnectToService_ptr;
            static ConnectToService_method() {
                ConnectToService_ptr = Main.GetMethodUFunction(ConnectionCallbackProxy.StaticClass, "ConnectToService");
            }

            internal static unsafe ConnectionCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                Main.GetProcessEvent(ConnectionCallbackProxy.DefaultObject, ConnectToService_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+16));
            }
        }
    }
    internal unsafe struct ConnectionCallbackProxy_events {
    }
}
