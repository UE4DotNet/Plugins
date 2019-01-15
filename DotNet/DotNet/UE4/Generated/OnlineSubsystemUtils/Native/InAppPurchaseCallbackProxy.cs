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
using UE4.OnlineSubsystem;

namespace UE4.OnlineSubsystemUtils.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct InAppPurchaseCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FInAppPurchaseResult OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FInAppPurchaseResult OnFailure
    }
    internal unsafe struct InAppPurchaseCallbackProxy_methods {
        internal struct CreateProxyObjectForInAppPurchase_method {
            static internal IntPtr CreateProxyObjectForInAppPurchase_ptr;
            static CreateProxyObjectForInAppPurchase_method() {
                CreateProxyObjectForInAppPurchase_ptr = Main.GetMethodUFunction(InAppPurchaseCallbackProxy.StaticClass, "CreateProxyObjectForInAppPurchase");
            }

            internal static unsafe InAppPurchaseCallbackProxy Invoke(PlayerController PlayerController, InAppPurchaseProductRequest ProductRequest) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = PlayerController;
                *((InAppPurchaseProductRequest*)(b+8)) = ProductRequest;
                Main.GetProcessEvent(InAppPurchaseCallbackProxy.DefaultObject, CreateProxyObjectForInAppPurchase_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+32));
            }
        }
    }
    internal unsafe struct InAppPurchaseCallbackProxy_events {
    }
}
