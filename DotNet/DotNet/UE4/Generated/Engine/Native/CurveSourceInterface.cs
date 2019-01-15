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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct CurveSourceInterface_fields {
    }
    internal unsafe struct CurveSourceInterface_methods {
    }
    internal unsafe struct CurveSourceInterface_events {
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        internal unsafe struct GetBindingName_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> GetBindingName_link;
            private static unsafe void GetBindingName_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<CurveSourceInterface>(context);
                var b = (byte*) theStack->Locals;
                *(Name*)result.ToPointer() = obj.on_GetBindingName(*(Name*)result);
            }
            internal static void Setup() {
                GetBindingName_link = new DelegateHolder<NativeFuncDelegate>(GetBindingName_process_event);
                var uf = Main.GetUFunction("GetBindingName");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(GetBindingName_link.Delegate));
            }
        }
        //TODO: event_native_blueprint: event with array parameter GetCurves
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct GetCurveValue_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> GetCurveValue_link;
            private static unsafe void GetCurveValue_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<CurveSourceInterface>(context);
                var b = (byte*) theStack->Locals;
                *(float*)result.ToPointer() = obj.on_GetCurveValue(*(Name*)(b+0), *(float*)result);
            }
            internal static void Setup() {
                GetCurveValue_link = new DelegateHolder<NativeFuncDelegate>(GetCurveValue_process_event);
                var uf = Main.GetUFunction("GetCurveValue");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(GetCurveValue_link.Delegate));
            }
        }
    }
}
