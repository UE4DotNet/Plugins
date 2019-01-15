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
    internal unsafe struct AsyncActionLoadPrimaryAssetClassList_fields {
        [FieldOffset(136)] byte Completed; //TODO: multicast delegate FOnPrimaryAssetClassListLoaded Completed
    }
    internal unsafe struct AsyncActionLoadPrimaryAssetClassList_methods {
        internal struct AsyncLoadPrimaryAssetClassList_method {
            static internal IntPtr AsyncLoadPrimaryAssetClassList_ptr;
            static AsyncLoadPrimaryAssetClassList_method() {
                AsyncLoadPrimaryAssetClassList_ptr = Main.GetMethodUFunction(AsyncActionLoadPrimaryAssetClassList.StaticClass, "AsyncLoadPrimaryAssetClassList");
            }

            internal static unsafe AsyncActionLoadPrimaryAssetClassList Invoke(UObject WorldContextObject, byte PrimaryAssetList /*TODO: array TArray */, byte LoadBundles /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                throw new NotImplementedException(); //TODO: array TArray PrimaryAssetList
                throw new NotImplementedException(); //TODO: array TArray LoadBundles
                Main.GetProcessEvent(AsyncActionLoadPrimaryAssetClassList.DefaultObject, AsyncLoadPrimaryAssetClassList_ptr, new IntPtr(p)); ;
                 //TODO: array TArray PrimaryAssetList
                 //TODO: array TArray LoadBundles
                return *((IntPtr*)(b+40));
            }
        }
    }
    internal unsafe struct AsyncActionLoadPrimaryAssetClassList_events {
    }
}
