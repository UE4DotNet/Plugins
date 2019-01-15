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
    ///<summary>A Level is a collection of Actors (lights, volumes, mesh instances etc.</summary>
    ///<remarks>
    ///).
    ///Multiple Levels can be loaded and unloaded into the World to create a streaming experience.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Levels
    ///@see UActor
    ///</remarks>
    public unsafe partial class Level : UObject  {
        ///<summary>The World that has this level in its Levels array.</summary>
        ///<remarks>
        ///This is not the same as GetOuter(), because GetOuter() for a streaming level is a vestigial world that is not used.
        ///It should not be accessed during BeginDestroy(), just like any other UObject references, since GC may occur in any order.
        ///</remarks>
        public unsafe World OwningWorld {
            get {return Level_ptr->OwningWorld;}
            set {Level_ptr->OwningWorld = value;}
        }
        ///<summary>BSP UModel.</summary>
        public unsafe Model Model {
            get {return Level_ptr->Model;}
            set {Level_ptr->Model = value;}
        }
        ///<summary>BSP Model components used for rendering.</summary>
        public ObjectArrayField<ModelComponent> ModelComponents{ get {
            if(ModelComponents_store == null) ModelComponents_store = new ObjectArrayField<ModelComponent> (&Level_ptr->ModelComponents);
            return ModelComponents_store;
        } }
        private ObjectArrayField<ModelComponent> ModelComponents_store;

        ///<summary>Actor Cluster</summary>
        public unsafe LevelActorContainer ActorCluster {
            get {return Level_ptr->ActorCluster;}
            set {Level_ptr->ActorCluster = value;}
        }
        ///<summary>Reference to the blueprint for level scripting</summary>
        public unsafe LevelScriptBlueprint LevelScriptBlueprint {
            get {return Level_ptr->LevelScriptBlueprint;}
            set {Level_ptr->LevelScriptBlueprint = value;}
        }
         //TODO: array not UObject TArray TextureStreamingResourceGuids
        ///<summary>Num of components missing valid texture streaming data. Updated in map check.</summary>
        public unsafe int NumTextureStreamingUnbuiltComponents {
            get {return Level_ptr->NumTextureStreamingUnbuiltComponents;}
            set {Level_ptr->NumTextureStreamingUnbuiltComponents = value;}
        }
        ///<summary>Num of resources that have changed since the last texture streaming build. Updated in map check.</summary>
        public unsafe int NumTextureStreamingDirtyResources {
            get {return Level_ptr->NumTextureStreamingDirtyResources;}
            set {Level_ptr->NumTextureStreamingDirtyResources = value;}
        }
        ///<summary>The level scripting actor, created by instantiating the class from LevelScriptBlueprint.  This handles all level scripting</summary>
        public unsafe LevelScriptActor LevelScriptActor {
            get {return Level_ptr->LevelScriptActor;}
            set {Level_ptr->LevelScriptActor = value;}
        }
        ///<summary>
        ///Start and end of the navigation list for this level, used for quickly fixing up
        ///when streaming this level in/out.
        ///</summary>
        ///<remarks>
        ///@TODO DEPRECATED - DELETE
        ///</remarks>
        public unsafe NavigationObjectBase NavListStart {
            get {return Level_ptr->NavListStart;}
            set {Level_ptr->NavListStart = value;}
        }
        ///<summary>Nav List End</summary>
        public unsafe NavigationObjectBase NavListEnd {
            get {return Level_ptr->NavListEnd;}
            set {Level_ptr->NavListEnd = value;}
        }
        ///<summary>Navigation related data that can be stored per level</summary>
        public ObjectArrayField<NavigationDataChunk> NavDataChunks{ get {
            if(NavDataChunks_store == null) NavDataChunks_store = new ObjectArrayField<NavigationDataChunk> (&Level_ptr->NavDataChunks);
            return NavDataChunks_store;
        } }
        private ObjectArrayField<NavigationDataChunk> NavDataChunks_store;

        ///<summary>Total number of KB used for lightmap textures in the level.</summary>
        public unsafe float LightmapTotalSize {
            get {return Level_ptr->LightmapTotalSize;}
            set {Level_ptr->LightmapTotalSize = value;}
        }
        ///<summary>Total number of KB used for shadowmap textures in the level.</summary>
        public unsafe float ShadowmapTotalSize {
            get {return Level_ptr->ShadowmapTotalSize;}
            set {Level_ptr->ShadowmapTotalSize = value;}
        }
         //TODO: array not UObject TArray StaticNavigableGeometry
         //TODO: array not UObject TArray StreamingTextureGuids
        public bool bIsLightingScenario {
            get {return Main.GetGetBoolPropertyByName(this, "bIsLightingScenario"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsLightingScenario", value); }
        }
        ///<summary>Identifies map build data specific to this level, eg lighting volume samples.</summary>
        public unsafe FGuid LevelBuildDataId {
            get {return Level_ptr->LevelBuildDataId;}
            set {Level_ptr->LevelBuildDataId = value;}
        }
        ///<summary>Registry for data from the map build.</summary>
        ///<remarks>
        ///This is stored in a separate package from the level to speed up saving / autosaving.
        ///ReleaseRenderingResources must be called before changing what is referenced, to update the rendering thread state.
        ///</remarks>
        public unsafe MapBuildDataRegistry MapBuildData {
            get {return Level_ptr->MapBuildData;}
            set {Level_ptr->MapBuildData = value;}
        }
        ///<summary>Level offset at time when lighting was built</summary>
        public unsafe IntVector LightBuildLevelOffset {
            get {return Level_ptr->LightBuildLevelOffset;}
            set {Level_ptr->LightBuildLevelOffset = value;}
        }
        public bool bTextureStreamingRotationChanged {
            get {return Main.GetGetBoolPropertyByName(this, "bTextureStreamingRotationChanged"); }
            set {Main.SetGetBoolPropertyByName(this, "bTextureStreamingRotationChanged", value); }
        }
        public bool bStaticComponentsRegisteredInStreamingManager {
            get {return Main.GetGetBoolPropertyByName(this, "bStaticComponentsRegisteredInStreamingManager"); }
            set {Main.SetGetBoolPropertyByName(this, "bStaticComponentsRegisteredInStreamingManager", value); }
        }
        public bool bIsVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bIsVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsVisible", value); }
        }
        public bool bLocked {
            get {return Main.GetGetBoolPropertyByName(this, "bLocked"); }
            set {Main.SetGetBoolPropertyByName(this, "bLocked", value); }
        }
        ///<summary>Level simplification settings for each LOD</summary>
        public unsafe LevelSimplificationDetails LevelSimplification {
            get {return Level_ptr->LevelSimplification;}
            set {Level_ptr->LevelSimplification = value;}
        }
        ///<summary>The level color used for visualization.</summary>
        ///<remarks>
        ///(Show -> Advanced -> Level Coloration)
        ///Used only in world composition mode
        ///</remarks>
        public unsafe LinearColor LevelColor {
            get {return Level_ptr->LevelColor;}
            set {Level_ptr->LevelColor = value;}
        }
        ///<summary>World Settings</summary>
        public unsafe WorldSettings WorldSettings {
            get {return Level_ptr->WorldSettings;}
            set {Level_ptr->WorldSettings = value;}
        }
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&Level_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

         //TODO: array not UObject TArray DestroyedReplicatedStaticActors
        static Level() {
            StaticClass = Main.GetClass("Level");
        }
        internal unsafe Level_fields* Level_ptr => (Level_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Level(IntPtr p) => UObject.Make<Level>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Level DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Level New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
