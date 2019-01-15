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
    ///<summary>The World is the top level object representing a map or a sandbox in which Actors and Components will exist and be rendered.</summary>
    ///<remarks>
    ///A World can be a single Persistent Level with an optional list of streaming levels that are loaded and unloaded via volumes and blueprint functions
    ///or it can be a collection of levels organized with a World Composition.
    ///
    ///In a standalone game, generally only a single World exists except during seamless area transitions when both a destination and current world exists.
    ///In the editor many Worlds exist: The level being edited, each PIE instance, each editor tool which has an interactive rendered viewport, and many more.
    ///</remarks>
    public unsafe partial class World : UObject  {
        ///<summary>List of all the layers referenced by the world's actors</summary>
        public ObjectArrayField<Layer> Layers{ get {
            if(Layers_store == null) Layers_store = new ObjectArrayField<Layer> (&World_ptr->Layers);
            return Layers_store;
        } }
        private ObjectArrayField<Layer> Layers_store;

        ///<summary>Group actors currently "active"</summary>
        public ObjectArrayField<Actor> ActiveGroupActors{ get {
            if(ActiveGroupActors_store == null) ActiveGroupActors_store = new ObjectArrayField<Actor> (&World_ptr->ActiveGroupActors);
            return ActiveGroupActors_store;
        } }
        private ObjectArrayField<Actor> ActiveGroupActors_store;

        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return World_ptr->ThumbnailInfo;}
            set {World_ptr->ThumbnailInfo = value;}
        }
        ///<summary>Persistent level containing the world info, default brush and actors spawned during gameplay among other things</summary>
        public unsafe Level PersistentLevel {
            get {return World_ptr->PersistentLevel;}
            set {World_ptr->PersistentLevel = value;}
        }
        ///<summary>The NAME_GameNetDriver game connection(s) for client/server communication</summary>
        public unsafe NetDriver NetDriver {
            get {return World_ptr->NetDriver;}
            set {World_ptr->NetDriver = value;}
        }
        ///<summary>Line Batchers. All lines to be drawn in the world.</summary>
        public unsafe LineBatchComponent LineBatcher {
            get {return World_ptr->LineBatcher;}
            set {World_ptr->LineBatcher = value;}
        }
        ///<summary>Persistent Line Batchers. They don't get flushed every frame.</summary>
        public unsafe LineBatchComponent PersistentLineBatcher {
            get {return World_ptr->PersistentLineBatcher;}
            set {World_ptr->PersistentLineBatcher = value;}
        }
        ///<summary>Foreground Line Batchers. This can't be Persistent.</summary>
        public unsafe LineBatchComponent ForegroundLineBatcher {
            get {return World_ptr->ForegroundLineBatcher;}
            set {World_ptr->ForegroundLineBatcher = value;}
        }
        ///<summary>Instance of this world's game-specific networking management</summary>
        public unsafe GameNetworkManager NetworkManager {
            get {return World_ptr->NetworkManager;}
            set {World_ptr->NetworkManager = value;}
        }
        ///<summary>Instance of this world's game-specific physics collision handler</summary>
        public unsafe PhysicsCollisionHandler PhysicsCollisionHandler {
            get {return World_ptr->PhysicsCollisionHandler;}
            set {World_ptr->PhysicsCollisionHandler = value;}
        }
        ///<summary>Array of any additional objects that need to be referenced by this world, to make sure they aren't GC'd</summary>
        public ObjectArrayField<UObject> ExtraReferencedObjects{ get {
            if(ExtraReferencedObjects_store == null) ExtraReferencedObjects_store = new ObjectArrayField<UObject> (&World_ptr->ExtraReferencedObjects);
            return ExtraReferencedObjects_store;
        } }
        private ObjectArrayField<UObject> ExtraReferencedObjects_store;

        ///<summary>External modules can have additional data associated with this UWorld.</summary>
        ///<remarks>
        ///This is a list of per module world data objects. These aren't
        ///loaded/saved by default.
        ///</remarks>
        public ObjectArrayField<UObject> PerModuleDataObjects{ get {
            if(PerModuleDataObjects_store == null) PerModuleDataObjects_store = new ObjectArrayField<UObject> (&World_ptr->PerModuleDataObjects);
            return PerModuleDataObjects_store;
        } }
        private ObjectArrayField<UObject> PerModuleDataObjects_store;

        ///<summary>Level collection. ULevels are referenced by FName (Package name) to avoid serialized references. Also contains offsets in world units</summary>
        public ObjectArrayField<LevelStreaming> StreamingLevels{ get {
            if(StreamingLevels_store == null) StreamingLevels_store = new ObjectArrayField<LevelStreaming> (&World_ptr->StreamingLevels);
            return StreamingLevels_store;
        } }
        private ObjectArrayField<LevelStreaming> StreamingLevels_store;

         //TODO: set TSet StreamingLevelsToConsider
         //TODO: string FString StreamingLevelsPrefix
        ///<summary>Pointer to the current level in the queue to be made visible, NULL if none are pending.</summary>
        public unsafe Level CurrentLevelPendingVisibility {
            get {return World_ptr->CurrentLevelPendingVisibility;}
            set {World_ptr->CurrentLevelPendingVisibility = value;}
        }
        ///<summary>Pointer to the current level in the queue to be made invisible, NULL if none are pending.</summary>
        public unsafe Level CurrentLevelPendingInvisibility {
            get {return World_ptr->CurrentLevelPendingInvisibility;}
            set {World_ptr->CurrentLevelPendingInvisibility = value;}
        }
        ///<summary>Fake NetDriver for capturing network traffic to record demos</summary>
        public unsafe DemoNetDriver DemoNetDriver {
            get {return World_ptr->DemoNetDriver;}
            set {World_ptr->DemoNetDriver = value;}
        }
        ///<summary>Particle event manager *</summary>
        public unsafe ParticleEventManager MyParticleEventManager {
            get {return World_ptr->MyParticleEventManager;}
            set {World_ptr->MyParticleEventManager = value;}
        }
        ///<summary>DefaultPhysicsVolume used for whole game *</summary>
        public unsafe PhysicsVolume DefaultPhysicsVolume {
            get {return World_ptr->DefaultPhysicsVolume;}
            set {World_ptr->DefaultPhysicsVolume = value;}
        }
        ///<summary>The world's navigation data manager</summary>
        public unsafe NavigationSystemBase NavigationSystem {
            get {return World_ptr->NavigationSystem;}
            set {World_ptr->NavigationSystem = value;}
        }
        ///<summary>The current GameMode, valid only on the server</summary>
        public unsafe GameModeBase AuthorityGameMode {
            get {return World_ptr->AuthorityGameMode;}
            set {World_ptr->AuthorityGameMode = value;}
        }
        ///<summary>The replicated actor which contains game state information that can be accessible to clients. Direct access is not allowed, use GetGameState<>()</summary>
        public unsafe GameStateBase GameState {
            get {return World_ptr->GameState;}
            set {World_ptr->GameState = value;}
        }
        ///<summary>The AI System handles generating pathing information and AI behavior</summary>
        public unsafe AISystemBase AISystem {
            get {return World_ptr->AISystem;}
            set {World_ptr->AISystem = value;}
        }
        ///<summary>RVO avoidance manager used by game</summary>
        public unsafe AvoidanceManager AvoidanceManager {
            get {return World_ptr->AvoidanceManager;}
            set {World_ptr->AvoidanceManager = value;}
        }
        ///<summary>Array of levels currently in this world. Not serialized to disk to avoid hard references.</summary>
        public ObjectArrayField<Level> Levels{ get {
            if(Levels_store == null) Levels_store = new ObjectArrayField<Level> (&World_ptr->Levels);
            return Levels_store;
        } }
        private ObjectArrayField<Level> Levels_store;

         //TODO: array not UObject TArray LevelCollections
        ///<summary>Pointer to the current level being edited. Level has to be in the Levels array and == PersistentLevel in the game.</summary>
        public unsafe Level CurrentLevel {
            get {return World_ptr->CurrentLevel;}
            set {World_ptr->CurrentLevel = value;}
        }
        ///<summary>Owning Game Instance</summary>
        public unsafe GameInstance OwningGameInstance {
            get {return World_ptr->OwningGameInstance;}
            set {World_ptr->OwningGameInstance = value;}
        }
        ///<summary>Parameter collection instances that hold parameter overrides for this world.</summary>
        public ObjectArrayField<MaterialParameterCollectionInstance> ParameterCollectionInstances{ get {
            if(ParameterCollectionInstances_store == null) ParameterCollectionInstances_store = new ObjectArrayField<MaterialParameterCollectionInstance> (&World_ptr->ParameterCollectionInstances);
            return ParameterCollectionInstances_store;
        } }
        private ObjectArrayField<MaterialParameterCollectionInstance> ParameterCollectionInstances_store;

        ///<summary>Canvas object used for drawing to render targets from blueprint functions eg DrawMaterialToRenderTarget.</summary>
        ///<remarks>This is cached as UCanvas creation takes >100ms.</remarks>
        public unsafe Canvas CanvasForRenderingToTarget {
            get {return World_ptr->CanvasForRenderingToTarget;}
            set {World_ptr->CanvasForRenderingToTarget = value;}
        }
        ///<summary>Canvas for Draw Material to Render Target</summary>
        public unsafe Canvas CanvasForDrawMaterialToRenderTarget {
            get {return World_ptr->CanvasForDrawMaterialToRenderTarget;}
            set {World_ptr->CanvasForDrawMaterialToRenderTarget = value;}
        }
         //TODO: array not UObject TArray EditorViews
        ///<summary>Array of selected levels currently in this world. Not serialized to disk to avoid hard references.</summary>
        public ObjectArrayField<Level> SelectedLevels{ get {
            if(SelectedLevels_store == null) SelectedLevels_store = new ObjectArrayField<Level> (&World_ptr->SelectedLevels);
            return SelectedLevels_store;
        } }
        private ObjectArrayField<Level> SelectedLevels_store;

        ///<summary>All levels information from which our world is composed</summary>
        public unsafe WorldComposition WorldComposition {
            get {return World_ptr->WorldComposition;}
            set {World_ptr->WorldComposition = value;}
        }
        public bool bAreConstraintsDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bAreConstraintsDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bAreConstraintsDirty", value); }
        }
        ///<summary>PSCPool</summary>
        public unsafe WorldPSCPool PSCPool {
            get {return World_ptr->PSCPool;}
            set {World_ptr->PSCPool = value;}
        }
        static World() {
            StaticClass = Main.GetClass("World");
        }
        internal unsafe World_fields* World_ptr => (World_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator World(IntPtr p) => UObject.Make<World>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static World DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static World New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
