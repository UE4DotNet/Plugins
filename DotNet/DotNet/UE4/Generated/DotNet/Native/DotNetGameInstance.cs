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

namespace UE4.DotNet.Native {
    [StructLayout( LayoutKind.Explicit, Size=232 )]
    internal unsafe struct DotNetGameInstance_fields {
        [FieldOffset(176)] public NativeArray AxisBindings;
        [FieldOffset(192)] public NativeArray ActionBindings;
        [FieldOffset(208)] public NativeArray ObjectsSharedWithDotNet;
        [FieldOffset(224)] public int FirstFreeShared;
    }
    internal unsafe struct DotNetGameInstance_methods {
    }
    internal unsafe struct DotNetGameInstance_events {
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct SetGameModeBase_event {
            private static DelegateHolder<NativeFuncDelegate> SetGameModeBase_link;
            private static unsafe void SetGameModeBase_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<DotNetGameInstance>(context);
                var b = (byte*) theStack->Locals;

                obj.on_SetGameModeBase(UObject.Make<GameModeBase>(*(IntPtr*)(b+0)), FString.Get(b+8));
            }
            internal static void Setup() {
                SetGameModeBase_link = new DelegateHolder<NativeFuncDelegate>(SetGameModeBase_process_event);
                var uf = Main.GetUFunction("SetGameModeBase");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(SetGameModeBase_link.Delegate));
            }
        }
    }
}
