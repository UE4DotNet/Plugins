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


namespace UE4.SteamVRController.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct SteamVRControllerLibrary_fields {
    }
    internal unsafe struct SteamVRControllerLibrary_methods {
        internal struct SetTouchDPadMapping_method {
            static internal IntPtr SetTouchDPadMapping_ptr;
            static SetTouchDPadMapping_method() {
                SetTouchDPadMapping_ptr = Main.GetMethodUFunction(SteamVRControllerLibrary.StaticClass, "SetTouchDPadMapping");
            }

            internal static unsafe void Invoke(ESteamVRTouchDPadMapping NewMapping) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *(b+0) = (byte)NewMapping;
                Main.GetProcessEvent(SteamVRControllerLibrary.DefaultObject, SetTouchDPadMapping_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SteamVRControllerLibrary_events {
    }
}
