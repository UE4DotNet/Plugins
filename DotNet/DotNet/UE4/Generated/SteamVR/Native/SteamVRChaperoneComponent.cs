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


namespace UE4.SteamVR.Native {
    [StructLayout( LayoutKind.Explicit, Size=296 )]
    internal unsafe struct SteamVRChaperoneComponent_fields {
        [FieldOffset(256)] byte OnLeaveBounds; //TODO: multicast delegate FSteamVRChaperoneEvent OnLeaveBounds
        [FieldOffset(272)] byte OnReturnToBounds; //TODO: multicast delegate FSteamVRChaperoneEvent OnReturnToBounds
    }
    internal unsafe struct SteamVRChaperoneComponent_methods {
        internal struct GetBounds_method {
            static internal IntPtr GetBounds_ptr;
            static GetBounds_method() {
                GetBounds_ptr = Main.GetMethodUFunction(SteamVRChaperoneComponent.StaticClass, "GetBounds");
            }

            internal static unsafe IReadOnlyCollection<Vector> Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetBounds_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ReturnValue
                return UObject.ToUnmangedCollection<Vector>(b+0);
            }
        }
    }
    internal unsafe struct SteamVRChaperoneComponent_events {
    }
}
