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
        ///<summary>Raw Distribution Vector</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct RawDistributionVector {
            [FieldOffset(40)] public float MinValue;

            [FieldOffset(44)] public float MaxValue;

            ///<summary>Min Value Vec</summary>
            [FieldOffset(48)] Vector MinValueVec;

            ///<summary>Max Value Vec</summary>
            [FieldOffset(60)] Vector MaxValueVec;

            [FieldOffset(72)] 
            private IntPtr  Distribution_field;
            ///<summary>Distribution</summary>
            public DistributionVector Distribution {
                get {return Distribution_field;}
                set {Distribution_field = value;}
            }

        }
}
