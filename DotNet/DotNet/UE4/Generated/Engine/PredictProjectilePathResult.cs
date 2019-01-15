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
        ///<summary>Container for the result of a projectile path trace (using PredictProjectilePath).</summary>
        [StructLayout( LayoutKind.Explicit, Size=192 )]
        public unsafe struct PredictProjectilePathResult {
            [FieldOffset(0)] byte PathData; //TODO: array TArray PathData

            ///<summary>Info on the last point we tried to trace to, which may have been beyond the final hit.</summary>
            [FieldOffset(16)] PredictProjectilePathPointData LastTraceDestination;

            ///<summary>Hit along the trace, if tracing with collision was enabled.</summary>
            [FieldOffset(44)] HitResult HitResult;

        }
}
