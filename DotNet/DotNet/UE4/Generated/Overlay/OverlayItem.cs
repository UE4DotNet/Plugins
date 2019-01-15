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


namespace UE4.Overlay{
        ///<summary>Overlay Item</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct OverlayItem {
            ///<summary>When the overlay should be displayed</summary>
            [FieldOffset(0)] Timespan StartTime;

            ///<summary>When the overlay should be cleared</summary>
            [FieldOffset(8)] Timespan EndTime;

            [FieldOffset(16)] byte Text; //TODO: string FString Text

            ///<summary>The position of the text on screen (Between 0.0 and 1.0)</summary>
            [FieldOffset(32)] Vector2D Position;

        }
}
