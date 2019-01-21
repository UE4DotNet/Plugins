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

namespace UE4.MovieSceneCapture.Native {
    [StructLayout( LayoutKind.Explicit, Size=248 )]
    internal unsafe struct UserDefinedCaptureProtocol_fields {
        [FieldOffset(104)]  public IntPtr  World;
    }
    internal unsafe struct UserDefinedCaptureProtocol_methods {
        internal struct BindToStream_method {
            static internal IntPtr BindToStream_ptr;
            static BindToStream_method() {
                BindToStream_ptr = Main.GetMethodUFunction(UserDefinedCaptureProtocol.StaticClass, "BindToStream");
            }

            internal static unsafe void Invoke(IntPtr obj, Name StreamName, byte Handler /*TODO: delegate FOnReceiveCapturedPixels */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = StreamName;
                throw new NotImplementedException(); //TODO: delegate FOnReceiveCapturedPixels Handler
                Main.GetProcessEvent(obj, BindToStream_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnReceiveCapturedPixels Handler
            }
        }
        internal struct GenerateFilename_method {
            static internal IntPtr GenerateFilename_ptr;
            static GenerateFilename_method() {
                GenerateFilename_ptr = Main.GetMethodUFunction(UserDefinedCaptureProtocol.StaticClass, "GenerateFilename");
            }

            internal static unsafe string Invoke(IntPtr obj, FrameMetrics InFrameMetrics) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((FrameMetrics*)(b+0)) = InFrameMetrics;
                Main.GetProcessEvent(obj, GenerateFilename_ptr, new IntPtr(p)); ;
                return FString.Get(b+16);
            }
        }
        internal struct GetCurrentFrameMetrics_method {
            static internal IntPtr GetCurrentFrameMetrics_ptr;
            static GetCurrentFrameMetrics_method() {
                GetCurrentFrameMetrics_ptr = Main.GetMethodUFunction(UserDefinedCaptureProtocol.StaticClass, "GetCurrentFrameMetrics");
            }

