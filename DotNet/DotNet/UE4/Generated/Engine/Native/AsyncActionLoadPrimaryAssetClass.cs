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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct AsyncActionLoadPrimaryAssetClass_fields {
        [FieldOffset(136)] byte Completed; //TODO: multicast delegate FOnPrimaryAssetClassLoaded Completed
    }
    internal unsafe struct AsyncActionLoadPrimaryAssetClass_methods {
        internal struct AsyncLoadPrimaryAssetClass_method {
            static internal IntPtr AsyncLoadPrimaryAssetClass_ptr;
            static AsyncLoadPrimaryAssetClass_method() {
                AsyncLoadPrimaryAssetClass_ptr = Main.GetMethodUFunction(AsyncActionLoadPrimaryAssetClass.StaticClass, "AsyncLoadPrimaryAssetClass");
            }

            internal static unsafe AsyncActionLoadPrimaryAssetClass Invoke(UObject WorldContextObject, PrimaryAssetId PrimaryAsset, byte LoadBundles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((PrimaryAssetId*)(b+8)) = PrimaryAsset;
                throw new NotImplementedException(); //TODO: array TArray LoadBundles
                Main.GetProcessEvent(AsyncActionLoadPrimaryAssetClass.DefaultObject, AsyncLoadPrimaryAssetClass_ptr, new IntPtr(p)); ;
                 //TODO: array TArray LoadBundles
                return *((IntPtr*)(b+48));
            }
        }
    }
    internal unsafe struct AsyncActionLoadPrimaryAssetClass_events {
    }
}
