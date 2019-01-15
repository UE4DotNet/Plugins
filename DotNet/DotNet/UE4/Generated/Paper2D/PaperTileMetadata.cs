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
        ///<summary>Information about a single tile in a tile set</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct PaperTileMetadata {
            [FieldOffset(0)] public Name UserDataName;

            ///<summary>Collision data for the tile</summary>
            [FieldOffset(16)] SpriteGeometryCollection CollisionData;

            [FieldOffset(64)] public byte TerrainMembership;

        }
}
