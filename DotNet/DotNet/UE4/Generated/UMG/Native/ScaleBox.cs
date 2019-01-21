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
    [StructLayout( LayoutKind.Explicit, Size=472 )]
    internal unsafe struct ScaleBox_fields {
        [FieldOffset(424)] public byte Stretch;
        [FieldOffset(425)] public byte StretchDirection;
        [FieldOffset(428)] public float UserSpecifiedScale;
        [FieldOffset(432)] public bool IgnoreInheritedScale;
        [FieldOffset(433)] public bool bSingleLayoutPass;
    }
    internal unsafe struct ScaleBox_methods {
        internal struct SetIgnoreInheritedScale_method {
            static internal IntPtr SetIgnoreInheritedScale_ptr;
            static SetIgnoreInheritedScale_method() {
                SetIgnoreInheritedScale_ptr = Main.GetMethodUFunction(ScaleBox.StaticClass, "SetIgnoreInheritedScale");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bInIgnoreInheritedScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bInIgnoreInheritedScale;
                Main.GetProcessEvent(obj, SetIgnoreInheritedScale_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStretch_method {
            static internal IntPtr SetStretch_ptr;
            static SetStretch_method() {
                SetStretch_ptr = Main.GetMethodUFunction(ScaleBox.StaticClass, "SetStretch");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InStretch) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InStretch;
                Main.GetProcessEvent(obj, SetStretch_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetStretchDirection_method {
            static internal IntPtr SetStretchDirection_ptr;
            static SetStretchDirection_method() {
                SetStretchDirection_ptr = Main.GetMethodUFunction(ScaleBox.StaticClass, "SetStretchDirection");
            }

            internal static unsafe void Invoke(IntPtr obj, byte InStretchDirection) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = InStretchDirection;
                Main.GetProcessEvent(obj, SetStretchDirection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetUserSpecifiedScale_method {
            static internal IntPtr SetUserSpecifiedScale_ptr;
            static SetUserSpecifiedScale_method() {
                SetUserSpecifiedScale_ptr = Main.GetMethodUFunction(ScaleBox.StaticClass, "SetUserSpecifiedScale");
            }

            internal static unsafe void Invoke(IntPtr obj, float InUserSpecifiedScale) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InUserSpecifiedScale;
                Main.GetProcessEvent(obj, SetUserSpecifiedScale_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ScaleBox_events {
    }
}
