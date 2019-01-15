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


namespace UE4.LinearTimecode.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct DropTimecodeToStringConversion_fields {
    }
    internal unsafe struct DropTimecodeToStringConversion_methods {
        internal struct Conv_DropTimecodeToString_method {
            static internal IntPtr Conv_DropTimecodeToString_ptr;
            static Conv_DropTimecodeToString_method() {
                Conv_DropTimecodeToString_ptr = Main.GetMethodUFunction(DropTimecodeToStringConversion.StaticClass, "Conv_DropTimecodeToString");
            }

            internal static unsafe string Invoke(DropTimecode InTimecode) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((DropTimecode*)(b+0)) = InTimecode;
                Main.GetProcessEvent(DropTimecodeToStringConversion.DefaultObject, Conv_DropTimecodeToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+32);
            }
        }
    }
    internal unsafe struct DropTimecodeToStringConversion_events {
    }
}
