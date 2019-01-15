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
    ///<summary>
    ///Abstract base class of container object encapsulating data required for streaming and providing
    ///interface for when a level should be streamed in and out of memory.
    ///</summary>
    public unsafe partial class LevelStreaming : UObject  {

        ///<summary>Creates a new instance of this streaming level with a provided unique instance name</summary>
        public LevelStreaming CreateInstance(string UniqueInstanceName)  => 
            LevelStreaming_methods.CreateInstance_method.Invoke(ObjPointer, UniqueInstanceName);

        ///<summary>Returns the Level Script Actor of the level if the level is loaded and valid</summary>
        public LevelScriptActor GetLevelScriptActor()  => 
            LevelStreaming_methods.GetLevelScriptActor_method.Invoke(ObjPointer);

        ///<summary>Gets the package name for the world asset referred to by this level streaming as an FName</summary>
        public Name GetWorldAssetPackageFName()  => 
            LevelStreaming_methods.GetWorldAssetPackageFName_method.Invoke(ObjPointer);

        ///<summary>Returns whether streaming level is loaded</summary>
        public bool IsLevelLoaded()  => 
            LevelStreaming_methods.IsLevelLoaded_method.Invoke(ObjPointer);

        ///<summary>Returns whether streaming level is visible</summary>
        public bool IsLevelVisible()  => 
            LevelStreaming_methods.IsLevelVisible_method.Invoke(ObjPointer);

        ///<summary>Returns whether level has streaming state change pending</summary>
        public bool IsStreamingStatePending()  => 
            LevelStreaming_methods.IsStreamingStatePending_method.Invoke(ObjPointer);

        ///<summary>Sets the world composition level LOD index and marks the streaming level as requiring consideration.</summary>
        public void SetLevelLODIndex(int LODIndex)  => 
            LevelStreaming_methods.SetLevelLODIndex_method.Invoke(ObjPointer, LODIndex);

        ///<summary>Virtual that can be overriden to change whether a streaming level should be loaded.</summary>
        ///<remarks>Doesn't do anything at the base level as should be loaded defaults to true</remarks>
        public void SetShouldBeLoaded(bool bInShouldBeLoaded)  => 
            LevelStreaming_methods.SetShouldBeLoaded_method.Invoke(ObjPointer, bInShouldBeLoaded);

        ///<summary>Sets the should be visible flag and marks the streaming level as requiring consideration.</summary>
        public void SetShouldBeVisible(bool bInShouldBeVisible)  => 
            LevelStreaming_methods.SetShouldBeVisible_method.Invoke(ObjPointer, bInShouldBeVisible);

        ///<summary>
        ///Return whether this level should be present in memory which in turn tells the
        ///streaming code to stream it in.
        ///</summary>
        ///<remarks>
        ///Please note that a change in value from false
        ///to true only tells the streaming code that it needs to START streaming it in
        ///so the code needs to return true an appropriate amount of time before it is
        ///needed.
        ///
        ///@return true if level should be loaded/ streamed in, false otherwise
        ///</remarks>
        public bool ShouldBeLoaded()  => 
            LevelStreaming_methods.ShouldBeLoaded_method.Invoke(ObjPointer);
         //TODO: soft object TSoftObjectPtr<UWorld> WorldAsset
        ///<summary>If this isn't Name_None, then we load from this package on disk to the new package named PackageName</summary>
        public unsafe Name PackageNameToLoad {
            get {return LevelStreaming_ptr->PackageNameToLoad;}
            set {LevelStreaming_ptr->PackageNameToLoad = value;}
        }
         //TODO: array not UObject TArray LODPackageNames
        ///<summary>Transform applied to actors after loading.</summary>
        public unsafe Transform LevelTransform {
            get {return LevelStreaming_ptr->LevelTransform;}
            set {LevelStreaming_ptr->LevelTransform = value;}
        }
        ///<summary>Requested LOD. Non LOD sub-levels have Index = -1</summary>
        public unsafe int LevelLODIndex {
            get {return LevelStreaming_ptr->LevelLODIndex;}
            set {LevelStreaming_ptr->LevelLODIndex = value;}
        }
        public bool bShouldBeVisibleInEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBeVisibleInEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBeVisibleInEditor", value); }
        }
        public bool bShouldBeVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBeVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBeVisible", value); }
        }
        public bool bShouldBeLoaded {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBeLoaded"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBeLoaded", value); }
        }
        public bool bLocked {
            get {return Main.GetGetBoolPropertyByName(this, "bLocked"); }
            set {Main.SetGetBoolPropertyByName(this, "bLocked", value); }
        }
        public bool bIsStatic {
            get {return Main.GetGetBoolPropertyByName(this, "bIsStatic"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsStatic", value); }
        }
        public bool bShouldBlockOnLoad {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBlockOnLoad"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBlockOnLoad", value); }
        }
        public bool bShouldBlockOnUnload {
            get {return Main.GetGetBoolPropertyByName(this, "bShouldBlockOnUnload"); }
            set {Main.SetGetBoolPropertyByName(this, "bShouldBlockOnUnload", value); }
        }
        public bool bDisableDistanceStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableDistanceStreaming"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableDistanceStreaming", value); }
        }
        public bool bDrawOnLevelStatusMap {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawOnLevelStatusMap"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawOnLevelStatusMap", value); }
        }
        ///<summary>The level color used for visualization. (Show -> Advanced -> Level Coloration)</summary>
        public unsafe LinearColor LevelColor {
            get {return LevelStreaming_ptr->LevelColor;}
            set {LevelStreaming_ptr->LevelColor = value;}
        }
        ///<summary>The level streaming volumes bound to this level.</summary>
        public ObjectArrayField<LevelStreamingVolume> EditorStreamingVolumes{ get {
            if(EditorStreamingVolumes_store == null) EditorStreamingVolumes_store = new ObjectArrayField<LevelStreamingVolume> (&LevelStreaming_ptr->EditorStreamingVolumes);
            return EditorStreamingVolumes_store;
        } }
        private ObjectArrayField<LevelStreamingVolume> EditorStreamingVolumes_store;

        ///<summary>Cooldown time in seconds between volume-based unload requests.  Used in preventing spurious unload requests.</summary>
        public unsafe float MinTimeBetweenVolumeUnloadRequests {
            get {return LevelStreaming_ptr->MinTimeBetweenVolumeUnloadRequests;}
            set {LevelStreaming_ptr->MinTimeBetweenVolumeUnloadRequests = value;}
        }
         //TODO: array not UObject TArray Keywords
         //TODO: multicast delegate FLevelStreamingLoadedStatus OnLevelLoaded
         //TODO: multicast delegate FLevelStreamingLoadedStatus OnLevelUnloaded
         //TODO: multicast delegate FLevelStreamingVisibilityStatus OnLevelShown
         //TODO: multicast delegate FLevelStreamingVisibilityStatus OnLevelHidden
        ///<summary>Pointer to Level object if currently loaded/ streamed in.</summary>
        public unsafe Level LoadedLevel {
            get {return LevelStreaming_ptr->LoadedLevel;}
            set {LevelStreaming_ptr->LoadedLevel = value;}
        }
        ///<summary>Pointer to a Level object that was previously active and was replaced with a new LoadedLevel (for LOD switching)</summary>
        public unsafe Level PendingUnloadLevel {
            get {return LevelStreaming_ptr->PendingUnloadLevel;}
            set {LevelStreaming_ptr->PendingUnloadLevel = value;}
        }
        ///<summary>The folder path for this level within the world browser.</summary>
        ///<remarks>
        ///This is only available in editor builds.
        ///              A NONE path indicates that it exists at the root. It is '/' separated.
        ///</remarks>
        public unsafe Name FolderPath {
            get {return LevelStreaming_ptr->FolderPath;}
            set {LevelStreaming_ptr->FolderPath = value;}
        }
        static LevelStreaming() {
            StaticClass = Main.GetClass("LevelStreaming");
        }
        internal unsafe LevelStreaming_fields* LevelStreaming_ptr => (LevelStreaming_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelStreaming(IntPtr p) => UObject.Make<LevelStreaming>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelStreaming DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelStreaming New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
