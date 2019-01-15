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
    [StructLayout( LayoutKind.Explicit, Size=1064 )]
    internal unsafe struct RichTextBlock_fields {
        [FieldOffset(416)] byte Text; //TODO: text FText Text
        [FieldOffset(440)]  public IntPtr  TextStyleSet;
        [FieldOffset(448)] public NativeArray DecoratorClasses;
        [FieldOffset(1032)] public NativeArray InstanceDecorators;
    }
    internal unsafe struct RichTextBlock_methods {
        internal struct GetDecoratorByClass_method {
            static internal IntPtr GetDecoratorByClass_ptr;
            static GetDecoratorByClass_method() {
                GetDecoratorByClass_ptr = Main.GetMethodUFunction(RichTextBlock.StaticClass, "GetDecoratorByClass");
            }

            internal static unsafe RichTextBlockDecorator Invoke(IntPtr obj, SubclassOf<RichTextBlockDecorator> DecoratorClass) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = DecoratorClass;
                Main.GetProcessEvent(obj, GetDecoratorByClass_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+8));
            }
        }
        internal struct SetText_method {
            static internal IntPtr SetText_ptr;
            static SetText_method() {
                SetText_ptr = Main.GetMethodUFunction(RichTextBlock.StaticClass, "SetText");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InText /*TODO: text FText */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                throw new NotImplementedException(); //TODO: text FText InText
                Main.GetProcessEvent(obj, SetText_ptr, new IntPtr(p)); ;
                 //TODO: text FText InText
            }
        }
    }
    internal unsafe struct RichTextBlock_events {
    }
}
