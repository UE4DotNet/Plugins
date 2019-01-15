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
using UE4.Paper2DEditor.Native;
using UE4.UnrealEd;

namespace UE4.Paper2DEditor {
    ///<summary>Paper Sprite Actor Factory</summary>
    public unsafe partial class PaperSpriteActorFactory : ActorFactory  {
        static PaperSpriteActorFactory() {
            StaticClass = Main.GetClass("PaperSpriteActorFactory");
        }
        internal unsafe PaperSpriteActorFactory_fields* PaperSpriteActorFactory_ptr => (PaperSpriteActorFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteActorFactory(IntPtr p) => UObject.Make<PaperSpriteActorFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteActorFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteActorFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
