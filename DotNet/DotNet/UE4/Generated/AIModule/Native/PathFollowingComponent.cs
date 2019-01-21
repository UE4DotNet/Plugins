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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=704 )]
    internal unsafe struct PathFollowingComponent_fields {
        [FieldOffset(336)]  public IntPtr  MovementComp;
        [FieldOffset(352)]  public IntPtr  MyNavData;
    }
    internal unsafe struct PathFollowingComponent_methods {
        internal struct GetPathActionType_method {
            static internal IntPtr GetPathActionType_ptr;
            static GetPathActionType_method() {
                GetPathActionType_ptr = Main.GetMethodUFunction(PathFollowingComponent.StaticClass, "GetPathActionType");
            }

            internal static unsafe byte Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPathActionType_ptr, new IntPtr(p)); ;
                return *(b+0);
            }
        }
        internal struct GetPathDestination_method {
            static internal IntPtr GetPathDestination_ptr;
            static GetPathDestination_method() {
                GetPathDestination_ptr = Main.GetMethodUFunction(PathFollowingComponent.StaticClass, "GetPathDestination");
            }

            internal static unsafe Vector Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPathDestination_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+0));
            }
        }
    }
    internal unsafe struct PathFollowingComponent_events {
    }
}
