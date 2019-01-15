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
        ///<summary>Struct defining a RootMotionExtractionStep.</summary>
        ///<remarks>
        ///When extracting RootMotion we can encounter looping animations (wrap around), or different animations.
        ///We break those up into different steps, to help with RootMotion extraction,
        ///as we can only extract a contiguous range per AnimSequence.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct RootMotionExtractionStep {
            [FieldOffset(0)] 
            private IntPtr  AnimSequence_field;
            ///<summary>AnimSequence ref</summary>
            public AnimSequence AnimSequence {
                get {return AnimSequence_field;}
                set {AnimSequence_field = value;}
            }

            [FieldOffset(8)] public float StartPosition;

            [FieldOffset(12)] public float EndPosition;

        }
}
