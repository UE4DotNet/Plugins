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
    [StructLayout( LayoutKind.Explicit, Size=304 )]
    internal unsafe struct NavRelevantComponent_fields {
        [FieldOffset(292)] public bool bAttachToOwnersRoot;
        [FieldOffset(296)]  public IntPtr  CachedNavParent;
    }
    internal unsafe struct NavRelevantComponent_methods {
        internal struct SetNavigationRelevancy_method {
            static internal IntPtr SetNavigationRelevancy_ptr;
            static SetNavigationRelevancy_method() {
                SetNavigationRelevancy_ptr = Main.GetMethodUFunction(NavRelevantComponent.StaticClass, "SetNavigationRelevancy");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bRelevant) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bRelevant;
                Main.GetProcessEvent(obj, SetNavigationRelevancy_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct NavRelevantComponent_events {
    }
}
