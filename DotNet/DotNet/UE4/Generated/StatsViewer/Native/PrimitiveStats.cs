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


namespace UE4.StatsViewer.Native {
    [StructLayout( LayoutKind.Explicit, Size=168 )]
    internal unsafe struct PrimitiveStats_fields {
        [FieldOffset(56)] byte UObject; //TODO: weak object TWeakObjectPtr<UObject> UObject
        [FieldOffset(64)] public NativeArray Actors;
        [FieldOffset(80)] byte Type; //TODO: string FString Type
        [FieldOffset(96)] public int Count;
        [FieldOffset(100)] public int Sections;
        [FieldOffset(104)] public int HWInstances;
        [FieldOffset(108)] public int InstSections;
        [FieldOffset(112)] public int Triangles;
        [FieldOffset(116)] public int InstTriangles;
        [FieldOffset(120)] public float ResourceSize;
        [FieldOffset(124)] public float VertexColorMem;
        [FieldOffset(128)] public float InstVertexColorMem;
        [FieldOffset(132)] public int LightsLM;
        [FieldOffset(136)] public float LightsOther;
        [FieldOffset(140)] public float LightsTotal;
        [FieldOffset(144)] public float ObjLightCost;
        [FieldOffset(148)] public float LightMapData;
        [FieldOffset(152)] public float LMSMResolution;
        [FieldOffset(156)] public float RadiusMin;
        [FieldOffset(160)] public float RadiusMax;
        [FieldOffset(164)] public float RadiusAvg;
    }
    internal unsafe struct PrimitiveStats_methods {
    }
    internal unsafe struct PrimitiveStats_events {
    }
}
