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

using UE4.SlateCore;

namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct DragDropOperation_fields {
        [FieldOffset(56)] byte Tag; //TODO: string FString Tag
        [FieldOffset(72)]  public IntPtr  Payload;
        [FieldOffset(80)]  public IntPtr  DefaultDragVisual;
        [FieldOffset(88)] byte Pivot; //TODO: enum EDragPivot Pivot
        [FieldOffset(92)] public Vector2D Offset;
        [FieldOffset(104)] byte OnDrop; //TODO: multicast delegate FOnDragDropMulticast OnDrop
        [FieldOffset(120)] byte OnDragCancelled; //TODO: multicast delegate FOnDragDropMulticast OnDragCancelled
        [FieldOffset(136)] byte OnDragged; //TODO: multicast delegate FOnDragDropMulticast OnDragged
    }
    internal unsafe struct DragDropOperation_methods {
    }
    internal unsafe struct DragDropOperation_events {
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        internal unsafe struct DragCancelled_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> DragCancelled_link;
            private static unsafe void DragCancelled_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<DragDropOperation>(context);
                var b = (byte*) theStack->Locals;
                obj.on_DragCancelled(*(PointerEvent*)(b+0));
            }
            internal static void Setup() {
                DragCancelled_link = new DelegateHolder<NativeFuncDelegate>(DragCancelled_process_event);
                var uf = Main.GetUFunction("DragCancelled");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(DragCancelled_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        internal unsafe struct Dragged_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> Dragged_link;
            private static unsafe void Dragged_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<DragDropOperation>(context);
                var b = (byte*) theStack->Locals;
                obj.on_Dragged(*(PointerEvent*)(b+0));
            }
            internal static void Setup() {
                Dragged_link = new DelegateHolder<NativeFuncDelegate>(Dragged_process_event);
                var uf = Main.GetUFunction("Dragged");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Dragged_link.Delegate));
            }
        }
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        internal unsafe struct Drop_event {
            private static FNativeFuncPtr NativeFunction;
            private static DelegateHolder<NativeFuncDelegate> Drop_link;
            private static unsafe void Drop_process_event(IntPtr context, Frame* theStack, IntPtr result) {
                NativeFunction(context, theStack,result);
                var obj = UObject.Make<DragDropOperation>(context);
                var b = (byte*) theStack->Locals;
                obj.on_Drop(*(PointerEvent*)(b+0));
            }
            internal static void Setup() {
                Drop_link = new DelegateHolder<NativeFuncDelegate>(Drop_process_event);
                var uf = Main.GetUFunction("Drop");
                var func = UObject.Make<Function>(uf);
                NativeFunction = Marshal.GetDelegateForFunctionPointer<FNativeFuncPtr>( func.GetNativeFunc() );
                func.SetNativeFunc(Marshal.GetFunctionPointerForDelegate(Drop_link.Delegate));
            }
        }
    }
}
