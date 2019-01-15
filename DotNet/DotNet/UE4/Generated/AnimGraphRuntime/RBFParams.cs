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


namespace UE4.AnimGraphRuntime{
        ///<summary>Parameters used by RBF solver</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct RBFParams {
            [FieldOffset(0)] public int TargetDimensions;

            [FieldOffset(4)] public float Radius;

            [FieldOffset(8)] byte Function; //TODO: enum ERBFFunctionType Function

            [FieldOffset(9)] byte DistanceMethod; //TODO: enum ERBFDistanceMethod DistanceMethod

            [FieldOffset(10)] public byte TwistAxis;

            [FieldOffset(12)] public float WeightThreshold;

        }
}
