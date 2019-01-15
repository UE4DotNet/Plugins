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


namespace UE4.EditableMesh{
        ///<summary>Subdivision Limit Data</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct SubdivisionLimitData {
            [FieldOffset(0)] byte VertexPositions; //TODO: array TArray VertexPositions

            [FieldOffset(16)] byte Sections; //TODO: array TArray Sections

            [FieldOffset(32)] byte SubdividedWireEdges; //TODO: array TArray SubdividedWireEdges

        }
}
