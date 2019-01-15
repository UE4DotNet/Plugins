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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Proxy</summary>
    public unsafe partial class LandscapeProxy : Actor  {

        ///<summary>Change ComponentScreenSizeToUseSubSections value on the render proxy.</summary>
        public void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections)  => 
            LandscapeProxy_methods.ChangeComponentScreenSizeToUseSubSections_method.Invoke(ObjPointer, InComponentScreenSizeToUseSubSections);

        ///<summary>Change the Level of Detail distance factor</summary>
        public void ChangeLODDistanceFactor(float InLODDistanceFactor)  => 
            LandscapeProxy_methods.ChangeLODDistanceFactor_method.Invoke(ObjPointer, InLODDistanceFactor);

        ///<summary>Change TessellationComponentScreenSize value on the render proxy.</summary>
        public void ChangeTessellationComponentScreenSize(float InTessellationComponentScreenSize)  => 
            LandscapeProxy_methods.ChangeTessellationComponentScreenSize_method.Invoke(ObjPointer, InTessellationComponentScreenSize);

        ///<summary>Change TessellationComponentScreenSizeFalloff value on the render proxy.</summary>
        public void ChangeTessellationComponentScreenSizeFalloff(float InUseTessellationComponentScreenSizeFalloff)  => 
            LandscapeProxy_methods.ChangeTessellationComponentScreenSizeFalloff_method.Invoke(ObjPointer, InUseTessellationComponentScreenSizeFalloff);

        ///<summary>Change UseTessellationComponentScreenSizeFalloff value on the render proxy.</summary>
        public void ChangeUseTessellationComponentScreenSizeFalloff(bool InComponentScreenSizeToUseSubSections)  => 
            LandscapeProxy_methods.ChangeUseTessellationComponentScreenSizeFalloff_method.Invoke(ObjPointer, InComponentScreenSizeToUseSubSections);

        ///<summary>
        ///Deform landscape using a given spline
        ///@
        ///</summary>
        ///<remarks>
        ///param StartWidth - Width of the spline at the start node, in Spline Component local space
        ///@param EndWidth   - Width of the spline at the end node, in Spline Component local space
        ///@param StartSideFalloff - Width of the falloff at either side of the spline at the start node, in Spline Component local space
        ///@param EndSideFalloff - Width of the falloff at either side of the spline at the end node, in Spline Component local space
        ///@param StartRoll - Roll applied to the spline at the start node, in degrees. 0 is flat
        ///@param EndRoll - Roll applied to the spline at the end node, in degrees. 0 is flat
        ///@param NumSubdivisions - Number of triangles to place along the spline when applying it to the landscape. Higher numbers give better results, but setting it too high will be slow and may cause artifacts
        ///@param bRaiseHeights - Allow the landscape to be raised up to the level of the spline. If both bRaiseHeights and bLowerHeights are false, no height modification of the landscape will be performed
        ///@param bLowerHeights - Allow the landscape to be lowered down to the level of the spline. If both bRaiseHeights and bLowerHeights are false, no height modification of the landscape will be performed
        ///@param PaintLayer - LayerInfo to paint, or none to skip painting. The landscape must be configured with the same layer info in one of its layers or this will do nothing!
        ///</remarks>
        public void EditorApplySpline(SplineComponent InSplineComponent, float StartWidth, float EndWidth, float StartSideFalloff, float EndSideFalloff, float StartRoll, float EndRoll, int NumSubdivisions, bool bRaiseHeights, bool bLowerHeights, LandscapeLayerInfoObject PaintLayer)  => 
            LandscapeProxy_methods.EditorApplySpline_method.Invoke(ObjPointer, InSplineComponent, StartWidth, EndWidth, StartSideFalloff, EndSideFalloff, StartRoll, EndRoll, NumSubdivisions, bRaiseHeights, bLowerHeights, PaintLayer);

        ///<summary>Setter for LandscapeMaterial. Has no effect outside the editor.</summary>
        public void EditorSetLandscapeMaterial(MaterialInterface NewLandscapeMaterial)  => 
            LandscapeProxy_methods.EditorSetLandscapeMaterial_method.Invoke(ObjPointer, NewLandscapeMaterial);

        ///<summary>Overwrites a landscape heightmap with render target data</summary>
        ///<remarks>Only works in the editor</remarks>
        public bool LandscapeImportHeightmapFromRenderTarget(TextureRenderTarget2D InRenderTarget)  => 
            LandscapeProxy_methods.LandscapeImportHeightmapFromRenderTarget_method.Invoke(ObjPointer, InRenderTarget);

        ///<summary>Overwrites a landscape weightmap with render target data</summary>
        ///<remarks>Only works in the editor</remarks>
        public bool LandscapeImportWeightmapFromRenderTarget(TextureRenderTarget2D InRenderTarget, Name InLayerName)  => 
            LandscapeProxy_methods.LandscapeImportWeightmapFromRenderTarget_method.Invoke(ObjPointer, InRenderTarget, InLayerName);

        ///<summary>Set a MID scalar (float) parameter value for all landscape components.</summary>
        public void SetLandscapeMaterialScalarParameterValue(Name ParameterName, float Value)  => 
            LandscapeProxy_methods.SetLandscapeMaterialScalarParameterValue_method.Invoke(ObjPointer, ParameterName, Value);

        ///<summary>Set an MID texture parameter value for all landscape components.</summary>
        public void SetLandscapeMaterialTextureParameterValue(Name ParameterName, Texture Value)  => 
            LandscapeProxy_methods.SetLandscapeMaterialTextureParameterValue_method.Invoke(ObjPointer, ParameterName, Value);

        ///<summary>Set an MID vector parameter value for all landscape components.</summary>
        public void SetLandscapeMaterialVectorParameterValue(Name ParameterName, LinearColor Value)  => 
            LandscapeProxy_methods.SetLandscapeMaterialVectorParameterValue_method.Invoke(ObjPointer, ParameterName, Value);
        ///<summary>Spline Component</summary>
        public unsafe LandscapeSplinesComponent SplineComponent {
            get {return LandscapeProxy_ptr->SplineComponent;}
            set {LandscapeProxy_ptr->SplineComponent = value;}
        }
        ///<summary>Guid for LandscapeEditorInfo *</summary>
        public unsafe FGuid LandscapeGuid {
            get {return LandscapeProxy_ptr->LandscapeGuid;}
            set {LandscapeProxy_ptr->LandscapeGuid = value;}
        }
        ///<summary>Offset in quads from global components grid origin (in quads) *</summary>
        public unsafe IntPoint LandscapeSectionOffset {
            get {return LandscapeProxy_ptr->LandscapeSectionOffset;}
            set {LandscapeProxy_ptr->LandscapeSectionOffset = value;}
        }
        ///<summary>Max LOD level to use when rendering, -1 means the max available</summary>
        public unsafe int MaxLODLevel {
            get {return LandscapeProxy_ptr->MaxLODLevel;}
            set {LandscapeProxy_ptr->MaxLODLevel = value;}
        }
        ///<summary>Component screen size (0.0 - 1.0) at which we should keep sub sections. This is mostly pertinent if you have large component of > 64 and component are close to the camera. The goal is to reduce draw call, so if a component is smaller than the value, we merge all subsections into 1 drawcall.</summary>
        public unsafe float ComponentScreenSizeToUseSubSections {
            get {return LandscapeProxy_ptr->ComponentScreenSizeToUseSubSections;}
            set {LandscapeProxy_ptr->ComponentScreenSizeToUseSubSections = value;}
        }
        ///<summary>The distribution setting used to change the LOD 0 generation, 1.75 is the normal distribution, numbers influence directly the LOD0 proportion on screen.</summary>
        public unsafe float LOD0DistributionSetting {
            get {return LandscapeProxy_ptr->LOD0DistributionSetting;}
            set {LandscapeProxy_ptr->LOD0DistributionSetting = value;}
        }
        ///<summary>The distribution setting used to change the LOD generation, 2 is the normal distribution, small number mean you want your last LODs to take more screen space and big number mean you want your first LODs to take more screen space.</summary>
        public unsafe float LODDistributionSetting {
            get {return LandscapeProxy_ptr->LODDistributionSetting;}
            set {LandscapeProxy_ptr->LODDistributionSetting = value;}
        }
        ///<summary>Component screen size (0.0 - 1.0) at which we should enable tessellation.</summary>
        public unsafe float TessellationComponentScreenSize {
            get {return LandscapeProxy_ptr->TessellationComponentScreenSize;}
            set {LandscapeProxy_ptr->TessellationComponentScreenSize = value;}
        }
        public bool UseTessellationComponentScreenSizeFalloff {
            get {return Main.GetGetBoolPropertyByName(this, "UseTessellationComponentScreenSizeFalloff"); }
            set {Main.SetGetBoolPropertyByName(this, "UseTessellationComponentScreenSizeFalloff", value); }
        }
        ///<summary>Component screen size (0.0 - 1.0) at which we start the tessellation falloff.</summary>
        public unsafe float TessellationComponentScreenSizeFalloff {
            get {return LandscapeProxy_ptr->TessellationComponentScreenSizeFalloff;}
            set {LandscapeProxy_ptr->TessellationComponentScreenSizeFalloff = value;}
        }
        ///<summary>Landscape LOD to use as an occluder geometry for software occlusion</summary>
        public unsafe int OccluderGeometryLOD {
            get {return LandscapeProxy_ptr->OccluderGeometryLOD;}
            set {LandscapeProxy_ptr->OccluderGeometryLOD = value;}
        }
        ///<summary>LOD level to use when exporting the landscape to obj or FBX</summary>
        public unsafe int ExportLOD {
            get {return LandscapeProxy_ptr->ExportLOD;}
            set {LandscapeProxy_ptr->ExportLOD = value;}
        }
         //TODO: array not UObject TArray TargetDisplayOrderList
         //TODO: enum ELandscapeLayerDisplayMode TargetDisplayOrder
        ///<summary>LOD level to use when running lightmass (increase to 1 or 2 for large landscapes to stop lightmass crashing)</summary>
        public unsafe int StaticLightingLOD {
            get {return LandscapeProxy_ptr->StaticLightingLOD;}
            set {LandscapeProxy_ptr->StaticLightingLOD = value;}
        }
        ///<summary>Default physical material, used when no per-layer values physical materials</summary>
        public unsafe PhysicalMaterial DefaultPhysMaterial {
            get {return LandscapeProxy_ptr->DefaultPhysMaterial;}
            set {LandscapeProxy_ptr->DefaultPhysMaterial = value;}
        }
        ///<summary>Allows artists to adjust the distance where textures using UV 0 are streamed in/out.</summary>
        ///<remarks>
        ///1.0 is the default, whereas a higher value increases the streamed-in resolution.
        ///Value can be < 0 (from legcay content, or code changes)
        ///</remarks>
        public unsafe float StreamingDistanceMultiplier {
            get {return LandscapeProxy_ptr->StreamingDistanceMultiplier;}
            set {LandscapeProxy_ptr->StreamingDistanceMultiplier = value;}
        }
        ///<summary>Combined material used to render the landscape</summary>
        public unsafe MaterialInterface LandscapeMaterial {
            get {return LandscapeProxy_ptr->LandscapeMaterial;}
            set {LandscapeProxy_ptr->LandscapeMaterial = value;}
        }
        ///<summary>Material used to render landscape components with holes. If not set, LandscapeMaterial will be used (blend mode will be overridden to Masked if it is set to Opaque)</summary>
        public unsafe MaterialInterface LandscapeHoleMaterial {
            get {return LandscapeProxy_ptr->LandscapeHoleMaterial;}
            set {LandscapeProxy_ptr->LandscapeHoleMaterial = value;}
        }
        ///<summary>Allows overriding the landscape bounds.</summary>
        ///<remarks>
        ///This is useful if you distort the landscape with world-position-offset, for example
        ///Extension value in the negative Z axis, positive value increases bound size
        ///Note that this can also be overridden per-component when the component is selected with the component select tool
        ///</remarks>
        public unsafe float NegativeZBoundsExtension {
            get {return LandscapeProxy_ptr->NegativeZBoundsExtension;}
            set {LandscapeProxy_ptr->NegativeZBoundsExtension = value;}
        }
        ///<summary>Allows overriding the landscape bounds.</summary>
        ///<remarks>
        ///This is useful if you distort the landscape with world-position-offset, for example
        ///Extension value in the positive Z axis, positive value increases bound size
        ///Note that this can also be overridden per-component when the component is selected with the component select tool
        ///</remarks>
        public unsafe float PositiveZBoundsExtension {
            get {return LandscapeProxy_ptr->PositiveZBoundsExtension;}
            set {LandscapeProxy_ptr->PositiveZBoundsExtension = value;}
        }
        ///<summary>The array of LandscapeComponent that are used by the landscape</summary>
        public ObjectArrayField<LandscapeComponent> LandscapeComponents{ get {
            if(LandscapeComponents_store == null) LandscapeComponents_store = new ObjectArrayField<LandscapeComponent> (&LandscapeProxy_ptr->LandscapeComponents);
            return LandscapeComponents_store;
        } }
        private ObjectArrayField<LandscapeComponent> LandscapeComponents_store;

        ///<summary>Array of LandscapeHeightfieldCollisionComponent</summary>
        public ObjectArrayField<LandscapeHeightfieldCollisionComponent> CollisionComponents{ get {
            if(CollisionComponents_store == null) CollisionComponents_store = new ObjectArrayField<LandscapeHeightfieldCollisionComponent> (&LandscapeProxy_ptr->CollisionComponents);
            return CollisionComponents_store;
        } }
        private ObjectArrayField<LandscapeHeightfieldCollisionComponent> CollisionComponents_store;

        ///<summary>Foliage Components</summary>
        public ObjectArrayField<HierarchicalInstancedStaticMeshComponent> FoliageComponents{ get {
            if(FoliageComponents_store == null) FoliageComponents_store = new ObjectArrayField<HierarchicalInstancedStaticMeshComponent> (&LandscapeProxy_ptr->FoliageComponents);
            return FoliageComponents_store;
        } }
        private ObjectArrayField<HierarchicalInstancedStaticMeshComponent> FoliageComponents_store;

        public bool bHasLandscapeGrass {
            get {return Main.GetGetBoolPropertyByName(this, "bHasLandscapeGrass"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasLandscapeGrass", value); }
        }
        ///<summary>
        ///The resolution to cache lighting at, in texels/quad in one axis
        ///Total resolution would be changed by StaticLightingResolution*StaticLightingResolution
        ///</summary>
        ///<remarks>Automatically calculate proper value for removing seams</remarks>
        public unsafe float StaticLightingResolution {
            get {return LandscapeProxy_ptr->StaticLightingResolution;}
            set {LandscapeProxy_ptr->StaticLightingResolution = value;}
        }
        public bool bCastStaticShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastStaticShadow"); }
            set {Main.SetGetBoolPropertyByName(this, "bCastStaticShadow", value); }
        }
        public bool bCastShadowAsTwoSided {
            get {return Main.GetGetBoolPropertyByName(this, "bCastShadowAsTwoSided"); }
            set {Main.SetGetBoolPropertyByName(this, "bCastShadowAsTwoSided", value); }
        }
        public bool bCastFarShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastFarShadow"); }
            set {Main.SetGetBoolPropertyByName(this, "bCastFarShadow", value); }
        }
        public bool bAffectDistanceFieldLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAffectDistanceFieldLighting"); }
        }
        ///<summary>Channels that this Landscape should be in.</summary>
        ///<remarks>
        ///Lights with matching channels will affect the Landscape.
        ///These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
        ///</remarks>
        public unsafe LightingChannels LightingChannels {
            get {return LandscapeProxy_ptr->LightingChannels;}
        }
        public bool bUseMaterialPositionOffsetInStaticLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMaterialPositionOffsetInStaticLighting"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMaterialPositionOffsetInStaticLighting", value); }
        }
        public bool bRenderCustomDepth {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderCustomDepth"); }
        }
        ///<summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
        public unsafe int CustomDepthStencilValue {
            get {return LandscapeProxy_ptr->CustomDepthStencilValue;}
        }
        ///<summary>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.</summary>
        public unsafe float LDMaxDrawDistance {
            get {return LandscapeProxy_ptr->LDMaxDrawDistance;}
        }
        public bool bIsMovingToLevel {
            get {return Main.GetGetBoolPropertyByName(this, "bIsMovingToLevel"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsMovingToLevel", value); }
        }
        ///<summary>The Lightmass settings for this object.</summary>
        public unsafe LightmassPrimitiveSettings LightmassSettings {
            get {return LandscapeProxy_ptr->LightmassSettings;}
            set {LandscapeProxy_ptr->LightmassSettings = value;}
        }
        ///<summary>Landscape LOD to use for collision tests. Higher numbers use less memory and process faster, but are much less accurate</summary>
        public unsafe int CollisionMipLevel {
            get {return LandscapeProxy_ptr->CollisionMipLevel;}
            set {LandscapeProxy_ptr->CollisionMipLevel = value;}
        }
        ///<summary>If set higher than the "Collision Mip Level", this specifies the Landscape LOD to use for "simple collision" tests, otherwise the "Collision Mip Level" is used for both simple and complex collision.</summary>
        ///<remarks>Does not work with an XY offset map (mesh collision)</remarks>
        public unsafe int SimpleCollisionMipLevel {
            get {return LandscapeProxy_ptr->SimpleCollisionMipLevel;}
            set {LandscapeProxy_ptr->SimpleCollisionMipLevel = value;}
        }
        ///<summary>Thickness of the collision surface, in unreal units</summary>
        public unsafe float CollisionThickness {
            get {return LandscapeProxy_ptr->CollisionThickness;}
            set {LandscapeProxy_ptr->CollisionThickness = value;}
        }
        ///<summary>Collision profile settings for this landscape</summary>
        public unsafe BodyInstance BodyInstance {
            get {return LandscapeProxy_ptr->BodyInstance;}
        }
        public bool bGenerateOverlapEvents {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateOverlapEvents"); }
        }
        public bool bBakeMaterialPositionOffsetIntoCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bBakeMaterialPositionOffsetIntoCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bBakeMaterialPositionOffsetIntoCollision", value); }
        }
         //TODO: string FString ReimportHeightmapFilePath
         //TODO: array not UObject TArray EditorLayerSettings
        ///<summary>Data set at creation time</summary>
        public unsafe int ComponentSizeQuads {
            get {return LandscapeProxy_ptr->ComponentSizeQuads;}
            set {LandscapeProxy_ptr->ComponentSizeQuads = value;}
        }
        ///<summary>Total number of quads in each component</summary>
        public unsafe int SubsectionSizeQuads {
            get {return LandscapeProxy_ptr->SubsectionSizeQuads;}
            set {LandscapeProxy_ptr->SubsectionSizeQuads = value;}
        }
        ///<summary>Number of quads for a subsection of a component. SubsectionSizeQuads+1 must be a power of two.</summary>
        public unsafe int NumSubsections {
            get {return LandscapeProxy_ptr->NumSubsections;}
            set {LandscapeProxy_ptr->NumSubsections = value;}
        }
        public bool bUsedForNavigation {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedForNavigation"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsedForNavigation", value); }
        }
        public bool bUseDynamicMaterialInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDynamicMaterialInstance"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDynamicMaterialInstance", value); }
        }
         //TODO: enum ENavDataGatheringMode NavigationGeometryGatheringMode
        ///<summary>Max Painted Layers Per Component</summary>
        public unsafe int MaxPaintedLayersPerComponent {
            get {return LandscapeProxy_ptr->MaxPaintedLayersPerComponent;}
            set {LandscapeProxy_ptr->MaxPaintedLayersPerComponent = value;}
        }
        public bool bUseLandscapeForCullingInvisibleHLODVertices {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLandscapeForCullingInvisibleHLODVertices"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseLandscapeForCullingInvisibleHLODVertices", value); }
        }
        static LandscapeProxy() {
            StaticClass = Main.GetClass("LandscapeProxy");
        }
        internal unsafe LandscapeProxy_fields* LandscapeProxy_ptr => (LandscapeProxy_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeProxy(IntPtr p) => UObject.Make<LandscapeProxy>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeProxy DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeProxy New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
