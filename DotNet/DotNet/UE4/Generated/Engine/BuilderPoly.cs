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
        ///<summary>Internal state, not accessible to script.</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct BuilderPoly {
            [FieldOffset(0)] byte VertexIndices; //TODO: array TArray VertexIndices

            [FieldOffset(16)] public int Direction;

            [FieldOffset(20)] public Name ItemName;

            [FieldOffset(32)] public int PolyFlags;

        }
}
