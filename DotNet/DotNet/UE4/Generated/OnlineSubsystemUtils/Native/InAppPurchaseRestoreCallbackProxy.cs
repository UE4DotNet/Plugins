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
    internal unsafe struct InAppPurchaseRestoreCallbackProxy_fields {
        [FieldOffset(56)] byte OnSuccess; //TODO: multicast delegate FInAppPurchaseRestoreResult OnSuccess
        [FieldOffset(72)] byte OnFailure; //TODO: multicast delegate FInAppPurchaseRestoreResult OnFailure
    }
    internal unsafe struct InAppPurchaseRestoreCallbackProxy_methods {
        internal struct CreateProxyObjectForInAppPurchaseRestore_method {
            static internal IntPtr CreateProxyObjectForInAppPurchaseRestore_ptr;
            static CreateProxyObjectForInAppPurchaseRestore_method() {
                CreateProxyObjectForInAppPurchaseRestore_ptr = Main.GetMethodUFunction(InAppPurchaseRestoreCallbackProxy.StaticClass, "CreateProxyObjectForInAppPurchaseRestore");
            }

            internal static unsafe InAppPurchaseRestoreCallbackProxy Invoke(byte ConsumableProductFlags /*TODO: array TArray */, PlayerController PlayerController) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: array TArray ConsumableProductFlags
                *((IntPtr*)(b+16)) = PlayerController;
                Main.GetProcessEvent(InAppPurchaseRestoreCallbackProxy.DefaultObject, CreateProxyObjectForInAppPurchaseRestore_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ConsumableProductFlags
                return *((IntPtr*)(b+24));
            }
        }
    }
    internal unsafe struct InAppPurchaseRestoreCallbackProxy_events {
    }
}
