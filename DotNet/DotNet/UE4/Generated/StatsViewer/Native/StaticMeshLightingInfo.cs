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
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct StaticMeshLightingInfo_fields {
        [FieldOffset(56)] byte StaticMeshActor; //TODO: weak object TWeakObjectPtr<AActor> StaticMeshActor
        [FieldOffset(64)] byte StaticMesh; //TODO: weak object TWeakObjectPtr<UStaticMesh> StaticMesh
        [FieldOffset(72)] byte LevelName; //TODO: string FString LevelName
        [FieldOffset(96)] byte TextureMapping; //TODO: string FString TextureMapping
        [FieldOffset(112)] public bool bTextureMapping;
        [FieldOffset(113)] public bool bHasLightmapTexCoords;
        [FieldOffset(116)] public int StaticLightingResolution;
        [FieldOffset(120)] public float TextureLightMapMemoryUsage;
        [FieldOffset(124)] public float VertexLightMapMemoryUsage;
        [FieldOffset(128)] public int LightMapLightCount;
        [FieldOffset(132)] public float TextureShadowMapMemoryUsage;
        [FieldOffset(136)] public float VertexShadowMapMemoryUsage;
        [FieldOffset(140)] public int ShadowMapLightCount;
    }
    internal unsafe struct StaticMeshLightingInfo_methods {
    }
    internal unsafe struct StaticMeshLightingInfo_events {
    }
}
