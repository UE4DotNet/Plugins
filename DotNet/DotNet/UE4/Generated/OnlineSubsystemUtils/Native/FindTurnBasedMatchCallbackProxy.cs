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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct FindTurnBasedMatchCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FOnlineTurnBasedMatchResult OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FOnlineTurnBasedMatchResult OnFailure
    }
    internal unsafe struct FindTurnBasedMatchCallbackProxy_methods {
        internal struct FindTurnBasedMatch_method {
            static internal IntPtr FindTurnBasedMatch_ptr;
            static FindTurnBasedMatch_method() {
                FindTurnBasedMatch_ptr = Main.GetMethodUFunction(FindTurnBasedMatchCallbackProxy.StaticClass, "FindTurnBasedMatch");
            }

            internal static unsafe FindTurnBasedMatchCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, byte MatchActor /*TODO: interface TScriptInterface */, int MinPlayers, int MaxPlayers, int PlayerGroup, bool ShowExistingMatches) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                throw new NotImplementedException(); //TODO: interface TScriptInterface MatchActor
                *((int*)(b+32)) = MinPlayers;
                *((int*)(b+36)) = MaxPlayers;
                *((int*)(b+40)) = PlayerGroup;
                *((bool*)(b+44)) = ShowExistingMatches;
                Main.GetProcessEvent(FindTurnBasedMatchCallbackProxy.DefaultObject, FindTurnBasedMatch_ptr, new IntPtr(p)); ;
                 //TODO: interface TScriptInterface MatchActor
                return *((IntPtr*)(b+48));
            }
        }
    }
    internal unsafe struct FindTurnBasedMatchCallbackProxy_events {
    }
}
