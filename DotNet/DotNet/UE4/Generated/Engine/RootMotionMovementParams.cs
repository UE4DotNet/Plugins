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
        ///<summary>Utility struct to accumulate root motion.</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct RootMotionMovementParams {
            [FieldOffset(0)] public bool bHasRootMotion;

            [FieldOffset(4)] public float BlendWeight;

            ///<summary>Root Motion Transform</summary>
            [FieldOffset(16)] Transform RootMotionTransform;

        }
}
