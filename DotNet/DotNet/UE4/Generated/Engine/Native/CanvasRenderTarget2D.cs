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
    [StructLayout( LayoutKind.Explicit, Size=608 )]
    internal unsafe struct CanvasRenderTarget2D_fields {
        [FieldOffset(568)] byte OnCanvasRenderTargetUpdate; //TODO: multicast delegate FOnCanvasRenderTargetUpdate OnCanvasRenderTargetUpdate
        [FieldOffset(584)] byte World; //TODO: weak object TWeakObjectPtr<UWorld> World
        [FieldOffset(592)] public bool bShouldClearRenderTargetOnReceiveUpdate;
    }
    internal unsafe struct CanvasRenderTarget2D_methods {
        internal struct CreateCanvasRenderTarget2D_method {
            static internal IntPtr CreateCanvasRenderTarget2D_ptr;
            static CreateCanvasRenderTarget2D_method() {
                CreateCanvasRenderTarget2D_ptr = Main.GetMethodUFunction(CanvasRenderTarget2D.StaticClass, "CreateCanvasRenderTarget2D");
            }

            internal static unsafe CanvasRenderTarget2D Invoke(UObject WorldContextObject, SubclassOf<CanvasRenderTarget2D> CanvasRenderTarget2DClass, int Width, int Height) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = CanvasRenderTarget2DClass;
                *((int*)(b+16)) = Width;
                *((int*)(b+20)) = Height;
                Main.GetProcessEvent(CanvasRenderTarget2D.DefaultObject, CreateCanvasRenderTarget2D_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+24));
            }
        }
        internal struct GetSize_method {
            static internal IntPtr GetSize_ptr;
            static GetSize_method() {
                GetSize_ptr = Main.GetMethodUFunction(CanvasRenderTarget2D.StaticClass, "GetSize");
            }

            internal static unsafe (int, int) Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSize_ptr, new IntPtr(p)); ;
                return (*((int*)(b+0)),*((int*)(b+4)));
            }
        }
        internal struct UpdateResource_method {
            static internal IntPtr UpdateResource_ptr;
            static UpdateResource_method() {
                UpdateResource_ptr = Main.GetMethodUFunction(CanvasRenderTarget2D.StaticClass, "UpdateResource");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, UpdateResource_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct CanvasRenderTarget2D_events {
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        internal unsafe struct ReceiveUpdate_event {
            private static DelegateHolder<NativeFuncDelegate> ReceiveUpdate_link;
            private static unsafe void ReceiveUpdate_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                var obj = UObject.Make<CanvasRenderTarget2D>(context);
                var b = (byte*) theStack->Locals;

                obj.on_ReceiveUpdate(UObject.Make<Canvas>(*(IntPtr*)(b+0)), *(int*)(b+8), *(int*)(b+12));
            }
            internal static void Setup() {
                ReceiveUpdate_link = new DelegateHolder<NativeFuncDelegate>(ReceiveUpdate_process_event);
                var uf = Main.GetUFunction("ReceiveUpdate");
                var func = UObject.Make<Function>(uf);
                func.SetFlags(func.GetFlags() | EFunctionFlags.FUNC_Native);
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(ReceiveUpdate_link.Delegate));
            }
        }
    }
}
