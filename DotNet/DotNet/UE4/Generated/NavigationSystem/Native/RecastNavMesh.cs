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


namespace UE4.NavigationSystem.Native {
    [StructLayout( LayoutKind.Explicit, Size=1648 )]
    internal unsafe struct RecastNavMesh_fields {
        [FieldOffset(1480)] public bool bDrawTriangleEdges;
        [FieldOffset(1480)] public bool bDrawPolyEdges;
        [FieldOffset(1480)] public bool bDrawFilledPolys;
        [FieldOffset(1480)] public bool bDrawNavMeshEdges;
        [FieldOffset(1480)] public bool bDrawTileBounds;
        [FieldOffset(1480)] public bool bDrawPathCollidingGeometry;
        [FieldOffset(1480)] public bool bDrawTileLabels;
        [FieldOffset(1480)] public bool bDrawPolygonLabels;
        [FieldOffset(1481)] public bool bDrawDefaultPolygonCost;
        [FieldOffset(1481)] public bool bDrawLabelsOnPathNodes;
        [FieldOffset(1481)] public bool bDrawNavLinks;
        [FieldOffset(1481)] public bool bDrawFailedNavLinks;
        [FieldOffset(1481)] public bool bDrawClusters;
        [FieldOffset(1481)] public bool bDrawOctree;
        [FieldOffset(1481)] public bool bDrawOctreeDetails;
        [FieldOffset(1481)] public bool bDistinctlyDrawTilesBeingBuilt;
        [FieldOffset(1482)] public bool bDrawNavMesh;
        [FieldOffset(1484)] public float DrawOffset;
        [FieldOffset(1488)] public bool bFixedTilePoolSize;
        [FieldOffset(1492)] public int TilePoolSize;
        [FieldOffset(1496)] public float TileSizeUU;
        [FieldOffset(1500)] public float CellSize;
        [FieldOffset(1504)] public float CellHeight;
        [FieldOffset(1508)] public float AgentRadius;
        [FieldOffset(1512)] public float AgentHeight;
        [FieldOffset(1516)] public float AgentMaxHeight;
        [FieldOffset(1520)] public float AgentMaxSlope;
        [FieldOffset(1524)] public float AgentMaxStepHeight;
        [FieldOffset(1528)] public float MinRegionArea;
        [FieldOffset(1532)] public float MergeRegionSize;
        [FieldOffset(1536)] public float MaxSimplificationError;
        [FieldOffset(1540)] public int MaxSimultaneousTileGenerationJobsCount;
        [FieldOffset(1544)] public int TileNumberHardLimit;
        [FieldOffset(1548)] public int PolyRefTileBits;
        [FieldOffset(1552)] public int PolyRefNavPolyBits;
        [FieldOffset(1556)] public int PolyRefSaltBits;
        [FieldOffset(1560)] public float DefaultDrawDistance;
        [FieldOffset(1564)] public float DefaultMaxSearchNodes;
        [FieldOffset(1568)] public float DefaultMaxHierarchicalSearchNodes;
        [FieldOffset(1572)] public byte RegionPartitioning;
        [FieldOffset(1573)] public byte LayerPartitioning;
        [FieldOffset(1576)] public int RegionChunkSplits;
        [FieldOffset(1580)] public int LayerChunkSplits;
        [FieldOffset(1584)] public bool bSortNavigationAreasByCost;
        [FieldOffset(1584)] public bool bPerformVoxelFiltering;
        [FieldOffset(1584)] public bool bMarkLowHeightAreas;
        [FieldOffset(1584)] public bool bFilterLowSpanSequences;
        [FieldOffset(1584)] public bool bFilterLowSpanFromTileCache;
        [FieldOffset(1584)] public bool bDoFullyAsyncNavDataGathering;
        [FieldOffset(1584)] public bool bUseBetterOffsetsFromCorners;
        [FieldOffset(1584)] public bool bStoreEmptyTileLayers;
        [FieldOffset(1585)] public bool bUseVirtualFilters;
        [FieldOffset(1585)] public bool bAllowNavLinkAsPathEnd;
        [FieldOffset(1585)] public bool bUseVoxelCache;
        [FieldOffset(1588)] public float TileSetUpdateInterval;
        [FieldOffset(1592)] public float HeuristicScale;
        [FieldOffset(1596)] public float VerticalDeviationFromGroundCompensation;
    }
    internal unsafe struct RecastNavMesh_methods {
    }
    internal unsafe struct RecastNavMesh_events {
    }
}
