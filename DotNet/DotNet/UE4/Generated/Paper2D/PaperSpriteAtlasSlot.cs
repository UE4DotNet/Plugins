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
        ///<summary>Paper Sprite Atlas Slot</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct PaperSpriteAtlasSlot {
            [FieldOffset(0)] byte SpriteRef; //TODO: soft object TSoftObjectPtr<UPaperSprite> SpriteRef

            [FieldOffset(48)] public int AtlasIndex;

            [FieldOffset(52)] public int X;

            [FieldOffset(56)] public int Y;

            [FieldOffset(60)] public int Width;

            [FieldOffset(64)] public int Height;

        }
}
