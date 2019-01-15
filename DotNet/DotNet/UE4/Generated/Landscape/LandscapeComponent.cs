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
    ///<summary>Landscape Component</summary>
    public unsafe partial class LandscapeComponent : PrimitiveComponent  {

        ///<summary>Gets the landscape material instance dynamic for this component</summary>
        public MaterialInstanceDynamic GetMaterialInstanceDynamic(int InIndex)  => 
            LandscapeComponent_methods.GetMaterialInstanceDynamic_method.Invoke(ObjPointer, InIndex);
        ///<summary>X offset from global components grid origin (in quads)</summary>
        public unsafe int SectionBaseX {
            get {return LandscapeComponent_ptr->SectionBaseX;}
        }
        ///<summary>Y offset from global components grid origin (in quads)</summary>
        public unsafe int SectionBaseY {
            get {return LandscapeComponent_ptr->SectionBaseY;}
        }
        ///<summary>Total number of quads for this component, has to be >0</summary>
        public unsafe int ComponentSizeQuads {
            get {return LandscapeComponent_ptr->ComponentSizeQuads;}
            set {LandscapeComponent_ptr->ComponentSizeQuads = value;}
        }
        ///<summary>Number of quads for a subsection of the component. SubsectionSizeQuads+1 must be a power of two.</summary>
        public unsafe int SubsectionSizeQuads {
            get {return LandscapeComponent_ptr->SubsectionSizeQuads;}
            set {LandscapeComponent_ptr->SubsectionSizeQuads = value;}
        }
        ///<summary>Number of subsections in X or Y axis</summary>
        public unsafe int NumSubsections {
            get {return LandscapeComponent_ptr->NumSubsections;}
            set {LandscapeComponent_ptr->NumSubsections = value;}
        }
        ///<summary>Override Material</summary>
        public unsafe MaterialInterface OverrideMaterial {
            get {return LandscapeComponent_ptr->OverrideMaterial;}
            set {LandscapeComponent_ptr->OverrideMaterial = value;}
        }
        ///<summary>Override Hole Material</summary>
        public unsafe MaterialInterface OverrideHoleMaterial {
            get {return LandscapeComponent_ptr->OverrideHoleMaterial;}
            set {LandscapeComponent_ptr->OverrideHoleMaterial = value;}
        }
        ///<summary>Material Instances</summary>
        public ObjectArrayField<MaterialInstanceConstant> MaterialInstances{ get {
            if(MaterialInstances_store == null) MaterialInstances_store = new ObjectArrayField<MaterialInstanceConstant> (&LandscapeComponent_ptr->MaterialInstances);
            return MaterialInstances_store;
        } }
        private ObjectArrayField<MaterialInstanceConstant> MaterialInstances_store;

        ///<summary>Material Instances Dynamic</summary>
        public ObjectArrayField<MaterialInstanceDynamic> MaterialInstancesDynamic{ get {
            if(MaterialInstancesDynamic_store == null) MaterialInstancesDynamic_store = new ObjectArrayField<MaterialInstanceDynamic> (&LandscapeComponent_ptr->MaterialInstancesDynamic);
            return MaterialInstancesDynamic_store;
        } }
        private ObjectArrayField<MaterialInstanceDynamic> MaterialInstancesDynamic_store;

         //TODO: array not UObject TArray WeightmapLayerAllocations
        ///<summary>Weightmap texture reference</summary>
        public ObjectArrayField<Texture2D> WeightmapTextures{ get {
            if(WeightmapTextures_store == null) WeightmapTextures_store = new ObjectArrayField<Texture2D> (&LandscapeComponent_ptr->WeightmapTextures);
            return WeightmapTextures_store;
        } }
        private ObjectArrayField<Texture2D> WeightmapTextures_store;

        ///<summary>XYOffsetmap texture reference</summary>
        public unsafe Texture2D XYOffsetmapTexture {
            get {return LandscapeComponent_ptr->XYOffsetmapTexture;}
            set {LandscapeComponent_ptr->XYOffsetmapTexture = value;}
        }
        ///<summary>UV offset to component's weightmap data from component local coordinates</summary>
        public unsafe Vector4 WeightmapScaleBias {
            get {return LandscapeComponent_ptr->WeightmapScaleBias;}
            set {LandscapeComponent_ptr->WeightmapScaleBias = value;}
        }
        ///<summary>U or V offset into the weightmap for the first subsection, in texture UV space</summary>
        public unsafe float WeightmapSubsectionOffset {
            get {return LandscapeComponent_ptr->WeightmapSubsectionOffset;}
            set {LandscapeComponent_ptr->WeightmapSubsectionOffset = value;}
        }
        ///<summary>UV offset to Heightmap data from component local coordinates</summary>
        public unsafe Vector4 HeightmapScaleBias {
            get {return LandscapeComponent_ptr->HeightmapScaleBias;}
            set {LandscapeComponent_ptr->HeightmapScaleBias = value;}
        }
        ///<summary>Heightmap texture reference</summary>
        public unsafe Texture2D HeightmapTexture {
            get {return LandscapeComponent_ptr->HeightmapTexture;}
            set {LandscapeComponent_ptr->HeightmapTexture = value;}
        }
        ///<summary>Cached local-space bounding box, created at heightmap update time</summary>
        public unsafe Box CachedLocalBox {
            get {return LandscapeComponent_ptr->CachedLocalBox;}
            set {LandscapeComponent_ptr->CachedLocalBox = value;}
        }
         //TODO: lazy object TLazyObjectPtr<ULandscapeHeightfieldCollisionComponent> CollisionComponent
        ///<summary>Unique ID for this component, used for caching during distributed lighting</summary>
        public unsafe FGuid LightingGuid {
            get {return LandscapeComponent_ptr->LightingGuid;}
            set {LandscapeComponent_ptr->LightingGuid = value;}
        }
        ///<summary>Uniquely identifies this component's built map data.</summary>
        public unsafe FGuid MapBuildDataId {
            get {return LandscapeComponent_ptr->MapBuildDataId;}
            set {LandscapeComponent_ptr->MapBuildDataId = value;}
        }
        ///<summary>Heightfield mipmap used to generate collision</summary>
        public unsafe int CollisionMipLevel {
            get {return LandscapeComponent_ptr->CollisionMipLevel;}
            set {LandscapeComponent_ptr->CollisionMipLevel = value;}
        }
        ///<summary>Heightfield mipmap used to generate simple collision</summary>
        public unsafe int SimpleCollisionMipLevel {
            get {return LandscapeComponent_ptr->SimpleCollisionMipLevel;}
            set {LandscapeComponent_ptr->SimpleCollisionMipLevel = value;}
        }
        ///<summary>Allows overriding the landscape bounds.</summary>
        ///<remarks>
        ///This is useful if you distort the landscape with world-position-offset, for example
        ///Extension value in the negative Z axis, positive value increases bound size
        ///</remarks>
        public unsafe float NegativeZBoundsExtension {
            get {return LandscapeComponent_ptr->NegativeZBoundsExtension;}
            set {LandscapeComponent_ptr->NegativeZBoundsExtension = value;}
        }
        ///<summary>Allows overriding the landscape bounds.</summary>
        ///<remarks>
        ///This is useful if you distort the landscape with world-position-offset, for example
        ///Extension value in the positive Z axis, positive value increases bound size
        ///</remarks>
        public unsafe float PositiveZBoundsExtension {
            get {return LandscapeComponent_ptr->PositiveZBoundsExtension;}
            set {LandscapeComponent_ptr->PositiveZBoundsExtension = value;}
        }
        ///<summary>StaticLightingResolution overriding per component, default value 0 means no overriding</summary>
        public unsafe float StaticLightingResolution {
            get {return LandscapeComponent_ptr->StaticLightingResolution;}
            set {LandscapeComponent_ptr->StaticLightingResolution = value;}
        }
        ///<summary>Forced LOD level to use when rendering</summary>
        public unsafe int ForcedLOD {
            get {return LandscapeComponent_ptr->ForcedLOD;}
        }
        ///<summary>LOD level Bias to use when rendering</summary>
        public unsafe int LODBias {
            get {return LandscapeComponent_ptr->LODBias;}
        }
        ///<summary>State Id</summary>
        public unsafe FGuid StateId {
            get {return LandscapeComponent_ptr->StateId;}
            set {LandscapeComponent_ptr->StateId = value;}
        }
        ///<summary>The Material Guid that used when baking, to detect material recompilations</summary>
        public unsafe FGuid BakedTextureMaterialGuid {
            get {return LandscapeComponent_ptr->BakedTextureMaterialGuid;}
            set {LandscapeComponent_ptr->BakedTextureMaterialGuid = value;}
        }
        ///<summary>Pre-baked Base Color texture for use by distance field GI</summary>
        public unsafe Texture2D GIBakedBaseColorTexture {
            get {return LandscapeComponent_ptr->GIBakedBaseColorTexture;}
        }
        ///<summary>LOD level Bias to use when lighting buidling via lightmass, -1 Means automatic LOD calculation based on ForcedLOD + LODBias</summary>
        public unsafe int LightingLODBias {
            get {return LandscapeComponent_ptr->LightingLODBias;}
            set {LandscapeComponent_ptr->LightingLODBias = value;}
        }
        ///<summary>List of layers allowed to be painted on this component</summary>
        public ObjectArrayField<LandscapeLayerInfoObject> LayerWhitelist{ get {
            if(LayerWhitelist_store == null) LayerWhitelist_store = new ObjectArrayField<LandscapeLayerInfoObject> (&LandscapeComponent_ptr->LayerWhitelist);
            return LayerWhitelist_store;
        } }
        private ObjectArrayField<LandscapeLayerInfoObject> LayerWhitelist_store;

        ///<summary>Pointer to data shared with the render thread, used by the editor tools</summary>
        public unsafe LandscapeEditToolRenderData EditToolRenderData {
            get {return LandscapeComponent_ptr->EditToolRenderData;}
            set {LandscapeComponent_ptr->EditToolRenderData = value;}
        }
        ///<summary>Hash of source for ES2 generated data. Used determine if we need to re-generate ES2 pixel data.</summary>
        public unsafe FGuid MobileDataSourceHash {
            get {return LandscapeComponent_ptr->MobileDataSourceHash;}
            set {LandscapeComponent_ptr->MobileDataSourceHash = value;}
        }
        ///<summary>For ES2</summary>
        public unsafe byte MobileBlendableLayerMask {
            get {return LandscapeComponent_ptr->MobileBlendableLayerMask;}
            set {LandscapeComponent_ptr->MobileBlendableLayerMask = value;}
        }
        ///<summary>Material interface used for ES2. Serialized only when cooking or loading cooked builds.</summary>
        public unsafe MaterialInterface MobileMaterialInterface {
            get {return LandscapeComponent_ptr->MobileMaterialInterface;}
            set {LandscapeComponent_ptr->MobileMaterialInterface = value;}
        }
        ///<summary>Generated weightmap textures used for ES2.</summary>
        ///<remarks>
        ///The first entry is also used for the normal map.
        ///Serialized only when cooking or loading cooked builds.
        ///</remarks>
        public ObjectArrayField<Texture2D> MobileWeightmapTextures{ get {
            if(MobileWeightmapTextures_store == null) MobileWeightmapTextures_store = new ObjectArrayField<Texture2D> (&LandscapeComponent_ptr->MobileWeightmapTextures);
            return MobileWeightmapTextures_store;
        } }
        private ObjectArrayField<Texture2D> MobileWeightmapTextures_store;

        ///<summary>The editor needs to save out the combination MIC we'll use for mobile,</summary>
        ///<remarks>because we cannot generate it at runtime for standalone PIE games</remarks>
        public unsafe MaterialInstanceConstant MobileCombinationMaterialInstance {
            get {return LandscapeComponent_ptr->MobileCombinationMaterialInstance;}
            set {LandscapeComponent_ptr->MobileCombinationMaterialInstance = value;}
        }
        static LandscapeComponent() {
            StaticClass = Main.GetClass("LandscapeComponent");
        }
        internal unsafe LandscapeComponent_fields* LandscapeComponent_ptr => (LandscapeComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeComponent(IntPtr p) => UObject.Make<LandscapeComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
