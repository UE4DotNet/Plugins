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
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct FunctionalTestUtilityLibrary_fields {
    }
    internal unsafe struct FunctionalTestUtilityLibrary_methods {
        internal struct TraceChannelTestUtil_method {
            static internal IntPtr TraceChannelTestUtil_ptr;
            static TraceChannelTestUtil_method() {
                TraceChannelTestUtil_ptr = Main.GetMethodUFunction(FunctionalTestUtilityLibrary.StaticClass, "TraceChannelTestUtil");
            }

            internal static unsafe TraceQueryTestResults Invoke(UObject WorldContextObject, TraceChannelTestBatchOptions BatchOptions, Vector Start, Vector End, float SphereCapsuleRadius, float CapsuleHalfHeight, Vector BoxHalfSize, Rotator Orientation, byte TraceChannel, byte ObjectTypes /*TODO: array TArray */, Name ProfileName, bool bTraceComplex, byte ActorsToIgnore /*TODO: array TArray */, bool bIgnoreSelf, byte DrawDebugType, LinearColor TraceColor, LinearColor TraceHitColor, float DrawTime) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((TraceChannelTestBatchOptions*)(b+8)) = BatchOptions;
                *((Vector*)(b+16)) = Start;
                *((Vector*)(b+28)) = End;
                *((float*)(b+40)) = SphereCapsuleRadius;
                *((float*)(b+44)) = CapsuleHalfHeight;
                *((Vector*)(b+48)) = BoxHalfSize;
                *((Rotator*)(b+60)) = Orientation;
                *(b+72) = TraceChannel;
                throw new NotImplementedException(); //TODO: array TArray ObjectTypes
                *((Name*)(b+96)) = ProfileName;
                *((bool*)(b+108)) = bTraceComplex;
                throw new NotImplementedException(); //TODO: array TArray ActorsToIgnore
                *((bool*)(b+128)) = bIgnoreSelf;
                *(b+129) = DrawDebugType;
                *((LinearColor*)(b+132)) = TraceColor;
                *((LinearColor*)(b+148)) = TraceHitColor;
                *((float*)(b+164)) = DrawTime;
                Main.GetProcessEvent(FunctionalTestUtilityLibrary.DefaultObject, TraceChannelTestUtil_ptr, new IntPtr(p)); ;
                 //TODO: array TArray ObjectTypes
                 //TODO: array TArray ActorsToIgnore
                return *((IntPtr*)(b+168));
            }
        }
    }
    internal unsafe struct FunctionalTestUtilityLibrary_events {
    }
}
