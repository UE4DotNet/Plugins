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
    ///<summary>Player</summary>
    public unsafe partial class Player : UObject  {
        ///<summary>The actor this player controls.</summary>
        public unsafe PlayerController PlayerController {
            get {return Player_ptr->PlayerController;}
            set {Player_ptr->PlayerController = value;}
        }
        ///<summary>the current speed of the connection</summary>
        public unsafe int CurrentNetSpeed {
            get {return Player_ptr->CurrentNetSpeed;}
            set {Player_ptr->CurrentNetSpeed = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe int ConfiguredInternetSpeed {
            get {return Player_ptr->ConfiguredInternetSpeed;}
            set {Player_ptr->ConfiguredInternetSpeed = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe int ConfiguredLanSpeed {
            get {return Player_ptr->ConfiguredLanSpeed;}
            set {Player_ptr->ConfiguredLanSpeed = value;}
        }
        static Player() {
            StaticClass = Main.GetClass("Player");
        }
        internal unsafe Player_fields* Player_ptr => (Player_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Player(IntPtr p) => UObject.Make<Player>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Player DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Player New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
