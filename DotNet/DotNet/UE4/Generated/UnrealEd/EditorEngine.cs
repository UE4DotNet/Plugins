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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Engine that drives the Editor.</summary>
    ///<remarks>Separate from UGameEngine because it may have much different functionality than desired for an instance of a game itself.</remarks>
    public unsafe partial class EditorEngine : UE4.Engine.Engine  {
        ///<summary>Objects.</summary>
        public unsafe Model TempModel {
            get {return EditorEngine_ptr->TempModel;}
            set {EditorEngine_ptr->TempModel = value;}
        }
        ///<summary>Conversion Temp Model</summary>
        public unsafe Model ConversionTempModel {
            get {return EditorEngine_ptr->ConversionTempModel;}
            set {EditorEngine_ptr->ConversionTempModel = value;}
        }
        ///<summary>Trans</summary>
        public unsafe Transactor Trans {
            get {return EditorEngine_ptr->Trans;}
            set {EditorEngine_ptr->Trans = value;}
        }
        ///<summary>Textures.</summary>
        public unsafe Texture2D Bad {
            get {return EditorEngine_ptr->Bad;}
            set {EditorEngine_ptr->Bad = value;}
        }
        ///<summary>Font used by Canvas-based editors</summary>
        public unsafe Font EditorFont {
            get {return EditorEngine_ptr->EditorFont;}
            set {EditorEngine_ptr->EditorFont = value;}
        }
        ///<summary>Audio</summary>
        public unsafe SoundCue PreviewSoundCue {
            get {return EditorEngine_ptr->PreviewSoundCue;}
            set {EditorEngine_ptr->PreviewSoundCue = value;}
        }
        ///<summary>Preview Audio Component</summary>
        public unsafe AudioComponent PreviewAudioComponent {
            get {return EditorEngine_ptr->PreviewAudioComponent;}
            set {EditorEngine_ptr->PreviewAudioComponent = value;}
        }
        ///<summary>Used in UnrealEd for showing materials</summary>
        public unsafe StaticMesh EditorCube {
            get {return EditorEngine_ptr->EditorCube;}
            set {EditorEngine_ptr->EditorCube = value;}
        }
        ///<summary>Editor Sphere</summary>
        public unsafe StaticMesh EditorSphere {
            get {return EditorEngine_ptr->EditorSphere;}
            set {EditorEngine_ptr->EditorSphere = value;}
        }
        ///<summary>Editor Plane</summary>
        public unsafe StaticMesh EditorPlane {
            get {return EditorEngine_ptr->EditorPlane;}
            set {EditorEngine_ptr->EditorPlane = value;}
        }
        ///<summary>Editor Cylinder</summary>
        public unsafe StaticMesh EditorCylinder {
            get {return EditorEngine_ptr->EditorCylinder;}
            set {EditorEngine_ptr->EditorCylinder = value;}
        }
        public bool bFastRebuild {
            get {return Main.GetGetBoolPropertyByName(this, "bFastRebuild"); }
            set {Main.SetGetBoolPropertyByName(this, "bFastRebuild", value); }
        }
        public bool IsImportingT3D {
            get {return Main.GetGetBoolPropertyByName(this, "IsImportingT3D"); }
            set {Main.SetGetBoolPropertyByName(this, "IsImportingT3D", value); }
        }
         //TODO: numeric uint32 ClickFlags
        ///<summary>Parent Context</summary>
        public unsafe Package ParentContext {
            get {return EditorEngine_ptr->ParentContext;}
            set {EditorEngine_ptr->ParentContext = value;}
        }
        ///<summary>Unsnapped Click Location</summary>
        public unsafe Vector UnsnappedClickLocation {
            get {return EditorEngine_ptr->UnsnappedClickLocation;}
            set {EditorEngine_ptr->UnsnappedClickLocation = value;}
        }
        ///<summary>Click Location</summary>
        public unsafe Vector ClickLocation {
            get {return EditorEngine_ptr->ClickLocation;}
            set {EditorEngine_ptr->ClickLocation = value;}
        }
        ///<summary>Click Plane</summary>
        public unsafe Plane ClickPlane {
            get {return EditorEngine_ptr->ClickPlane;}
            set {EditorEngine_ptr->ClickPlane = value;}
        }
        ///<summary>Mouse Movement</summary>
        public unsafe Vector MouseMovement {
            get {return EditorEngine_ptr->MouseMovement;}
            set {EditorEngine_ptr->MouseMovement = value;}
        }
        ///<summary>Setting for the detail mode to show in the editor viewports</summary>
        public unsafe byte DetailMode {
            get {return EditorEngine_ptr->DetailMode;}
            set {EditorEngine_ptr->DetailMode = value;}
        }
        public bool UseSizingBox {
            get {return Main.GetGetBoolPropertyByName(this, "UseSizingBox"); }
            set {Main.SetGetBoolPropertyByName(this, "UseSizingBox", value); }
        }
        public bool UseAxisIndicator {
            get {return Main.GetGetBoolPropertyByName(this, "UseAxisIndicator"); }
            set {Main.SetGetBoolPropertyByName(this, "UseAxisIndicator", value); }
        }
        public bool GodMode {
            get {return Main.GetGetBoolPropertyByName(this, "GodMode"); }
            set {Main.SetGetBoolPropertyByName(this, "GodMode", value); }
        }
         //TODO: string FString GameCommandLine
        public bool bShowBrushMarkerPolys {
            get {return Main.GetGetBoolPropertyByName(this, "bShowBrushMarkerPolys"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowBrushMarkerPolys", value); }
        }
        public bool bEnableSocketSnapping {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSocketSnapping"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableSocketSnapping", value); }
        }
        public bool bEnableLODLocking {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableLODLocking"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableLODLocking", value); }
        }
         //TODO: string FString HeightMapExportClassName
        ///<summary>Array of actor factories created at editor startup and used by context menu etc.</summary>
        public ObjectArrayField<ActorFactory> ActorFactories{ get {
            if(ActorFactories_store == null) ActorFactories_store = new ObjectArrayField<ActorFactory> (&EditorEngine_ptr->ActorFactories);
            return ActorFactories_store;
        } }
        private ObjectArrayField<ActorFactory> ActorFactories_store;

         //TODO: string FString UserOpenedFile
         //TODO: string FString InEditorGameURLOptions
        ///<summary>A pointer to a UWorld that is the duplicated/saved-loaded to be played in with "Play From Here"</summary>
        public unsafe World PlayWorld {
            get {return EditorEngine_ptr->PlayWorld;}
            set {EditorEngine_ptr->PlayWorld = value;}
        }
        ///<summary>An optional location for the starting location for "Play From Here"</summary>
        public unsafe Vector PlayWorldLocation {
            get {return EditorEngine_ptr->PlayWorldLocation;}
            set {EditorEngine_ptr->PlayWorldLocation = value;}
        }
        ///<summary>An optional rotation for the starting location for "Play From Here"</summary>
        public unsafe Rotator PlayWorldRotation {
            get {return EditorEngine_ptr->PlayWorldRotation;}
            set {EditorEngine_ptr->PlayWorldRotation = value;}
        }
        public bool bIsPlayWorldQueued {
            get {return Main.GetGetBoolPropertyByName(this, "bIsPlayWorldQueued"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsPlayWorldQueued", value); }
        }
        public bool bIsToggleBetweenPIEandSIEQueued {
            get {return Main.GetGetBoolPropertyByName(this, "bIsToggleBetweenPIEandSIEQueued"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsToggleBetweenPIEandSIEQueued", value); }
        }
        public bool bIsSimulateInEditorQueued {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSimulateInEditorQueued"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSimulateInEditorQueued", value); }
        }
        public bool bAllowMultiplePIEWorlds {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowMultiplePIEWorlds"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowMultiplePIEWorlds", value); }
        }
        public bool bRequestEndPlayMapQueued {
            get {return Main.GetGetBoolPropertyByName(this, "bRequestEndPlayMapQueued"); }
            set {Main.SetGetBoolPropertyByName(this, "bRequestEndPlayMapQueued", value); }
        }
        public bool bHasPlayWorldPlacement {
            get {return Main.GetGetBoolPropertyByName(this, "bHasPlayWorldPlacement"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasPlayWorldPlacement", value); }
        }
        public bool bUseMobilePreviewForPlayWorld {
            get {return Main.GetGetBoolPropertyByName(this, "bUseMobilePreviewForPlayWorld"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseMobilePreviewForPlayWorld", value); }
        }
        public bool bUseVRPreviewForPlayWorld {
            get {return Main.GetGetBoolPropertyByName(this, "bUseVRPreviewForPlayWorld"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseVRPreviewForPlayWorld", value); }
        }
        public bool bIsSimulatingInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bIsSimulatingInEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsSimulatingInEditor", value); }
        }
        public bool bSquelchTransactionNotification {
            get {return Main.GetGetBoolPropertyByName(this, "bSquelchTransactionNotification"); }
            set {Main.SetGetBoolPropertyByName(this, "bSquelchTransactionNotification", value); }
        }
        ///<summary>The PlayerStart class used when spawning the player at the current camera location.</summary>
        public unsafe SubclassOf<NavigationObjectBase> PlayFromHerePlayerStartClass {
            get {return EditorEngine_ptr->PlayFromHerePlayerStartClass;}
            set {EditorEngine_ptr->PlayFromHerePlayerStartClass = value;}
        }
        ///<summary>When Simulating In Editor, a pointer to the original (non-simulating) editor world</summary>
        public unsafe World EditorWorld {
            get {return EditorEngine_ptr->EditorWorld;}
            set {EditorEngine_ptr->EditorWorld = value;}
        }
         //TODO: array not UObject TArray ActorsThatWereSelected
        ///<summary>Where did the person want to play? Where to play the game - -1 means in editor, 0 or more is an index into the GConsoleSupportContainer</summary>
        public unsafe int PlayWorldDestination {
            get {return EditorEngine_ptr->PlayWorldDestination;}
            set {EditorEngine_ptr->PlayWorldDestination = value;}
        }
        ///<summary>The current play world destination (I.E console).  -1 means no current play world destination, 0 or more is an index into the GConsoleSupportContainer</summary>
        public unsafe int CurrentPlayWorldDestination {
            get {return EditorEngine_ptr->CurrentPlayWorldDestination;}
            set {EditorEngine_ptr->CurrentPlayWorldDestination = value;}
        }
        public bool bMobilePreviewPortrait {
            get {return Main.GetGetBoolPropertyByName(this, "bMobilePreviewPortrait"); }
            set {Main.SetGetBoolPropertyByName(this, "bMobilePreviewPortrait", value); }
        }
        ///<summary>Currently targeted device for mobile previewer.</summary>
        public unsafe int BuildPlayDevice {
            get {return EditorEngine_ptr->BuildPlayDevice;}
            set {EditorEngine_ptr->BuildPlayDevice = value;}
        }
        ///<summary>When set to anything other than -1, indicates a specific In-Editor viewport index that PIE should use</summary>
        public unsafe int PlayInEditorViewportIndex {
            get {return EditorEngine_ptr->PlayInEditorViewportIndex;}
            set {EditorEngine_ptr->PlayInEditorViewportIndex = value;}
        }
         //TODO: string FString UserEditedPlayWorldURL
        ///<summary>Temporary render target that can be used by the editor.</summary>
        public unsafe TextureRenderTarget2D ScratchRenderTarget2048 {
            get {return EditorEngine_ptr->ScratchRenderTarget2048;}
            set {EditorEngine_ptr->ScratchRenderTarget2048 = value;}
        }
        ///<summary>Scratch Render Target 1024</summary>
        public unsafe TextureRenderTarget2D ScratchRenderTarget1024 {
            get {return EditorEngine_ptr->ScratchRenderTarget1024;}
            set {EditorEngine_ptr->ScratchRenderTarget1024 = value;}
        }
        ///<summary>Scratch Render Target 512</summary>
        public unsafe TextureRenderTarget2D ScratchRenderTarget512 {
            get {return EditorEngine_ptr->ScratchRenderTarget512;}
            set {EditorEngine_ptr->ScratchRenderTarget512 = value;}
        }
        ///<summary>Scratch Render Target 256</summary>
        public unsafe TextureRenderTarget2D ScratchRenderTarget256 {
            get {return EditorEngine_ptr->ScratchRenderTarget256;}
            set {EditorEngine_ptr->ScratchRenderTarget256 = value;}
        }
        ///<summary>A mesh component used to preview in editor without spawning a static mesh actor.</summary>
        public unsafe StaticMeshComponent PreviewMeshComp {
            get {return EditorEngine_ptr->PreviewMeshComp;}
            set {EditorEngine_ptr->PreviewMeshComp = value;}
        }
        ///<summary>The index of the mesh to use from the list of preview meshes.</summary>
        public unsafe int PreviewMeshIndex {
            get {return EditorEngine_ptr->PreviewMeshIndex;}
            set {EditorEngine_ptr->PreviewMeshIndex = value;}
        }
        public bool bShowPreviewMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bShowPreviewMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowPreviewMesh", value); }
        }
        public bool bCustomCameraAlignEmitter {
            get {return Main.GetGetBoolPropertyByName(this, "bCustomCameraAlignEmitter"); }
            set {Main.SetGetBoolPropertyByName(this, "bCustomCameraAlignEmitter", value); }
        }
        ///<summary>The distance to place the camera from an emitter actor when custom zooming is enabled</summary>
        public unsafe float CustomCameraAlignEmitterDistance {
            get {return EditorEngine_ptr->CustomCameraAlignEmitterDistance;}
            set {EditorEngine_ptr->CustomCameraAlignEmitterDistance = value;}
        }
        public bool bDrawSocketsInGMode {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawSocketsInGMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawSocketsInGMode", value); }
        }
        public bool bDrawParticleHelpers {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawParticleHelpers"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawParticleHelpers", value); }
        }
        ///<summary>Brush builders that have been created in the editor</summary>
        public ObjectArrayField<BrushBuilder> BrushBuilders{ get {
            if(BrushBuilders_store == null) BrushBuilders_store = new ObjectArrayField<BrushBuilder> (&EditorEngine_ptr->BrushBuilders);
            return BrushBuilders_store;
        } }
        private ObjectArrayField<BrushBuilder> BrushBuilders_store;

        ///<summary>Manager that holds all extensions paired with a world</summary>
        public unsafe EditorWorldExtensionManager EditorWorldExtensionsManager {
            get {return EditorEngine_ptr->EditorWorldExtensionsManager;}
            set {EditorEngine_ptr->EditorWorldExtensionsManager = value;}
        }
        ///<summary>Actor Grouping Utils Class Name</summary>
        public unsafe SoftClassPath ActorGroupingUtilsClassName {
            get {return EditorEngine_ptr->ActorGroupingUtilsClassName;}
            set {EditorEngine_ptr->ActorGroupingUtilsClassName = value;}
        }
        ///<summary>Actor Grouping Utils</summary>
        public unsafe ActorGroupingUtils ActorGroupingUtils {
            get {return EditorEngine_ptr->ActorGroupingUtils;}
            set {EditorEngine_ptr->ActorGroupingUtils = value;}
        }
        static EditorEngine() {
            StaticClass = Main.GetClass("EditorEngine");
        }
        internal unsafe EditorEngine_fields* EditorEngine_ptr => (EditorEngine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorEngine(IntPtr p) => UObject.Make<EditorEngine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorEngine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorEngine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
