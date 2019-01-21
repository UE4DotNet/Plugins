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
    ///<summary>Level Streaming Dynamic</summary>
    public unsafe partial class LevelStreamingDynamic : LevelStreaming  {

        ///<summary>Stream in a level with a specific location and rotation.</summary>
        ///<remarks>
        ///You can create multiple instances of the same level!
        ///
        ///The level to be loaded does not have to be in the persistent map's Levels list, however to ensure that the .umap does get
        ///packaged, please be sure to include the .umap in your Packaging Settings:
        ///
        ///  Project Settings -> Packaging -> List of Maps to Include in a Packaged Build (you may have to show advanced or type in filter)
        ///
        ///@param LevelName - Level package name, ex: /Game/Maps/MyMapName, specifying short name like MyMapName will force very slow search on disk
        ///@param Location - World space location where the level should be spawned
        ///@param Rotation - World space rotation for rotating the entire level
        ///@param bOutSuccess - Whether operation was successful (map was found and added to the sub-levels list)
        ///@return Streaming level object for a level instance
        ///</remarks>
        public static (bool, LevelStreamingDynamic) LoadLevelInstance(UObject WorldContextObject, string LevelName, Vector Location, Rotator Rotation)  => 
            LevelStreamingDynamic_methods.LoadLevelInstance_method.Invoke(WorldContextObject, LevelName, Location, Rotation);

        ///<summary>Load Level Instance by Soft Object Ptr</summary>
        public static (bool, LevelStreamingDynamic) LoadLevelInstanceBySoftObjectPtr(UObject WorldContextObject, byte Level /*TODO: soft object TSoftObjectPtr<UWorld> */, Vector Location, Rotator Rotation)  => 
            LevelStreamingDynamic_methods.LoadLevelInstanceBySoftObjectPtr_method.Invoke(WorldContextObject, Level, Location, Rotation);
        public bool bInitiallyLoaded {
            get {return Main.GetGetBoolPropertyByName(this, "bInitiallyLoaded"); }
            set {Main.SetGetBoolPropertyByName(this, "bInitiallyLoaded", value); }
        }
        public bool bInitiallyVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bInitiallyVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bInitiallyVisible", value); }
        }
        static LevelStreamingDynamic() {
            StaticClass = Main.GetClass("LevelStreamingDynamic");
        }
        internal unsafe LevelStreamingDynamic_fields* LevelStreamingDynamic_ptr => (LevelStreamingDynamic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LevelStreamingDynamic(IntPtr p) => UObject.Make<LevelStreamingDynamic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LevelStreamingDynamic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LevelStreamingDynamic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
