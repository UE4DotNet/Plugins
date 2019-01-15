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
using UE4.PaperSpriteSheetImporter.Native;
using UE4.Engine;

namespace UE4.PaperSpriteSheetImporter {
    ///<summary>Paper Sprite Sheet</summary>
    public unsafe partial class PaperSpriteSheet : UObject  {
         //TODO: array not UObject TArray SpriteNames
         //TODO: array not UObject TArray Sprites
         //TODO: string FString TextureName
        ///<summary>The asset that was created for TextureName</summary>
        public unsafe Texture2D Texture {
            get {return PaperSpriteSheet_ptr->Texture;}
            set {PaperSpriteSheet_ptr->Texture = value;}
        }
         //TODO: string FString NormalMapTextureName
        ///<summary>The asset that was created for NormalMapTextureName (if any)</summary>
        public unsafe Texture2D NormalMapTexture {
            get {return PaperSpriteSheet_ptr->NormalMapTexture;}
            set {PaperSpriteSheet_ptr->NormalMapTexture = value;}
        }
        ///<summary>Import data for this</summary>
        public unsafe AssetImportData AssetImportData {
            get {return PaperSpriteSheet_ptr->AssetImportData;}
            set {PaperSpriteSheet_ptr->AssetImportData = value;}
        }
        static PaperSpriteSheet() {
            StaticClass = Main.GetClass("PaperSpriteSheet");
        }
        internal unsafe PaperSpriteSheet_fields* PaperSpriteSheet_ptr => (PaperSpriteSheet_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteSheet(IntPtr p) => UObject.Make<PaperSpriteSheet>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteSheet DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteSheet New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
