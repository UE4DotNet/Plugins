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
    [StructLayout( LayoutKind.Explicit, Size=1616 )]
    internal unsafe struct ArrowComponent_fields {
        [FieldOffset(1504)] public Color ArrowColor;
        [FieldOffset(1508)] public float ArrowSize;
        [FieldOffset(1512)] public bool bIsScreenSizeScaled;
        [FieldOffset(1516)] public float ScreenSize;
        [FieldOffset(1520)] public bool bTreatAsASprite;
        [FieldOffset(1536)] public SpriteCategoryInfo SpriteInfo;
        [FieldOffset(1600)] public bool bLightAttachment;
        [FieldOffset(1604)] public bool bUseInEditorScaling;
    }
    internal unsafe struct ArrowComponent_methods {
        internal struct SetArrowColor_method {
            static internal IntPtr SetArrowColor_ptr;
            static SetArrowColor_method() {
                SetArrowColor_ptr = Main.GetMethodUFunction(ArrowComponent.StaticClass, "SetArrowColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewColor;
                Main.GetProcessEvent(obj, SetArrowColor_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ArrowComponent_events {
    }
}
