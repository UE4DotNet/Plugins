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

namespace UE4.Paper2DEditor {
    ///<summary>Paper Extract Sprite Grid Settings</summary>
    public unsafe partial class PaperExtractSpriteGridSettings : UObject  {
        ///<summary>The width of each sprite in grid mode</summary>
        public unsafe int CellWidth {
            get {return PaperExtractSpriteGridSettings_ptr->CellWidth;}
            set {PaperExtractSpriteGridSettings_ptr->CellWidth = value;}
        }
        ///<summary>The height of each sprite in grid mode</summary>
        public unsafe int CellHeight {
            get {return PaperExtractSpriteGridSettings_ptr->CellHeight;}
            set {PaperExtractSpriteGridSettings_ptr->CellHeight = value;}
        }
        ///<summary>Number of cells extracted horizontally. Can be used to limit the number of sprites extracted. Set to 0 to extract all sprites</summary>
        public unsafe int NumCellsX {
            get {return PaperExtractSpriteGridSettings_ptr->NumCellsX;}
            set {PaperExtractSpriteGridSettings_ptr->NumCellsX = value;}
        }
        ///<summary>Number of cells extracted vertically. Can be used to limit the number of sprites extracted. Set to 0 to extract all sprites</summary>
        public unsafe int NumCellsY {
            get {return PaperExtractSpriteGridSettings_ptr->NumCellsY;}
            set {PaperExtractSpriteGridSettings_ptr->NumCellsY = value;}
        }
        ///<summary>Margin from the left of the texture to the first sprite</summary>
        public unsafe int MarginX {
            get {return PaperExtractSpriteGridSettings_ptr->MarginX;}
            set {PaperExtractSpriteGridSettings_ptr->MarginX = value;}
        }
        ///<summary>Margin from the top of the texture to the first sprite</summary>
        public unsafe int MarginY {
            get {return PaperExtractSpriteGridSettings_ptr->MarginY;}
            set {PaperExtractSpriteGridSettings_ptr->MarginY = value;}
        }
        ///<summary>Horizontal spacing between sprites</summary>
        public unsafe int SpacingX {
            get {return PaperExtractSpriteGridSettings_ptr->SpacingX;}
            set {PaperExtractSpriteGridSettings_ptr->SpacingX = value;}
        }
        ///<summary>Vertical spacing between sprites</summary>
        public unsafe int SpacingY {
            get {return PaperExtractSpriteGridSettings_ptr->SpacingY;}
            set {PaperExtractSpriteGridSettings_ptr->SpacingY = value;}
        }
        static PaperExtractSpriteGridSettings() {
            StaticClass = Main.GetClass("PaperExtractSpriteGridSettings");
        }
        internal unsafe PaperExtractSpriteGridSettings_fields* PaperExtractSpriteGridSettings_ptr => (PaperExtractSpriteGridSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperExtractSpriteGridSettings(IntPtr p) => UObject.Make<PaperExtractSpriteGridSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperExtractSpriteGridSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperExtractSpriteGridSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
