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


namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=1584 )]
    internal unsafe struct PaperSpriteComponent_fields {
        [FieldOffset(1544)]  public IntPtr  SourceSprite;
        [FieldOffset(1560)] public LinearColor SpriteColor;
    }
    internal unsafe struct PaperSpriteComponent_methods {
        internal struct GetSprite_method {
            static internal IntPtr GetSprite_ptr;
            static GetSprite_method() {
                GetSprite_ptr = Main.GetMethodUFunction(PaperSpriteComponent.StaticClass, "GetSprite");
            }

            internal static unsafe PaperSprite Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetSprite_ptr, new IntPtr(p)); ;
                return *((IntPtr*)(b+0));
            }
        }
        internal struct SetSprite_method {
            static internal IntPtr SetSprite_ptr;
            static SetSprite_method() {
                SetSprite_ptr = Main.GetMethodUFunction(PaperSpriteComponent.StaticClass, "SetSprite");
            }

            internal static unsafe bool Invoke(IntPtr obj, PaperSprite NewSprite) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewSprite;
                Main.GetProcessEvent(obj, SetSprite_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetSpriteColor_method {
            static internal IntPtr SetSpriteColor_ptr;
            static SetSpriteColor_method() {
                SetSpriteColor_ptr = Main.GetMethodUFunction(PaperSpriteComponent.StaticClass, "SetSpriteColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewColor;
                Main.GetProcessEvent(obj, SetSpriteColor_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PaperSpriteComponent_events {
    }
}
