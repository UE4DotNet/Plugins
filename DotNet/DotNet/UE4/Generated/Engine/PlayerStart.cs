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
    ///This class indicates a location where a player can spawn when the game begins
    ///@
    ///</summary>
    ///<remarks>see https://docs.unrealengine.com/latest/INT/Engine/Actors/PlayerStart/</remarks>
    public unsafe partial class PlayerStart : NavigationObjectBase  {
        ///<summary>Used when searching for which playerstart to use.</summary>
        public unsafe Name PlayerStartTag {
            get {return PlayerStart_ptr->PlayerStartTag;}
            set {PlayerStart_ptr->PlayerStartTag = value;}
        }
        ///<summary>Arrow Component</summary>
        public unsafe ArrowComponent ArrowComponent {
            get {return PlayerStart_ptr->ArrowComponent;}
            set {PlayerStart_ptr->ArrowComponent = value;}
        }
        static PlayerStart() {
            StaticClass = Main.GetClass("PlayerStart");
        }
        internal unsafe PlayerStart_fields* PlayerStart_ptr => (PlayerStart_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlayerStart(IntPtr p) => UObject.Make<PlayerStart>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlayerStart DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlayerStart New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
