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


namespace UE4.Engine{
        ///<summary>Texture source data management.</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct TextureSource {
            ///<summary>GUID used to track changes to the source data.</summary>
            [FieldOffset(136)] FGuid Id;

            [FieldOffset(152)] public int SizeX;

            [FieldOffset(156)] public int SizeY;

            [FieldOffset(160)] public int NumSlices;

            [FieldOffset(164)] public int NumMips;

            [FieldOffset(168)] public bool bPNGCompressed;

            [FieldOffset(169)] public bool bGuidIsHash;

            [FieldOffset(170)] public byte Format;

        }
}
