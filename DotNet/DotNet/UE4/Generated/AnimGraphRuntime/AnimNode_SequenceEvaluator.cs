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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>Evaluates a point in an anim sequence, using a specific time input rather than advancing time internally.</summary>
        ///<remarks>
        ///Typically the playback position of the animation for this node will represent something other than time, like jump height.
        ///This node will not trigger any notifies present in the associated sequence.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        public unsafe struct AnimNode_SequenceEvaluator {
            [FieldOffset(96)] 
            private IntPtr  Sequence_field;
            ///<summary>The animation sequence asset to evaluate</summary>
            public AnimSequenceBase Sequence {
                get {return Sequence_field;}
                set {Sequence_field = value;}
            }

            [FieldOffset(104)] public float ExplicitTime;

            [FieldOffset(108)] public bool bShouldLoop;

            [FieldOffset(109)] public bool bTeleportToExplicitTime;

            [FieldOffset(112)] public float StartPosition;

            [FieldOffset(116)] public byte ReinitializationBehavior;

            [FieldOffset(117)] public bool bReinitialized;

        }
}
