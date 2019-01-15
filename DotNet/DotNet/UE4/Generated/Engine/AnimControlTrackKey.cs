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
        ///<summary>Structure used for holding information for one animation played on the Anim Control track.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AnimControlTrackKey {
            [FieldOffset(0)] public float StartTime;

            [FieldOffset(8)] 
            private IntPtr  AnimSeq_field;
            ///<summary>Animation Sequence to play</summary>
            public AnimSequence AnimSeq {
                get {return AnimSeq_field;}
                set {AnimSeq_field = value;}
            }

            [FieldOffset(16)] public float AnimStartOffset;

            [FieldOffset(20)] public float AnimEndOffset;

            [FieldOffset(24)] public float AnimPlayRate;

            [FieldOffset(28)] public bool bLooping;

            [FieldOffset(28)] public bool bReverse;

        }
}
