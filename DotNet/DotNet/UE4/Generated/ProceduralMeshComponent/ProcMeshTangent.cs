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


namespace UE4.ProceduralMeshComponent{
        ///<summary>
        ///Struct used to specify a tangent vector for a vertex
        ///The Y tangent is computed from the cross product of the vertex normal (Tangent Z) and the TangentX member.
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct ProcMeshTangent {
            ///<summary>Direction of X tangent for this vertex</summary>
            [FieldOffset(0)] Vector TangentX;

            [FieldOffset(12)] public bool bFlipTangentY;

        }
}
