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
        ///<summary>Raw Curve data for serialization</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct RawCurveTracks {
            [FieldOffset(0)] byte FloatCurves; //TODO: array TArray FloatCurves

            [FieldOffset(16)] byte VectorCurves; //TODO: array TArray VectorCurves

            [FieldOffset(32)] byte TransformCurves; //TODO: array TArray TransformCurves

        }
}
