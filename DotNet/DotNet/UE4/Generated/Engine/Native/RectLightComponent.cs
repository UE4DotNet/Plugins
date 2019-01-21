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
    [StructLayout( LayoutKind.Explicit, Size=992 )]
    internal unsafe struct RectLightComponent_fields {
        [FieldOffset(976)] public float SourceWidth;
        [FieldOffset(980)] public float SourceHeight;
        [FieldOffset(984)]  public IntPtr  SourceTexture;
    }
    internal unsafe struct RectLightComponent_methods {
        internal struct SetSourceHeight_method {
            static internal IntPtr SetSourceHeight_ptr;
            static SetSourceHeight_method() {
                SetSourceHeight_ptr = Main.GetMethodUFunction(RectLightComponent.StaticClass, "SetSourceHeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetSourceHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSourceWidth_method {
            static internal IntPtr SetSourceWidth_ptr;
            static SetSourceWidth_method() {
                SetSourceWidth_ptr = Main.GetMethodUFunction(RectLightComponent.StaticClass, "SetSourceWidth");
            }

            internal static unsafe void Invoke(IntPtr obj, float bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetSourceWidth_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct RectLightComponent_events {
    }
}
