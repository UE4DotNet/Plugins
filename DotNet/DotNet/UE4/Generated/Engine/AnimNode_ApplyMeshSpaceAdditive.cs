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
        ///<summary>Anim Node Apply Mesh Space Additive</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct AnimNode_ApplyMeshSpaceAdditive {
            ///<summary>Base</summary>
            [FieldOffset(56)] PoseLink Base;

            ///<summary>Additive</summary>
            [FieldOffset(80)] PoseLink Additive;

            [FieldOffset(104)] public float Alpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(108)] InputScaleBias AlphaScaleBias;

            [FieldOffset(116)] public int LODThreshold;

            [FieldOffset(120)] public float ActualAlpha;

        }
}
