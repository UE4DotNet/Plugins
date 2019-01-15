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
    ///<summary>GameState is a subclass of GameStateBase that behaves like a multiplayer match-based game.</summary>
    ///<remarks>It is tied to functionality in GameMode.</remarks>
    public unsafe partial class GameState : GameStateBase  {
        ///<summary>What match state we are currently in</summary>
        public unsafe Name MatchState {
            get {return GameState_ptr->MatchState;}
        }
        ///<summary>Previous map state, used to handle if multiple transitions happen per frame</summary>
        public unsafe Name PreviousMatchState {
            get {return GameState_ptr->PreviousMatchState;}
        }
        ///<summary>Elapsed game time since match has started.</summary>
        public unsafe int ElapsedTime {
            get {return GameState_ptr->ElapsedTime;}
        }
        static GameState() {
            StaticClass = Main.GetClass("GameState");
        }
        internal unsafe GameState_fields* GameState_ptr => (GameState_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameState(IntPtr p) => UObject.Make<GameState>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameState DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameState New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
