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
        ///<summary>Represents the appearance of an STableColumnHeader</summary>
        [StructLayout( LayoutKind.Explicit, Size=1448 )]
        public unsafe struct TableColumnHeaderStyle {
            ///<summary>Image used when a column is primarily sorted in ascending order</summary>
            [FieldOffset(8)] SlateBrush SortPrimaryAscendingImage;

            ///<summary>Image used when a column is primarily sorted in descending order</summary>
            [FieldOffset(168)] SlateBrush SortPrimaryDescendingImage;

            ///<summary>Image used when a column is secondarily sorted in ascending order</summary>
            [FieldOffset(328)] SlateBrush SortSecondaryAscendingImage;

            ///<summary>Image used when a column is secondarily sorted in descending order</summary>
            [FieldOffset(488)] SlateBrush SortSecondaryDescendingImage;

            ///<summary>Brush used to draw the header in its normal state</summary>
            [FieldOffset(648)] SlateBrush NormalBrush;

            ///<summary>Brush used to draw the header in its hovered state</summary>
            [FieldOffset(808)] SlateBrush HoveredBrush;

            ///<summary>Image used for the menu drop-down button</summary>
            [FieldOffset(968)] SlateBrush MenuDropdownImage;

            ///<summary>Brush used to draw the menu drop-down border in its normal state</summary>
            [FieldOffset(1128)] SlateBrush MenuDropdownNormalBorderBrush;

            ///<summary>Brush used to draw the menu drop-down border in its hovered state</summary>
            [FieldOffset(1288)] SlateBrush MenuDropdownHoveredBorderBrush;

        }
}
