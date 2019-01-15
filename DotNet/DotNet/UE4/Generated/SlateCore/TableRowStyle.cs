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
        ///<summary>Represents the appearance of an STableRow</summary>
        [StructLayout( LayoutKind.Explicit, Size=2008 )]
        public unsafe struct TableRowStyle {
            ///<summary>Brush used as a selector when a row is focused</summary>
            [FieldOffset(8)] SlateBrush SelectorFocusedBrush;

            ///<summary>Brush used when a selected row is active and hovered</summary>
            [FieldOffset(168)] SlateBrush ActiveHoveredBrush;

            ///<summary>Brush used when a selected row is active</summary>
            [FieldOffset(328)] SlateBrush ActiveBrush;

            ///<summary>Brush used when a selected row is inactive and hovered</summary>
            [FieldOffset(488)] SlateBrush InactiveHoveredBrush;

            ///<summary>Brush used when a selected row is inactive</summary>
            [FieldOffset(648)] SlateBrush InactiveBrush;

            ///<summary>Brush used when an even row is hovered</summary>
            [FieldOffset(808)] SlateBrush EvenRowBackgroundHoveredBrush;

            ///<summary>Brush used when an even row is in its normal state</summary>
            [FieldOffset(968)] SlateBrush EvenRowBackgroundBrush;

            ///<summary>Brush used when an odd row is hovered</summary>
            [FieldOffset(1128)] SlateBrush OddRowBackgroundHoveredBrush;

            ///<summary>Brush to used when an odd row is in its normal state</summary>
            [FieldOffset(1288)] SlateBrush OddRowBackgroundBrush;

            ///<summary>Text color used for all rows</summary>
            [FieldOffset(1448)] SlateColor TextColor;

            ///<summary>Text color used for the selected row</summary>
            [FieldOffset(1488)] SlateColor SelectedTextColor;

            ///<summary>Brush used to provide feedback that a user can drop above the hovered row.</summary>
            [FieldOffset(1528)] SlateBrush DropIndicator_Above;

            ///<summary>Brush used to provide feedback that a user can drop onto the hovered row.</summary>
            [FieldOffset(1688)] SlateBrush DropIndicator_Onto;

            ///<summary>Brush used to provide feedback that a user can drop below the hovered row.</summary>
            [FieldOffset(1848)] SlateBrush DropIndicator_Below;

        }
}
