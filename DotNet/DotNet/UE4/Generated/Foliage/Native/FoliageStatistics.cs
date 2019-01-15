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

using UE4.Engine;

namespace UE4.Foliage.Native {
    [StructLayout( LayoutKind.Explicit, Size=56 )]
    internal unsafe struct FoliageStatistics_fields {
    }
    internal unsafe struct FoliageStatistics_methods {
        internal struct FoliageOverlappingBoxCount_method {
            static internal IntPtr FoliageOverlappingBoxCount_ptr;
            static FoliageOverlappingBoxCount_method() {
                FoliageOverlappingBoxCount_ptr = Main.GetMethodUFunction(FoliageStatistics.StaticClass, "FoliageOverlappingBoxCount");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, StaticMesh StaticMesh, Box Box) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = StaticMesh;
                *((Box*)(b+16)) = Box;
                Main.GetProcessEvent(FoliageStatistics.DefaultObject, FoliageOverlappingBoxCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+44));
            }
        }
        internal struct FoliageOverlappingSphereCount_method {
            static internal IntPtr FoliageOverlappingSphereCount_ptr;
            static FoliageOverlappingSphereCount_method() {
                FoliageOverlappingSphereCount_ptr = Main.GetMethodUFunction(FoliageStatistics.StaticClass, "FoliageOverlappingSphereCount");
            }

            internal static unsafe int Invoke(UObject WorldContextObject, StaticMesh StaticMesh, Vector CenterPosition, float Radius) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = WorldContextObject;
                *((IntPtr*)(b+8)) = StaticMesh;
                *((Vector*)(b+16)) = CenterPosition;
                *((float*)(b+28)) = Radius;
                Main.GetProcessEvent(FoliageStatistics.DefaultObject, FoliageOverlappingSphereCount_ptr, new IntPtr(p)); ;
                return *((int*)(b+32));
            }
        }
    }
    internal unsafe struct FoliageStatistics_events {
    }
}
