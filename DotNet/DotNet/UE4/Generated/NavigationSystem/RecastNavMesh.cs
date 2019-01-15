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

#pragma warning disable CS0108
using UE4.NavigationSystem.Native;

namespace UE4.NavigationSystem {
    ///<summary>Recast Nav Mesh</summary>
    public unsafe partial class RecastNavMesh : NavigationData  {
        public bool bDrawTriangleEdges {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawTriangleEdges"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawTriangleEdges", value); }
        }
        public bool bDrawPolyEdges {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawPolyEdges"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawPolyEdges", value); }
        }
        public bool bDrawFilledPolys {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawFilledPolys"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawFilledPolys", value); }
        }
        public bool bDrawNavMeshEdges {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawNavMeshEdges"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawNavMeshEdges", value); }
        }
        public bool bDrawTileBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawTileBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawTileBounds", value); }
        }
        public bool bDrawPathCollidingGeometry {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawPathCollidingGeometry"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawPathCollidingGeometry", value); }
        }
        public bool bDrawTileLabels {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawTileLabels"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawTileLabels", value); }
        }
        public bool bDrawPolygonLabels {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawPolygonLabels"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawPolygonLabels", value); }
        }
        public bool bDrawDefaultPolygonCost {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawDefaultPolygonCost"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawDefaultPolygonCost", value); }
        }
        public bool bDrawLabelsOnPathNodes {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawLabelsOnPathNodes"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawLabelsOnPathNodes", value); }
        }
        public bool bDrawNavLinks {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawNavLinks"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawNavLinks", value); }
        }
        public bool bDrawFailedNavLinks {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawFailedNavLinks"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawFailedNavLinks", value); }
        }
        public bool bDrawClusters {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawClusters"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawClusters", value); }
        }
        public bool bDrawOctree {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawOctree"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawOctree", value); }
        }
        public bool bDrawOctreeDetails {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawOctreeDetails"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawOctreeDetails", value); }
        }
        public bool bDistinctlyDrawTilesBeingBuilt {
            get {return Main.GetGetBoolPropertyByName(this, "bDistinctlyDrawTilesBeingBuilt"); }
            set {Main.SetGetBoolPropertyByName(this, "bDistinctlyDrawTilesBeingBuilt", value); }
        }
        public bool bDrawNavMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawNavMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawNavMesh", value); }
        }
        ///<summary>vertical offset added to navmesh's debug representation for better readability</summary>
        public unsafe float DrawOffset {
            get {return RecastNavMesh_ptr->DrawOffset;}
            set {RecastNavMesh_ptr->DrawOffset = value;}
        }
        public bool bFixedTilePoolSize {
            get {return Main.GetGetBoolPropertyByName(this, "bFixedTilePoolSize"); }
            set {Main.SetGetBoolPropertyByName(this, "bFixedTilePoolSize", value); }
        }
        ///<summary>maximum number of tiles NavMesh can hold</summary>
        public unsafe int TilePoolSize {
            get {return RecastNavMesh_ptr->TilePoolSize;}
            set {RecastNavMesh_ptr->TilePoolSize = value;}
        }
        ///<summary>size of single tile, expressed in uu</summary>
        public unsafe float TileSizeUU {
            get {return RecastNavMesh_ptr->TileSizeUU;}
            set {RecastNavMesh_ptr->TileSizeUU = value;}
        }
        ///<summary>horizontal size of voxelization cell</summary>
        public unsafe float CellSize {
            get {return RecastNavMesh_ptr->CellSize;}
            set {RecastNavMesh_ptr->CellSize = value;}
        }
        ///<summary>vertical size of voxelization cell</summary>
        public unsafe float CellHeight {
            get {return RecastNavMesh_ptr->CellHeight;}
            set {RecastNavMesh_ptr->CellHeight = value;}
        }
        ///<summary>Radius of smallest agent to traverse this navmesh</summary>
        public unsafe float AgentRadius {
            get {return RecastNavMesh_ptr->AgentRadius;}
            set {RecastNavMesh_ptr->AgentRadius = value;}
        }
        ///<summary>Agent Height</summary>
        public unsafe float AgentHeight {
            get {return RecastNavMesh_ptr->AgentHeight;}
            set {RecastNavMesh_ptr->AgentHeight = value;}
        }
        ///<summary>Size of the tallest agent that will path with this navmesh.</summary>
        public unsafe float AgentMaxHeight {
            get {return RecastNavMesh_ptr->AgentMaxHeight;}
            set {RecastNavMesh_ptr->AgentMaxHeight = value;}
        }
        ///<summary>The maximum slope (angle) that the agent can move on.</summary>
        public unsafe float AgentMaxSlope {
            get {return RecastNavMesh_ptr->AgentMaxSlope;}
            set {RecastNavMesh_ptr->AgentMaxSlope = value;}
        }
        ///<summary>Agent Max Step Height</summary>
        public unsafe float AgentMaxStepHeight {
            get {return RecastNavMesh_ptr->AgentMaxStepHeight;}
            set {RecastNavMesh_ptr->AgentMaxStepHeight = value;}
        }
        ///<summary>The minimum dimension of area. Areas smaller than this will be discarded</summary>
        public unsafe float MinRegionArea {
            get {return RecastNavMesh_ptr->MinRegionArea;}
            set {RecastNavMesh_ptr->MinRegionArea = value;}
        }
        ///<summary>The size limit of regions to be merged with bigger regions (watershed partitioning only)</summary>
        public unsafe float MergeRegionSize {
            get {return RecastNavMesh_ptr->MergeRegionSize;}
            set {RecastNavMesh_ptr->MergeRegionSize = value;}
        }
        ///<summary>How much navigable shapes can get simplified - the higher the value the more freedom</summary>
        public unsafe float MaxSimplificationError {
            get {return RecastNavMesh_ptr->MaxSimplificationError;}
            set {RecastNavMesh_ptr->MaxSimplificationError = value;}
        }
        ///<summary>Max Simultaneous Tile Generation Jobs Count</summary>
        public unsafe int MaxSimultaneousTileGenerationJobsCount {
            get {return RecastNavMesh_ptr->MaxSimultaneousTileGenerationJobsCount;}
            set {RecastNavMesh_ptr->MaxSimultaneousTileGenerationJobsCount = value;}
        }
        ///<summary>Absolute hard limit to number of navmesh tiles.</summary>
        ///<remarks>
        ///Be very, very careful while modifying it while
        ///    having big maps with navmesh. A single, empty tile takes 176 bytes and empty tiles are
        ///    allocated up front (subject to change, but that's where it's at now)
        ///    @note TileNumberHardLimit is always rounded up to the closest power of 2
        ///</remarks>
        public unsafe int TileNumberHardLimit {
            get {return RecastNavMesh_ptr->TileNumberHardLimit;}
            set {RecastNavMesh_ptr->TileNumberHardLimit = value;}
        }
        ///<summary>Poly Ref Tile Bits</summary>
        public unsafe int PolyRefTileBits {
            get {return RecastNavMesh_ptr->PolyRefTileBits;}
            set {RecastNavMesh_ptr->PolyRefTileBits = value;}
        }
        ///<summary>Poly Ref Nav Poly Bits</summary>
        public unsafe int PolyRefNavPolyBits {
            get {return RecastNavMesh_ptr->PolyRefNavPolyBits;}
            set {RecastNavMesh_ptr->PolyRefNavPolyBits = value;}
        }
        ///<summary>Poly Ref Salt Bits</summary>
        public unsafe int PolyRefSaltBits {
            get {return RecastNavMesh_ptr->PolyRefSaltBits;}
            set {RecastNavMesh_ptr->PolyRefSaltBits = value;}
        }
        ///<summary>navmesh draw distance in game (always visible in editor)</summary>
        public unsafe float DefaultDrawDistance {
            get {return RecastNavMesh_ptr->DefaultDrawDistance;}
            set {RecastNavMesh_ptr->DefaultDrawDistance = value;}
        }
        ///<summary>specifes default limit to A* nodes used when performing navigation queries.</summary>
        ///<remarks>Can be overridden by passing custom FNavigationQueryFilter</remarks>
        public unsafe float DefaultMaxSearchNodes {
            get {return RecastNavMesh_ptr->DefaultMaxSearchNodes;}
            set {RecastNavMesh_ptr->DefaultMaxSearchNodes = value;}
        }
        ///<summary>specifes default limit to A* nodes used when performing hierarchical navigation queries.</summary>
        public unsafe float DefaultMaxHierarchicalSearchNodes {
            get {return RecastNavMesh_ptr->DefaultMaxHierarchicalSearchNodes;}
            set {RecastNavMesh_ptr->DefaultMaxHierarchicalSearchNodes = value;}
        }
        ///<summary>partitioning method for creating navmesh polys</summary>
        public unsafe byte RegionPartitioning {
            get {return RecastNavMesh_ptr->RegionPartitioning;}
            set {RecastNavMesh_ptr->RegionPartitioning = value;}
        }
        ///<summary>partitioning method for creating tile layers</summary>
        public unsafe byte LayerPartitioning {
            get {return RecastNavMesh_ptr->LayerPartitioning;}
            set {RecastNavMesh_ptr->LayerPartitioning = value;}
        }
        ///<summary>number of chunk splits (along single axis) used for region's partitioning: ChunkyMonotone</summary>
        public unsafe int RegionChunkSplits {
            get {return RecastNavMesh_ptr->RegionChunkSplits;}
            set {RecastNavMesh_ptr->RegionChunkSplits = value;}
        }
        ///<summary>number of chunk splits (along single axis) used for layer's partitioning: ChunkyMonotone</summary>
        public unsafe int LayerChunkSplits {
            get {return RecastNavMesh_ptr->LayerChunkSplits;}
            set {RecastNavMesh_ptr->LayerChunkSplits = value;}
        }
        public bool bSortNavigationAreasByCost {
            get {return Main.GetGetBoolPropertyByName(this, "bSortNavigationAreasByCost"); }
            set {Main.SetGetBoolPropertyByName(this, "bSortNavigationAreasByCost", value); }
        }
        public bool bPerformVoxelFiltering {
            get {return Main.GetGetBoolPropertyByName(this, "bPerformVoxelFiltering"); }
            set {Main.SetGetBoolPropertyByName(this, "bPerformVoxelFiltering", value); }
        }
        public bool bMarkLowHeightAreas {
            get {return Main.GetGetBoolPropertyByName(this, "bMarkLowHeightAreas"); }
            set {Main.SetGetBoolPropertyByName(this, "bMarkLowHeightAreas", value); }
        }
        public bool bFilterLowSpanSequences {
            get {return Main.GetGetBoolPropertyByName(this, "bFilterLowSpanSequences"); }
            set {Main.SetGetBoolPropertyByName(this, "bFilterLowSpanSequences", value); }
        }
        public bool bFilterLowSpanFromTileCache {
            get {return Main.GetGetBoolPropertyByName(this, "bFilterLowSpanFromTileCache"); }
            set {Main.SetGetBoolPropertyByName(this, "bFilterLowSpanFromTileCache", value); }
        }
        public bool bDoFullyAsyncNavDataGathering {
            get {return Main.GetGetBoolPropertyByName(this, "bDoFullyAsyncNavDataGathering"); }
            set {Main.SetGetBoolPropertyByName(this, "bDoFullyAsyncNavDataGathering", value); }
        }
        public bool bUseBetterOffsetsFromCorners {
            get {return Main.GetGetBoolPropertyByName(this, "bUseBetterOffsetsFromCorners"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseBetterOffsetsFromCorners", value); }
        }
        public bool bStoreEmptyTileLayers {
            get {return Main.GetGetBoolPropertyByName(this, "bStoreEmptyTileLayers"); }
            set {Main.SetGetBoolPropertyByName(this, "bStoreEmptyTileLayers", value); }
        }
        public bool bUseVirtualFilters {
            get {return Main.GetGetBoolPropertyByName(this, "bUseVirtualFilters"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseVirtualFilters", value); }
        }
        public bool bAllowNavLinkAsPathEnd {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowNavLinkAsPathEnd"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowNavLinkAsPathEnd", value); }
        }
        public bool bUseVoxelCache {
            get {return Main.GetGetBoolPropertyByName(this, "bUseVoxelCache"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseVoxelCache", value); }
        }
        ///<summary>indicates how often we will sort navigation tiles to mach players position</summary>
        public unsafe float TileSetUpdateInterval {
            get {return RecastNavMesh_ptr->TileSetUpdateInterval;}
            set {RecastNavMesh_ptr->TileSetUpdateInterval = value;}
        }
        ///<summary>Euclidean distance heuristic scale used while pathfinding</summary>
        public unsafe float HeuristicScale {
            get {return RecastNavMesh_ptr->HeuristicScale;}
            set {RecastNavMesh_ptr->HeuristicScale = value;}
        }
        ///<summary>Value added to each search height to compensate for error between navmesh polys and walkable geometry</summary>
        public unsafe float VerticalDeviationFromGroundCompensation {
            get {return RecastNavMesh_ptr->VerticalDeviationFromGroundCompensation;}
            set {RecastNavMesh_ptr->VerticalDeviationFromGroundCompensation = value;}
        }
        static RecastNavMesh() {
            StaticClass = Main.GetClass("RecastNavMesh");
        }
        internal unsafe RecastNavMesh_fields* RecastNavMesh_ptr => (RecastNavMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RecastNavMesh(IntPtr p) => UObject.Make<RecastNavMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RecastNavMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RecastNavMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
