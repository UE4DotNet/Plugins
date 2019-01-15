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
using UE4.Foliage.Native;
using UE4.Engine;

namespace UE4.Foliage {
    ///<summary>Foliage Type</summary>
    public unsafe partial class FoliageType : UObject  {
        ///<summary>
        ///A GUID that is updated every time the foliage type is modified,
        ///         so foliage placed in the level can detect the FoliageType has changed.
        ///</summary>
        public unsafe FGuid UpdateGuid {
            get {return FoliageType_ptr->UpdateGuid;}
            set {FoliageType_ptr->UpdateGuid = value;}
        }
        ///<summary>Foliage instances will be placed at this density, specified in instances per 1000x1000 unit area</summary>
        public unsafe float Density {
            get {return FoliageType_ptr->Density;}
            set {FoliageType_ptr->Density = value;}
        }
        ///<summary>The factor by which to adjust the density of instances. Values >1 will increase density while values <1 will decrease it.</summary>
        public unsafe float DensityAdjustmentFactor {
            get {return FoliageType_ptr->DensityAdjustmentFactor;}
            set {FoliageType_ptr->DensityAdjustmentFactor = value;}
        }
        ///<summary>The minimum distance between foliage instances</summary>
        public unsafe float Radius {
            get {return FoliageType_ptr->Radius;}
            set {FoliageType_ptr->Radius = value;}
        }
         //TODO: enum EFoliageScaling Scaling
        ///<summary>Specifies the range of scale, from minimum to maximum, to apply to a foliage instance's X Scale property</summary>
        public unsafe FloatInterval ScaleX {
            get {return FoliageType_ptr->ScaleX;}
            set {FoliageType_ptr->ScaleX = value;}
        }
        ///<summary>Specifies the range of scale, from minimum to maximum, to apply to a foliage instance's Y Scale property</summary>
        public unsafe FloatInterval ScaleY {
            get {return FoliageType_ptr->ScaleY;}
            set {FoliageType_ptr->ScaleY = value;}
        }
        ///<summary>Specifies the range of scale, from minimum to maximum, to apply to a foliage instance's Z Scale property</summary>
        public unsafe FloatInterval ScaleZ {
            get {return FoliageType_ptr->ScaleZ;}
            set {FoliageType_ptr->ScaleZ = value;}
        }
        ///<summary>Vertex Color Mask by Channel</summary>
        public unsafe FoliageVertexColorChannelMask VertexColorMaskByChannel {
            get {return FoliageType_ptr->VertexColorMaskByChannel;}
            set {FoliageType_ptr->VertexColorMaskByChannel = value;}
        }
        ///<summary>Specifies a range from minimum to maximum of the offset to apply to a foliage instance's Z location</summary>
        public unsafe FloatInterval ZOffset {
            get {return FoliageType_ptr->ZOffset;}
            set {FoliageType_ptr->ZOffset = value;}
        }
        public bool AlignToNormal {
            get {return Main.GetGetBoolPropertyByName(this, "AlignToNormal"); }
            set {Main.SetGetBoolPropertyByName(this, "AlignToNormal", value); }
        }
        ///<summary>The maximum angle in degrees that foliage instances will be adjusted away from the vertical</summary>
        public unsafe float AlignMaxAngle {
            get {return FoliageType_ptr->AlignMaxAngle;}
            set {FoliageType_ptr->AlignMaxAngle = value;}
        }
        public bool RandomYaw {
            get {return Main.GetGetBoolPropertyByName(this, "RandomYaw"); }
            set {Main.SetGetBoolPropertyByName(this, "RandomYaw", value); }
        }
        ///<summary>A random pitch adjustment can be applied to each instance, up to the specified angle in degrees, from the original vertical</summary>
        public unsafe float RandomPitchAngle {
            get {return FoliageType_ptr->RandomPitchAngle;}
            set {FoliageType_ptr->RandomPitchAngle = value;}
        }
        ///<summary>Foliage instances will only be placed on surfaces sloping in the specified angle range from the horizontal</summary>
        public unsafe FloatInterval GroundSlopeAngle {
            get {return FoliageType_ptr->GroundSlopeAngle;}
            set {FoliageType_ptr->GroundSlopeAngle = value;}
        }
        ///<summary>The valid altitude range where foliage instances will be placed, specified using minimum and maximum world coordinate Z values</summary>
        public unsafe FloatInterval Height {
            get {return FoliageType_ptr->Height;}
            set {FoliageType_ptr->Height = value;}
        }
         //TODO: array not UObject TArray LandscapeLayers
        public bool CollisionWithWorld {
            get {return Main.GetGetBoolPropertyByName(this, "CollisionWithWorld"); }
            set {Main.SetGetBoolPropertyByName(this, "CollisionWithWorld", value); }
        }
        ///<summary>The foliage instance's collision bounding box will be scaled by the specified amount before performing the overlap check</summary>
        public unsafe Vector CollisionScale {
            get {return FoliageType_ptr->CollisionScale;}
            set {FoliageType_ptr->CollisionScale = value;}
        }
        ///<summary>Specifies the minimum value above which the landscape layer weight value must be, in order for foliage instances to be placed in a specific area</summary>
        public unsafe float MinimumLayerWeight {
            get {return FoliageType_ptr->MinimumLayerWeight;}
            set {FoliageType_ptr->MinimumLayerWeight = value;}
        }
        ///<summary>Mesh Bounds</summary>
        public unsafe BoxSphereBounds MeshBounds {
            get {return FoliageType_ptr->MeshBounds;}
            set {FoliageType_ptr->MeshBounds = value;}
        }
        ///<summary>X, Y is origin position and Z is radius...</summary>
        public unsafe Vector LowBoundOriginRadius {
            get {return FoliageType_ptr->LowBoundOriginRadius;}
            set {FoliageType_ptr->LowBoundOriginRadius = value;}
        }
        ///<summary>Mobility property to apply to foliage components</summary>
        public unsafe byte Mobility {
            get {return FoliageType_ptr->Mobility;}
        }
        ///<summary>The distance where instances will begin to fade out if using a PerInstanceFadeAmount material node.</summary>
        ///<remarks>
        ///0 disables.
        ///When the entire cluster is beyond this distance, the cluster is completely culled and not rendered at all.
        ///</remarks>
        public unsafe Int32Interval CullDistance {
            get {return FoliageType_ptr->CullDistance;}
            set {FoliageType_ptr->CullDistance = value;}
        }
        public bool CastShadow {
            get {return Main.GetGetBoolPropertyByName(this, "CastShadow"); }
        }
        public bool bAffectDynamicIndirectLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectDynamicIndirectLighting"); }
        }
        public bool bAffectDistanceFieldLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectDistanceFieldLighting"); }
        }
        public bool bCastDynamicShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastDynamicShadow"); }
        }
        public bool bCastStaticShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastStaticShadow"); }
        }
        public bool bCastShadowAsTwoSided {
            get {return Main.GetGetBoolPropertyByName(this, "bCastShadowAsTwoSided"); }
        }
        public bool bReceivesDecals {
            get {return Main.GetGetBoolPropertyByName(this, "bReceivesDecals"); }
        }
        public bool bOverrideLightMapRes {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideLightMapRes"); }
        }
        ///<summary>Overrides the lightmap resolution defined in the static mesh</summary>
        public unsafe int OverriddenLightMapRes {
            get {return FoliageType_ptr->OverriddenLightMapRes;}
        }
         //TODO: enum ELightmapType LightmapType
        public bool bUseAsOccluder {
            get {return Main.GetGetBoolPropertyByName(this, "bUseAsOccluder"); }
        }
        ///<summary>Custom collision for foliage</summary>
        public unsafe BodyInstance BodyInstance {
            get {return FoliageType_ptr->BodyInstance;}
            set {FoliageType_ptr->BodyInstance = value;}
        }
        ///<summary>Force navmesh</summary>
        public unsafe byte CustomNavigableGeometry {
            get {return FoliageType_ptr->CustomNavigableGeometry;}
            set {FoliageType_ptr->CustomNavigableGeometry = value;}
        }
        ///<summary>Lighting channels that placed foliage will be assigned.</summary>
        ///<remarks>
        ///Lights with matching channels will affect the foliage.
        ///These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
        ///</remarks>
        public unsafe LightingChannels LightingChannels {
            get {return FoliageType_ptr->LightingChannels;}
        }
        public bool bRenderCustomDepth {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderCustomDepth"); }
        }
        ///<summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
        public unsafe int CustomDepthStencilValue {
            get {return FoliageType_ptr->CustomDepthStencilValue;}
        }
         //TODO: numeric uint64 HiddenEditorViews
        public bool IsSelected {
            get {return Main.GetGetBoolPropertyByName(this, "IsSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "IsSelected", value); }
        }
        ///<summary>The CollisionRadius determines when two instances overlap. When two instances overlap a winner will be picked based on rules and priority.</summary>
        public unsafe float CollisionRadius {
            get {return FoliageType_ptr->CollisionRadius;}
            set {FoliageType_ptr->CollisionRadius = value;}
        }
        ///<summary>The ShadeRadius determines when two instances overlap. If an instance can grow in the shade this radius is ignored.</summary>
        public unsafe float ShadeRadius {
            get {return FoliageType_ptr->ShadeRadius;}
            set {FoliageType_ptr->ShadeRadius = value;}
        }
        ///<summary>The number of times we age the species and spread its seeds.</summary>
        public unsafe int NumSteps {
            get {return FoliageType_ptr->NumSteps;}
            set {FoliageType_ptr->NumSteps = value;}
        }
        ///<summary>Specifies the number of seeds to populate along 10 meters. The number is implicitly squared to cover a 10m x 10m area</summary>
        public unsafe float InitialSeedDensity {
            get {return FoliageType_ptr->InitialSeedDensity;}
            set {FoliageType_ptr->InitialSeedDensity = value;}
        }
        ///<summary>The average distance between the spreading instance and its seeds. For example, a tree with an AverageSpreadDistance 10 will ensure the average distance between the tree and its seeds is 10cm</summary>
        public unsafe float AverageSpreadDistance {
            get {return FoliageType_ptr->AverageSpreadDistance;}
            set {FoliageType_ptr->AverageSpreadDistance = value;}
        }
        ///<summary>Specifies how much seed distance varies from the average. For example, a tree with an AverageSpreadDistance 10 and a SpreadVariance 1 will produce seeds with an average distance of 10cm plus or minus 1cm</summary>
        public unsafe float SpreadVariance {
            get {return FoliageType_ptr->SpreadVariance;}
            set {FoliageType_ptr->SpreadVariance = value;}
        }
        ///<summary>The number of seeds an instance will spread in a single step of the simulation.</summary>
        public unsafe int SeedsPerStep {
            get {return FoliageType_ptr->SeedsPerStep;}
            set {FoliageType_ptr->SeedsPerStep = value;}
        }
        ///<summary>The seed that determines placement of initial seeds.</summary>
        public unsafe int DistributionSeed {
            get {return FoliageType_ptr->DistributionSeed;}
            set {FoliageType_ptr->DistributionSeed = value;}
        }
        ///<summary>The seed that determines placement of initial seeds.</summary>
        public unsafe float MaxInitialSeedOffset {
            get {return FoliageType_ptr->MaxInitialSeedOffset;}
            set {FoliageType_ptr->MaxInitialSeedOffset = value;}
        }
        public bool bCanGrowInShade {
            get {return Main.GetGetBoolPropertyByName(this, "bCanGrowInShade"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanGrowInShade", value); }
        }
        public bool bSpawnsInShade {
            get {return Main.GetGetBoolPropertyByName(this, "bSpawnsInShade"); }
            set {Main.SetGetBoolPropertyByName(this, "bSpawnsInShade", value); }
        }
        ///<summary>Allows a new seed to be older than 0 when created. New seeds will be randomly assigned an age in the range [0,MaxInitialAge]</summary>
        public unsafe float MaxInitialAge {
            get {return FoliageType_ptr->MaxInitialAge;}
            set {FoliageType_ptr->MaxInitialAge = value;}
        }
        ///<summary>Specifies the oldest a seed can be. After reaching this age the instance will still spread seeds, but will not get any older</summary>
        public unsafe float MaxAge {
            get {return FoliageType_ptr->MaxAge;}
            set {FoliageType_ptr->MaxAge = value;}
        }
        ///<summary>When two instances overlap we must determine which instance to remove.</summary>
        ///<remarks>
        ///The instance with a lower OverlapPriority will be removed.
        ///In the case where OverlapPriority is the same regular simulation rules apply.
        ///</remarks>
        public unsafe float OverlapPriority {
            get {return FoliageType_ptr->OverlapPriority;}
            set {FoliageType_ptr->OverlapPriority = value;}
        }
        ///<summary>The scale range of this type when being procedurally generated. Configured with the Scale Curve.</summary>
        public unsafe FloatInterval ProceduralScale {
            get {return FoliageType_ptr->ProceduralScale;}
            set {FoliageType_ptr->ProceduralScale = value;}
        }
        ///<summary>Instance scale factor as a function of normalized age (i.</summary>
        ///<remarks>
        ///e. Current Age / Max Age).
        ///X = 0 corresponds to Age = 0, X = 1 corresponds to Age = Max Age.
        ///Y = 0 corresponds to Min Scale, Y = 1 corresponds to Max Scale.
        ///</remarks>
        public unsafe RuntimeFloatCurve ScaleCurve {
            get {return FoliageType_ptr->ScaleCurve;}
            set {FoliageType_ptr->ScaleCurve = value;}
        }
        ///<summary>Change Count</summary>
        public unsafe int ChangeCount {
            get {return FoliageType_ptr->ChangeCount;}
            set {FoliageType_ptr->ChangeCount = value;}
        }
        public bool ReapplyDensity {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyDensity"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyDensity", value); }
        }
        public bool ReapplyRadius {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyRadius"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyRadius", value); }
        }
        public bool ReapplyAlignToNormal {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyAlignToNormal"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyAlignToNormal", value); }
        }
        public bool ReapplyRandomYaw {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyRandomYaw"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyRandomYaw", value); }
        }
        public bool ReapplyScaling {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyScaling", value); }
        }
        public bool ReapplyScaleX {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyScaleX"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyScaleX", value); }
        }
        public bool ReapplyScaleY {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyScaleY"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyScaleY", value); }
        }
        public bool ReapplyScaleZ {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyScaleZ"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyScaleZ", value); }
        }
        public bool ReapplyRandomPitchAngle {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyRandomPitchAngle"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyRandomPitchAngle", value); }
        }
        public bool ReapplyGroundSlope {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyGroundSlope"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyGroundSlope", value); }
        }
        public bool ReapplyHeight {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyHeight"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyHeight", value); }
        }
        public bool ReapplyLandscapeLayers {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyLandscapeLayers"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyLandscapeLayers", value); }
        }
        public bool ReapplyZOffset {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyZOffset"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyZOffset", value); }
        }
        public bool ReapplyCollisionWithWorld {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyCollisionWithWorld"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyCollisionWithWorld", value); }
        }
        public bool ReapplyVertexColorMask {
            get {return Main.GetGetBoolPropertyByName(this, "ReapplyVertexColorMask"); }
            set {Main.SetGetBoolPropertyByName(this, "ReapplyVertexColorMask", value); }
        }
        public bool bEnableDensityScaling {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableDensityScaling"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableDensityScaling", value); }
        }
        static FoliageType() {
            StaticClass = Main.GetClass("FoliageType");
        }
        internal unsafe FoliageType_fields* FoliageType_ptr => (FoliageType_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator FoliageType(IntPtr p) => UObject.Make<FoliageType>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static FoliageType DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static FoliageType New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
