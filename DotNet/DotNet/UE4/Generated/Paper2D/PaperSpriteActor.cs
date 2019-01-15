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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>An instance of a UPaperSprite in a level.</summary>
    ///<remarks>
    ///This actor is created when you drag a sprite asset from the content browser into the level, and
    ///it is just a thin wrapper around a UPaperSpriteComponent that actually references the asset.
    ///</remarks>
    public unsafe partial class PaperSpriteActor : Actor  {
        ///<summary>Render Component</summary>
        public unsafe PaperSpriteComponent RenderComponent {
            get {return PaperSpriteActor_ptr->RenderComponent;}
        }
        static PaperSpriteActor() {
            StaticClass = Main.GetClass("PaperSpriteActor");
        }
        internal unsafe PaperSpriteActor_fields* PaperSpriteActor_ptr => (PaperSpriteActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteActor(IntPtr p) => UObject.Make<PaperSpriteActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
