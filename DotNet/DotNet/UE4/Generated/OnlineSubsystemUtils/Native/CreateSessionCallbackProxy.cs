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
    [StructLayout( LayoutKind.Explicit, Size=160 )]
    internal unsafe struct CreateSessionCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
    }
    internal unsafe struct CreateSessionCallbackProxy_methods {
        internal struct CreateSession_method {
            static internal IntPtr CreateSession_ptr;
            static CreateSession_method() {
                CreateSession_ptr = Main.GetMethodUFunction(CreateSessionCallbackProxy.StaticClass, "CreateSession");
            }

            internal static unsafe CreateSessionCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, int PublicConnections, bool bUseLAN) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                *((int*)(b+16)) = PublicConnections;
                *((bool*)(b+20)) = bUseLAN;
                Main.GetProcessEvent(CreateSessionCallbackProxy.DefaultObject, CreateSession_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
    }
    internal unsafe struct CreateSessionCallbackProxy_events {
    }
}
