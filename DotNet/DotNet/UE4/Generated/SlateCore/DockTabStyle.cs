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
        ///<summary>Represents the appearance of an SDockTab</summary>
        [StructLayout( LayoutKind.Explicit, Size=2120 )]
        public unsafe struct DockTabStyle {
            ///<summary>Style used for the close button</summary>
            [FieldOffset(8)] ButtonStyle CloseButtonStyle;

            ///<summary>Brush used when this tab is in its normal state</summary>
            [FieldOffset(776)] SlateBrush NormalBrush;

            ///<summary>Brush used when this tab is in its active state</summary>
            [FieldOffset(936)] SlateBrush ActiveBrush;

            ///<summary>Brush used to overlay a given color onto this tab</summary>
            [FieldOffset(1096)] SlateBrush ColorOverlayTabBrush;

            ///<summary>Brush used to overlay a given color onto this tab</summary>
            [FieldOffset(1256)] SlateBrush ColorOverlayIconBrush;

            ///<summary>Brush used when this tab is in the foreground</summary>
            [FieldOffset(1416)] SlateBrush ForegroundBrush;

            ///<summary>Brush used when this tab is hovered over</summary>
            [FieldOffset(1576)] SlateBrush HoveredBrush;

            ///<summary>Brush used by the SDockingTabStack to draw the content associated with this tab; Documents, Apps, and Tool Panels have different backgrounds</summary>
            [FieldOffset(1736)] SlateBrush ContentAreaBrush;

            ///<summary>Brush used by the SDockingTabStack to draw the content associated with this tab; Documents, Apps, and Tool Panels have different backgrounds</summary>
            [FieldOffset(1896)] SlateBrush TabWellBrush;

            ///<summary>Padding used around this tab</summary>
            [FieldOffset(2056)] Margin TabPadding;

            [FieldOffset(2072)] public float OverlapWidth;

            ///<summary>Color used when flashing this tab</summary>
            [FieldOffset(2080)] SlateColor FlashColor;

        }
}
