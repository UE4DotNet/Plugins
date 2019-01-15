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


namespace UE4.FunctionalTesting.Native {
    [StructLayout( LayoutKind.Explicit, Size=2752 )]
    internal unsafe struct TraceQueryTestResults_fields {
        [FieldOffset(56)] public TraceQueryTestResultsInner ChannelResults;
        [FieldOffset(952)] public TraceQueryTestResultsInner ObjectResults;
        [FieldOffset(1848)] public TraceQueryTestResultsInner ProfileResults;
    }
    internal unsafe struct TraceQueryTestResults_methods {
        internal struct ToString_method {
            static internal IntPtr ToString_ptr;
            static ToString_method() {
                ToString_ptr = Main.GetMethodUFunction(TraceQueryTestResults.StaticClass, "ToString");
            }

            internal static unsafe string Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ToString_ptr, new IntPtr(p)); ;
                return FString.Get(b+0);
            }
        }
    }
    internal unsafe struct TraceQueryTestResults_events {
    }
}
