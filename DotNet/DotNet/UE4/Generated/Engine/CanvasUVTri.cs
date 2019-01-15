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
        ///<summary>Simple 2d triangle with UVs</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct CanvasUVTri {
            ///<summary>Position of first vertex</summary>
            [FieldOffset(0)] Vector2D V0_Pos;

            ///<summary>UV of first vertex</summary>
            [FieldOffset(8)] Vector2D V0_UV;

            ///<summary>Color of first vertex</summary>
            [FieldOffset(16)] LinearColor V0_Color;

            ///<summary>Position of second vertex</summary>
            [FieldOffset(32)] Vector2D V1_Pos;

            ///<summary>UV of second vertex</summary>
            [FieldOffset(40)] Vector2D V1_UV;

            ///<summary>Color of second vertex</summary>
            [FieldOffset(48)] LinearColor V1_Color;

            ///<summary>Position of third vertex</summary>
            [FieldOffset(64)] Vector2D V2_Pos;

            ///<summary>UV of third vertex</summary>
            [FieldOffset(72)] Vector2D V2_UV;

            ///<summary>Color of third vertex</summary>
            [FieldOffset(80)] LinearColor V2_Color;

        }
}
