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
    [StructLayout( LayoutKind.Explicit, Size=1648 )]
    internal unsafe struct BillboardComponent_fields {
        [FieldOffset(1520)]  public IntPtr  Sprite;
        [FieldOffset(1528)] public bool bIsScreenSizeScaled;
        [FieldOffset(1532)] public float ScreenSize;
        [FieldOffset(1536)] public float U;
        [FieldOffset(1540)] public float UL;
        [FieldOffset(1544)] public float V;
        [FieldOffset(1548)] public float VL;
        [FieldOffset(1568)] public SpriteCategoryInfo SpriteInfo;
        [FieldOffset(1632)] public bool bUseInEditorScaling;
    }
    internal unsafe struct BillboardComponent_methods {
        internal struct SetSprite_method {
            static internal IntPtr SetSprite_ptr;
            static SetSprite_method() {
                SetSprite_ptr = Main.GetMethodUFunction(BillboardComponent.StaticClass, "SetSprite");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture2D NewSprite) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewSprite;
                Main.GetProcessEvent(obj, SetSprite_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSpriteAndUV_method {
            static internal IntPtr SetSpriteAndUV_ptr;
            static SetSpriteAndUV_method() {
                SetSpriteAndUV_ptr = Main.GetMethodUFunction(BillboardComponent.StaticClass, "SetSpriteAndUV");
            }

            internal static unsafe void Invoke(IntPtr obj, Texture2D NewSprite, int NewU, int NewUL, int NewV, int NewVL) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewSprite;
                *((int*)(b+8)) = NewU;
                *((int*)(b+12)) = NewUL;
                *((int*)(b+16)) = NewV;
                *((int*)(b+20)) = NewVL;
                Main.GetProcessEvent(obj, SetSpriteAndUV_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUV_method {
            static internal IntPtr SetUV_ptr;
            static SetUV_method() {
                SetUV_ptr = Main.GetMethodUFunction(BillboardComponent.StaticClass, "SetUV");
            }

            internal static unsafe void Invoke(IntPtr obj, int NewU, int NewUL, int NewV, int NewVL) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NewU;
                *((int*)(b+4)) = NewUL;
                *((int*)(b+8)) = NewV;
                *((int*)(b+12)) = NewVL;
                Main.GetProcessEvent(obj, SetUV_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct BillboardComponent_events {
    }
}
