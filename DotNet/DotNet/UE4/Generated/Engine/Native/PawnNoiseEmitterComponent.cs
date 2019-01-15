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
    [StructLayout( LayoutKind.Explicit, Size=296 )]
    internal unsafe struct PawnNoiseEmitterComponent_fields {
        [FieldOffset(256)] public bool bAIPerceptionSystemCompatibilityMode;
        [FieldOffset(260)] public Vector LastRemoteNoisePosition;
        [FieldOffset(272)] public float NoiseLifetime;
        [FieldOffset(276)] public float LastRemoteNoiseVolume;
        [FieldOffset(280)] public float LastRemoteNoiseTime;
        [FieldOffset(284)] public float LastLocalNoiseVolume;
        [FieldOffset(288)] public float LastLocalNoiseTime;
    }
    internal unsafe struct PawnNoiseEmitterComponent_methods {
        internal struct MakeNoise_method {
            static internal IntPtr MakeNoise_ptr;
            static MakeNoise_method() {
                MakeNoise_ptr = Main.GetMethodUFunction(PawnNoiseEmitterComponent.StaticClass, "MakeNoise");
            }

            internal static unsafe void Invoke(IntPtr obj, Actor NoiseMaker, float Loudness, Vector NoiseLocation) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NoiseMaker;
                *((float*)(b+8)) = Loudness;
                *((Vector*)(b+12)) = NoiseLocation;
                Main.GetProcessEvent(obj, MakeNoise_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PawnNoiseEmitterComponent_events {
    }
}
