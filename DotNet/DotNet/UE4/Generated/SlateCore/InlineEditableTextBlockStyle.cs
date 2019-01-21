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
        ///<summary>Represents the appearance of an SInlineEditableTextBlock</summary>
        [StructLayout( LayoutKind.Explicit, Size=2944 )]
        public unsafe struct InlineEditableTextBlockStyle {
            ///<summary>The style of the editable text box, which dictates the font, color, and shadow options.</summary>
            [FieldOffset(8)] EditableTextBoxStyle EditableTextBoxStyle;

            ///<summary>The style of the text block, which dictates the font, color, and shadow options. Style overrides all other properties!</summary>
            [FieldOffset(2384)] TextBlockStyle TextStyle;

        }
}
