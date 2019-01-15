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
    ///<summary>Abstract base class of all Engine classes, responsible for management of systems critical to editor or game systems.</summary>
    ///<remarks>Also defines default classes for certain engine systems.</remarks>
    public unsafe partial class Engine : UObject  {
        ///<summary>Fonts.</summary>
        public unsafe Font TinyFont {
            get {return Engine_ptr->TinyFont;}
            set {Engine_ptr->TinyFont = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath TinyFontName {
            get {return Engine_ptr->TinyFontName;}
            set {Engine_ptr->TinyFontName = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Font SmallFont {
            get {return Engine_ptr->SmallFont;}
            set {Engine_ptr->SmallFont = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath SmallFontName {
            get {return Engine_ptr->SmallFontName;}
            set {Engine_ptr->SmallFontName = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Font MediumFont {
            get {return Engine_ptr->MediumFont;}
            set {Engine_ptr->MediumFont = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath MediumFontName {
            get {return Engine_ptr->MediumFontName;}
            set {Engine_ptr->MediumFontName = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Font LargeFont {
            get {return Engine_ptr->LargeFont;}
            set {Engine_ptr->LargeFont = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath LargeFontName {
            get {return Engine_ptr->LargeFontName;}
            set {Engine_ptr->LargeFontName = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Font SubtitleFont {
            get {return Engine_ptr->SubtitleFont;}
            set {Engine_ptr->SubtitleFont = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath SubtitleFontName {
            get {return Engine_ptr->SubtitleFontName;}
            set {Engine_ptr->SubtitleFontName = value;}
        }
        ///<summary>Any additional fonts that script may use without hard-referencing the font.</summary>
        public ObjectArrayField<Font> AdditionalFonts{ get {
            if(AdditionalFonts_store == null) AdditionalFonts_store = new ObjectArrayField<Font> (&Engine_ptr->AdditionalFonts);
            return AdditionalFonts_store;
        } }
        private ObjectArrayField<Font> AdditionalFonts_store;

         //TODO: array not UObject TArray AdditionalFontNames
        ///<summary>The class to use for the game console.</summary>
        public unsafe SubclassOf<Console> ConsoleClass {
            get {return Engine_ptr->ConsoleClass;}
            set {Engine_ptr->ConsoleClass = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftClassPath ConsoleClassName {
            get {return Engine_ptr->ConsoleClassName;}
            set {Engine_ptr->ConsoleClassName = value;}
        }
        ///<summary>The class to use for the game viewport client.</summary>
        public unsafe SubclassOf<GameViewportClient> GameViewportClientClass {
            get {return Engine_ptr->GameViewportClientClass;}
            set {Engine_ptr->GameViewportClientClass = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftClassPath GameViewportClientClassName {
            get {return Engine_ptr->GameViewportClientClassName;}
            set {Engine_ptr->GameViewportClientClassName = value;}
        }
        ///<summary>The class to use for local players.</summary>
        public unsafe SubclassOf<LocalPlayer> LocalPlayerClass {
            get {return Engine_ptr->LocalPlayerClass;}
            set {Engine_ptr->LocalPlayerClass = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftClassPath LocalPlayerClassName {
            get {return Engine_ptr->LocalPlayerClassName;}
            set {Engine_ptr->LocalPlayerClassName = value;}
        }
        ///<summary>The class for WorldSettings *</summary>
        public unsafe SubclassOf<WorldSettings> WorldSettingsClass {
            get {return Engine_ptr->WorldSettingsClass;}
            set {Engine_ptr->WorldSettingsClass = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftClassPath WorldSettingsClassName {
            get {return Engine_ptr->WorldSettingsClassName;}
            set {Engine_ptr->WorldSettingsClassName = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftClassPath NavigationSystemClassName {
            get {return Engine_ptr->NavigationSystemClassName;}
            set {Engine_ptr->NavigationSystemClassName = value;}
        }
        ///<summary>The class for NavigationSystem *</summary>
        public unsafe SubclassOf<NavigationSystemBase> NavigationSystemClass {
            get {return Engine_ptr->NavigationSystemClass;}
            set {Engine_ptr->NavigationSystemClass = value;}
        }
        ///<summary>Navigation System Config Class Name</summary>
        public unsafe SoftClassPath NavigationSystemConfigClassName {
            get {return Engine_ptr->NavigationSystemConfigClassName;}
            set {Engine_ptr->NavigationSystemConfigClassName = value;}
        }
        ///<summary>Name of behavior tree manager class</summary>
        public unsafe SoftClassPath AvoidanceManagerClassName {
            get {return Engine_ptr->AvoidanceManagerClassName;}
            set {Engine_ptr->AvoidanceManagerClassName = value;}
        }
        ///<summary>The class for behavior tree manager *</summary>
        public unsafe SubclassOf<AvoidanceManager> AvoidanceManagerClass {
            get {return Engine_ptr->AvoidanceManagerClass;}
            set {Engine_ptr->AvoidanceManagerClass = value;}
        }
        ///<summary>PhysicsCollisionHandler class we should use by default *</summary>
        public unsafe SubclassOf<PhysicsCollisionHandler> PhysicsCollisionHandlerClass {
            get {return Engine_ptr->PhysicsCollisionHandlerClass;}
            set {Engine_ptr->PhysicsCollisionHandlerClass = value;}
        }
        ///<summary>Name of PhysicsCollisionHandler class we should use by default.</summary>
        public unsafe SoftClassPath PhysicsCollisionHandlerClassName {
            get {return Engine_ptr->PhysicsCollisionHandlerClassName;}
            set {Engine_ptr->PhysicsCollisionHandlerClassName = value;}
        }
        ///<summary>Game User Settings Class Name</summary>
        public unsafe SoftClassPath GameUserSettingsClassName {
            get {return Engine_ptr->GameUserSettingsClassName;}
            set {Engine_ptr->GameUserSettingsClassName = value;}
        }
        ///<summary>Game User Settings Class</summary>
        public unsafe SubclassOf<GameUserSettings> GameUserSettingsClass {
            get {return Engine_ptr->GameUserSettingsClass;}
            set {Engine_ptr->GameUserSettingsClass = value;}
        }
        ///<summary>name of Controller class to be used as default AIController class for pawns</summary>
        public unsafe SoftClassPath AIControllerClassName {
            get {return Engine_ptr->AIControllerClassName;}
            set {Engine_ptr->AIControllerClassName = value;}
        }
        ///<summary>Global instance of the user game settings</summary>
        public unsafe GameUserSettings GameUserSettings {
            get {return Engine_ptr->GameUserSettings;}
            set {Engine_ptr->GameUserSettings = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SubclassOf<LevelScriptActor> LevelScriptActorClass {
            get {return Engine_ptr->LevelScriptActorClass;}
            set {Engine_ptr->LevelScriptActorClass = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftClassPath LevelScriptActorClassName {
            get {return Engine_ptr->LevelScriptActorClassName;}
            set {Engine_ptr->LevelScriptActorClassName = value;}
        }
        ///<summary>Name of the base class to use for new blueprints, configurable on a per-game basis</summary>
        public unsafe SoftClassPath DefaultBlueprintBaseClassName {
            get {return Engine_ptr->DefaultBlueprintBaseClassName;}
            set {Engine_ptr->DefaultBlueprintBaseClassName = value;}
        }
        ///<summary>Name of a singleton class to create at startup time, configurable per game</summary>
        public unsafe SoftClassPath GameSingletonClassName {
            get {return Engine_ptr->GameSingletonClassName;}
            set {Engine_ptr->GameSingletonClassName = value;}
        }
        ///<summary>A UObject spawned at initialization time to handle game-specific data</summary>
        public unsafe UObject GameSingleton {
            get {return Engine_ptr->GameSingleton;}
            set {Engine_ptr->GameSingleton = value;}
        }
        ///<summary>Name of a singleton class to spawn as the AssetManager, configurable per game. If empty, it will not spawn one</summary>
        public unsafe SoftClassPath AssetManagerClassName {
            get {return Engine_ptr->AssetManagerClassName;}
            set {Engine_ptr->AssetManagerClassName = value;}
        }
        ///<summary>A UObject spawned at initialization time to handle game-specific data</summary>
        public unsafe AssetManager AssetManager {
            get {return Engine_ptr->AssetManager;}
            set {Engine_ptr->AssetManager = value;}
        }
        ///<summary>A global default texture.</summary>
        public unsafe Texture2D DefaultTexture {
            get {return Engine_ptr->DefaultTexture;}
            set {Engine_ptr->DefaultTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath DefaultTextureName {
            get {return Engine_ptr->DefaultTextureName;}
            set {Engine_ptr->DefaultTextureName = value;}
        }
        ///<summary>A global default diffuse texture.</summary>
        public unsafe Texture DefaultDiffuseTexture {
            get {return Engine_ptr->DefaultDiffuseTexture;}
            set {Engine_ptr->DefaultDiffuseTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath DefaultDiffuseTextureName {
            get {return Engine_ptr->DefaultDiffuseTextureName;}
            set {Engine_ptr->DefaultDiffuseTextureName = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Texture2D DefaultBSPVertexTexture {
            get {return Engine_ptr->DefaultBSPVertexTexture;}
            set {Engine_ptr->DefaultBSPVertexTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath DefaultBSPVertexTextureName {
            get {return Engine_ptr->DefaultBSPVertexTextureName;}
            set {Engine_ptr->DefaultBSPVertexTextureName = value;}
        }
        ///<summary>Texture used to get random image grain values for post processing</summary>
        public unsafe Texture2D HighFrequencyNoiseTexture {
            get {return Engine_ptr->HighFrequencyNoiseTexture;}
            set {Engine_ptr->HighFrequencyNoiseTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath HighFrequencyNoiseTextureName {
            get {return Engine_ptr->HighFrequencyNoiseTextureName;}
            set {Engine_ptr->HighFrequencyNoiseTextureName = value;}
        }
        ///<summary>Texture used to blur out of focus content, mimics the Bokeh shape of actual cameras</summary>
        public unsafe Texture2D DefaultBokehTexture {
            get {return Engine_ptr->DefaultBokehTexture;}
            set {Engine_ptr->DefaultBokehTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath DefaultBokehTextureName {
            get {return Engine_ptr->DefaultBokehTextureName;}
            set {Engine_ptr->DefaultBokehTextureName = value;}
        }
        ///<summary>Texture used to bloom when using FFT, mimics characteristic bloom produced in a camera from a signle bright source</summary>
        public unsafe Texture2D DefaultBloomKernelTexture {
            get {return Engine_ptr->DefaultBloomKernelTexture;}
            set {Engine_ptr->DefaultBloomKernelTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath DefaultBloomKernelTextureName {
            get {return Engine_ptr->DefaultBloomKernelTextureName;}
            set {Engine_ptr->DefaultBloomKernelTextureName = value;}
        }
        ///<summary>The material used to render wireframe meshes.</summary>
        public unsafe Material WireframeMaterial {
            get {return Engine_ptr->WireframeMaterial;}
            set {Engine_ptr->WireframeMaterial = value;}
        }
         //TODO: string FString WireframeMaterialName
        ///<summary>A translucent material used to render things in geometry mode.</summary>
        public unsafe Material GeomMaterial {
            get {return Engine_ptr->GeomMaterial;}
            set {Engine_ptr->GeomMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath GeomMaterialName {
            get {return Engine_ptr->GeomMaterialName;}
            set {Engine_ptr->GeomMaterialName = value;}
        }
        ///<summary>A material used to render debug meshes.</summary>
        public unsafe Material DebugMeshMaterial {
            get {return Engine_ptr->DebugMeshMaterial;}
            set {Engine_ptr->DebugMeshMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath DebugMeshMaterialName {
            get {return Engine_ptr->DebugMeshMaterialName;}
            set {Engine_ptr->DebugMeshMaterialName = value;}
        }
        ///<summary>Material used for visualizing level membership in lit view port modes.</summary>
        public unsafe Material LevelColorationLitMaterial {
            get {return Engine_ptr->LevelColorationLitMaterial;}
            set {Engine_ptr->LevelColorationLitMaterial = value;}
        }
         //TODO: string FString LevelColorationLitMaterialName
        ///<summary>Material used for visualizing level membership in unlit view port modes.</summary>
        public unsafe Material LevelColorationUnlitMaterial {
            get {return Engine_ptr->LevelColorationUnlitMaterial;}
            set {Engine_ptr->LevelColorationUnlitMaterial = value;}
        }
         //TODO: string FString LevelColorationUnlitMaterialName
        ///<summary>Material used for visualizing lighting only w/ lightmap texel density.</summary>
        public unsafe Material LightingTexelDensityMaterial {
            get {return Engine_ptr->LightingTexelDensityMaterial;}
            set {Engine_ptr->LightingTexelDensityMaterial = value;}
        }
         //TODO: string FString LightingTexelDensityName
        ///<summary>Material used for visualizing level membership in lit view port modes. Uses shading to show axis directions.</summary>
        public unsafe Material ShadedLevelColorationLitMaterial {
            get {return Engine_ptr->ShadedLevelColorationLitMaterial;}
            set {Engine_ptr->ShadedLevelColorationLitMaterial = value;}
        }
         //TODO: string FString ShadedLevelColorationLitMaterialName
        ///<summary>Material used for visualizing level membership in unlit view port modes.  Uses shading to show axis directions.</summary>
        public unsafe Material ShadedLevelColorationUnlitMaterial {
            get {return Engine_ptr->ShadedLevelColorationUnlitMaterial;}
            set {Engine_ptr->ShadedLevelColorationUnlitMaterial = value;}
        }
         //TODO: string FString ShadedLevelColorationUnlitMaterialName
        ///<summary>Material used to indicate that the associated BSP surface should be removed.</summary>
        public unsafe Material RemoveSurfaceMaterial {
            get {return Engine_ptr->RemoveSurfaceMaterial;}
            set {Engine_ptr->RemoveSurfaceMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath RemoveSurfaceMaterialName {
            get {return Engine_ptr->RemoveSurfaceMaterialName;}
            set {Engine_ptr->RemoveSurfaceMaterialName = value;}
        }
        ///<summary>Material that renders vertex color as emmissive.</summary>
        public unsafe Material VertexColorMaterial {
            get {return Engine_ptr->VertexColorMaterial;}
            set {Engine_ptr->VertexColorMaterial = value;}
        }
         //TODO: string FString VertexColorMaterialName
        ///<summary>Material for visualizing vertex colors on meshes in the scene (color only, no alpha)</summary>
        public unsafe Material VertexColorViewModeMaterial_ColorOnly {
            get {return Engine_ptr->VertexColorViewModeMaterial_ColorOnly;}
            set {Engine_ptr->VertexColorViewModeMaterial_ColorOnly = value;}
        }
         //TODO: string FString VertexColorViewModeMaterialName_ColorOnly
        ///<summary>Material for visualizing vertex colors on meshes in the scene (alpha channel as color)</summary>
        public unsafe Material VertexColorViewModeMaterial_AlphaAsColor {
            get {return Engine_ptr->VertexColorViewModeMaterial_AlphaAsColor;}
            set {Engine_ptr->VertexColorViewModeMaterial_AlphaAsColor = value;}
        }
         //TODO: string FString VertexColorViewModeMaterialName_AlphaAsColor
        ///<summary>Material for visualizing vertex colors on meshes in the scene (red only)</summary>
        public unsafe Material VertexColorViewModeMaterial_RedOnly {
            get {return Engine_ptr->VertexColorViewModeMaterial_RedOnly;}
            set {Engine_ptr->VertexColorViewModeMaterial_RedOnly = value;}
        }
         //TODO: string FString VertexColorViewModeMaterialName_RedOnly
        ///<summary>Material for visualizing vertex colors on meshes in the scene (green only)</summary>
        public unsafe Material VertexColorViewModeMaterial_GreenOnly {
            get {return Engine_ptr->VertexColorViewModeMaterial_GreenOnly;}
            set {Engine_ptr->VertexColorViewModeMaterial_GreenOnly = value;}
        }
         //TODO: string FString VertexColorViewModeMaterialName_GreenOnly
        ///<summary>Material for visualizing vertex colors on meshes in the scene (blue only)</summary>
        public unsafe Material VertexColorViewModeMaterial_BlueOnly {
            get {return Engine_ptr->VertexColorViewModeMaterial_BlueOnly;}
            set {Engine_ptr->VertexColorViewModeMaterial_BlueOnly = value;}
        }
         //TODO: string FString VertexColorViewModeMaterialName_BlueOnly
        ///<summary>Material used to render bone weights on skeletal meshes</summary>
        public unsafe Material BoneWeightMaterial {
            get {return Engine_ptr->BoneWeightMaterial;}
            set {Engine_ptr->BoneWeightMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath BoneWeightMaterialName {
            get {return Engine_ptr->BoneWeightMaterialName;}
            set {Engine_ptr->BoneWeightMaterialName = value;}
        }
        ///<summary>Materials used to render cloth properties on skeletal meshes</summary>
        public unsafe Material ClothPaintMaterial {
            get {return Engine_ptr->ClothPaintMaterial;}
            set {Engine_ptr->ClothPaintMaterial = value;}
        }
        ///<summary>Cloth Paint Material Wireframe</summary>
        public unsafe Material ClothPaintMaterialWireframe {
            get {return Engine_ptr->ClothPaintMaterialWireframe;}
            set {Engine_ptr->ClothPaintMaterialWireframe = value;}
        }
        ///<summary>Cloth Paint Material Instance</summary>
        public unsafe MaterialInstanceDynamic ClothPaintMaterialInstance {
            get {return Engine_ptr->ClothPaintMaterialInstance;}
            set {Engine_ptr->ClothPaintMaterialInstance = value;}
        }
        ///<summary>Cloth Paint Material Wireframe Instance</summary>
        public unsafe MaterialInstanceDynamic ClothPaintMaterialWireframeInstance {
            get {return Engine_ptr->ClothPaintMaterialWireframeInstance;}
            set {Engine_ptr->ClothPaintMaterialWireframeInstance = value;}
        }
        ///<summary>Name of the material used to render cloth in the clothing tools</summary>
        public unsafe SoftObjectPath ClothPaintMaterialName {
            get {return Engine_ptr->ClothPaintMaterialName;}
            set {Engine_ptr->ClothPaintMaterialName = value;}
        }
        ///<summary>Name of the material used to render cloth wireframe in the clothing tools</summary>
        public unsafe SoftObjectPath ClothPaintMaterialWireframeName {
            get {return Engine_ptr->ClothPaintMaterialWireframeName;}
            set {Engine_ptr->ClothPaintMaterialWireframeName = value;}
        }
        ///<summary>A material used to render debug meshes.</summary>
        public unsafe Material DebugEditorMaterial {
            get {return Engine_ptr->DebugEditorMaterial;}
            set {Engine_ptr->DebugEditorMaterial = value;}
        }
        ///<summary>A material used to render debug opaque material. Used in various animation editor viewport features.</summary>
        public unsafe SoftObjectPath DebugEditorMaterialName {
            get {return Engine_ptr->DebugEditorMaterialName;}
            set {Engine_ptr->DebugEditorMaterialName = value;}
        }
        ///<summary>Material used to render constraint limits</summary>
        public unsafe Material ConstraintLimitMaterial {
            get {return Engine_ptr->ConstraintLimitMaterial;}
            set {Engine_ptr->ConstraintLimitMaterial = value;}
        }
        ///<summary>Constraint Limit Material X</summary>
        public unsafe MaterialInstanceDynamic ConstraintLimitMaterialX {
            get {return Engine_ptr->ConstraintLimitMaterialX;}
            set {Engine_ptr->ConstraintLimitMaterialX = value;}
        }
        ///<summary>Constraint Limit Material XAxis</summary>
        public unsafe MaterialInstanceDynamic ConstraintLimitMaterialXAxis {
            get {return Engine_ptr->ConstraintLimitMaterialXAxis;}
            set {Engine_ptr->ConstraintLimitMaterialXAxis = value;}
        }
        ///<summary>Constraint Limit Material Y</summary>
        public unsafe MaterialInstanceDynamic ConstraintLimitMaterialY {
            get {return Engine_ptr->ConstraintLimitMaterialY;}
            set {Engine_ptr->ConstraintLimitMaterialY = value;}
        }
        ///<summary>Constraint Limit Material YAxis</summary>
        public unsafe MaterialInstanceDynamic ConstraintLimitMaterialYAxis {
            get {return Engine_ptr->ConstraintLimitMaterialYAxis;}
            set {Engine_ptr->ConstraintLimitMaterialYAxis = value;}
        }
        ///<summary>Constraint Limit Material Z</summary>
        public unsafe MaterialInstanceDynamic ConstraintLimitMaterialZ {
            get {return Engine_ptr->ConstraintLimitMaterialZ;}
            set {Engine_ptr->ConstraintLimitMaterialZ = value;}
        }
        ///<summary>Constraint Limit Material ZAxis</summary>
        public unsafe MaterialInstanceDynamic ConstraintLimitMaterialZAxis {
            get {return Engine_ptr->ConstraintLimitMaterialZAxis;}
            set {Engine_ptr->ConstraintLimitMaterialZAxis = value;}
        }
        ///<summary>Constraint Limit Material Prismatic</summary>
        public unsafe MaterialInstanceDynamic ConstraintLimitMaterialPrismatic {
            get {return Engine_ptr->ConstraintLimitMaterialPrismatic;}
            set {Engine_ptr->ConstraintLimitMaterialPrismatic = value;}
        }
        ///<summary>Material that renders a message about lightmap settings being invalid.</summary>
        public unsafe Material InvalidLightmapSettingsMaterial {
            get {return Engine_ptr->InvalidLightmapSettingsMaterial;}
            set {Engine_ptr->InvalidLightmapSettingsMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath InvalidLightmapSettingsMaterialName {
            get {return Engine_ptr->InvalidLightmapSettingsMaterialName;}
            set {Engine_ptr->InvalidLightmapSettingsMaterialName = value;}
        }
        ///<summary>Material that renders a message about preview shadows being used.</summary>
        public unsafe Material PreviewShadowsIndicatorMaterial {
            get {return Engine_ptr->PreviewShadowsIndicatorMaterial;}
            set {Engine_ptr->PreviewShadowsIndicatorMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath PreviewShadowsIndicatorMaterialName {
            get {return Engine_ptr->PreviewShadowsIndicatorMaterialName;}
            set {Engine_ptr->PreviewShadowsIndicatorMaterialName = value;}
        }
        ///<summary>Material that 'fakes' lighting, used for arrows, widgets.</summary>
        public unsafe Material ArrowMaterial {
            get {return Engine_ptr->ArrowMaterial;}
            set {Engine_ptr->ArrowMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath ArrowMaterialName {
            get {return Engine_ptr->ArrowMaterialName;}
            set {Engine_ptr->ArrowMaterialName = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe LinearColor LightingOnlyBrightness {
            get {return Engine_ptr->LightingOnlyBrightness;}
            set {Engine_ptr->LightingOnlyBrightness = value;}
        }
         //TODO: array not UObject TArray ShaderComplexityColors
         //TODO: array not UObject TArray QuadComplexityColors
         //TODO: array not UObject TArray LightComplexityColors
         //TODO: array not UObject TArray StationaryLightOverlapColors
         //TODO: array not UObject TArray LODColorationColors
         //TODO: array not UObject TArray HLODColorationColors
         //TODO: array not UObject TArray StreamingAccuracyColors
        ///<summary>Complexity limits for the various complexity view mode combinations.</summary>
        ///<remarks>These limits are used to map instruction counts to ShaderComplexityColors.</remarks>
        public unsafe float MaxPixelShaderAdditiveComplexityCount {
            get {return Engine_ptr->MaxPixelShaderAdditiveComplexityCount;}
            set {Engine_ptr->MaxPixelShaderAdditiveComplexityCount = value;}
        }
        ///<summary>Max ES2Pixel Shader Additive Complexity Count</summary>
        public unsafe float MaxES2PixelShaderAdditiveComplexityCount {
            get {return Engine_ptr->MaxES2PixelShaderAdditiveComplexityCount;}
            set {Engine_ptr->MaxES2PixelShaderAdditiveComplexityCount = value;}
        }
        ///<summary>Max ES3Pixel Shader Additive Complexity Count</summary>
        public unsafe float MaxES3PixelShaderAdditiveComplexityCount {
            get {return Engine_ptr->MaxES3PixelShaderAdditiveComplexityCount;}
            set {Engine_ptr->MaxES3PixelShaderAdditiveComplexityCount = value;}
        }
        ///<summary>Minimum lightmap density value for coloring.</summary>
        public unsafe float MinLightMapDensity {
            get {return Engine_ptr->MinLightMapDensity;}
            set {Engine_ptr->MinLightMapDensity = value;}
        }
        ///<summary>Ideal lightmap density value for coloring.</summary>
        public unsafe float IdealLightMapDensity {
            get {return Engine_ptr->IdealLightMapDensity;}
            set {Engine_ptr->IdealLightMapDensity = value;}
        }
        ///<summary>Maximum lightmap density value for coloring.</summary>
        public unsafe float MaxLightMapDensity {
            get {return Engine_ptr->MaxLightMapDensity;}
            set {Engine_ptr->MaxLightMapDensity = value;}
        }
        public bool bRenderLightMapDensityGrayscale {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderLightMapDensityGrayscale"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderLightMapDensityGrayscale", value); }
        }
        ///<summary>The scale factor when rendering gray scale density.</summary>
        public unsafe float RenderLightMapDensityGrayscaleScale {
            get {return Engine_ptr->RenderLightMapDensityGrayscaleScale;}
            set {Engine_ptr->RenderLightMapDensityGrayscaleScale = value;}
        }
        ///<summary>The scale factor when rendering color density.</summary>
        public unsafe float RenderLightMapDensityColorScale {
            get {return Engine_ptr->RenderLightMapDensityColorScale;}
            set {Engine_ptr->RenderLightMapDensityColorScale = value;}
        }
        ///<summary>The color to render vertex mapped objects in for LightMap Density view mode.</summary>
        public unsafe LinearColor LightMapDensityVertexMappedColor {
            get {return Engine_ptr->LightMapDensityVertexMappedColor;}
            set {Engine_ptr->LightMapDensityVertexMappedColor = value;}
        }
        ///<summary>The color to render selected objects in for LightMap Density view mode.</summary>
        public unsafe LinearColor LightMapDensitySelectedColor {
            get {return Engine_ptr->LightMapDensitySelectedColor;}
            set {Engine_ptr->LightMapDensitySelectedColor = value;}
        }
         //TODO: array not UObject TArray StatColorMappings
        ///<summary>A material used to render the sides of the builder brush/volumes/etc.</summary>
        public unsafe Material EditorBrushMaterial {
            get {return Engine_ptr->EditorBrushMaterial;}
            set {Engine_ptr->EditorBrushMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath EditorBrushMaterialName {
            get {return Engine_ptr->EditorBrushMaterialName;}
            set {Engine_ptr->EditorBrushMaterialName = value;}
        }
        ///<summary>PhysicalMaterial to use if none is defined for a particular object.</summary>
        public unsafe PhysicalMaterial DefaultPhysMaterial {
            get {return Engine_ptr->DefaultPhysMaterial;}
            set {Engine_ptr->DefaultPhysMaterial = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath DefaultPhysMaterialName {
            get {return Engine_ptr->DefaultPhysMaterialName;}
            set {Engine_ptr->DefaultPhysMaterialName = value;}
        }
         //TODO: array not UObject TArray ActiveGameNameRedirects
         //TODO: array not UObject TArray ActiveClassRedirects
         //TODO: array not UObject TArray ActivePluginRedirects
         //TODO: array not UObject TArray ActiveStructRedirects
        ///<summary>Texture used for pre-integrated skin shading</summary>
        public unsafe Texture2D PreIntegratedSkinBRDFTexture {
            get {return Engine_ptr->PreIntegratedSkinBRDFTexture;}
            set {Engine_ptr->PreIntegratedSkinBRDFTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath PreIntegratedSkinBRDFTextureName {
            get {return Engine_ptr->PreIntegratedSkinBRDFTextureName;}
            set {Engine_ptr->PreIntegratedSkinBRDFTextureName = value;}
        }
        ///<summary>Texture used to do font rendering in shaders</summary>
        public unsafe Texture2D MiniFontTexture {
            get {return Engine_ptr->MiniFontTexture;}
            set {Engine_ptr->MiniFontTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath MiniFontTextureName {
            get {return Engine_ptr->MiniFontTextureName;}
            set {Engine_ptr->MiniFontTextureName = value;}
        }
        ///<summary>Texture used as a placeholder for terrain weight-maps to give the material the correct texture format.</summary>
        public unsafe Texture WeightMapPlaceholderTexture {
            get {return Engine_ptr->WeightMapPlaceholderTexture;}
            set {Engine_ptr->WeightMapPlaceholderTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath WeightMapPlaceholderTextureName {
            get {return Engine_ptr->WeightMapPlaceholderTextureName;}
            set {Engine_ptr->WeightMapPlaceholderTextureName = value;}
        }
        ///<summary>Texture used to display LightMapDensity</summary>
        public unsafe Texture2D LightMapDensityTexture {
            get {return Engine_ptr->LightMapDensityTexture;}
            set {Engine_ptr->LightMapDensityTexture = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe SoftObjectPath LightMapDensityTextureName {
            get {return Engine_ptr->LightMapDensityTextureName;}
            set {Engine_ptr->LightMapDensityTextureName = value;}
        }
        ///<summary>The view port representing the current game instance. Can be 0 so don't use without checking.</summary>
        public unsafe GameViewportClient GameViewport {
            get {return Engine_ptr->GameViewport;}
            set {Engine_ptr->GameViewport = value;}
        }
         //TODO: array not UObject TArray DeferredCommands
        ///<summary>@todo document</summary>
        public unsafe int TickCycles {
            get {return Engine_ptr->TickCycles;}
            set {Engine_ptr->TickCycles = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe int GameCycles {
            get {return Engine_ptr->GameCycles;}
            set {Engine_ptr->GameCycles = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe int ClientCycles {
            get {return Engine_ptr->ClientCycles;}
            set {Engine_ptr->ClientCycles = value;}
        }
        ///<summary>The distance of the camera's near clipping plane.</summary>
        public unsafe float NearClipPlane {
            get {return Engine_ptr->NearClipPlane;}
            set {Engine_ptr->NearClipPlane = value;}
        }
        public bool bSubtitlesEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "bSubtitlesEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "bSubtitlesEnabled", value); }
        }
        public bool bSubtitlesForcedOff {
            get {return Main.GetGetBoolPropertyByName(this, "bSubtitlesForcedOff"); }
            set {Main.SetGetBoolPropertyByName(this, "bSubtitlesForcedOff", value); }
        }
        ///<summary>Script maximum loop iteration count used as a threshold to warn users about script execution runaway</summary>
        public unsafe int MaximumLoopIterationCount {
            get {return Engine_ptr->MaximumLoopIterationCount;}
            set {Engine_ptr->MaximumLoopIterationCount = value;}
        }
        public bool bCanBlueprintsTickByDefault {
            get {return Main.GetGetBoolPropertyByName(this, "bCanBlueprintsTickByDefault"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanBlueprintsTickByDefault", value); }
        }
        public bool bOptimizeAnimBlueprintMemberVariableAccess {
            get {return Main.GetGetBoolPropertyByName(this, "bOptimizeAnimBlueprintMemberVariableAccess"); }
            set {Main.SetGetBoolPropertyByName(this, "bOptimizeAnimBlueprintMemberVariableAccess", value); }
        }
        public bool bAllowMultiThreadedAnimationUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowMultiThreadedAnimationUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowMultiThreadedAnimationUpdate", value); }
        }
        public bool bEnableEditorPSysRealtimeLOD {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableEditorPSysRealtimeLOD"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableEditorPSysRealtimeLOD", value); }
        }
        public bool bSmoothFrameRate {
            get {return Main.GetGetBoolPropertyByName(this, "bSmoothFrameRate"); }
            set {Main.SetGetBoolPropertyByName(this, "bSmoothFrameRate", value); }
        }
        public bool bUseFixedFrameRate {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFixedFrameRate"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFixedFrameRate", value); }
        }
        ///<summary>The fixed framerate to use.</summary>
        public unsafe float FixedFrameRate {
            get {return Engine_ptr->FixedFrameRate;}
            set {Engine_ptr->FixedFrameRate = value;}
        }
        ///<summary>Range of framerates in which smoothing will kick in</summary>
        public unsafe FloatRange SmoothedFrameRateRange {
            get {return Engine_ptr->SmoothedFrameRateRange;}
            set {Engine_ptr->SmoothedFrameRateRange = value;}
        }
        ///<summary>Control how the Engine process the Framerate/Timestep</summary>
        public unsafe EngineCustomTimeStep CustomTimeStep {
            get {return Engine_ptr->CustomTimeStep;}
            set {Engine_ptr->CustomTimeStep = value;}
        }
        ///<summary>Override how the Engine process the Framerate/Timestep.</summary>
        ///<remarks>
        ///This class will be responsible of updating the application Time and DeltaTime.
        ///Can be used to synchronize the engine with another process (gen-lock).
        ///</remarks>
        public unsafe SoftClassPath CustomTimeStepClassName {
            get {return Engine_ptr->CustomTimeStepClassName;}
            set {Engine_ptr->CustomTimeStepClassName = value;}
        }
        ///<summary>Provide a timecode to the Engine</summary>
        public unsafe TimecodeProvider TimecodeProvider {
            get {return Engine_ptr->TimecodeProvider;}
            set {Engine_ptr->TimecodeProvider = value;}
        }
        ///<summary>Provide a timecode to the Engine</summary>
        public unsafe SoftClassPath TimecodeFrameRateClassName {
            get {return Engine_ptr->TimecodeFrameRateClassName;}
            set {Engine_ptr->TimecodeFrameRateClassName = value;}
        }
        ///<summary>Frame rate used to generated the engine Timecode's frame number when no TimecodeProvider are specified.</summary>
        ///<remarks>It doesn't control the Engine frame rate. The Engine can run faster or slower that the specified TimecodeFrameRate.</remarks>
        public unsafe FrameRate DefaultTimecodeFrameRate {
            get {return Engine_ptr->DefaultTimecodeFrameRate;}
            set {Engine_ptr->DefaultTimecodeFrameRate = value;}
        }
        public bool bCheckForMultiplePawnsSpawnedInAFrame {
            get {return Main.GetGetBoolPropertyByName(this, "bCheckForMultiplePawnsSpawnedInAFrame"); }
            set {Main.SetGetBoolPropertyByName(this, "bCheckForMultiplePawnsSpawnedInAFrame", value); }
        }
        ///<summary>If bCheckForMultiplePawnsSpawnedInAFrame==true, then we will check to see that no more than this number of pawns are spawned in a frame. *</summary>
        public unsafe int NumPawnsAllowedToBeSpawnedInAFrame {
            get {return Engine_ptr->NumPawnsAllowedToBeSpawnedInAFrame;}
            set {Engine_ptr->NumPawnsAllowedToBeSpawnedInAFrame = value;}
        }
        ///<summary>Color preferences.</summary>
        public unsafe Color C_WorldBox {
            get {return Engine_ptr->C_WorldBox;}
            set {Engine_ptr->C_WorldBox = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_BrushWire {
            get {return Engine_ptr->C_BrushWire;}
            set {Engine_ptr->C_BrushWire = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_AddWire {
            get {return Engine_ptr->C_AddWire;}
            set {Engine_ptr->C_AddWire = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_SubtractWire {
            get {return Engine_ptr->C_SubtractWire;}
            set {Engine_ptr->C_SubtractWire = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_SemiSolidWire {
            get {return Engine_ptr->C_SemiSolidWire;}
            set {Engine_ptr->C_SemiSolidWire = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_NonSolidWire {
            get {return Engine_ptr->C_NonSolidWire;}
            set {Engine_ptr->C_NonSolidWire = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_WireBackground {
            get {return Engine_ptr->C_WireBackground;}
            set {Engine_ptr->C_WireBackground = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_ScaleBoxHi {
            get {return Engine_ptr->C_ScaleBoxHi;}
            set {Engine_ptr->C_ScaleBoxHi = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_VolumeCollision {
            get {return Engine_ptr->C_VolumeCollision;}
            set {Engine_ptr->C_VolumeCollision = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_BSPCollision {
            get {return Engine_ptr->C_BSPCollision;}
            set {Engine_ptr->C_BSPCollision = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_OrthoBackground {
            get {return Engine_ptr->C_OrthoBackground;}
            set {Engine_ptr->C_OrthoBackground = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_Volume {
            get {return Engine_ptr->C_Volume;}
            set {Engine_ptr->C_Volume = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe Color C_BrushShape {
            get {return Engine_ptr->C_BrushShape;}
            set {Engine_ptr->C_BrushShape = value;}
        }
        ///<summary>Fudge factor for tweaking the distance based miplevel determination</summary>
        public unsafe float StreamingDistanceFactor {
            get {return Engine_ptr->StreamingDistanceFactor;}
            set {Engine_ptr->StreamingDistanceFactor = value;}
        }
        ///<summary>The save directory for newly created screenshots</summary>
        public unsafe DirectoryPath GameScreenshotSaveDirectory {
            get {return Engine_ptr->GameScreenshotSaveDirectory;}
            set {Engine_ptr->GameScreenshotSaveDirectory = value;}
        }
        ///<summary>The current transition type.</summary>
        public unsafe byte TransitionType {
            get {return Engine_ptr->TransitionType;}
            set {Engine_ptr->TransitionType = value;}
        }
         //TODO: string FString TransitionDescription
         //TODO: string FString TransitionGameMode
        ///<summary>Level of detail range control for meshes</summary>
        public unsafe float MeshLODRange {
            get {return Engine_ptr->MeshLODRange;}
            set {Engine_ptr->MeshLODRange = value;}
        }
        public bool bAllowMatureLanguage {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowMatureLanguage"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowMatureLanguage", value); }
        }
        ///<summary>camera rotation (deg) beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
        public unsafe float CameraRotationThreshold {
            get {return Engine_ptr->CameraRotationThreshold;}
            set {Engine_ptr->CameraRotationThreshold = value;}
        }
        ///<summary>camera movement beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
        public unsafe float CameraTranslationThreshold {
            get {return Engine_ptr->CameraTranslationThreshold;}
            set {Engine_ptr->CameraTranslationThreshold = value;}
        }
        ///<summary>The amount of time a primitive is considered to be probably visible after it was last actually visible.</summary>
        public unsafe float PrimitiveProbablyVisibleTime {
            get {return Engine_ptr->PrimitiveProbablyVisibleTime;}
            set {Engine_ptr->PrimitiveProbablyVisibleTime = value;}
        }
        ///<summary>Max screen pixel fraction where retesting when unoccluded is worth the GPU time.</summary>
        public unsafe float MaxOcclusionPixelsFraction {
            get {return Engine_ptr->MaxOcclusionPixelsFraction;}
            set {Engine_ptr->MaxOcclusionPixelsFraction = value;}
        }
        public bool bPauseOnLossOfFocus {
            get {return Main.GetGetBoolPropertyByName(this, "bPauseOnLossOfFocus"); }
            set {Main.SetGetBoolPropertyByName(this, "bPauseOnLossOfFocus", value); }
        }
        ///<summary>The maximum allowed size to a ParticleEmitterInstance::Resize call.</summary>
        ///<remarks>If larger, the function will return without resizing.</remarks>
        public unsafe int MaxParticleResize {
            get {return Engine_ptr->MaxParticleResize;}
            set {Engine_ptr->MaxParticleResize = value;}
        }
        ///<summary>If the resize request is larger than this, spew out a warning to the log</summary>
        public unsafe int MaxParticleResizeWarn {
            get {return Engine_ptr->MaxParticleResizeWarn;}
            set {Engine_ptr->MaxParticleResizeWarn = value;}
        }
         //TODO: array not UObject TArray PendingDroppedNotes
        ///<summary>Number of times to tick each client per second</summary>
        public unsafe float NetClientTicksPerSecond {
            get {return Engine_ptr->NetClientTicksPerSecond;}
            set {Engine_ptr->NetClientTicksPerSecond = value;}
        }
        ///<summary>Current display gamma setting</summary>
        public unsafe float DisplayGamma {
            get {return Engine_ptr->DisplayGamma;}
            set {Engine_ptr->DisplayGamma = value;}
        }
        ///<summary>Minimum desired framerate setting</summary>
        public unsafe float MinDesiredFrameRate {
            get {return Engine_ptr->MinDesiredFrameRate;}
            set {Engine_ptr->MinDesiredFrameRate = value;}
        }
        ///<summary>Default color of selected objects in the level viewport (additive)</summary>
        public unsafe LinearColor DefaultSelectedMaterialColor {
            get {return Engine_ptr->DefaultSelectedMaterialColor;}
            set {Engine_ptr->DefaultSelectedMaterialColor = value;}
        }
        ///<summary>Color of selected objects in the level viewport (additive)</summary>
        public unsafe LinearColor SelectedMaterialColor {
            get {return Engine_ptr->SelectedMaterialColor;}
            set {Engine_ptr->SelectedMaterialColor = value;}
        }
        ///<summary>Color of the selection outline color.  Generally the same as selected material color unless the selection material color is being overridden</summary>
        public unsafe LinearColor SelectionOutlineColor {
            get {return Engine_ptr->SelectionOutlineColor;}
            set {Engine_ptr->SelectionOutlineColor = value;}
        }
        ///<summary>Subdued version of the selection outline color. Used for indicating sub-selection of components vs actors</summary>
        public unsafe LinearColor SubduedSelectionOutlineColor {
            get {return Engine_ptr->SubduedSelectionOutlineColor;}
            set {Engine_ptr->SubduedSelectionOutlineColor = value;}
        }
        ///<summary>An override to use in some cases instead of the selected material color</summary>
        public unsafe LinearColor SelectedMaterialColorOverride {
            get {return Engine_ptr->SelectedMaterialColorOverride;}
            set {Engine_ptr->SelectedMaterialColorOverride = value;}
        }
        public bool bIsOverridingSelectedColor {
            get {return Main.GetGetBoolPropertyByName(this, "bIsOverridingSelectedColor"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsOverridingSelectedColor", value); }
        }
        public bool bEnableOnScreenDebugMessages {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableOnScreenDebugMessages"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableOnScreenDebugMessages", value); }
        }
        public bool bEnableOnScreenDebugMessagesDisplay {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableOnScreenDebugMessagesDisplay"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableOnScreenDebugMessagesDisplay", value); }
        }
        public bool bSuppressMapWarnings {
            get {return Main.GetGetBoolPropertyByName(this, "bSuppressMapWarnings"); }
            set {Main.SetGetBoolPropertyByName(this, "bSuppressMapWarnings", value); }
        }
        public bool bDisableAILogging {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableAILogging"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableAILogging", value); }
        }
         //TODO: numeric uint32 bEnableVisualLogRecordingOnStart
        ///<summary>Semaphore to control screen saver inhibitor thread access.</summary>
        public unsafe int ScreenSaverInhibitorSemaphore {
            get {return Engine_ptr->ScreenSaverInhibitorSemaphore;}
            set {Engine_ptr->ScreenSaverInhibitorSemaphore = value;}
        }
        public bool bLockReadOnlyLevels {
            get {return Main.GetGetBoolPropertyByName(this, "bLockReadOnlyLevels"); }
            set {Main.SetGetBoolPropertyByName(this, "bLockReadOnlyLevels", value); }
        }
         //TODO: string FString ParticleEventManagerClassPath
        ///<summary>Used to alter the intensity level of the selection highlight on selected objects</summary>
        public unsafe float SelectionHighlightIntensity {
            get {return Engine_ptr->SelectionHighlightIntensity;}
            set {Engine_ptr->SelectionHighlightIntensity = value;}
        }
        ///<summary>Used to alter the intensity level of the selection highlight on selected mesh sections in mesh editors</summary>
        public unsafe float SelectionMeshSectionHighlightIntensity {
            get {return Engine_ptr->SelectionMeshSectionHighlightIntensity;}
            set {Engine_ptr->SelectionMeshSectionHighlightIntensity = value;}
        }
        ///<summary>Used to alter the intensity level of the selection highlight on selected BSP surfaces</summary>
        public unsafe float BSPSelectionHighlightIntensity {
            get {return Engine_ptr->BSPSelectionHighlightIntensity;}
            set {Engine_ptr->BSPSelectionHighlightIntensity = value;}
        }
        ///<summary>Used to alter the intensity level of the selection highlight on hovered objects</summary>
        public unsafe float HoverHighlightIntensity {
            get {return Engine_ptr->HoverHighlightIntensity;}
            set {Engine_ptr->HoverHighlightIntensity = value;}
        }
        ///<summary>Used to alter the intensity level of the selection highlight on selected billboard objects</summary>
        public unsafe float SelectionHighlightIntensityBillboards {
            get {return Engine_ptr->SelectionHighlightIntensityBillboards;}
            set {Engine_ptr->SelectionHighlightIntensityBillboards = value;}
        }
         //TODO: array not UObject TArray NetDriverDefinitions
         //TODO: array not UObject TArray ServerActors
         //TODO: array not UObject TArray RuntimeServerActors
        public bool bStartedLoadMapMovie {
            get {return Main.GetGetBoolPropertyByName(this, "bStartedLoadMapMovie"); }
            set {Main.SetGetBoolPropertyByName(this, "bStartedLoadMapMovie", value); }
        }
        ///<summary>Next World Context Handle</summary>
        public unsafe int NextWorldContextHandle {
            get {return Engine_ptr->NextWorldContextHandle;}
            set {Engine_ptr->NextWorldContextHandle = value;}
        }
        static Engine() {
            StaticClass = Main.GetClass("Engine");
        }
        internal unsafe Engine_fields* Engine_ptr => (Engine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Engine(IntPtr p) => UObject.Make<Engine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Engine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Engine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
