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
    [StructLayout( LayoutKind.Explicit, Size=400 )]
    internal unsafe struct AnimSequenceBase_fields {
        [FieldOffset(240)] public NativeArray Notifies;
        [FieldOffset(256)] public float SequenceLength;
        [FieldOffset(260)] public float RateScale;
        [FieldOffset(264)] public RawCurveTracks RawCurveData;
        [FieldOffset(312)] public NativeArray AnimNotifyTracks;
    }
    internal unsafe struct AnimSequenceBase_methods {
        internal struct GetPlayLength_method {
            static internal IntPtr GetPlayLength_ptr;
            static GetPlayLength_method() {
                GetPlayLength_ptr = Main.GetMethodUFunction(AnimSequenceBase.StaticClass, "GetPlayLength");
            }

            internal static unsafe float Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetPlayLength_ptr, new IntPtr(p)); ;
                return *((float*)(b+0));
            }
        }
    }
    internal unsafe struct AnimSequenceBase_events {
    }
}
