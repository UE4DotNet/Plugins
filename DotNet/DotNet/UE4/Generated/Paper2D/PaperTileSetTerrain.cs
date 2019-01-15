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
        ///<summary>Information about a terrain type</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PaperTileSetTerrain {
            [FieldOffset(0)] byte TerrainName; //TODO: string FString TerrainName

            [FieldOffset(16)] public int CenterTileIndex;

        }
}
