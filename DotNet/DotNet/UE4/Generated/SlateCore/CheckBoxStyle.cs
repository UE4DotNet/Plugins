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
        ///<summary>Represents the appearance of an SCheckBox</summary>
        [StructLayout( LayoutKind.Explicit, Size=1688 )]
        public unsafe struct CheckBoxStyle {
            [FieldOffset(8)] public byte CheckBoxType;

            ///<summary>CheckBox appearance when the CheckBox is unchecked (normal)</summary>
            [FieldOffset(16)] SlateBrush UncheckedImage;

            ///<summary>CheckBox appearance when the CheckBox is unchecked and hovered</summary>
            [FieldOffset(176)] SlateBrush UncheckedHoveredImage;

            ///<summary>CheckBox appearance when the CheckBox is unchecked and hovered</summary>
            [FieldOffset(336)] SlateBrush UncheckedPressedImage;

            ///<summary>CheckBox appearance when the CheckBox is checked</summary>
            [FieldOffset(496)] SlateBrush CheckedImage;

            ///<summary>CheckBox appearance when checked and hovered</summary>
            [FieldOffset(656)] SlateBrush CheckedHoveredImage;

            ///<summary>CheckBox appearance when checked and pressed</summary>
            [FieldOffset(816)] SlateBrush CheckedPressedImage;

            ///<summary>CheckBox appearance when the CheckBox is undetermined</summary>
            [FieldOffset(976)] SlateBrush UndeterminedImage;

            ///<summary>CheckBox appearance when CheckBox is undetermined and hovered</summary>
            [FieldOffset(1136)] SlateBrush UndeterminedHoveredImage;

            ///<summary>CheckBox appearance when CheckBox is undetermined and pressed</summary>
            [FieldOffset(1296)] SlateBrush UndeterminedPressedImage;

            ///<summary>Padding</summary>
            [FieldOffset(1456)] Margin Padding;

            ///<summary>The foreground color</summary>
            [FieldOffset(1472)] SlateColor ForegroundColor;

            ///<summary>BorderBackgroundColor refers to the actual color and opacity of the supplied border image on toggle buttons</summary>
            [FieldOffset(1512)] SlateColor BorderBackgroundColor;

            ///<summary>The sound the check box should play when checked</summary>
            [FieldOffset(1552)] SlateSound CheckedSlateSound;

            ///<summary>The sound the check box should play when unchecked</summary>
            [FieldOffset(1584)] SlateSound UncheckedSlateSound;

            ///<summary>The sound the check box should play when initially hovered over</summary>
            [FieldOffset(1616)] SlateSound HoveredSlateSound;

        }
}
