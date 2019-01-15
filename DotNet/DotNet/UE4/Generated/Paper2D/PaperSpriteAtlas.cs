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
    ///<summary>Groups together a set of sprites that will try to share the same texture atlas (allowing them to be combined into a single draw call)</summary>
    public unsafe partial class PaperSpriteAtlas : UObject  {
         //TODO: string FString AtlasDescription
        ///<summary>Maximum atlas page width (single pages might be smaller)</summary>
        public unsafe int MaxWidth {
            get {return PaperSpriteAtlas_ptr->MaxWidth;}
            set {PaperSpriteAtlas_ptr->MaxWidth = value;}
        }
        ///<summary>Maximum atlas page height (single pages might be smaller)</summary>
        public unsafe int MaxHeight {
            get {return PaperSpriteAtlas_ptr->MaxHeight;}
            set {PaperSpriteAtlas_ptr->MaxHeight = value;}
        }
        ///<summary>Maximum atlas page height (single pages might be smaller)</summary>
        public unsafe int MipCount {
            get {return PaperSpriteAtlas_ptr->MipCount;}
            set {PaperSpriteAtlas_ptr->MipCount = value;}
        }
         //TODO: enum EPaperSpriteAtlasPadding PaddingType
        ///<summary>The number of pixels of padding</summary>
        public unsafe int Padding {
            get {return PaperSpriteAtlas_ptr->Padding;}
            set {PaperSpriteAtlas_ptr->Padding = value;}
        }
        ///<summary>Compression settings to use on atlas texture</summary>
        public unsafe byte CompressionSettings {
            get {return PaperSpriteAtlas_ptr->CompressionSettings;}
            set {PaperSpriteAtlas_ptr->CompressionSettings = value;}
        }
        ///<summary>Texture filtering mode when sampling these textures</summary>
        public unsafe byte Filter {
            get {return PaperSpriteAtlas_ptr->Filter;}
            set {PaperSpriteAtlas_ptr->Filter = value;}
        }
        ///<summary>List of generated atlas textures</summary>
        public ObjectArrayField<Texture> GeneratedTextures{ get {
            if(GeneratedTextures_store == null) GeneratedTextures_store = new ObjectArrayField<Texture> (&PaperSpriteAtlas_ptr->GeneratedTextures);
            return GeneratedTextures_store;
        } }
        private ObjectArrayField<Texture> GeneratedTextures_store;

        ///<summary>The GUID of the atlas group, used to match up sprites that belong to this group even thru atlas renames</summary>
        public unsafe FGuid AtlasGUID {
            get {return PaperSpriteAtlas_ptr->AtlasGUID;}
            set {PaperSpriteAtlas_ptr->AtlasGUID = value;}
        }
        public bool bRebuildAtlas {
            get {return Main.GetGetBoolPropertyByName(this, "bRebuildAtlas"); }
            set {Main.SetGetBoolPropertyByName(this, "bRebuildAtlas", value); }
        }
         //TODO: array not UObject TArray AtlasSlots
        ///<summary>Track the number of incremental builds</summary>
        public unsafe int NumIncrementalBuilds {
            get {return PaperSpriteAtlas_ptr->NumIncrementalBuilds;}
            set {PaperSpriteAtlas_ptr->NumIncrementalBuilds = value;}
        }
        ///<summary>Values used when building this atlas</summary>
        public unsafe int BuiltWidth {
            get {return PaperSpriteAtlas_ptr->BuiltWidth;}
            set {PaperSpriteAtlas_ptr->BuiltWidth = value;}
        }
        ///<summary>Built Height</summary>
        public unsafe int BuiltHeight {
            get {return PaperSpriteAtlas_ptr->BuiltHeight;}
            set {PaperSpriteAtlas_ptr->BuiltHeight = value;}
        }
        ///<summary>Built Padding</summary>
        public unsafe int BuiltPadding {
            get {return PaperSpriteAtlas_ptr->BuiltPadding;}
            set {PaperSpriteAtlas_ptr->BuiltPadding = value;}
        }
        static PaperSpriteAtlas() {
            StaticClass = Main.GetClass("PaperSpriteAtlas");
        }
        internal unsafe PaperSpriteAtlas_fields* PaperSpriteAtlas_ptr => (PaperSpriteAtlas_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteAtlas(IntPtr p) => UObject.Make<PaperSpriteAtlas>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteAtlas DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteAtlas New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
