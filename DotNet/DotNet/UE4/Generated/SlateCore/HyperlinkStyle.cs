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


namespace UE4.SlateCore{
        ///<summary>Represents the appearance of an SHyperlink</summary>
        [StructLayout( LayoutKind.Explicit, Size=1344 )]
        public unsafe struct HyperlinkStyle {
            ///<summary>Underline style</summary>
            [FieldOffset(8)] ButtonStyle UnderlineStyle;

            ///<summary>Text style</summary>
            [FieldOffset(776)] TextBlockStyle TextStyle;

            ///<summary>Padding</summary>
            [FieldOffset(1328)] Margin Padding;

        }
}
