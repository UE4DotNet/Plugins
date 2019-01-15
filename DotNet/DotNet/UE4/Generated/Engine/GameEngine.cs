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
    ///<summary>Engine that manages core systems that enable a game.</summary>
    public unsafe partial class GameEngine : UE4.Engine.Engine  {
        ///<summary>Maximium delta time the engine uses to populate FApp::DeltaTime. If 0, unbound.</summary>
        public unsafe float MaxDeltaTime {
            get {return GameEngine_ptr->MaxDeltaTime;}
            set {GameEngine_ptr->MaxDeltaTime = value;}
        }
        ///<summary>Maximium time (in seconds) between the flushes of the logs on the server (best effort). If 0, this will happen every tick.</summary>
        public unsafe float ServerFlushLogInterval {
            get {return GameEngine_ptr->ServerFlushLogInterval;}
            set {GameEngine_ptr->ServerFlushLogInterval = value;}
        }
        ///<summary>Game Instance</summary>
        public unsafe GameInstance GameInstance {
            get {return GameEngine_ptr->GameInstance;}
            set {GameEngine_ptr->GameInstance = value;}
        }
        static GameEngine() {
            StaticClass = Main.GetClass("GameEngine");
        }
        internal unsafe GameEngine_fields* GameEngine_ptr => (GameEngine_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameEngine(IntPtr p) => UObject.Make<GameEngine>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameEngine DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameEngine New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
