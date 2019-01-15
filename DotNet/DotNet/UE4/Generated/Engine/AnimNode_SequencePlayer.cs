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
        ///<summary>Sequence player node</summary>
        [StructLayout( LayoutKind.Explicit, Size=184 )]
        public unsafe struct AnimNode_SequencePlayer {
            [FieldOffset(96)] 
            private IntPtr  Sequence_field;
            ///<summary>The animation sequence asset to play</summary>
            public AnimSequenceBase Sequence {
                get {return Sequence_field;}
                set {Sequence_field = value;}
            }

            [FieldOffset(104)] public bool bLoopAnimation;

            [FieldOffset(108)] public float PlayRateBasis;

            [FieldOffset(112)] public float PlayRate;

            ///<summary>Additional scaling, offsetting and clamping of PlayRate input.</summary>
            ///<remarks>Performed after PlayRateBasis.</remarks>
            [FieldOffset(116)] InputScaleBiasClamp PlayRateScaleBiasClamp;

            [FieldOffset(176)] public float StartPosition;

        }
}
