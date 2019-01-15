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
    ///<summary>
    ///A group of sprites that will be rendered and culled as a single unit
    ///This actor is created when you Merge several sprite components together.
    ///</summary>
    ///<remarks>it is just a thin wrapper around a UPaperGroupedSpriteComponent.</remarks>
    public unsafe partial class PaperGroupedSpriteActor : Actor  {
        ///<summary>Render Component</summary>
        public unsafe PaperGroupedSpriteComponent RenderComponent {
            get {return PaperGroupedSpriteActor_ptr->RenderComponent;}
        }
        static PaperGroupedSpriteActor() {
            StaticClass = Main.GetClass("PaperGroupedSpriteActor");
        }
        internal unsafe PaperGroupedSpriteActor_fields* PaperGroupedSpriteActor_ptr => (PaperGroupedSpriteActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperGroupedSpriteActor(IntPtr p) => UObject.Make<PaperGroupedSpriteActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperGroupedSpriteActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperGroupedSpriteActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
