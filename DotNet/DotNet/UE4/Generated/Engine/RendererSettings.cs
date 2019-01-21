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
    ///<summary>Rendering settings.</summary>
    public unsafe partial class RendererSettings : DeveloperSettings  {
        public bool bMobileHDR {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileHDR"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileHDR", value); }
        }
        public bool bMobileDisableVertexFog {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileDisableVertexFog"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileDisableVertexFog", value); }
        }
        ///<summary>The maximum number of cascades with which to render dynamic directional light shadows when using the mobile renderer.</summary>
        public unsafe int MaxMobileCascades {
            get {return RendererSettings_ptr->MaxMobileCascades;}
            set {RendererSettings_ptr->MaxMobileCascades = value;}
        }
        ///<summary>Multi-sample anti-aliasing setting to use on mobile.</summary>
        ///<remarks>
        ///MSAA is currently supported using Metal on iOS, and on Android devices with the required support using ES 2 or ES 3.1.
        ///If MSAA is not available, the current default AA method will be used.
        ///</remarks>
        public unsafe byte MobileMSAASampleCount {
            get {return RendererSettings_ptr->MobileMSAASampleCount;}
            set {RendererSettings_ptr->MobileMSAASampleCount = value;}
        }
        public bool bMobileUseLegacyShadingModel {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileUseLegacyShadingModel"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileUseLegacyShadingModel", value); }
        }
        public bool bMobileAllowDitheredLODTransition {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileAllowDitheredLODTransition"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileAllowDitheredLODTransition", value); }
        }
        public bool bMobileAllowSoftwareOcclusionCulling {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileAllowSoftwareOcclusionCulling"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileAllowSoftwareOcclusionCulling", value); }
        }
        public bool bDiscardUnusedQualityLevels {
            get {return Main.GetGetBoolPropertyByName(this, "bDiscardUnusedQualityLevels"); }
            set {Main.SetGetBoolPropertyByName(this, "bDiscardUnusedQualityLevels", value); }
        }
        public bool bOcclusionCulling {
            get {return Main.GetGetBoolPropertyByName(this, "bOcclusionCulling"); }
            set {Main.SetGetBoolPropertyByName(this, "bOcclusionCulling", value); }
        }
        ///<summary>Screen radius at which lights are culled. Larger values can improve performance but causes lights to pop off when they affect a small area of the screen.</summary>
        public unsafe float MinScreenRadiusForLights {
            get {return RendererSettings_ptr->MinScreenRadiusForLights;}
            set {RendererSettings_ptr->MinScreenRadiusForLights = value;}
        }
        ///<summary>Screen radius at which objects are culled for the early Z pass. Larger values can improve performance but very large values can degrade performance if large occluders are not rendered.</summary>
        public unsafe float MinScreenRadiusForEarlyZPass {
            get {return RendererSettings_ptr->MinScreenRadiusForEarlyZPass;}
            set {RendererSettings_ptr->MinScreenRadiusForEarlyZPass = value;}
        }
        ///<summary>Screen radius at which objects are culled for cascaded shadow map depth passes. Larger values can improve performance but can cause artifacts as objects stop casting shadows.</summary>
        public unsafe float MinScreenRadiusForCSMdepth {
            get {return RendererSettings_ptr->MinScreenRadiusForCSMdepth;}
            set {RendererSettings_ptr->MinScreenRadiusForCSMdepth = value;}
        }
        public bool bPrecomputedVisibilityWarning {
            get {return Main.GetGetBoolPropertyByName(this, "bPrecomputedVisibilityWarning"); }
            set {Main.SetGetBoolPropertyByName(this, "bPrecomputedVisibilityWarning", value); }
        }
        public bool bTextureStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "bTextureStreaming"); }
            set {Main.SetGetBoolPropertyByName(this, "bTextureStreaming", value); }
        }
        public bool bUseDXT5NormalMaps {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDXT5NormalMaps"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDXT5NormalMaps", value); }
        }
        public bool bClearCoatEnableSecondNormal {
            get {return Main.GetGetBoolPropertyByName(this, "bClearCoatEnableSecondNormal"); }
            set {Main.SetGetBoolPropertyByName(this, "bClearCoatEnableSecondNormal", value); }
        }
        ///<summary>The cubemap resolution for all reflection capture probes. Must be power of 2. Note that for very high values the memory and performance impact may be severe.</summary>
        public unsafe int ReflectionCaptureResolution {
            get {return RendererSettings_ptr->ReflectionCaptureResolution;}
            set {RendererSettings_ptr->ReflectionCaptureResolution = value;}
        }
        public bool ReflectionEnvironmentLightmapMixBasedOnRoughness {
            get {return Main.GetGetBoolPropertyByName(this, "ReflectionEnvironmentLightmapMixBasedOnRoughness"); }
            set {Main.SetGetBoolPropertyByName(this, "ReflectionEnvironmentLightmapMixBasedOnRoughness", value); }
        }
        public bool bForwardShading {
            get {return Main.GetGetBoolPropertyByName(this, "bForwardShading"); }
            set {Main.SetGetBoolPropertyByName(this, "bForwardShading", value); }
        }
        public bool bVertexFoggingForOpaque {
            get {return Main.GetGetBoolPropertyByName(this, "bVertexFoggingForOpaque"); }
            set {Main.SetGetBoolPropertyByName(this, "bVertexFoggingForOpaque", value); }
        }
        public bool bAllowStaticLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowStaticLighting"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowStaticLighting", value); }
        }
        public bool bUseNormalMapsForStaticLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bUseNormalMapsForStaticLighting"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseNormalMapsForStaticLighting", value); }
        }
        public bool bGenerateMeshDistanceFields {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateMeshDistanceFields"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateMeshDistanceFields", value); }
        }
        public bool bEightBitMeshDistanceFields {
            get {return Main.GetGetBoolPropertyByName(this, "bEightBitMeshDistanceFields"); }
            set {Main.SetGetBoolPropertyByName(this, "bEightBitMeshDistanceFields", value); }
        }
        public bool bGenerateLandscapeGIData {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateLandscapeGIData"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateLandscapeGIData", value); }
        }
        public bool bCompressMeshDistanceFields {
            get {return Main.GetGetBoolPropertyByName(this, "bCompressMeshDistanceFields"); }
            set {Main.SetGetBoolPropertyByName(this, "bCompressMeshDistanceFields", value); }
        }
        ///<summary>When adaptive tessellation is enabled it will try to tessellate a mesh so that each triangle contains the specified number of pixels. The tessellation multiplier specified in the material can increase or decrease the amount of tessellation.</summary>
        public unsafe float TessellationAdaptivePixelsPerTriangle {
            get {return RendererSettings_ptr->TessellationAdaptivePixelsPerTriangle;}
            set {RendererSettings_ptr->TessellationAdaptivePixelsPerTriangle = value;}
        }
        public bool bSeparateTranslucency {
            get {return Main.GetGetBoolPropertyByName(this, "bSeparateTranslucency"); }
            set {Main.SetGetBoolPropertyByName(this, "bSeparateTranslucency", value); }
        }
        ///<summary>The sort mode for translucent primitives, affecting how they are ordered and how they change order as the camera moves. Requires that Separate Translucency (under Postprocessing) is true.</summary>
        public unsafe byte TranslucentSortPolicy {
            get {return RendererSettings_ptr->TranslucentSortPolicy;}
            set {RendererSettings_ptr->TranslucentSortPolicy = value;}
        }
        ///<summary>The axis that sorting will occur along when Translucent Sort Policy is set to SortAlongAxis.</summary>
        public unsafe Vector TranslucentSortAxis {
            get {return RendererSettings_ptr->TranslucentSortAxis;}
            set {RendererSettings_ptr->TranslucentSortAxis = value;}
        }
        ///<summary>Whether the custom depth pass for tagging primitives for postprocessing passes is enabled. Enabling it on demand can save memory but may cause a hitch the first time the feature is used.</summary>
        public unsafe byte CustomDepthStencil {
            get {return RendererSettings_ptr->CustomDepthStencil;}
            set {RendererSettings_ptr->CustomDepthStencil = value;}
        }
        public bool bCustomDepthTaaJitter {
            get {return Main.GetGetBoolPropertyByName(this, "bCustomDepthTaaJitter"); }
            set {Main.SetGetBoolPropertyByName(this, "bCustomDepthTaaJitter", value); }
        }
        ///<summary>Configures alpha channel support in renderer's post processing chain. Still experimental: works only with Temporal AA, Motion Blur, Circle Depth Of Field. This option also force disable the separate translucency.</summary>
        public unsafe byte bEnableAlphaChannelInPostProcessing {
            get {return RendererSettings_ptr->bEnableAlphaChannelInPostProcessing;}
            set {RendererSettings_ptr->bEnableAlphaChannelInPostProcessing = value;}
        }
        public bool bUseNewAlgorithm {
            get {return Main.GetGetBoolPropertyByName(this, "bUseNewAlgorithm"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseNewAlgorithm", value); }
        }
        public bool bDefaultFeatureBloom {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultFeatureBloom"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultFeatureBloom", value); }
        }
        public bool bDefaultFeatureAmbientOcclusion {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultFeatureAmbientOcclusion"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultFeatureAmbientOcclusion", value); }
        }
        public bool bDefaultFeatureAmbientOcclusionStaticFraction {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultFeatureAmbientOcclusionStaticFraction"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultFeatureAmbientOcclusionStaticFraction", value); }
        }
        public bool bDefaultFeatureAutoExposure {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultFeatureAutoExposure"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultFeatureAutoExposure", value); }
        }
        ///<summary>The default method for AutoExposure(postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
        public unsafe byte DefaultFeatureAutoExposure {
            get {return RendererSettings_ptr->DefaultFeatureAutoExposure;}
            set {RendererSettings_ptr->DefaultFeatureAutoExposure = value;}
        }
        public bool bExtendDefaultLuminanceRangeInAutoExposureSettings {
            get {return Main.GetGetBoolPropertyByName(this, "bExtendDefaultLuminanceRangeInAutoExposureSettings"); }
            set {Main.SetGetBoolPropertyByName(this, "bExtendDefaultLuminanceRangeInAutoExposureSettings", value); }
        }
        public bool bUsePreExposure {
            get {return Main.GetGetBoolPropertyByName(this, "bUsePreExposure"); }
            set {Main.SetGetBoolPropertyByName(this, "bUsePreExposure", value); }
        }
        public bool bDefaultFeatureMotionBlur {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultFeatureMotionBlur"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultFeatureMotionBlur", value); }
        }
        public bool bDefaultFeatureLensFlare {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultFeatureLensFlare"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultFeatureLensFlare", value); }
        }
        public bool bTemporalUpsampling {
            get {return Main.GetGetBoolPropertyByName(this, "bTemporalUpsampling"); }
            set {Main.SetGetBoolPropertyByName(this, "bTemporalUpsampling", value); }
        }
        ///<summary>Which anti-aliasing mode is used by default</summary>
        public unsafe byte DefaultFeatureAntiAliasing {
            get {return RendererSettings_ptr->DefaultFeatureAntiAliasing;}
            set {RendererSettings_ptr->DefaultFeatureAntiAliasing = value;}
        }
         //TODO: enum ELightUnits DefaultLightUnits
        ///<summary>Pixel format used for back buffer, when not specified</summary>
        public unsafe byte DefaultBackBufferPixelFormat {
            get {return RendererSettings_ptr->DefaultBackBufferPixelFormat;}
            set {RendererSettings_ptr->DefaultBackBufferPixelFormat = value;}
        }
        public bool bRenderUnbuiltPreviewShadowsInGame {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderUnbuiltPreviewShadowsInGame"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderUnbuiltPreviewShadowsInGame", value); }
        }
        public bool bStencilForLODDither {
            get {return Main.GetGetBoolPropertyByName(this, "bStencilForLODDither"); }
            set {Main.SetGetBoolPropertyByName(this, "bStencilForLODDither", value); }
        }
        ///<summary>Whether to use a depth only pass to initialize Z culling for the base pass.</summary>
        public unsafe byte EarlyZPass {
            get {return RendererSettings_ptr->EarlyZPass;}
            set {RendererSettings_ptr->EarlyZPass = value;}
        }
        public bool bEarlyZPassMovable {
            get {return Main.GetGetBoolPropertyByName(this, "bEarlyZPassMovable"); }
            set {Main.SetGetBoolPropertyByName(this, "bEarlyZPassMovable", value); }
        }
        public bool bEarlyZPassOnlyMaterialMasking {
            get {return Main.GetGetBoolPropertyByName(this, "bEarlyZPassOnlyMaterialMasking"); }
            set {Main.SetGetBoolPropertyByName(this, "bEarlyZPassOnlyMaterialMasking", value); }
        }
        public bool bDBuffer {
            get {return Main.GetGetBoolPropertyByName(this, "bDBuffer"); }
            set {Main.SetGetBoolPropertyByName(this, "bDBuffer", value); }
        }
        ///<summary>Select how the g-buffer is cleared in game mode (only affects deferred shading).</summary>
        public unsafe byte ClearSceneMethod {
            get {return RendererSettings_ptr->ClearSceneMethod;}
            set {RendererSettings_ptr->ClearSceneMethod = value;}
        }
        public bool bBasePassOutputsVelocity {
            get {return Main.GetGetBoolPropertyByName(this, "bBasePassOutputsVelocity"); }
            set {Main.SetGetBoolPropertyByName(this, "bBasePassOutputsVelocity", value); }
        }
        public bool bSelectiveBasePassOutputs {
            get {return Main.GetGetBoolPropertyByName(this, "bSelectiveBasePassOutputs"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelectiveBasePassOutputs", value); }
        }
        public bool bDefaultParticleCutouts {
            get {return Main.GetGetBoolPropertyByName(this, "bDefaultParticleCutouts"); }
            set {Main.SetGetBoolPropertyByName(this, "bDefaultParticleCutouts", value); }
        }
        ///<summary>The X size of the GPU simulation texture size. SizeX*SizeY determines the maximum number of GPU simulated particles in an emitter. Potentially overridden by CVar settings in BaseDeviceProfile.ini.</summary>
        public unsafe int GPUSimulationTextureSizeX {
            get {return RendererSettings_ptr->GPUSimulationTextureSizeX;}
            set {RendererSettings_ptr->GPUSimulationTextureSizeX = value;}
        }
        ///<summary>The Y size of the GPU simulation texture size. SizeX*SizeY determines the maximum number of GPU simulated particles in an emitter. Potentially overridden by CVar settings in BaseDeviceProfile.ini.</summary>
        public unsafe int GPUSimulationTextureSizeY {
            get {return RendererSettings_ptr->GPUSimulationTextureSizeY;}
            set {RendererSettings_ptr->GPUSimulationTextureSizeY = value;}
        }
        public bool bGlobalClipPlane {
            get {return Main.GetGetBoolPropertyByName(this, "bGlobalClipPlane"); }
            set {Main.SetGetBoolPropertyByName(this, "bGlobalClipPlane", value); }
        }
        ///<summary>Selects which GBuffer format should be used. Affects performance primarily via how much GPU memory bandwidth used.</summary>
        public unsafe byte GBufferFormat {
            get {return RendererSettings_ptr->GBufferFormat;}
            set {RendererSettings_ptr->GBufferFormat = value;}
        }
        public bool bUseGPUMorphTargets {
            get {return Main.GetGetBoolPropertyByName(this, "bUseGPUMorphTargets"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseGPUMorphTargets", value); }
        }
        public bool bNvidiaAftermathEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bNvidiaAftermathEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bNvidiaAftermathEnabled", value); }
        }
        public bool bInstancedStereo {
            get {return Main.GetGetBoolPropertyByName(this, "bInstancedStereo"); }
            set {Main.SetGetBoolPropertyByName(this, "bInstancedStereo", value); }
        }
        public bool bMultiView {
            get {return Main.GetGetBoolPropertyByName(this, "bMultiView"); }
            set {Main.SetGetBoolPropertyByName(this, "bMultiView", value); }
        }
        public bool bMobileMultiView {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileMultiView"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileMultiView", value); }
        }
        public bool bMobileMultiViewDirect {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileMultiViewDirect"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileMultiViewDirect", value); }
        }
        public bool bMonoscopicFarField {
            get {return Main.GetGetBoolPropertyByName(this, "bMonoscopicFarField"); }
            set {Main.SetGetBoolPropertyByName(this, "bMonoscopicFarField", value); }
        }
        public bool bRoundRobinOcclusion {
            get {return Main.GetGetBoolPropertyByName(this, "bRoundRobinOcclusion"); }
            set {Main.SetGetBoolPropertyByName(this, "bRoundRobinOcclusion", value); }
        }
        public bool bODSCapture {
            get {return Main.GetGetBoolPropertyByName(this, "bODSCapture"); }
            set {Main.SetGetBoolPropertyByName(this, "bODSCapture", value); }
        }
        ///<summary>Screen radius at which wireframe objects are culled. Larger values can improve performance when viewing a scene in wireframe.</summary>
        public unsafe float WireframeCullThreshold {
            get {return RendererSettings_ptr->WireframeCullThreshold;}
            set {RendererSettings_ptr->WireframeCullThreshold = value;}
        }
        public bool bSupportStationarySkylight {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportStationarySkylight"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportStationarySkylight", value); }
        }
        public bool bSupportLowQualityLightmaps {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportLowQualityLightmaps"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportLowQualityLightmaps", value); }
        }
        public bool bSupportPointLightWholeSceneShadows {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportPointLightWholeSceneShadows"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportPointLightWholeSceneShadows", value); }
        }
        public bool bSupportAtmosphericFog {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportAtmosphericFog"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportAtmosphericFog", value); }
        }
        public bool bSupportSkinCacheShaders {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportSkinCacheShaders"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportSkinCacheShaders", value); }
        }
        public bool bMobileEnableStaticAndCSMShadowReceivers {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileEnableStaticAndCSMShadowReceivers"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileEnableStaticAndCSMShadowReceivers", value); }
        }
        public bool bMobileEnableMovableLightCSMShaderCulling {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileEnableMovableLightCSMShaderCulling"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileEnableMovableLightCSMShaderCulling", value); }
        }
        public bool bMobileAllowDistanceFieldShadows {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileAllowDistanceFieldShadows"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileAllowDistanceFieldShadows", value); }
        }
        public bool bMobileAllowMovableDirectionalLights {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileAllowMovableDirectionalLights"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileAllowMovableDirectionalLights", value); }
        }
         //TODO: numeric uint32 MobileNumDynamicPointLights
        public bool bMobileDynamicPointLightsUseStaticBranch {
            get {return Main.GetGetBoolPropertyByName(this, "bMobileDynamicPointLightsUseStaticBranch"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobileDynamicPointLightsUseStaticBranch", value); }
        }
        ///<summary>Maximum amount of memory (in MB) per world/scene allowed for the Compute Skincache to generate output vertex data and recompute tangents.</summary>
        public unsafe float SkinCacheSceneMemoryLimitInMB {
            get {return RendererSettings_ptr->SkinCacheSceneMemoryLimitInMB;}
            set {RendererSettings_ptr->SkinCacheSceneMemoryLimitInMB = value;}
        }
        public bool bGPUSkinLimit2BoneInfluences {
            get {return Main.GetGetBoolPropertyByName(this, "bGPUSkinLimit2BoneInfluences"); }
            set {Main.SetGetBoolPropertyByName(this, "bGPUSkinLimit2BoneInfluences", value); }
        }
        public bool bSupportDepthOnlyIndexBuffers {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportDepthOnlyIndexBuffers"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportDepthOnlyIndexBuffers", value); }
        }
        public bool bSupportReversedIndexBuffers {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportReversedIndexBuffers"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportReversedIndexBuffers", value); }
        }
        public bool bSupportMaterialLayers {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportMaterialLayers"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportMaterialLayers", value); }
        }
        static RendererSettings() {
            StaticClass = Main.GetClass("RendererSettings");
        }
        internal unsafe RendererSettings_fields* RendererSettings_ptr => (RendererSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RendererSettings(IntPtr p) => UObject.Make<RendererSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RendererSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RendererSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
