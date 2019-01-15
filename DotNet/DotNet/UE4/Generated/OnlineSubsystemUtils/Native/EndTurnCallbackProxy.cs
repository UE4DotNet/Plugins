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
    internal unsafe struct EndTurnCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FEmptyOnlineDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FEmptyOnlineDelegate OnFailure
    }
    internal unsafe struct EndTurnCallbackProxy_methods {
        internal struct EndTurn_method {
            static internal IntPtr EndTurn_ptr;
            static EndTurn_method() {
                EndTurn_ptr = Main.GetMethodUFunction(EndTurnCallbackProxy.StaticClass, "EndTurn");
            }

            internal static unsafe EndTurnCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, string MatchID, byte TurnBasedMatchInterface /*TODO: interface TScriptInterface */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                var MatchID_handle = GCHandle.Alloc(MatchID, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = MatchID_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = MatchID.Length;
                *(int*)(b+IntPtr.Size+4+16) = MatchID.Length;
                throw new NotImplementedException(); //TODO: interface TScriptInterface TurnBasedMatchInterface
                Main.GetProcessEvent(EndTurnCallbackProxy.DefaultObject, EndTurn_ptr, new IntPtr(p)); ;
                MatchID_handle.Free();
                 //TODO: interface TScriptInterface TurnBasedMatchInterface
                return *((IntPtr*)(b+48));
            }
        }
    }
    internal unsafe struct EndTurnCallbackProxy_events {
    }
}
