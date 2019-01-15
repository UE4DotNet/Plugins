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
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct FindSessionsCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FBlueprintFindSessionsResultDelegate OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FBlueprintFindSessionsResultDelegate OnFailure
    }
    internal unsafe struct FindSessionsCallbackProxy_methods {
        internal struct FindSessions_method {
            static internal IntPtr FindSessions_ptr;
            static FindSessions_method() {
                FindSessions_ptr = Main.GetMethodUFunction(FindSessionsCallbackProxy.StaticClass, "FindSessions");
            }

            internal static unsafe FindSessionsCallbackProxy Invoke(UObject WorldContextObject, PlayerController PlayerController, int MaxResults, bool bUseLAN) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = PlayerController;
                *((int*)(b+16)) = MaxResults;
                *((bool*)(b+20)) = bUseLAN;
                Main.GetProcessEvent(FindSessionsCallbackProxy.DefaultObject, FindSessions_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct GetCurrentPlayers_method {
            static internal IntPtr GetCurrentPlayers_ptr;
            static GetCurrentPlayers_method() {
                GetCurrentPlayers_ptr = Main.GetMethodUFunction(FindSessionsCallbackProxy.StaticClass, "GetCurrentPlayers");
            }

            internal static unsafe int Invoke(BlueprintSessionResult Result) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((BlueprintSessionResult*)(b+0)) = Result;
                Main.GetProcessEvent(FindSessionsCallbackProxy.DefaultObject, GetCurrentPlayers_ptr, new IntPtr(p)); ;
                return *((int*)(b+184));
            }
        }
        internal struct GetMaxPlayers_method {
            static internal IntPtr GetMaxPlayers_ptr;
            static GetMaxPlayers_method() {
                GetMaxPlayers_ptr = Main.GetMethodUFunction(FindSessionsCallbackProxy.StaticClass, "GetMaxPlayers");
            }

            internal static unsafe int Invoke(BlueprintSessionResult Result) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((BlueprintSessionResult*)(b+0)) = Result;
                Main.GetProcessEvent(FindSessionsCallbackProxy.DefaultObject, GetMaxPlayers_ptr, new IntPtr(p)); ;
                return *((int*)(b+184));
            }
        }
        internal struct GetPingInMs_method {
            static internal IntPtr GetPingInMs_ptr;
            static GetPingInMs_method() {
                GetPingInMs_ptr = Main.GetMethodUFunction(FindSessionsCallbackProxy.StaticClass, "GetPingInMs");
            }

            internal static unsafe int Invoke(BlueprintSessionResult Result) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((BlueprintSessionResult*)(b+0)) = Result;
                Main.GetProcessEvent(FindSessionsCallbackProxy.DefaultObject, GetPingInMs_ptr, new IntPtr(p)); ;
                return *((int*)(b+184));
            }
        }
        internal struct GetServerName_method {
            static internal IntPtr GetServerName_ptr;
            static GetServerName_method() {
                GetServerName_ptr = Main.GetMethodUFunction(FindSessionsCallbackProxy.StaticClass, "GetServerName");
            }

            internal static unsafe string Invoke(BlueprintSessionResult Result) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((BlueprintSessionResult*)(b+0)) = Result;
                Main.GetProcessEvent(FindSessionsCallbackProxy.DefaultObject, GetServerName_ptr, new IntPtr(p)); ;
                return FString.Get(b+184);
            }
        }
    }
    internal unsafe struct FindSessionsCallbackProxy_events {
    }
}
