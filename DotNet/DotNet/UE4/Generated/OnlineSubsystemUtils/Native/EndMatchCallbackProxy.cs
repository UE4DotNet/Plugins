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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct EndMatchCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
    }
    internal unsafe struct EndMatchCallbackProxy_methods {
        internal struct EndMatch_method {
            static internal IntPtr EndMatch_ptr;
            static EndMatch_method() {
                EndMatch_ptr = Main.GetMethodUFunction(EndMatchCallbackProxy.StaticClass, "EndMatch");
            }

            internal static unsafe EndMatchCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, byte MatchActor /*TODO: interface TScriptInterface */, string MatchID, byte LocalPlayerOutcome, byte OtherPlayersOutcome) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                throw new NotImplementedException(); //TODO: interface TScriptInterface MatchActor
                var MatchID_handle = GCHandle.Alloc(MatchID, GCHandleType.Pinned);
                *(IntPtr*)(b+32) = MatchID_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+32) = MatchID.Length;
                *(int*)(b+IntPtr.Size+4+32) = MatchID.Length;
                *(b+48) = LocalPlayerOutcome;
                *(b+49) = OtherPlayersOutcome;
                Main.GetProcessEvent(EndMatchCallbackProxy.DefaultObject, EndMatch_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface MatchActor
                MatchID_handle.Free();
                return *((IntPtr*)(b+56));
            }
        }
    }
    internal unsafe struct EndMatchCallbackProxy_events {
    }
}
