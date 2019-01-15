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


namespace UE4.Paper2DEditor{
        ///<summary>Tile Set Import Mapping</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct TileSetImportMapping {
            [FieldOffset(0)] byte SourceName; //TODO: string FString SourceName

            [FieldOffset(16)] byte ImportedTileSet; //TODO: weak object TWeakObjectPtr<UPaperTileSet> ImportedTileSet

            [FieldOffset(24)] byte ImportedTexture; //TODO: weak object TWeakObjectPtr<UTexture> ImportedTexture

        }
}
