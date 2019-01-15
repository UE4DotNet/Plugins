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
    internal unsafe struct AsyncActionChangePrimaryAssetBundles_fields {
        [FieldOffset(136)] byte Completed; //TODO: multicast delegate FOnPrimaryAssetBundlesChanged Completed
    }
    internal unsafe struct AsyncActionChangePrimaryAssetBundles_methods {
        internal struct AsyncChangeBundleStateForMatchingPrimaryAssets_method {
            static internal IntPtr AsyncChangeBundleStateForMatchingPrimaryAssets_ptr;
            static AsyncChangeBundleStateForMatchingPrimaryAssets_method() {
                AsyncChangeBundleStateForMatchingPrimaryAssets_ptr = Main.GetMethodUFunction(AsyncActionChangePrimaryAssetBundles.StaticClass, "AsyncChangeBundleStateForMatchingPrimaryAssets");
            }

            internal static unsafe AsyncActionChangePrimaryAssetBundles Invoke(UObject WorldContextObject, byte NewBundles /*TODO: array TArray */, byte OldBundles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: array TArray NewBundles
                throw new NotImplementedException(); //TODO: array TArray OldBundles
                Main.GetProcessEvent(AsyncActionChangePrimaryAssetBundles.DefaultObject, AsyncChangeBundleStateForMatchingPrimaryAssets_ptr, new IntPtr(p)); ;
                 //TODO: array TArray NewBundles
                 //TODO: array TArray OldBundles
                return *((IntPtr*)(b+40));
            }
        }
        internal struct AsyncChangeBundleStateForPrimaryAssetList_method {
            static internal IntPtr AsyncChangeBundleStateForPrimaryAssetList_ptr;
            static AsyncChangeBundleStateForPrimaryAssetList_method() {
                AsyncChangeBundleStateForPrimaryAssetList_ptr = Main.GetMethodUFunction(AsyncActionChangePrimaryAssetBundles.StaticClass, "AsyncChangeBundleStateForPrimaryAssetList");
            }

            internal static unsafe AsyncActionChangePrimaryAssetBundles Invoke(UObject WorldContextObject, byte PrimaryAssetList /*TODO: array TArray */, byte AddBundles /*TODO: array TArray */, byte RemoveBundles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: array TArray PrimaryAssetList
                throw new NotImplementedException(); //TODO: array TArray AddBundles
                throw new NotImplementedException(); //TODO: array TArray RemoveBundles
                Main.GetProcessEvent(AsyncActionChangePrimaryAssetBundles.DefaultObject, AsyncChangeBundleStateForPrimaryAssetList_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PrimaryAssetList
                 //TODO: array TArray AddBundles
                 //TODO: array TArray RemoveBundles
                return *((IntPtr*)(b+56));
            }
        }
    }
    internal unsafe struct AsyncActionChangePrimaryAssetBundles_events {
    }
}
