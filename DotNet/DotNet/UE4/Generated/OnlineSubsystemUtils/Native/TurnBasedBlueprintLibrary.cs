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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct TurnBasedBlueprintLibrary_fields {
    }
    internal unsafe struct TurnBasedBlueprintLibrary_methods {
        internal struct GetIsMyTurn_method {
            static internal IntPtr GetIsMyTurn_ptr;
            static GetIsMyTurn_method() {
                GetIsMyTurn_ptr = Main.GetMethodUFunction(TurnBasedBlueprintLibrary.StaticClass, "GetIsMyTurn");
            }

            internal static unsafe bool Invoke(UObject WorldContextObject, PlayerController PlayerController, string MatchID) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                var MatchID_handle = GCHandle.Alloc(MatchID, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = MatchID_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = MatchID.Length;
                *(int*)(b+IntPtr.Size+4+16) = MatchID.Length;
                Main.GetProcessEvent(TurnBasedBlueprintLibrary.DefaultObject, GetIsMyTurn_ptr, new IntPtr(p)); ;
                MatchID_handle.Free();
                return *((bool*)(b+32));
            }
        }
        internal struct GetMyPlayerIndex_method {
            static internal IntPtr GetMyPlayerIndex_ptr;
            static GetMyPlayerIndex_method() {
                GetMyPlayerIndex_ptr = Main.GetMethodUFunction(TurnBasedBlueprintLibrary.StaticClass, "GetMyPlayerIndex");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, PlayerController PlayerController, string MatchID) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                var MatchID_handle = GCHandle.Alloc(MatchID, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = MatchID_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = MatchID.Length;
                *(int*)(b+IntPtr.Size+4+16) = MatchID.Length;
                Main.GetProcessEvent(TurnBasedBlueprintLibrary.DefaultObject, GetMyPlayerIndex_ptr, new IntPtr(p)); ;
                MatchID_handle.Free();
                return *((int*)(b+32));
            }
        }
        internal struct GetPlayerDisplayName_method {
            static internal IntPtr GetPlayerDisplayName_ptr;
            static GetPlayerDisplayName_method() {
                GetPlayerDisplayName_ptr = Main.GetMethodUFunction(TurnBasedBlueprintLibrary.StaticClass, "GetPlayerDisplayName");
            }

            internal static unsafe string Invoke(UObject WorldContextObject, PlayerController PlayerController, string MatchID, int PlayerIndex) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                var MatchID_handle = GCHandle.Alloc(MatchID, GCHandleType.Pinned);
                *(IntPtr*)(b+16) = MatchID_handle.AddrOfPinnedObject();
                *(int*)(b+IntPtr.Size+16) = MatchID.Length;
                *(int*)(b+IntPtr.Size+4+16) = MatchID.Length;
                *((int*)(b+32)) = PlayerIndex;
                Main.GetProcessEvent(TurnBasedBlueprintLibrary.DefaultObject, GetPlayerDisplayName_ptr, new IntPtr(p)); ;
                MatchID_handle.Free();
                return FString.Get(b+40);
            }
        }
        internal struct RegisterTurnBasedMatchInterfaceObject_method {
            static internal IntPtr RegisterTurnBasedMatchInterfaceObject_ptr;
            static RegisterTurnBasedMatchInterfaceObject_method() {
                RegisterTurnBasedMatchInterfaceObject_ptr = Main.GetMethodUFunction(TurnBasedBlueprintLibrary.StaticClass, "RegisterTurnBasedMatchInterfaceObject");
            }

            internal static unsafe void Invoke(UObject WorldContextObject, PlayerController PlayerController, UObject UObject) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                *((IntPtr*)(b+16)) = UObject;
                Main.GetProcessEvent(TurnBasedBlueprintLibrary.DefaultObject, RegisterTurnBasedMatchInterfaceObject_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct TurnBasedBlueprintLibrary_events {
    }
}
