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
        ///<summary>A single piece of geometry (e.g., a polygon which may be convex or concave, a box, or a circle)</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct SpriteGeometryShape {
            [FieldOffset(0)] byte ShapeType; //TODO: enum ESpriteShapeType ShapeType

            [FieldOffset(8)] byte Vertices; //TODO: array TArray Vertices

            ///<summary>Size of the box or major/minor dimensions of the circle</summary>
            ///<remarks>Note: Only valid when GeometryType is Box or Circle</remarks>
            [FieldOffset(24)] Vector2D BoxSize;

            ///<summary>Center of the box or circle, acts as the pivot point for polygons (but may not be at the center of them)</summary>
            [FieldOffset(32)] Vector2D BoxPosition;

            [FieldOffset(40)] public float Rotation;

            [FieldOffset(44)] public bool bNegativeWinding;

        }
}
