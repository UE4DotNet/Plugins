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
        ///<summary>Raw Distribution Float</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct RawDistributionFloat {
            [FieldOffset(40)] public float MinValue;

            [FieldOffset(44)] public float MaxValue;

            [FieldOffset(48)] 
            private IntPtr  Distribution_field;
            ///<summary>Distribution</summary>
            public DistributionFloat Distribution {
                get {return Distribution_field;}
                set {Distribution_field = value;}
            }

        }
}
