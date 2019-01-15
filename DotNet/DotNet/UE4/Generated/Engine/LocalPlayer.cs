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
    ///<summary>Each player that is active on the current client has a LocalPlayer.</summary>
    ///<remarks>
    ///It stays active across maps
    ///There may be several spawned in the case of splitscreen/coop.
    ///There may be 0 spawned on servers.
    ///</remarks>
    public unsafe partial class LocalPlayer : Player  {
        ///<summary>The master viewport containing this player's view.</summary>
        public unsafe GameViewportClient ViewportClient {
            get {return LocalPlayer_ptr->ViewportClient;}
            set {LocalPlayer_ptr->ViewportClient = value;}
        }
        ///<summary>How to constrain perspective viewport FOV</summary>
        public unsafe byte AspectRatioAxisConstraint {
            get {return LocalPlayer_ptr->AspectRatioAxisConstraint;}
            set {LocalPlayer_ptr->AspectRatioAxisConstraint = value;}
        }
        ///<summary>The class of PlayerController to spawn for players logging in.</summary>
        public unsafe SubclassOf<PlayerController> PendingLevelPlayerControllerClass {
            get {return LocalPlayer_ptr->PendingLevelPlayerControllerClass;}
            set {LocalPlayer_ptr->PendingLevelPlayerControllerClass = value;}
        }
        public bool bSentSplitJoin {
            get {return Main.GetGetBoolPropertyByName(this, "bSentSplitJoin"); }
            set {Main.SetGetBoolPropertyByName(this, "bSentSplitJoin", value); }
        }
        ///<summary>The controller ID which this player accepts input from.</summary>
        public unsafe int ControllerId {
            get {return LocalPlayer_ptr->ControllerId;}
            set {LocalPlayer_ptr->ControllerId = value;}
        }
        static LocalPlayer() {
            StaticClass = Main.GetClass("LocalPlayer");
        }
        internal unsafe LocalPlayer_fields* LocalPlayer_ptr => (LocalPlayer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocalPlayer(IntPtr p) => UObject.Make<LocalPlayer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocalPlayer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocalPlayer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
