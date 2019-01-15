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
    ///<summary>Acts as a game-specific wrapper around the session interface.</summary>
    ///<remarks>
    ///The game code makes calls to this when it needs to interact with the session interface.
    ///A game session exists only the server, while running an online game.
    ///</remarks>
    public unsafe partial class GameSession : Info  {
        ///<summary>Maximum number of spectators allowed by this server.</summary>
        public unsafe int MaxSpectators {
            get {return GameSession_ptr->MaxSpectators;}
            set {GameSession_ptr->MaxSpectators = value;}
        }
        ///<summary>Maximum number of players allowed by this server.</summary>
        public unsafe int MaxPlayers {
            get {return GameSession_ptr->MaxPlayers;}
            set {GameSession_ptr->MaxPlayers = value;}
        }
        ///<summary>Restrictions on the largest party that can join together</summary>
        public unsafe int MaxPartySize {
            get {return GameSession_ptr->MaxPartySize;}
            set {GameSession_ptr->MaxPartySize = value;}
        }
        ///<summary>Maximum number of splitscreen players to allow from one connection</summary>
        public unsafe byte MaxSplitscreensPerConnection {
            get {return GameSession_ptr->MaxSplitscreensPerConnection;}
            set {GameSession_ptr->MaxSplitscreensPerConnection = value;}
        }
        public bool bRequiresPushToTalk {
            get {return Main.GetGetBoolPropertyByName(this, "bRequiresPushToTalk"); }
            set {Main.SetGetBoolPropertyByName(this, "bRequiresPushToTalk", value); }
        }
        ///<summary>SessionName local copy from PlayerState class.  should really be define in this class, but need to address replication issues</summary>
        public unsafe Name SessionName {
            get {return GameSession_ptr->SessionName;}
            set {GameSession_ptr->SessionName = value;}
        }
        static GameSession() {
            StaticClass = Main.GetClass("GameSession");
        }
        internal unsafe GameSession_fields* GameSession_ptr => (GameSession_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameSession(IntPtr p) => UObject.Make<GameSession>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameSession DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameSession New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
