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
using UE4.Engine.Native;
using UE4.SlateCore;

namespace UE4.Engine {
    ///<summary>A font object, for use by Slate, UMG, and Canvas.</summary>
    ///<remarks>
    ///A font can either be:
    ///  * Runtime cached - The font contains a series of TTF files that combine to form a composite font. The glyphs are cached on demand when required at runtime.
    ///  * Offline cached - The font contains a series of textures containing pre-baked cached glyphs and their associated texture coordinates.
    ///</remarks>
    public unsafe partial class Font : UObject  {
         //TODO: enum EFontCacheType FontCacheType
         //TODO: array not UObject TArray Characters
        ///<summary>Textures that store this font's glyph image data //NOTE: Do not expose this to the editor as it has nasty crash potential</summary>
        public ObjectArrayField<Texture2D> Textures{ get {
            if(Textures_store == null) Textures_store = new ObjectArrayField<Texture2D> (&Font_ptr->Textures);
            return Textures_store;
        } }
        private ObjectArrayField<Texture2D> Textures_store;

        ///<summary>True if font is 'remapped'.</summary>
        ///<remarks>
        ///That is, the character array is not a direct mapping to unicode values.  Instead,
        ///              all characters are indexed indirectly through the CharRemap array
        ///</remarks>
        public unsafe int IsRemapped {
            get {return Font_ptr->IsRemapped;}
            set {Font_ptr->IsRemapped = value;}
        }
        ///<summary>Font metrics.</summary>
        public unsafe float EmScale {
            get {return Font_ptr->EmScale;}
            set {Font_ptr->EmScale = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe float Ascent {
            get {return Font_ptr->Ascent;}
            set {Font_ptr->Ascent = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe float Descent {
            get {return Font_ptr->Descent;}
            set {Font_ptr->Descent = value;}
        }
        ///<summary>@todo document</summary>
        public unsafe float Leading {
            get {return Font_ptr->Leading;}
            set {Font_ptr->Leading = value;}
        }
        ///<summary>Default horizontal spacing between characters when rendering text with this font</summary>
        public unsafe int Kerning {
            get {return Font_ptr->Kerning;}
            set {Font_ptr->Kerning = value;}
        }
        ///<summary>Options used when importing this font</summary>
        public unsafe FontImportOptionsData ImportOptions {
            get {return Font_ptr->ImportOptions;}
            set {Font_ptr->ImportOptions = value;}
        }
        ///<summary>Number of characters in the font, not including multiple instances of the same character (for multi-fonts).</summary>
        ///<remarks>This is cached at load-time or creation time, and is never serialized.</remarks>
        public unsafe int NumCharacters {
            get {return Font_ptr->NumCharacters;}
            set {Font_ptr->NumCharacters = value;}
        }
         //TODO: array not UObject TArray MaxCharHeight
        ///<summary>Scale to apply to the font.</summary>
        public unsafe float ScalingFactor {
            get {return Font_ptr->ScalingFactor;}
            set {Font_ptr->ScalingFactor = value;}
        }
        ///<summary>The default size of the font used for legacy Canvas APIs that don't specify a font size</summary>
        public unsafe int LegacyFontSize {
            get {return Font_ptr->LegacyFontSize;}
            set {Font_ptr->LegacyFontSize = value;}
        }
        ///<summary>The default font name to use for legacy Canvas APIs that don't specify a font name</summary>
        public unsafe Name LegacyFontName {
            get {return Font_ptr->LegacyFontName;}
            set {Font_ptr->LegacyFontName = value;}
        }
        ///<summary>Embedded composite font data</summary>
        public unsafe CompositeFont CompositeFont {
            get {return Font_ptr->CompositeFont;}
            set {Font_ptr->CompositeFont = value;}
        }
        static Font() {
            StaticClass = Main.GetClass("Font");
        }
        internal unsafe Font_fields* Font_ptr => (Font_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Font(IntPtr p) => UObject.Make<Font>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Font DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Font New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
