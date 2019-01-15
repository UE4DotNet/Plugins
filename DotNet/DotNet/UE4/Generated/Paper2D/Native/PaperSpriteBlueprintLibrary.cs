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

namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct PaperSpriteBlueprintLibrary_fields {
    }
    internal unsafe struct PaperSpriteBlueprintLibrary_methods {
        internal struct MakeBrushFromSprite_method {
            static internal IntPtr MakeBrushFromSprite_ptr;
            static MakeBrushFromSprite_method() {
                MakeBrushFromSprite_ptr = Main.GetMethodUFunction(PaperSpriteBlueprintLibrary.StaticClass, "MakeBrushFromSprite");
            }

            internal static unsafe SlateBrush Invoke(PaperSprite Sprite, int Width, int Height) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = Sprite;
                *((int*)(b+8)) = Width;
                *((int*)(b+12)) = Height;
                Main.GetProcessEvent(PaperSpriteBlueprintLibrary.DefaultObject, MakeBrushFromSprite_ptr, new IntPtr(p)); ;
                return *((SlateBrush*)(b+16));
            }
        }
    }
    internal unsafe struct PaperSpriteBlueprintLibrary_events {
    }
}
