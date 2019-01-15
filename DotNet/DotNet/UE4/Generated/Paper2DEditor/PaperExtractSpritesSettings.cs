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
    ///<summary>Paper Extract Sprites Settings</summary>
    public unsafe partial class PaperExtractSpritesSettings : UObject  {
         //TODO: enum ESpriteExtractMode SpriteExtractMode
        ///<summary>The color of the sprite boundary outlines</summary>
        public unsafe LinearColor OutlineColor {
            get {return PaperExtractSpritesSettings_ptr->OutlineColor;}
            set {PaperExtractSpritesSettings_ptr->OutlineColor = value;}
        }
        ///<summary>Apply a tint to the texture in the viewport to improve outline visibility in this editor</summary>
        public unsafe LinearColor ViewportTextureTint {
            get {return PaperExtractSpritesSettings_ptr->ViewportTextureTint;}
            set {PaperExtractSpritesSettings_ptr->ViewportTextureTint = value;}
        }
        ///<summary>The viewport background color</summary>
        public unsafe LinearColor BackgroundColor {
            get {return PaperExtractSpritesSettings_ptr->BackgroundColor;}
            set {PaperExtractSpritesSettings_ptr->BackgroundColor = value;}
        }
         //TODO: string FString NamingTemplate
        ///<summary>The number to start naming with</summary>
        public unsafe int NamingStartIndex {
            get {return PaperExtractSpritesSettings_ptr->NamingStartIndex;}
            set {PaperExtractSpritesSettings_ptr->NamingStartIndex = value;}
        }
        static PaperExtractSpritesSettings() {
            StaticClass = Main.GetClass("PaperExtractSpritesSettings");
        }
        internal unsafe PaperExtractSpritesSettings_fields* PaperExtractSpritesSettings_ptr => (PaperExtractSpritesSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperExtractSpritesSettings(IntPtr p) => UObject.Make<PaperExtractSpritesSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperExtractSpritesSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperExtractSpritesSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
