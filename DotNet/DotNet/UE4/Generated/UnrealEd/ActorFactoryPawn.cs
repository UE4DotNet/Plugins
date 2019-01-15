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

namespace UE4.UnrealEd {
    ///<summary>Actor Factory Pawn</summary>
    public unsafe partial class ActorFactoryPawn : ActorFactoryEmptyActor  {
        static ActorFactoryPawn() {
            StaticClass = Main.GetClass("ActorFactoryPawn");
        }
        internal unsafe ActorFactoryPawn_fields* ActorFactoryPawn_ptr => (ActorFactoryPawn_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ActorFactoryPawn(IntPtr p) => UObject.Make<ActorFactoryPawn>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ActorFactoryPawn DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ActorFactoryPawn New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
