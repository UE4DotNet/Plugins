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
    ///<summary>An instance of a UPaperTileMap in a level.</summary>
    ///<remarks>
    ///This actor is created when you drag a tile map asset from the content browser into the level, and
    ///it is just a thin wrapper around a UPaperTileMapComponent that actually references the asset.
    ///</remarks>
    public unsafe partial class PaperTileMapActor : Actor  {
        ///<summary>Render Component</summary>
        public unsafe PaperTileMapComponent RenderComponent {
            get {return PaperTileMapActor_ptr->RenderComponent;}
        }
        static PaperTileMapActor() {
            StaticClass = Main.GetClass("PaperTileMapActor");
        }
        internal unsafe PaperTileMapActor_fields* PaperTileMapActor_ptr => (PaperTileMapActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileMapActor(IntPtr p) => UObject.Make<PaperTileMapActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileMapActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileMapActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
