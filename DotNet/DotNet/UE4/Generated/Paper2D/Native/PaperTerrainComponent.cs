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


namespace UE4.Paper2D.Native {
    [StructLayout( LayoutKind.Explicit, Size=1600 )]
    internal unsafe struct PaperTerrainComponent_fields {
        [FieldOffset(1504)]  public IntPtr  TerrainMaterial;
        [FieldOffset(1512)] public bool bClosedSpline;
        [FieldOffset(1513)] public bool bFilledSpline;
        [FieldOffset(1520)]  public IntPtr  AssociatedSpline;
        [FieldOffset(1528)] public int RandomSeed;
        [FieldOffset(1532)] public float SegmentOverlapAmount;
        [FieldOffset(1536)] public LinearColor TerrainColor;
        [FieldOffset(1552)] public int ReparamStepsPerSegment;
        [FieldOffset(1556)] public byte SpriteCollisionDomain;
        [FieldOffset(1560)] public float CollisionThickness;
        [FieldOffset(1568)]  public IntPtr  CachedBodySetup;
    }
    internal unsafe struct PaperTerrainComponent_methods {
        internal struct SetTerrainColor_method {
            static internal IntPtr SetTerrainColor_ptr;
            static SetTerrainColor_method() {
                SetTerrainColor_ptr = Main.GetMethodUFunction(PaperTerrainComponent.StaticClass, "SetTerrainColor");
            }

            internal static unsafe void Invoke(IntPtr obj, LinearColor NewColor) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((LinearColor*)(b+0)) = NewColor;
                Main.GetProcessEvent(obj, SetTerrainColor_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct PaperTerrainComponent_events {
    }
}
