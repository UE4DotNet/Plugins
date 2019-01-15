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
    ///<summary>Game Session Settings</summary>
    public unsafe partial class GameSessionSettings : UObject  {
        ///<summary>Maximum number of spectators allowed by this server.</summary>
        public unsafe int MaxSpectators {
            get {return GameSessionSettings_ptr->MaxSpectators;}
            set {GameSessionSettings_ptr->MaxSpectators = value;}
        }
        ///<summary>Maximum number of players allowed by this server.</summary>
        public unsafe int MaxPlayers {
            get {return GameSessionSettings_ptr->MaxPlayers;}
            set {GameSessionSettings_ptr->MaxPlayers = value;}
        }
        public bool bRequiresPushToTalk {
            get {return Main.GetGetBoolPropertyByName(this, "bRequiresPushToTalk"); }
            set {Main.SetGetBoolPropertyByName(this, "bRequiresPushToTalk", value); }
        }
        static GameSessionSettings() {
            StaticClass = Main.GetClass("GameSessionSettings");
        }
        internal unsafe GameSessionSettings_fields* GameSessionSettings_ptr => (GameSessionSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameSessionSettings(IntPtr p) => UObject.Make<GameSessionSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameSessionSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameSessionSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
