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
        ///<summary>Transform definition</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct BlendSampleData {
            [FieldOffset(0)] public int SampleDataIndex;

            [FieldOffset(8)] 
            private IntPtr  Animation_field;
            ///<summary>Animation</summary>
            public AnimSequence Animation {
                get {return Animation_field;}
                set {Animation_field = value;}
            }

            [FieldOffset(16)] public float TotalWeight;

            [FieldOffset(20)] public float Time;

            [FieldOffset(24)] public float PreviousTime;

            [FieldOffset(28)] public float SamplePlayRate;

        }
}
