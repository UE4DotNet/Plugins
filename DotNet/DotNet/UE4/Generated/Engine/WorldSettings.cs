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
    ///<summary>Actor containing all script accessible world properties.</summary>
    public unsafe partial class WorldSettings : Info  {
        public bool bEnableWorldBoundsChecks {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableWorldBoundsChecks"); }
        }
        public bool bEnableNavigationSystem {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableNavigationSystem"); }
        }
        public bool bEnableAISystem {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableAISystem"); }
        }
        public bool bEnableWorldComposition {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableWorldComposition"); }
        }
        public bool bUseClientSideLevelStreamingVolumes {
            get {return Main.GetGetBoolPropertyByName(this, "bUseClientSideLevelStreamingVolumes"); }
        }
        public bool bEnableWorldOriginRebasing {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableWorldOriginRebasing"); }
        }
        public bool bWorldGravitySet {
            get {return Main.GetGetBoolPropertyByName(this, "bWorldGravitySet"); }
            set {Main.SetGetBoolPropertyByName(this, "bWorldGravitySet", value); }
        }
        public bool bGlobalGravitySet {
            get {return Main.GetGetBoolPropertyByName(this, "bGlobalGravitySet"); }
        }
        ///<summary>Holds parameters for NavigationSystem's creation.</summary>
        ///<remarks>
        ///Set to Null will result
        ///    in NavigationSystem instance not being created for this world. Note that
        ///    if set NavigationSystemConfigOverride will be used instead.
        ///</remarks>
        public unsafe NavigationSystemConfig NavigationSystemConfig {
            get {return WorldSettings_ptr->NavigationSystemConfig;}
        }
        ///<summary>Overrides NavigationSystemConfig.</summary>
        public unsafe NavigationSystemConfig NavigationSystemConfigOverride {
            get {return WorldSettings_ptr->NavigationSystemConfigOverride;}
            set {WorldSettings_ptr->NavigationSystemConfigOverride = value;}
        }
        ///<summary>any actor falling below this level gets destroyed</summary>
        public unsafe float KillZ {
            get {return WorldSettings_ptr->KillZ;}
        }
        ///<summary>The type of damage inflicted when a actor falls below KillZ</summary>
        public unsafe SubclassOf<DamageType> KillZDamageType {
            get {return WorldSettings_ptr->KillZDamageType;}
        }
        ///<summary>current gravity actually being used</summary>
        public unsafe float WorldGravityZ {
            get {return WorldSettings_ptr->WorldGravityZ;}
            set {WorldSettings_ptr->WorldGravityZ = value;}
        }
        ///<summary>optional level specific gravity override set by level designer</summary>
        public unsafe float GlobalGravityZ {
            get {return WorldSettings_ptr->GlobalGravityZ;}
        }
        ///<summary>level specific default physics volume</summary>
        public unsafe SubclassOf<DefaultPhysicsVolume> DefaultPhysicsVolumeClass {
            get {return WorldSettings_ptr->DefaultPhysicsVolumeClass;}
        }
        ///<summary>optional level specific collision handler</summary>
        public unsafe SubclassOf<PhysicsCollisionHandler> PhysicsCollisionHandlerClass {
            get {return WorldSettings_ptr->PhysicsCollisionHandlerClass;}
        }
        ///<summary>The default GameMode to use when starting this map in the game. If this value is NULL, the INI setting for default game type is used.</summary>
        public unsafe SubclassOf<GameModeBase> DefaultGameMode {
            get {return WorldSettings_ptr->DefaultGameMode;}
        }
        ///<summary>Class of GameNetworkManager to spawn for network games</summary>
        public unsafe SubclassOf<GameNetworkManager> GameNetworkManagerClass {
            get {return WorldSettings_ptr->GameNetworkManagerClass;}
            set {WorldSettings_ptr->GameNetworkManagerClass = value;}
        }
        ///<summary>Maximum size of textures for packed light and shadow maps</summary>
        public unsafe int PackedLightAndShadowMapTextureSize {
            get {return WorldSettings_ptr->PackedLightAndShadowMapTextureSize;}
            set {WorldSettings_ptr->PackedLightAndShadowMapTextureSize = value;}
        }
        public bool bMinimizeBSPSections {
            get {return Main.GetGetBoolPropertyByName(this, "bMinimizeBSPSections"); }
            set {Main.SetGetBoolPropertyByName(this, "bMinimizeBSPSections", value); }
        }
        ///<summary>Default color scale for the level</summary>
        public unsafe Vector DefaultColorScale {
            get {return WorldSettings_ptr->DefaultColorScale;}
        }
        ///<summary>Max occlusion distance used by mesh distance fields, overridden if there is a movable skylight.</summary>
        public unsafe float DefaultMaxDistanceFieldOcclusionDistance {
            get {return WorldSettings_ptr->DefaultMaxDistanceFieldOcclusionDistance;}
            set {WorldSettings_ptr->DefaultMaxDistanceFieldOcclusionDistance = value;}
        }
        ///<summary>Distance from the camera that the global distance field should cover.</summary>
        public unsafe float GlobalDistanceFieldViewDistance {
            get {return WorldSettings_ptr->GlobalDistanceFieldViewDistance;}
            set {WorldSettings_ptr->GlobalDistanceFieldViewDistance = value;}
        }
        ///<summary>Controls the intensity of self-shadowing from capsule indirect shadows.</summary>
        ///<remarks>These types of shadows use approximate occluder representations, so reducing self-shadowing intensity can hide those artifacts.</remarks>
        public unsafe float DynamicIndirectShadowsSelfShadowingIntensity {
            get {return WorldSettings_ptr->DynamicIndirectShadowsSelfShadowingIntensity;}
            set {WorldSettings_ptr->DynamicIndirectShadowsSelfShadowingIntensity = value;}
        }
        public bool bPrecomputeVisibility {
            get {return Main.GetGetBoolPropertyByName(this, "bPrecomputeVisibility"); }
            set {Main.SetGetBoolPropertyByName(this, "bPrecomputeVisibility", value); }
        }
        public bool bPlaceCellsOnlyAlongCameraTracks {
            get {return Main.GetGetBoolPropertyByName(this, "bPlaceCellsOnlyAlongCameraTracks"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlaceCellsOnlyAlongCameraTracks", value); }
        }
        ///<summary>World space size of precomputed visibility cells in x and y.</summary>
        ///<remarks>Smaller sizes produce more effective occlusion culling at the cost of increased runtime memory usage and lighting build times.</remarks>
        public unsafe int VisibilityCellSize {
            get {return WorldSettings_ptr->VisibilityCellSize;}
            set {WorldSettings_ptr->VisibilityCellSize = value;}
        }
        ///<summary>Determines how aggressive precomputed visibility should be.</summary>
        ///<remarks>More aggressive settings cull more objects but also cause more visibility errors like popping.</remarks>
        public unsafe byte VisibilityAggressiveness {
            get {return WorldSettings_ptr->VisibilityAggressiveness;}
            set {WorldSettings_ptr->VisibilityAggressiveness = value;}
        }
        public bool bForceNoPrecomputedLighting {
            get {return Main.GetGetBoolPropertyByName(this, "bForceNoPrecomputedLighting"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceNoPrecomputedLighting", value); }
        }
        ///<summary>Lightmass Settings</summary>
        public unsafe LightmassWorldInfoSettings LightmassSettings {
            get {return WorldSettings_ptr->LightmassSettings;}
            set {WorldSettings_ptr->LightmassSettings = value;}
        }
        ///<summary>Default reverb settings used by audio volumes.</summary>
        public unsafe ReverbSettings DefaultReverbSettings {
            get {return WorldSettings_ptr->DefaultReverbSettings;}
            set {WorldSettings_ptr->DefaultReverbSettings = value;}
        }
        ///<summary>Default interior settings used by audio volumes.</summary>
        public unsafe InteriorSettings DefaultAmbientZoneSettings {
            get {return WorldSettings_ptr->DefaultAmbientZoneSettings;}
            set {WorldSettings_ptr->DefaultAmbientZoneSettings = value;}
        }
        ///<summary>Default Base SoundMix.</summary>
        public unsafe SoundMix DefaultBaseSoundMix {
            get {return WorldSettings_ptr->DefaultBaseSoundMix;}
            set {WorldSettings_ptr->DefaultBaseSoundMix = value;}
        }
        public bool bEnableHierarchicalLODSystem {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableHierarchicalLODSystem"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableHierarchicalLODSystem", value); }
        }
         //TODO: soft class TSoftClassPtr<UHierarchicalLODSetup>  HLODSetupAsset
         //TODO: soft object TSoftObjectPtr<UMaterialInterface> OverrideBaseMaterial
         //TODO: array not UObject TArray HierarchicalLODSetup
        ///<summary>Num HLODLevels</summary>
        public unsafe int NumHLODLevels {
            get {return WorldSettings_ptr->NumHLODLevels;}
            set {WorldSettings_ptr->NumHLODLevels = value;}
        }
        public bool bGenerateSingleClusterForLevel {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateSingleClusterForLevel"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateSingleClusterForLevel", value); }
        }
        ///<summary>scale of 1uu to 1m in real world measurements, for HMD and other physically tracked devices (e.g. 1uu = 1cm would be 100.0)</summary>
        public unsafe float WorldToMeters {
            get {return WorldSettings_ptr->WorldToMeters;}
        }
        ///<summary>Distance from the player after which content will be rendered in mono if monoscopic far field rendering is activated</summary>
        public unsafe float MonoCullingDistance {
            get {return WorldSettings_ptr->MonoCullingDistance;}
        }
        ///<summary>Book Marks</summary>
        public unsafe BookMark BookMarks {
            get {return WorldSettings_ptr->BookMarks;}
            set {WorldSettings_ptr->BookMarks = value;}
        }
        ///<summary>Normally 1 - scales real time passage.</summary>
        ///<remarks>Warning - most use cases should use GetEffectiveTimeDilation() instead of reading from this directly</remarks>
        public unsafe float TimeDilation {
            get {return WorldSettings_ptr->TimeDilation;}
            set {WorldSettings_ptr->TimeDilation = value;}
        }
        ///<summary>Additional time dilation used by Matinee (or Sequencer) slomo track.</summary>
        ///<remarks>
        ///Transient because this is often
        ///temporarily modified by the editor when previewing slow motion effects, yet we don't want it saved or loaded from level packages.
        ///</remarks>
        public unsafe float MatineeTimeDilation {
            get {return WorldSettings_ptr->MatineeTimeDilation;}
            set {WorldSettings_ptr->MatineeTimeDilation = value;}
        }
        ///<summary>Additional TimeDilation used to control demo playback speed</summary>
        public unsafe float DemoPlayTimeDilation {
            get {return WorldSettings_ptr->DemoPlayTimeDilation;}
            set {WorldSettings_ptr->DemoPlayTimeDilation = value;}
        }
        ///<summary>Lowest acceptable global time dilation.</summary>
        public unsafe float MinGlobalTimeDilation {
            get {return WorldSettings_ptr->MinGlobalTimeDilation;}
            set {WorldSettings_ptr->MinGlobalTimeDilation = value;}
        }
        ///<summary>Highest acceptable global time dilation.</summary>
        public unsafe float MaxGlobalTimeDilation {
            get {return WorldSettings_ptr->MaxGlobalTimeDilation;}
            set {WorldSettings_ptr->MaxGlobalTimeDilation = value;}
        }
        ///<summary>Smallest possible frametime, not considering dilation. Equiv to 1/FastestFPS.</summary>
        public unsafe float MinUndilatedFrameTime {
            get {return WorldSettings_ptr->MinUndilatedFrameTime;}
            set {WorldSettings_ptr->MinUndilatedFrameTime = value;}
        }
        ///<summary>Largest possible frametime, not considering dilation. Equiv to 1/SlowestFPS.</summary>
        public unsafe float MaxUndilatedFrameTime {
            get {return WorldSettings_ptr->MaxUndilatedFrameTime;}
            set {WorldSettings_ptr->MaxUndilatedFrameTime = value;}
        }
        ///<summary>If paused, FName of person pausing the game.</summary>
        public unsafe PlayerState Pauser {
            get {return WorldSettings_ptr->Pauser;}
            set {WorldSettings_ptr->Pauser = value;}
        }
        public bool bHighPriorityLoading {
            get {return Main.GetGetBoolPropertyByName(this, "bHighPriorityLoading"); }
            set {Main.SetGetBoolPropertyByName(this, "bHighPriorityLoading", value); }
        }
        public bool bHighPriorityLoadingLocal {
            get {return Main.GetGetBoolPropertyByName(this, "bHighPriorityLoadingLocal"); }
            set {Main.SetGetBoolPropertyByName(this, "bHighPriorityLoadingLocal", value); }
        }
         //TODO: array not UObject TArray ReplicationViewers
        public bool bOverrideDefaultBroadphaseSettings {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideDefaultBroadphaseSettings"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideDefaultBroadphaseSettings", value); }
        }
        ///<summary>Broadphase Settings</summary>
        public unsafe BroadphaseSettings BroadphaseSettings {
            get {return WorldSettings_ptr->BroadphaseSettings;}
            set {WorldSettings_ptr->BroadphaseSettings = value;}
        }
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&WorldSettings_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        ///<summary>Maximum number of bookmarks allowed.</summary>
        ///<remarks>
        ///Changing this will change the allocation of the bookmarks array, and when shrinking
        ///may cause some bookmarks to become eligible for GC.
        ///</remarks>
        public unsafe int MaxNumberOfBookmarks {
            get {return WorldSettings_ptr->MaxNumberOfBookmarks;}
            set {WorldSettings_ptr->MaxNumberOfBookmarks = value;}
        }
        ///<summary>Class that will be used when creating new bookmarks.</summary>
        ///<remarks>Old bookmarks may be recreated with the new class where possible.</remarks>
        public unsafe SubclassOf<BookmarkBase> DefaultBookmarkClass {
            get {return WorldSettings_ptr->DefaultBookmarkClass;}
            set {WorldSettings_ptr->DefaultBookmarkClass = value;}
        }
        ///<summary>Bookmark Array</summary>
        public ObjectArrayField<BookmarkBase> BookmarkArray{ get {
            if(BookmarkArray_store == null) BookmarkArray_store = new ObjectArrayField<BookmarkBase> (&WorldSettings_ptr->BookmarkArray);
            return BookmarkArray_store;
        } }
        private ObjectArrayField<BookmarkBase> BookmarkArray_store;

        ///<summary>Tracked so we can detect changes from Config</summary>
        public unsafe SubclassOf<BookmarkBase> LastBookmarkClass {
            get {return WorldSettings_ptr->LastBookmarkClass;}
            set {WorldSettings_ptr->LastBookmarkClass = value;}
        }
        static WorldSettings() {
            StaticClass = Main.GetClass("WorldSettings");
        }
        internal unsafe WorldSettings_fields* WorldSettings_ptr => (WorldSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WorldSettings(IntPtr p) => UObject.Make<WorldSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WorldSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WorldSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
