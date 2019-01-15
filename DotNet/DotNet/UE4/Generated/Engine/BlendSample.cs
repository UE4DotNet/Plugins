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
        ///<summary>Sample data</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct BlendSample {
            [FieldOffset(0)] 
            private IntPtr  Animation_field;
            ///<summary>Animation</summary>
            public AnimSequence Animation {
                get {return Animation_field;}
                set {Animation_field = value;}
            }

            ///<summary>blend 0->x, blend 1->y, blend 2->z</summary>
            [FieldOffset(8)] Vector SampleValue;

            [FieldOffset(20)] public float RateScale;

            [FieldOffset(24)] public bool bSnapToGrid;

            [FieldOffset(24)] public bool bIsValid;

        }
}
