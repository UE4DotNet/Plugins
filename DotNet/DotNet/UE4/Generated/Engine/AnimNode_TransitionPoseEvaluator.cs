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
        ///<summary>Animation data node for state machine transitions.</summary>
        ///<remarks>Can be set to supply either the animation data from the transition source (From State) or the transition destination (To State).</remarks>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct AnimNode_TransitionPoseEvaluator {
            [FieldOffset(56)] public byte DataSource;

            [FieldOffset(57)] public byte EvaluatorMode;

            [FieldOffset(60)] public int FramesToCachePose;

            [FieldOffset(120)] public int CacheFramesRemaining;

        }
}
