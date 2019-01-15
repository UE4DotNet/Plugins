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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>A Material is an asset which can be applied to a mesh to control the visual look of the scene.</summary>
    ///<remarks>
    ///When light from the scene hits the surface, the shading model of the material is used to calculate how that light interacts with the surface.
    ///
    ///Warning: Creating new materials directly increases shader compile times!  Consider creating a Material Instance off of an existing material instead.
    ///</remarks>
    public unsafe partial class Material : MaterialInterface  {
        ///<summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
        public unsafe PhysicalMaterial PhysMaterial {
            get {return Material_ptr->PhysMaterial;}
            set {Material_ptr->PhysMaterial = value;}
        }
        ///<summary>Base Color</summary>
        public unsafe ColorMaterialInput BaseColor {
            get {return Material_ptr->BaseColor;}
            set {Material_ptr->BaseColor = value;}
        }
        ///<summary>Metallic</summary>
        public unsafe ScalarMaterialInput Metallic {
            get {return Material_ptr->Metallic;}
            set {Material_ptr->Metallic = value;}
        }
        ///<summary>Specular</summary>
        public unsafe ScalarMaterialInput Specular {
            get {return Material_ptr->Specular;}
            set {Material_ptr->Specular = value;}
        }
        ///<summary>Roughness</summary>
        public unsafe ScalarMaterialInput Roughness {
            get {return Material_ptr->Roughness;}
            set {Material_ptr->Roughness = value;}
        }
        ///<summary>Normal</summary>
        public unsafe VectorMaterialInput Normal {
            get {return Material_ptr->Normal;}
            set {Material_ptr->Normal = value;}
        }
        ///<summary>Emission.</summary>
        public unsafe ColorMaterialInput EmissiveColor {
            get {return Material_ptr->EmissiveColor;}
            set {Material_ptr->EmissiveColor = value;}
        }
        ///<summary>Transmission.</summary>
        public unsafe ScalarMaterialInput Opacity {
            get {return Material_ptr->Opacity;}
            set {Material_ptr->Opacity = value;}
        }
        ///<summary>Opacity Mask</summary>
        public unsafe ScalarMaterialInput OpacityMask {
            get {return Material_ptr->OpacityMask;}
            set {Material_ptr->OpacityMask = value;}
        }
        ///<summary>The domain that the material's attributes will be evaluated in.</summary>
        ///<remarks>Certain pieces of material functionality are only valid in certain domains, for example vertex normal is only valid on a surface.</remarks>
        public unsafe byte MaterialDomain {
            get {return Material_ptr->MaterialDomain;}
        }
        ///<summary>Determines how the material's color is blended with background colors.</summary>
        public unsafe byte BlendMode {
            get {return Material_ptr->BlendMode;}
        }
        ///<summary>Defines how the GBuffer chanels are getting manipulated by a decal material pass. (only with MaterialDomain == MD_DeferredDecal)</summary>
        public unsafe byte DecalBlendMode {
            get {return Material_ptr->DecalBlendMode;}
            set {Material_ptr->DecalBlendMode = value;}
        }
        ///<summary>Defines how the material reacts on DBuffer decals (Affects look, performance and texture/sample usage).</summary>
        ///<remarks>Non DBuffer Decals can be disabled on the primitive (e.g. static mesh)</remarks>
        public unsafe byte MaterialDecalResponse {
            get {return Material_ptr->MaterialDecalResponse;}
        }
        ///<summary>Determines how inputs are combined to create the material's final color.</summary>
        public unsafe byte ShadingModel {
            get {return Material_ptr->ShadingModel;}
            set {Material_ptr->ShadingModel = value;}
        }
        ///<summary>If BlendMode is BLEND_Masked, the surface is not rendered where OpacityMask < OpacityMaskClipValue.</summary>
        public unsafe float OpacityMaskClipValue {
            get {return Material_ptr->OpacityMaskClipValue;}
            set {Material_ptr->OpacityMaskClipValue = value;}
        }
        public bool bCastDynamicShadowAsMasked {
            get {return Main.GetGetBoolPropertyByName(this, "bCastDynamicShadowAsMasked"); }
            set {Main.SetGetBoolPropertyByName(this, "bCastDynamicShadowAsMasked", value); }
        }
        ///<summary>Adds to world position in the vertex shader.</summary>
        public unsafe VectorMaterialInput WorldPositionOffset {
            get {return Material_ptr->WorldPositionOffset;}
            set {Material_ptr->WorldPositionOffset = value;}
        }
        ///<summary>Offset in world space applied to tessellated vertices.</summary>
        public unsafe VectorMaterialInput WorldDisplacement {
            get {return Material_ptr->WorldDisplacement;}
            set {Material_ptr->WorldDisplacement = value;}
        }
        ///<summary>Multiplies the tessellation factors applied when a tessellation mode is set.</summary>
        public unsafe ScalarMaterialInput TessellationMultiplier {
            get {return Material_ptr->TessellationMultiplier;}
            set {Material_ptr->TessellationMultiplier = value;}
        }
        ///<summary>Inner material color, only used for ShadingModel=Subsurface</summary>
        public unsafe ColorMaterialInput SubsurfaceColor {
            get {return Material_ptr->SubsurfaceColor;}
            set {Material_ptr->SubsurfaceColor = value;}
        }
        ///<summary>Clear Coat</summary>
        public unsafe ScalarMaterialInput ClearCoat {
            get {return Material_ptr->ClearCoat;}
            set {Material_ptr->ClearCoat = value;}
        }
        ///<summary>Clear Coat Roughness</summary>
        public unsafe ScalarMaterialInput ClearCoatRoughness {
            get {return Material_ptr->ClearCoatRoughness;}
            set {Material_ptr->ClearCoatRoughness = value;}
        }
        ///<summary>output ambient occlusion to the GBuffer</summary>
        public unsafe ScalarMaterialInput AmbientOcclusion {
            get {return Material_ptr->AmbientOcclusion;}
            set {Material_ptr->AmbientOcclusion = value;}
        }
        ///<summary>
        ///output refraction index for translucent rendering
        ///Air:1.
        ///</summary>
        ///<remarks>0 Water:1.333 Ice:1.3 Glass:~1.6 Diamond:2.42</remarks>
        public unsafe ScalarMaterialInput Refraction {
            get {return Material_ptr->Refraction;}
            set {Material_ptr->Refraction = value;}
        }
        ///<summary>These inputs are evaluated in the vertex shader and allow artists to do arbitrary vertex shader operations and access them in the pixel shader.</summary>
        ///<remarks>When unconnected or hidden they default to passing through the vertex UVs.</remarks>
        public unsafe Vector2MaterialInput CustomizedUVs {
            get {return Material_ptr->CustomizedUVs;}
            set {Material_ptr->CustomizedUVs = value;}
        }
        ///<summary>Material Attributes</summary>
        public unsafe MaterialAttributesInput MaterialAttributes {
            get {return Material_ptr->MaterialAttributes;}
            set {Material_ptr->MaterialAttributes = value;}
        }
        ///<summary>Pixel Depth Offset</summary>
        public unsafe ScalarMaterialInput PixelDepthOffset {
            get {return Material_ptr->PixelDepthOffset;}
            set {Material_ptr->PixelDepthOffset = value;}
        }
        public bool bEnableSeparateTranslucency {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSeparateTranslucency"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableSeparateTranslucency", value); }
        }
        public bool bEnableMobileSeparateTranslucency {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMobileSeparateTranslucency"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMobileSeparateTranslucency", value); }
        }
        public bool bEnableResponsiveAA {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableResponsiveAA"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableResponsiveAA", value); }
        }
        public bool bScreenSpaceReflections {
            get {return Main.GetGetBoolPropertyByName(this, "bScreenSpaceReflections"); }
            set {Main.SetGetBoolPropertyByName(this, "bScreenSpaceReflections", value); }
        }
        public bool bContactShadows {
            get {return Main.GetGetBoolPropertyByName(this, "bContactShadows"); }
            set {Main.SetGetBoolPropertyByName(this, "bContactShadows", value); }
        }
        public bool TwoSided {
            get {return Main.GetGetBoolPropertyByName(this, "TwoSided"); }
            set {Main.SetGetBoolPropertyByName(this, "TwoSided", value); }
        }
        public bool DitheredLODTransition {
            get {return Main.GetGetBoolPropertyByName(this, "DitheredLODTransition"); }
            set {Main.SetGetBoolPropertyByName(this, "DitheredLODTransition", value); }
        }
        public bool DitherOpacityMask {
            get {return Main.GetGetBoolPropertyByName(this, "DitherOpacityMask"); }
            set {Main.SetGetBoolPropertyByName(this, "DitherOpacityMask", value); }
        }
        public bool bAllowNegativeEmissiveColor {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowNegativeEmissiveColor"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowNegativeEmissiveColor", value); }
        }
        ///<summary>Number of customized UV inputs to display.  Unconnected customized UV inputs will just pass through the vertex UVs.</summary>
        public unsafe int NumCustomizedUVs {
            get {return Material_ptr->NumCustomizedUVs;}
            set {Material_ptr->NumCustomizedUVs = value;}
        }
        ///<summary>Sets the lighting mode that will be used on this material if it is translucent.</summary>
        public unsafe byte TranslucencyLightingMode {
            get {return Material_ptr->TranslucencyLightingMode;}
            set {Material_ptr->TranslucencyLightingMode = value;}
        }
        ///<summary>Useful for artificially increasing the influence of the normal on the lighting result for translucency.</summary>
        ///<remarks>A value larger than 1 increases the influence of the normal, a value smaller than 1 makes the lighting more ambient.</remarks>
        public unsafe float TranslucencyDirectionalLightingIntensity {
            get {return Material_ptr->TranslucencyDirectionalLightingIntensity;}
            set {Material_ptr->TranslucencyDirectionalLightingIntensity = value;}
        }
        public bool AllowTranslucentCustomDepthWrites {
            get {return Main.GetGetBoolPropertyByName(this, "AllowTranslucentCustomDepthWrites"); }
            set {Main.SetGetBoolPropertyByName(this, "AllowTranslucentCustomDepthWrites", value); }
        }
        ///<summary>Scale used to make translucent shadows more or less opaque than the material's actual opacity.</summary>
        public unsafe float TranslucentShadowDensityScale {
            get {return Material_ptr->TranslucentShadowDensityScale;}
            set {Material_ptr->TranslucentShadowDensityScale = value;}
        }
        ///<summary>Scale used to make translucent self-shadowing more or less opaque than the material's shadow on other objects.</summary>
        ///<remarks>This is only used when the object is casting a volumetric translucent shadow.</remarks>
        public unsafe float TranslucentSelfShadowDensityScale {
            get {return Material_ptr->TranslucentSelfShadowDensityScale;}
            set {Material_ptr->TranslucentSelfShadowDensityScale = value;}
        }
        ///<summary>Used to make a second self shadow gradient, to add interesting shading in the shadow of the first.</summary>
        public unsafe float TranslucentSelfShadowSecondDensityScale {
            get {return Material_ptr->TranslucentSelfShadowSecondDensityScale;}
            set {Material_ptr->TranslucentSelfShadowSecondDensityScale = value;}
        }
        ///<summary>Controls the strength of the second self shadow gradient.</summary>
        public unsafe float TranslucentSelfShadowSecondOpacity {
            get {return Material_ptr->TranslucentSelfShadowSecondOpacity;}
            set {Material_ptr->TranslucentSelfShadowSecondOpacity = value;}
        }
        ///<summary>Controls how diffuse the material's backscattering is when using the MSM_Subsurface shading model.</summary>
        ///<remarks>
        ///Larger exponents give a less diffuse look (smaller, brighter backscattering highlight).
        ///This is only used when the object is casting a volumetric translucent shadow from a directional light.
        ///</remarks>
        public unsafe float TranslucentBackscatteringExponent {
            get {return Material_ptr->TranslucentBackscatteringExponent;}
            set {Material_ptr->TranslucentBackscatteringExponent = value;}
        }
        ///<summary>Colored extinction factor used to approximate multiple scattering in dense volumes.</summary>
        ///<remarks>This is only used when the object is casting a volumetric translucent shadow.</remarks>
        public unsafe LinearColor TranslucentMultipleScatteringExtinction {
            get {return Material_ptr->TranslucentMultipleScatteringExtinction;}
            set {Material_ptr->TranslucentMultipleScatteringExtinction = value;}
        }
        ///<summary>Local space distance to bias the translucent shadow.  Positive values move the shadow away from the light.</summary>
        public unsafe float TranslucentShadowStartOffset {
            get {return Material_ptr->TranslucentShadowStartOffset;}
            set {Material_ptr->TranslucentShadowStartOffset = value;}
        }
        public bool bDisableDepthTest {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableDepthTest"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableDepthTest", value); }
        }
        public bool bWriteOnlyAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "bWriteOnlyAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "bWriteOnlyAlpha", value); }
        }
        public bool bGenerateSphericalParticleNormals {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateSphericalParticleNormals"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateSphericalParticleNormals", value); }
        }
        public bool bTangentSpaceNormal {
            get {return Main.GetGetBoolPropertyByName(this, "bTangentSpaceNormal"); }
            set {Main.SetGetBoolPropertyByName(this, "bTangentSpaceNormal", value); }
        }
        public bool bUseEmissiveForDynamicAreaLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bUseEmissiveForDynamicAreaLighting"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseEmissiveForDynamicAreaLighting", value); }
        }
        public bool bBlockGI {
            get {return Main.GetGetBoolPropertyByName(this, "bBlockGI"); }
            set {Main.SetGetBoolPropertyByName(this, "bBlockGI", value); }
        }
        public bool bUsedAsSpecialEngineMaterial {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedAsSpecialEngineMaterial"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsedAsSpecialEngineMaterial", value); }
        }
        public bool bUsedWithSkeletalMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithSkeletalMesh"); }
        }
        public bool bUsedWithEditorCompositing {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithEditorCompositing"); }
        }
        public bool bUsedWithParticleSprites {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithParticleSprites"); }
        }
        public bool bUsedWithBeamTrails {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithBeamTrails"); }
        }
        public bool bUsedWithMeshParticles {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithMeshParticles"); }
        }
        public bool bUsedWithNiagaraSprites {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithNiagaraSprites"); }
        }
        public bool bUsedWithNiagaraRibbons {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithNiagaraRibbons"); }
        }
        public bool bUsedWithNiagaraMeshParticles {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithNiagaraMeshParticles"); }
        }
        public bool bUsedWithGeometryCache {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithGeometryCache"); }
        }
        public bool bUsedWithStaticLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithStaticLighting"); }
        }
        public bool bUsedWithMorphTargets {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithMorphTargets"); }
        }
        public bool bUsedWithSplineMeshes {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithSplineMeshes"); }
        }
        public bool bUsedWithInstancedStaticMeshes {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithInstancedStaticMeshes"); }
        }
        public bool bUsesDistortion {
            get {return Main.GetGetBoolPropertyByName(this, "bUsesDistortion"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsesDistortion", value); }
        }
        public bool bUsedWithClothing {
            get {return Main.GetGetBoolPropertyByName(this, "bUsedWithClothing"); }
        }
        public bool bAutomaticallySetUsageInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bAutomaticallySetUsageInEditor"); }
        }
        public bool bFullyRough {
            get {return Main.GetGetBoolPropertyByName(this, "bFullyRough"); }
        }
        public bool bUseFullPrecision {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFullPrecision"); }
        }
        public bool bUseLightmapDirectionality {
            get {return Main.GetGetBoolPropertyByName(this, "bUseLightmapDirectionality"); }
        }
        public bool bUseHQForwardReflections {
            get {return Main.GetGetBoolPropertyByName(this, "bUseHQForwardReflections"); }
        }
        public bool bUsePlanarForwardReflections {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePlanarForwardReflections"); }
        }
        public bool bNormalCurvatureToRoughness {
            get {return Main.GetGetBoolPropertyByName(this, "bNormalCurvatureToRoughness"); }
        }
        ///<summary>The type of tessellation to apply to this object.  Note D3D11 required for anything except MTM_NoTessellation.</summary>
        public unsafe byte D3D11TessellationMode {
            get {return Material_ptr->D3D11TessellationMode;}
        }
        public bool bEnableCrackFreeDisplacement {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableCrackFreeDisplacement"); }
        }
        public bool bEnableAdaptiveTessellation {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableAdaptiveTessellation"); }
        }
        ///<summary>Max Displacement</summary>
        public unsafe float MaxDisplacement {
            get {return Material_ptr->MaxDisplacement;}
            set {Material_ptr->MaxDisplacement = value;}
        }
        public bool Wireframe {
            get {return Main.GetGetBoolPropertyByName(this, "Wireframe"); }
            set {Main.SetGetBoolPropertyByName(this, "Wireframe", value); }
        }
        public bool bOutputVelocityOnBasePass {
            get {return Main.GetGetBoolPropertyByName(this, "bOutputVelocityOnBasePass"); }
            set {Main.SetGetBoolPropertyByName(this, "bOutputVelocityOnBasePass", value); }
        }
        ///<summary>Editor X</summary>
        public unsafe int EditorX {
            get {return Material_ptr->EditorX;}
            set {Material_ptr->EditorX = value;}
        }
        ///<summary>Editor Y</summary>
        public unsafe int EditorY {
            get {return Material_ptr->EditorY;}
            set {Material_ptr->EditorY = value;}
        }
        ///<summary>Editor Pitch</summary>
        public unsafe int EditorPitch {
            get {return Material_ptr->EditorPitch;}
            set {Material_ptr->EditorPitch = value;}
        }
        ///<summary>Editor Yaw</summary>
        public unsafe int EditorYaw {
            get {return Material_ptr->EditorYaw;}
            set {Material_ptr->EditorYaw = value;}
        }
        ///<summary>Array of material expressions, excluding Comments.  Used by the material editor.</summary>
        public ObjectArrayField<MaterialExpression> Expressions{ get {
            if(Expressions_store == null) Expressions_store = new ObjectArrayField<MaterialExpression> (&Material_ptr->Expressions);
            return Expressions_store;
        } }
        private ObjectArrayField<MaterialExpression> Expressions_store;

        ///<summary>Array of comments associated with this material; viewed in the material editor.</summary>
        public ObjectArrayField<MaterialExpressionComment> EditorComments{ get {
            if(EditorComments_store == null) EditorComments_store = new ObjectArrayField<MaterialExpressionComment> (&Material_ptr->EditorComments);
            return EditorComments_store;
        } }
        private ObjectArrayField<MaterialExpressionComment> EditorComments_store;

         //TODO: array not UObject TArray ParameterGroupData
         //TODO: array not UObject TArray MaterialFunctionInfos
         //TODO: array not UObject TArray MaterialParameterCollectionInfos
        public bool bCanMaskedBeAssumedOpaque {
            get {return Main.GetGetBoolPropertyByName(this, "bCanMaskedBeAssumedOpaque"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanMaskedBeAssumedOpaque", value); }
        }
        public bool bIsPreviewMaterial {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPreviewMaterial"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPreviewMaterial", value); }
        }
        public bool bIsFunctionPreviewMaterial {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFunctionPreviewMaterial"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsFunctionPreviewMaterial", value); }
        }
        public bool bUseMaterialAttributes {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMaterialAttributes"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMaterialAttributes", value); }
        }
        public bool bUseTranslucencyVertexFog {
            get {return Main.GetGetBoolPropertyByName(this, "bUseTranslucencyVertexFog"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseTranslucencyVertexFog", value); }
        }
        public bool bComputeFogPerPixel {
            get {return Main.GetGetBoolPropertyByName(this, "bComputeFogPerPixel"); }
            set {Main.SetGetBoolPropertyByName(this, "bComputeFogPerPixel", value); }
        }
        public bool bAllowDevelopmentShaderCompile {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowDevelopmentShaderCompile"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowDevelopmentShaderCompile", value); }
        }
        public bool bIsMaterialEditorStatsMaterial {
            get {return Main.GetGetBoolPropertyByName(this, "bIsMaterialEditorStatsMaterial"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsMaterialEditorStatsMaterial", value); }
        }
         //TODO: numeric uint32 UsageFlagWarnings
        ///<summary>Where the node is inserted in the (post processing) graph, only used if domain is PostProcess</summary>
        public unsafe byte BlendableLocation {
            get {return Material_ptr->BlendableLocation;}
            set {Material_ptr->BlendableLocation = value;}
        }
        ///<summary>If multiple nodes with the same  type are inserted at the same point, this defined order and if they get combined, only used if domain is PostProcess</summary>
        public unsafe int BlendablePriority {
            get {return Material_ptr->BlendablePriority;}
            set {Material_ptr->BlendablePriority = value;}
        }
        public bool BlendableOutputAlpha {
            get {return Main.GetGetBoolPropertyByName(this, "BlendableOutputAlpha"); }
            set {Main.SetGetBoolPropertyByName(this, "BlendableOutputAlpha", value); }
        }
        ///<summary>Controls how the Refraction input is interpreted and how the refraction offset into scene color is computed for this material.</summary>
        public unsafe byte RefractionMode {
            get {return Material_ptr->RefractionMode;}
            set {Material_ptr->RefractionMode = value;}
        }
        ///<summary>This is the refraction depth bias, larger values offset distortion to prevent closer objects from rendering into the distorted surface at acute viewing angles but increases the disconnect between surface and where the refraction starts.</summary>
        public unsafe float RefractionDepthBias {
            get {return Material_ptr->RefractionDepthBias;}
            set {Material_ptr->RefractionDepthBias = value;}
        }
        ///<summary>Guid that uniquely identifies this material.</summary>
        ///<remarks>
        ///Any changes to the state of the material that do not appear separately in the shadermap DDC keys must cause this guid to be regenerated!
        ///For example, a modification to the Expressions array.
        ///Code changes that cause the guid to be regenerated on load should be avoided, as that requires a resave of the content to stop recompiling every load.
        ///</remarks>
        public unsafe FGuid StateId {
            get {return Material_ptr->StateId;}
            set {Material_ptr->StateId = value;}
        }
         //TODO: array not UObject TArray CachedQualityLevelsUsed
        ///<summary>Cached texture references from all expressions in the material (including nested functions).</summary>
        ///<remarks>This is used to link uniform texture expressions which were stored in the DDC with the UTextures that they reference.</remarks>
        public ObjectArrayField<Texture> ExpressionTextureReferences{ get {
            if(ExpressionTextureReferences_store == null) ExpressionTextureReferences_store = new ObjectArrayField<Texture> (&Material_ptr->ExpressionTextureReferences);
            return ExpressionTextureReferences_store;
        } }
        private ObjectArrayField<Texture> ExpressionTextureReferences_store;

         //TODO: array not UObject TArray ReferencedTextureGuids
        static Material() {
            StaticClass = Main.GetClass("Material");
        }
        internal unsafe Material_fields* Material_ptr => (Material_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Material(IntPtr p) => UObject.Make<Material>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Material DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Material New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
