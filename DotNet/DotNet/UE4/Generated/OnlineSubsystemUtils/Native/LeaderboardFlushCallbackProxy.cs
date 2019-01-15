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
    internal unsafe struct LeaderboardFlushCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FOnLeaderboardFlushed OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FOnLeaderboardFlushed OnFailure
    }
    internal unsafe struct LeaderboardFlushCallbackProxy_methods {
        internal struct CreateProxyObjectForFlush_method {
            static internal IntPtr CreateProxyObjectForFlush_ptr;
            static CreateProxyObjectForFlush_method() {
                CreateProxyObjectForFlush_ptr = Main.GetMethodUFunction(LeaderboardFlushCallbackProxy.StaticClass, "CreateProxyObjectForFlush");
            }

            internal static unsafe LeaderboardFlushCallbackProxy Invoke(PlayerController PlayerController, Name SessionName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                *((Name*)(b+8)) = SessionName;
                Main.GetProcessEvent(LeaderboardFlushCallbackProxy.DefaultObject, CreateProxyObjectForFlush_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
    }
    internal unsafe struct LeaderboardFlushCallbackProxy_events {
    }
}
