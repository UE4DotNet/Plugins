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
using UE4.EngineSettings.Native;

namespace UE4.EngineSettings {
    ///<summary>Game Maps Settings</summary>
    public unsafe partial class GameMapsSettings : UObject  {
        ///<summary>If set, this map will be loaded when the Editor starts up.</summary>
        public unsafe SoftObjectPath EditorStartupMap {
            get {return GameMapsSettings_ptr->EditorStartupMap;}
            set {GameMapsSettings_ptr->EditorStartupMap = value;}
        }
         //TODO: string FString LocalMapOptions
        ///<summary>The map loaded when transition from one map to another.</summary>
        public unsafe SoftObjectPath TransitionMap {
            get {return GameMapsSettings_ptr->TransitionMap;}
            set {GameMapsSettings_ptr->TransitionMap = value;}
        }
        public bool bUseSplitscreen {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSplitscreen"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSplitscreen", value); }
        }
        ///<summary>The viewport layout to use if the screen should be split and there are two local players</summary>
        public unsafe byte TwoPlayerSplitscreenLayout {
            get {return GameMapsSettings_ptr->TwoPlayerSplitscreenLayout;}
            set {GameMapsSettings_ptr->TwoPlayerSplitscreenLayout = value;}
        }
        ///<summary>The viewport layout to use if the screen should be split and there are three local players</summary>
        public unsafe byte ThreePlayerSplitscreenLayout {
            get {return GameMapsSettings_ptr->ThreePlayerSplitscreenLayout;}
            set {GameMapsSettings_ptr->ThreePlayerSplitscreenLayout = value;}
        }
        public bool bOffsetPlayerGamepadIds {
            get {return Main.GetGetBoolPropertyByName(this, "bOffsetPlayerGamepadIds"); }
            set {Main.SetGetBoolPropertyByName(this, "bOffsetPlayerGamepadIds", value); }
        }
        ///<summary>The class to use when instantiating the transient GameInstance class</summary>
        public unsafe SoftClassPath GameInstanceClass {
            get {return GameMapsSettings_ptr->GameInstanceClass;}
            set {GameMapsSettings_ptr->GameInstanceClass = value;}
        }
        ///<summary>The map that will be loaded by default when no other map is loaded.</summary>
        public unsafe SoftObjectPath GameDefaultMap {
            get {return GameMapsSettings_ptr->GameDefaultMap;}
            set {GameMapsSettings_ptr->GameDefaultMap = value;}
        }
        ///<summary>The map that will be loaded by default when no other map is loaded (DEDICATED SERVER).</summary>
        public unsafe SoftObjectPath ServerDefaultMap {
            get {return GameMapsSettings_ptr->ServerDefaultMap;}
            set {GameMapsSettings_ptr->ServerDefaultMap = value;}
        }
        ///<summary>GameMode to use if not specified in any other way. (e.g. per-map DefaultGameMode or on the URL).</summary>
        public unsafe SoftClassPath GlobalDefaultGameMode {
            get {return GameMapsSettings_ptr->GlobalDefaultGameMode;}
            set {GameMapsSettings_ptr->GlobalDefaultGameMode = value;}
        }
        ///<summary>GameMode to use if not specified in any other way.</summary>
        ///<remarks>
        ///(e.g. per-map DefaultGameMode or on the URL) (DEDICATED SERVERS)
        ///If not set, the GlobalDefaultGameMode value will be used.
        ///</remarks>
        public unsafe SoftClassPath GlobalDefaultServerGameMode {
            get {return GameMapsSettings_ptr->GlobalDefaultServerGameMode;}
            set {GameMapsSettings_ptr->GlobalDefaultServerGameMode = value;}
        }
         //TODO: array not UObject TArray GameModeMapPrefixes
         //TODO: array not UObject TArray GameModeClassAliases
        static GameMapsSettings() {
            StaticClass = Main.GetClass("GameMapsSettings");
        }
        internal unsafe GameMapsSettings_fields* GameMapsSettings_ptr => (GameMapsSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameMapsSettings(IntPtr p) => UObject.Make<GameMapsSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameMapsSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameMapsSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