            internal static unsafe FrameMetrics Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetCurrentFrameMetrics_ptr, new IntPtr(p)); ;
                return *((FrameMetrics*)(b+0));
            }
        }
        internal struct PushBufferToStream_method {
            static internal IntPtr PushBufferToStream_ptr;
            static PushBufferToStream_method() {
                PushBufferToStream_ptr = Main.GetMethodUFunction(UserDefinedCaptureProtocol.StaticClass, "PushBufferToStream");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture Buffer, Name StreamName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Buffer;
                *((Name*)(b+8)) = StreamName;
                Main.GetProcessEvent(obj, PushBufferToStream_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ResolveBuffer_method {
            static internal IntPtr ResolveBuffer_ptr;
            static ResolveBuffer_method() {
                ResolveBuffer_ptr = Main.GetMethodUFunction(UserDefinedCaptureProtocol.StaticClass, "ResolveBuffer");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture Buffer, Name BufferName, byte Handler /*TODO: delegate FOnReceiveCapturedPixels */) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Buffer;
                *((Name*)(b+8)) = BufferName;
                throw new NotImplementedException(); //TODO: delegate FOnReceiveCapturedPixels Handler
                Main.GetProcessEvent(obj, ResolveBuffer_ptr, new IntPtr(p)); ;
                 //TODO: delegate FOnReceiveCapturedPixels Handler
            }
        }
        internal struct StartCapturingFinalPixels_method {
            static internal IntPtr StartCapturingFinalPixels_ptr;
            static StartCapturingFinalPixels_method() {
                StartCapturingFinalPixels_ptr = Main.GetMethodUFunction(UserDefinedCaptureProtocol.StaticClass, "StartCapturingFinalPixels");
            }

            internal static unsafe void Invoke(IntPtr obj, Name StreamName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = StreamName;
                Main.GetProcessEvent(obj, StartCapturingFinalPixels_ptr, new IntPtr(p)); ;
            }
        }
        internal struct StopCapturingFinalPixels_method {
            static internal IntPtr StopCapturingFinalPixels_ptr;
            static StopCapturingFinalPixels_method() {
                StopCapturingFinalPixels_ptr = Main.GetMethodUFunction(UserDefinedCaptureProtocol.StaticClass, "StopCapturingFinalPixels");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, StopCapturingFinalPixels_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct UserDefinedCaptureProtocol_events {
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnBeginFinalize_event {
            private static DelegateHolder<NativeFuncDelegate> OnBeginFinalize_link;
            private static unsafe void OnBeginFinalize_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnBeginFinalize();
            }
            internal static void Setup() {
                OnBeginFinalize_link = new DelegateHolder<NativeFuncDelegate>(OnBeginFinalize_process_event);
                var uf = Main.GetUFunction("OnBeginFinalize");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnBeginFinalize_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnCaptureFrame_event {
            private static DelegateHolder<NativeFuncDelegate> OnCaptureFrame_link;
            private static unsafe void OnCaptureFrame_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnCaptureFrame();
            }
            internal static void Setup() {
                OnCaptureFrame_link = new DelegateHolder<NativeFuncDelegate>(OnCaptureFrame_process_event);
                var uf = Main.GetUFunction("OnCaptureFrame");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnCaptureFrame_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnFinalize_event {
            private static DelegateHolder<NativeFuncDelegate> OnFinalize_link;
            private static unsafe void OnFinalize_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnFinalize();
            }
            internal static void Setup() {
                OnFinalize_link = new DelegateHolder<NativeFuncDelegate>(OnFinalize_process_event);
                var uf = Main.GetUFunction("OnFinalize");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnFinalize_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnPauseCapture_event {
            private static DelegateHolder<NativeFuncDelegate> OnPauseCapture_link;
            private static unsafe void OnPauseCapture_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnPauseCapture();
            }
            internal static void Setup() {
                OnPauseCapture_link = new DelegateHolder<NativeFuncDelegate>(OnPauseCapture_process_event);
                var uf = Main.GetUFunction("OnPauseCapture");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPauseCapture_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnPreTick_event {
            private static DelegateHolder<NativeFuncDelegate> OnPreTick_link;
            private static unsafe void OnPreTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnPreTick();
            }
            internal static void Setup() {
                OnPreTick_link = new DelegateHolder<NativeFuncDelegate>(OnPreTick_process_event);
                var uf = Main.GetUFunction("OnPreTick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnPreTick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnStartCapture_event {
            private static DelegateHolder<NativeFuncDelegate> OnStartCapture_link;
            private static unsafe void OnStartCapture_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnStartCapture();
            }
            internal static void Setup() {
                OnStartCapture_link = new DelegateHolder<NativeFuncDelegate>(OnStartCapture_process_event);
                var uf = Main.GetUFunction("OnStartCapture");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnStartCapture_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnTick_event {
            private static DelegateHolder<NativeFuncDelegate> OnTick_link;
            private static unsafe void OnTick_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnTick();
            }
            internal static void Setup() {
                OnTick_link = new DelegateHolder<NativeFuncDelegate>(OnTick_process_event);
                var uf = Main.GetUFunction("OnTick");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnTick_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=0 )]
        internal unsafe struct OnWarmUp_event {
            private static DelegateHolder<NativeFuncDelegate> OnWarmUp_link;
            private static unsafe void OnWarmUp_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;

                obj.on_OnWarmUp();
            }
            internal static void Setup() {
                OnWarmUp_link = new DelegateHolder<NativeFuncDelegate>(OnWarmUp_process_event);
                var uf = Main.GetUFunction("OnWarmUp");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnWarmUp_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct OnCanFinalize_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnCanFinalize_link;
            private static unsafe void OnCanFinalize_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_OnCanFinalize(*(bool*)result);
            }
            internal static void Setup() {
                OnCanFinalize_link = new DelegateHolder<NativeFuncDelegate>(OnCanFinalize_process_event);
                var uf = Main.GetUFunction("OnCanFinalize");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnCanFinalize_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=1 )]
        internal unsafe struct OnSetup_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> OnSetup_link;
            private static unsafe void OnSetup_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<UserDefinedCaptureProtocol>(context);
                var b = (byte*) theStack->Locals;
                *(bool*)result.ToPointer() = obj.on_OnSetup(*(bool*)result);
            }
            internal static void Setup() {
                OnSetup_link = new DelegateHolder<NativeFuncDelegate>(OnSetup_process_event);
                var uf = Main.GetUFunction("OnSetup");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(OnSetup_link.Delegate));
            }
        }
    }
}
