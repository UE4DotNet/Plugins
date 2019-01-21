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
    internal unsafe struct SizeBox_fields {
        [FieldOffset(424)] public bool bOverride_WidthOverride;
        [FieldOffset(424)] public bool bOverride_HeightOverride;
        [FieldOffset(424)] public bool bOverride_MinDesiredWidth;
        [FieldOffset(424)] public bool bOverride_MinDesiredHeight;
        [FieldOffset(424)] public bool bOverride_MaxDesiredWidth;
        [FieldOffset(424)] public bool bOverride_MaxDesiredHeight;
        [FieldOffset(424)] public bool bOverride_MaxAspectRatio;
        [FieldOffset(428)] public float WidthOverride;
        [FieldOffset(432)] public float HeightOverride;
        [FieldOffset(436)] public float MinDesiredWidth;
        [FieldOffset(440)] public float MinDesiredHeight;
        [FieldOffset(444)] public float MaxDesiredWidth;
        [FieldOffset(448)] public float MaxDesiredHeight;
        [FieldOffset(452)] public float MaxAspectRatio;
    }
    internal unsafe struct SizeBox_methods {
        internal struct ClearHeightOverride_method {
            static internal IntPtr ClearHeightOverride_ptr;
            static ClearHeightOverride_method() {
                ClearHeightOverride_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "ClearHeightOverride");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearHeightOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMaxAspectRatio_method {
            static internal IntPtr ClearMaxAspectRatio_ptr;
            static ClearMaxAspectRatio_method() {
                ClearMaxAspectRatio_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "ClearMaxAspectRatio");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMaxAspectRatio_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMaxDesiredHeight_method {
            static internal IntPtr ClearMaxDesiredHeight_ptr;
            static ClearMaxDesiredHeight_method() {
                ClearMaxDesiredHeight_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "ClearMaxDesiredHeight");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMaxDesiredHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMaxDesiredWidth_method {
            static internal IntPtr ClearMaxDesiredWidth_ptr;
            static ClearMaxDesiredWidth_method() {
                ClearMaxDesiredWidth_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "ClearMaxDesiredWidth");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMaxDesiredWidth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMinDesiredHeight_method {
            static internal IntPtr ClearMinDesiredHeight_ptr;
            static ClearMinDesiredHeight_method() {
                ClearMinDesiredHeight_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "ClearMinDesiredHeight");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMinDesiredHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearMinDesiredWidth_method {
            static internal IntPtr ClearMinDesiredWidth_ptr;
            static ClearMinDesiredWidth_method() {
                ClearMinDesiredWidth_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "ClearMinDesiredWidth");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearMinDesiredWidth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearWidthOverride_method {
            static internal IntPtr ClearWidthOverride_ptr;
            static ClearWidthOverride_method() {
                ClearWidthOverride_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "ClearWidthOverride");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ClearWidthOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetHeightOverride_method {
            static internal IntPtr SetHeightOverride_ptr;
            static SetHeightOverride_method() {
                SetHeightOverride_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "SetHeightOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, float InHeightOverride) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InHeightOverride;
                Main.GetProcessEvent(obj, SetHeightOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaxAspectRatio_method {
            static internal IntPtr SetMaxAspectRatio_ptr;
            static SetMaxAspectRatio_method() {
                SetMaxAspectRatio_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "SetMaxAspectRatio");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMaxAspectRatio) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMaxAspectRatio;
                Main.GetProcessEvent(obj, SetMaxAspectRatio_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaxDesiredHeight_method {
            static internal IntPtr SetMaxDesiredHeight_ptr;
            static SetMaxDesiredHeight_method() {
                SetMaxDesiredHeight_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "SetMaxDesiredHeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMaxDesiredHeight) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMaxDesiredHeight;
                Main.GetProcessEvent(obj, SetMaxDesiredHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMaxDesiredWidth_method {
            static internal IntPtr SetMaxDesiredWidth_ptr;
            static SetMaxDesiredWidth_method() {
                SetMaxDesiredWidth_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "SetMaxDesiredWidth");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMaxDesiredWidth) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMaxDesiredWidth;
                Main.GetProcessEvent(obj, SetMaxDesiredWidth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinDesiredHeight_method {
            static internal IntPtr SetMinDesiredHeight_ptr;
            static SetMinDesiredHeight_method() {
                SetMinDesiredHeight_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "SetMinDesiredHeight");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMinDesiredHeight) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMinDesiredHeight;
                Main.GetProcessEvent(obj, SetMinDesiredHeight_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinDesiredWidth_method {
            static internal IntPtr SetMinDesiredWidth_ptr;
            static SetMinDesiredWidth_method() {
                SetMinDesiredWidth_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "SetMinDesiredWidth");
            }

            internal static unsafe void Invoke(IntPtr obj, float InMinDesiredWidth) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InMinDesiredWidth;
                Main.GetProcessEvent(obj, SetMinDesiredWidth_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetWidthOverride_method {
            static internal IntPtr SetWidthOverride_ptr;
            static SetWidthOverride_method() {
                SetWidthOverride_ptr = Main.GetMethodUFunction(SizeBox.StaticClass, "SetWidthOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, float InWidthOverride) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = InWidthOverride;
                Main.GetProcessEvent(obj, SetWidthOverride_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SizeBox_events {
    }
}
