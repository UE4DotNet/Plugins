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


namespace UE4.Engine{
        ///<summary>Font import options</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct FontImportOptionsData {
            [FieldOffset(0)] byte FontName; //TODO: string FString FontName

            [FieldOffset(16)] public float Height;

            [FieldOffset(20)] public bool bEnableAntialiasing;

            [FieldOffset(20)] public bool bEnableBold;

            [FieldOffset(20)] public bool bEnableItalic;

            [FieldOffset(20)] public bool bEnableUnderline;

            [FieldOffset(20)] public bool bAlphaOnly;

            [FieldOffset(24)] public byte CharacterSet;

            [FieldOffset(32)] byte Chars; //TODO: string FString Chars

            [FieldOffset(48)] byte UnicodeRange; //TODO: string FString UnicodeRange

            [FieldOffset(64)] byte CharsFilePath; //TODO: string FString CharsFilePath

            [FieldOffset(80)] byte CharsFileWildcard; //TODO: string FString CharsFileWildcard

            [FieldOffset(96)] public bool bCreatePrintableOnly;

            [FieldOffset(96)] public bool bIncludeASCIIRange;

            ///<summary>Color of the foreground font pixels.  Usually you should leave this white and instead use the UI Styles editor to change the color of the font on the fly</summary>
            [FieldOffset(100)] LinearColor ForegroundColor;

            [FieldOffset(116)] public bool bEnableDropShadow;

            [FieldOffset(120)] public int TexturePageWidth;

            [FieldOffset(124)] public int TexturePageMaxHeight;

            [FieldOffset(128)] public int XPadding;

            [FieldOffset(132)] public int YPadding;

            [FieldOffset(136)] public int ExtendBoxTop;

            [FieldOffset(140)] public int ExtendBoxBottom;

            [FieldOffset(144)] public int ExtendBoxRight;

            [FieldOffset(148)] public int ExtendBoxLeft;

            [FieldOffset(152)] public bool bEnableLegacyMode;

            [FieldOffset(156)] public int Kerning;

            [FieldOffset(160)] public bool bUseDistanceFieldAlpha;

            [FieldOffset(164)] public int DistanceFieldScaleFactor;

            [FieldOffset(168)] public float DistanceFieldScanRadiusScale;

        }
}
