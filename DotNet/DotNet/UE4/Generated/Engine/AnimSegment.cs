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
        ///<summary>this is anim segment that defines what animation and how *</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AnimSegment {
            [FieldOffset(0)] 
            private IntPtr  AnimReference_field;
            ///<summary>Anim Reference to play - only allow AnimSequence or AnimComposite *</summary>
            public AnimSequenceBase AnimReference {
                get {return AnimReference_field;}
                set {AnimReference_field = value;}
            }

            [FieldOffset(8)] public float StartPos;

            [FieldOffset(12)] public float AnimStartTime;

            [FieldOffset(16)] public float AnimEndTime;

            [FieldOffset(20)] public float AnimPlayRate;

            [FieldOffset(24)] public int LoopingCount;

        }
}
