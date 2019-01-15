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
    internal unsafe struct QuitMatchCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
    }
    internal unsafe struct QuitMatchCallbackProxy_methods {
        internal struct QuitMatch_method {
            static internal IntPtr QuitMatch_ptr;
            static QuitMatch_method() {
                QuitMatch_ptr = Main.GetMethodUFunction(QuitMatchCallbackProxy.StaticClass, "QuitMatch");
            }

            internal static unsafe QuitMatchCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, string MatchID, byte Outcome, int TurnTimeoutInSeconds) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                var MatchID_handle = GCHandle.Alloc(MatchID, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = MatchID_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = MatchID.Length;
                *(int*)(b+IntPtr.Size+4+16) = MatchID.Length;
                *(b+32) = Outcome;
                *((int*)(b+36)) = TurnTimeoutInSeconds;
                Main.GetProcessEvent(QuitMatchCallbackProxy.DefaultObject, QuitMatch_ptr, new IntPtr(p)); ;
                MatchID_handle.Free();
                return *((IntPtr*)(b+40));
            }
        }
    }
    internal unsafe struct QuitMatchCallbackProxy_events {
    }
}
