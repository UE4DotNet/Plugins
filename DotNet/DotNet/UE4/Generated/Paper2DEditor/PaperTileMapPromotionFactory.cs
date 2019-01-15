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
using UE4.Paper2D;

namespace UE4.Paper2DEditor {
    ///<summary>Paper Tile Map Promotion Factory</summary>
    public unsafe partial class PaperTileMapPromotionFactory : Factory  {
        ///<summary>Object being promoted to an asset</summary>
        public unsafe PaperTileMap AssetToRename {
            get {return PaperTileMapPromotionFactory_ptr->AssetToRename;}
            set {PaperTileMapPromotionFactory_ptr->AssetToRename = value;}
        }
        static PaperTileMapPromotionFactory() {
            StaticClass = Main.GetClass("PaperTileMapPromotionFactory");
        }
        internal unsafe PaperTileMapPromotionFactory_fields* PaperTileMapPromotionFactory_ptr => (PaperTileMapPromotionFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTileMapPromotionFactory(IntPtr p) => UObject.Make<PaperTileMapPromotionFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTileMapPromotionFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTileMapPromotionFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
