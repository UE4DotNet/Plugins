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


namespace UE4.NavigationSystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=1088 )]
    internal unsafe struct NavModifierVolume_fields {
        [FieldOffset(1080)] public IntPtr AreaClass;
    }
    internal unsafe struct NavModifierVolume_methods {
        internal struct SetAreaClass_method {
            static internal IntPtr SetAreaClass_ptr;
            static SetAreaClass_method() {
                SetAreaClass_ptr = Main.GetMethodUFunction(NavModifierVolume.StaticClass, "SetAreaClass");
            }

            internal static unsafe void Invoke(IntPtr obj, SubclassOf<NavArea> NewAreaClass) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewAreaClass;
                Main.GetProcessEvent(obj, SetAreaClass_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct NavModifierVolume_events {
    }
}
