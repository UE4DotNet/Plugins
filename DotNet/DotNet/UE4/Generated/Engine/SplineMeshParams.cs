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
        ///<summary>Structure that holds info about spline, passed to renderer to deform UStaticMesh.</summary>
        ///<remarks>Also used by Lightmass, so be sure to update Lightmass::FSplineMeshParams and the static lighting code if this changes!</remarks>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct SplineMeshParams {
            ///<summary>Start location of spline, in component space.</summary>
            [FieldOffset(0)] Vector StartPos;

            ///<summary>Start tangent of spline, in component space.</summary>
            [FieldOffset(12)] Vector StartTangent;

            ///<summary>X and Y scale applied to mesh at start of spline.</summary>
            [FieldOffset(24)] Vector2D StartScale;

            [FieldOffset(32)] public float StartRoll;

            ///<summary>Starting offset of the mesh from the spline, in component space.</summary>
            [FieldOffset(36)] Vector2D StartOffset;

            ///<summary>End location of spline, in component space.</summary>
            [FieldOffset(44)] Vector EndPos;

            ///<summary>End tangent of spline, in component space.</summary>
            [FieldOffset(56)] Vector EndTangent;

            ///<summary>X and Y scale applied to mesh at end of spline.</summary>
            [FieldOffset(68)] Vector2D EndScale;

            [FieldOffset(76)] public float EndRoll;

            ///<summary>Ending offset of the mesh from the spline, in component space.</summary>
            [FieldOffset(80)] Vector2D EndOffset;

        }
}
