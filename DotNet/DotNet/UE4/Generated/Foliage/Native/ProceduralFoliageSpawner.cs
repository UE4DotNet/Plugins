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


namespace UE4.Foliage.Native {
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct ProceduralFoliageSpawner_fields {
        [FieldOffset(56)] public int RandomSeed;
        [FieldOffset(60)] public float TileSize;
        [FieldOffset(64)] public int NumUniqueTiles;
        [FieldOffset(68)] public float MinimumQuadTreeSize;
        [FieldOffset(80)] public NativeArray FoliageTypes;
        [FieldOffset(96)] public bool bNeedsSimulation;
    }
    internal unsafe struct ProceduralFoliageSpawner_methods {
        internal struct Simulate_method {
            static internal IntPtr Simulate_ptr;
            static Simulate_method() {
                Simulate_ptr = Main.GetMethodUFunction(ProceduralFoliageSpawner.StaticClass, "Simulate");
            }

            internal static unsafe void Invoke(IntPtr obj, int NumSteps) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = NumSteps;
                Main.GetProcessEvent(obj, Simulate_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct ProceduralFoliageSpawner_events {
    }
}
