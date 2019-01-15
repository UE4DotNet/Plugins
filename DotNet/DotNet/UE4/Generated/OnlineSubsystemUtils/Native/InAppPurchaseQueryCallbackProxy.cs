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
    internal unsafe struct InAppPurchaseQueryCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FInAppPurchaseQueryResult OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FInAppPurchaseQueryResult OnFailure
    }
    internal unsafe struct InAppPurchaseQueryCallbackProxy_methods {
        internal struct CreateProxyObjectForInAppPurchaseQuery_method {
            static internal IntPtr CreateProxyObjectForInAppPurchaseQuery_ptr;
            static CreateProxyObjectForInAppPurchaseQuery_method() {
                CreateProxyObjectForInAppPurchaseQuery_ptr = Main.GetMethodUFunction(InAppPurchaseQueryCallbackProxy.StaticClass, "CreateProxyObjectForInAppPurchaseQuery");
            }

            internal static unsafe InAppPurchaseQueryCallbackProxy Invoke(PlayerController PlayerController, byte ProductIdentifiers /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                throw new NotImplementedException(); //TODO: array TArray ProductIdentifiers
                Main.GetProcessEvent(InAppPurchaseQueryCallbackProxy.DefaultObject, CreateProxyObjectForInAppPurchaseQuery_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ProductIdentifiers
                return *((IntPtr*)(b+24));
            }
        }
    }
    internal unsafe struct InAppPurchaseQueryCallbackProxy_events {
    }
}
