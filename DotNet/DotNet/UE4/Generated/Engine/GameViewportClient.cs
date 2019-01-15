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
    ///A game viewport (FViewport) is a high-level abstract interface for the
    ///platform specific rendering, audio, and input subsystems.
    ///</summary>
    ///<remarks>
    ///GameViewportClient is the engine's interface to a game viewport.
    ///Exactly one GameViewportClient is created for each instance of the game.  The
    ///only case (so far) where you might have a single instance of Engine, but
    ///multiple instances of the game (and thus multiple GameViewportClients) is when
    ///you have more than one PIE window running.
    ///
    ///Responsibilities:
    ///propagating input events to the global interactions list
    ///
    ///@see UGameViewportClient
    ///</remarks>
    public unsafe partial class GameViewportClient : ScriptViewportClient  {
        ///<summary>The viewport's console.   Might be null on consoles</summary>
        public unsafe Console ViewportConsole {
            get {return GameViewportClient_ptr->ViewportConsole;}
            set {GameViewportClient_ptr->ViewportConsole = value;}
        }
         //TODO: array not UObject TArray DebugProperties
        ///<summary>The relative world context for this viewport</summary>
        public unsafe World World {
            get {return GameViewportClient_ptr->World;}
            set {GameViewportClient_ptr->World = value;}
        }
        ///<summary>Game Instance</summary>
        public unsafe GameInstance GameInstance {
            get {return GameViewportClient_ptr->GameInstance;}
            set {GameViewportClient_ptr->GameInstance = value;}
        }
        static GameViewportClient() {
            StaticClass = Main.GetClass("GameViewportClient");
        }
        internal unsafe GameViewportClient_fields* GameViewportClient_ptr => (GameViewportClient_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameViewportClient(IntPtr p) => UObject.Make<GameViewportClient>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameViewportClient DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameViewportClient New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
