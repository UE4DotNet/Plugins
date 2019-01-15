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

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=64 )]
    internal unsafe struct EnvQueryContext_BlueprintBase_fields {
    }
    internal unsafe struct EnvQueryContext_BlueprintBase_methods {
    }
    internal unsafe struct EnvQueryContext_BlueprintBase_events {
        //TODO: event_native: event with array parameterProvideActorsSet
        //TODO: event_native: event with array parameterProvideLocationsSet
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        internal unsafe struct ProvideSingleActor_event {
            private static DelegateHolder<NativeFuncDelegate> ProvideSingleActor_link;
            private static unsafe void ProvideSingleActor_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<EnvQueryContext_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ProvideSingleActor(UObject.Make<UObject>(*(IntPtr*)(b+0)), UObject.Make<Actor>(*(IntPtr*)(b+8)), UObject.Make<Actor>(*(IntPtr*)(b+16)));
            }
            internal static void Setup() {
                ProvideSingleActor_link = new DelegateHolder<NativeFuncDelegate>(ProvideSingleActor_process_event);
                var uf = Main.GetUFunction("ProvideSingleActor");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ProvideSingleActor_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        internal unsafe struct ProvideSingleLocation_event {
            private static DelegateHolder<NativeFuncDelegate> ProvideSingleLocation_link;
            private static unsafe void ProvideSingleLocation_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<EnvQueryContext_BlueprintBase>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ProvideSingleLocation(UObject.Make<UObject>(*(IntPtr*)(b+0)), UObject.Make<Actor>(*(IntPtr*)(b+8)), *(Vector*)(b+16));
            }
            internal static void Setup() {
                ProvideSingleLocation_link = new DelegateHolder<NativeFuncDelegate>(ProvideSingleLocation_process_event);
                var uf = Main.GetUFunction("ProvideSingleLocation");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ProvideSingleLocation_link.Delegate));
            }
        }
    }
}
