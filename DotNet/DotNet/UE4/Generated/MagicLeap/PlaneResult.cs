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


namespace UE4.MagicLeap{
        ///<summary>Represents a plane returned from the ML-API.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct PlaneResult {
            ///<summary>Position of the center of the plane in world coordinates.</summary>
            [FieldOffset(0)] Vector PlanePosition;

            ///<summary>Orientation of the plane.</summary>
            [FieldOffset(12)] Rotator PlaneOrientation;

            ///<summary>Orientation of the content with its up-vector orthogonal to the plane.</summary>
            [FieldOffset(24)] Rotator ContentOrientation;

            ///<summary>Width and height of the plane (in Unreal units).</summary>
            [FieldOffset(36)] Vector2D PlaneDimensions;

            [FieldOffset(48)] byte PlaneFlags; //TODO: array TArray PlaneFlags

        }
}
