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
    ///<summary>Editor Level Utils</summary>
    public unsafe partial class EditorLevelUtils : UObject  {

        ///<summary>
        ///Creates a new streaming level in the current world
        ///@
        ///</summary>
        ///<remarks>
        ///param       LevelStreamingClass                                     The streaming class type instead to use for the level.
        ///@param       NewLevelPath                                            Optional path to the level package path format ("e.g /Game/MyLevel").  If empty, the user will be prompted during the save process.
        ///@param       bMoveSelectedActorsIntoNewLevel         If true, move any selected actors into the new level.
        ///
        ///@return      Returns the newly created level, or NULL on failure
        ///</remarks>
        public static LevelStreaming CreateNewStreamingLevel(SubclassOf<LevelStreaming> LevelStreamingClass, string NewLevelPath, bool bMoveSelectedActorsIntoNewLevel)  => 
            EditorLevelUtils_methods.CreateNewStreamingLevel_method.Invoke(LevelStreamingClass, NewLevelPath, bMoveSelectedActorsIntoNewLevel);

        ///<summary>Makes the specified streaming level the current level for editing.</summary>
        ///<remarks>
        ///The current level is where actors are spawned to when calling SpawnActor
        ///
        ///@return      true    If a level was removed.
        ///</remarks>
        public static void MakeLevelCurrent(LevelStreaming InStreamingLevel)  => 
            EditorLevelUtils_methods.MakeLevelCurrent_method.Invoke(InStreamingLevel);

        ///<summary>Moves the specified list of actors to the specified streaming level.</summary>
        ///<remarks>
        ///The new actors will be selected
        ///
        ///@param       ActorsToMove                    List of actors to move
        ///@param       DestStreamingLevel              The destination streaming level of the current world to move the actors to
        ///@param       bWarnAboutReferences    Whether or not to show a modal warning about referenced actors that may no longer function after being moved
        ///@return                                                      The number of actors that were successfully moved to the new level
        ///</remarks>
        public static int MoveActorsToLevel(byte ActorsToMove /*TODO: array TArray */, LevelStreaming DestStreamingLevel, bool bWarnAboutReferences)  => 
            EditorLevelUtils_methods.MoveActorsToLevel_method.Invoke(ActorsToMove, DestStreamingLevel, bWarnAboutReferences);

        ///<summary>Moves the currently selected actors to the specified streaming level.</summary>
        ///<remarks>
        ///The new actors will be selected
        ///
        ///@param       DestStreamingLevel              The destination streaming level of the current world to move the actors to
        ///@param       bWarnAboutReferences    Whether or not to show a modal warning about referenced actors that may no longer function after being moved
        ///@return                                                      The number of actors that were successfully moved to the new level
        ///</remarks>
        public static int MoveSelectedActorsToLevel(LevelStreaming DestLevel, bool bWarnAboutReferences)  => 
            EditorLevelUtils_methods.MoveSelectedActorsToLevel_method.Invoke(DestLevel, bWarnAboutReferences);
        static EditorLevelUtils() {
            StaticClass = Main.GetClass("EditorLevelUtils");
        }
        internal unsafe EditorLevelUtils_fields* EditorLevelUtils_ptr => (EditorLevelUtils_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditorLevelUtils(IntPtr p) => UObject.Make<EditorLevelUtils>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditorLevelUtils DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditorLevelUtils New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
