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
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct LeaderboardQueryCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FLeaderboardQueryResult OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FLeaderboardQueryResult OnFailure
    }
    internal unsafe struct LeaderboardQueryCallbackProxy_methods {
        internal struct CreateProxyObjectForIntQuery_method {
            static internal IntPtr CreateProxyObjectForIntQuery_ptr;
            static CreateProxyObjectForIntQuery_method() {
                CreateProxyObjectForIntQuery_ptr = Main.GetMethodUFunction(LeaderboardQueryCallbackProxy.StaticClass, "CreateProxyObjectForIntQuery");
            }

            internal static unsafe LeaderboardQueryCallbackProxy Invoke(PlayerController PlayerController, Name StatName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                *((Name*)(b+8)) = StatName;
                Main.GetProcessEvent(LeaderboardQueryCallbackProxy.DefaultObject, CreateProxyObjectForIntQuery_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
    }
    internal unsafe struct LeaderboardQueryCallbackProxy_events {
    }
}
