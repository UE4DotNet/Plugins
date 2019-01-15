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

using UE4.Engine;

namespace UE4.Paper2D{
        ///<summary>Sprite Draw Call Record</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct SpriteDrawCallRecord {
            ///<summary>Destination</summary>
            [FieldOffset(0)] Vector Destination;

            [FieldOffset(16)] 
            private IntPtr  BaseTexture_field;
            ///<summary>Base Texture</summary>
            public Texture BaseTexture {
                get {return BaseTexture_field;}
                set {BaseTexture_field = value;}
            }

            ///<summary>Color</summary>
            [FieldOffset(72)] Color Color;

        }
}
