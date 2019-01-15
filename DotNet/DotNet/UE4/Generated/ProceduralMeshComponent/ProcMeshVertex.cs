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
        ///<summary>One vertex for the procedural mesh, used for storing data internally</summary>
        [StructLayout( LayoutKind.Explicit, Size=76 )]
        public unsafe struct ProcMeshVertex {
            ///<summary>Vertex position</summary>
            [FieldOffset(0)] Vector Position;

            ///<summary>Vertex normal</summary>
            [FieldOffset(12)] Vector Normal;

            ///<summary>Vertex tangent</summary>
            [FieldOffset(24)] ProcMeshTangent Tangent;

            ///<summary>Vertex color</summary>
            [FieldOffset(40)] Color Color;

            ///<summary>Vertex texture co-ordinate</summary>
            [FieldOffset(44)] Vector2D UV0;

            ///<summary>Vertex texture co-ordinate</summary>
            [FieldOffset(52)] Vector2D UV1;

            ///<summary>Vertex texture co-ordinate</summary>
            [FieldOffset(60)] Vector2D UV2;

            ///<summary>Vertex texture co-ordinate</summary>
            [FieldOffset(68)] Vector2D UV3;

        }
}
