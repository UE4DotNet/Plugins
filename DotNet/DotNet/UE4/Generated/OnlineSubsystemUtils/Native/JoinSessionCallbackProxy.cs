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
    [StructLayout( LayoutKind.Explicit, Size=312 )]
    internal unsafe struct JoinSessionCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
    }
    internal unsafe struct JoinSessionCallbackProxy_methods {
        internal struct JoinSession_method {
            static internal IntPtr JoinSession_ptr;
            static JoinSession_method() {
                JoinSession_ptr = Main.GetMethodUFunction(JoinSessionCallbackProxy.StaticClass, "JoinSession");
            }

            internal static unsafe JoinSessionCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, BlueprintSessionResult SearchResult) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                *((BlueprintSessionResult*)(b+16)) = SearchResult;
                Main.GetProcessEvent(JoinSessionCallbackProxy.DefaultObject, JoinSession_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+200));
            }
        }
    }
    internal unsafe struct JoinSessionCallbackProxy_events {
    }
}
