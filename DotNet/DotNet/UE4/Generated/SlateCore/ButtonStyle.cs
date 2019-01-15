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
        ///<summary>Represents the appearance of an SButton</summary>
        [StructLayout( LayoutKind.Explicit, Size=768 )]
        public unsafe struct ButtonStyle {
            ///<summary>Button appearance when the button is not hovered or pressed</summary>
            [FieldOffset(8)] SlateBrush Normal;

            ///<summary>Button appearance when hovered</summary>
            [FieldOffset(168)] SlateBrush Hovered;

            ///<summary>Button appearance when pressed</summary>
            [FieldOffset(328)] SlateBrush Pressed;

            ///<summary>Button appearance when disabled, by default this is set to an invalid resource when that is the case default disabled drawing is used.</summary>
            [FieldOffset(488)] SlateBrush Disabled;

            ///<summary>Padding that accounts for the border in the button's background image.</summary>
            ///<remarks>
            ///When this is applied, the content of the button should appear flush
            ///with the button's border. Use this padding when the button is not pressed.
            ///</remarks>
            [FieldOffset(648)] Margin NormalPadding;

            ///<summary>Same as NormalPadding but used when the button is pressed.</summary>
            ///<remarks>
            ///Allows for moving the content to match
            ///any "movement" in the button's border image.
            ///</remarks>
            [FieldOffset(664)] Margin PressedPadding;

            ///<summary>The sound the button should play when pressed</summary>
            [FieldOffset(680)] SlateSound PressedSlateSound;

            ///<summary>The sound the button should play when initially hovered over</summary>
            [FieldOffset(712)] SlateSound HoveredSlateSound;

        }
}
