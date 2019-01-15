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

using UE4.SlateCore;
using UE4.Slate;

namespace UE4.UMG{
        ///<summary>Anchor Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct AnchorData {
            ///<summary>Offset.</summary>
            [FieldOffset(0)] Margin Offsets;

            ///<summary>Anchors.</summary>
            [FieldOffset(16)] Anchors Anchors;

            ///<summary>Alignment is the pivot point of the widget.</summary>
            ///<remarks>
            ///Starting in the upper left at (0,0),
            ///ending in the lower right at (1,1).  Moving the alignment point allows you to move
            ///the origin of the widget.
            ///</remarks>
            [FieldOffset(32)] Vector2D Alignment;

        }
}
