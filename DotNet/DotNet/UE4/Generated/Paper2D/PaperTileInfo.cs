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


namespace UE4.Paper2D{
        ///<summary>This is the contents of a tile map cell</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct PaperTileInfo {
            [FieldOffset(0)] 
            private IntPtr  TileSet_field;
            ///<summary>The tile set that this tile comes from</summary>
            public PaperTileSet TileSet {
                get {return TileSet_field;}
                set {TileSet_field = value;}
            }

            [FieldOffset(8)] public int PackedTileIndex;

        }
}
