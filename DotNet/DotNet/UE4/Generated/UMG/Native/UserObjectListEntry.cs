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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct UserObjectListEntry_fields {
    }
    internal unsafe struct UserObjectListEntry_methods {
    }
    internal unsafe struct UserObjectListEntry_events {
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct OnListItemObjectSet_event {
            private static DelegateHolder<NativeFuncDelegate> OnListItemObjectSet_link;
            private static unsafe void OnListItemObjectSet_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserObjectListEntry>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnListItemObjectSet(UObject.Make<UObject>(*(IntPtr*)(b+0)));
            }
            internal static void Setup() {
                OnListItemObjectSet_link = new DelegateHolder<NativeFuncDelegate>(OnListItemObjectSet_process_event);
                var uf = Main.GetUFunction("OnListItemObjectSet");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnListItemObjectSet_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        internal unsafe struct GetListItemObject_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> GetListItemObject_link;
            private static unsafe void GetListItemObject_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<UserObjectListEntry>(context);
                var b = (byte*) theStack->Locals;
                *(IntPtr*)result.ToPointer() = obj.on_GetListItemObject(*(IntPtr*)result);
            }
            internal static void Setup() {
                GetListItemObject_link = new DelegateHolder<NativeFuncDelegate>(GetListItemObject_process_event);
                var uf = Main.GetUFunction("GetListItemObject");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(GetListItemObject_link.Delegate));
            }
        }
    }
}
