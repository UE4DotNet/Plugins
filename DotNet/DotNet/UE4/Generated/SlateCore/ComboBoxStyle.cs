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
        ///<summary>Represents the appearance of an SComboBox</summary>
        [StructLayout( LayoutKind.Explicit, Size=1208 )]
        public unsafe struct ComboBoxStyle {
            ///<summary>The style to use for our SComboButton</summary>
            [FieldOffset(8)] ComboButtonStyle ComboButtonStyle;

            ///<summary>The sound the button should play when pressed</summary>
            [FieldOffset(1120)] SlateSound PressedSlateSound;

            ///<summary>The Sound to play when the selection is changed</summary>
            [FieldOffset(1152)] SlateSound SelectionChangeSlateSound;

        }
}
