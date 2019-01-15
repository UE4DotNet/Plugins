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
    [StructLayout( LayoutKind.Explicit, Size=656 )]
    internal unsafe struct Texture2D_fields {
        [FieldOffset(520)] public int StreamingIndex;
        [FieldOffset(524)] public int LevelIndex;
        [FieldOffset(528)] public int FirstResourceMemMip;
        [FieldOffset(532)] public bool bTemporarilyDisableStreaming;
        [FieldOffset(532)] public bool bIsStreamable;
        [FieldOffset(532)] public bool bHasStreamingUpdatePending;
        [FieldOffset(532)] public bool bForceMiplevelsToBeResident;
        [FieldOffset(532)] public bool bIgnoreStreamingMipBias;
        [FieldOffset(532)] public bool bGlobalForceMipLevelsToBeResident;
        [FieldOffset(532)] public bool bHasBeenPaintedInEditor;
        [FieldOffset(533)] public byte AddressX;
        [FieldOffset(534)] public byte AddressY;
        [FieldOffset(536)] public IntPoint ImportedSize;
        [FieldOffset(544)] public double ForceMipLevelsToBeResidentTimestamp;
    }
    internal unsafe struct Texture2D_methods {
        internal struct Blueprint_GetSizeX_method {
            static internal IntPtr Blueprint_GetSizeX_ptr;
            static Blueprint_GetSizeX_method() {
                Blueprint_GetSizeX_ptr = Main.GetMethodUFunction(Texture2D.StaticClass, "Blueprint_GetSizeX");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Blueprint_GetSizeX_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct Blueprint_GetSizeY_method {
            static internal IntPtr Blueprint_GetSizeY_ptr;
            static Blueprint_GetSizeY_method() {
                Blueprint_GetSizeY_ptr = Main.GetMethodUFunction(Texture2D.StaticClass, "Blueprint_GetSizeY");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, Blueprint_GetSizeY_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
    }
    internal unsafe struct Texture2D_events {
    }
}
