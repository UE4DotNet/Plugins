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
        ///<summary>DEPRECATED Pairs desired tire friction scale with tire type</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct TireFrictionScalePair {
            [FieldOffset(0)] 
            private IntPtr  TireType_field;
            ///<summary>Tire type</summary>
            public TireType TireType {
                get {return TireType_field;}
                set {TireType_field = value;}
            }

            [FieldOffset(8)] public float FrictionScale;

        }
}
