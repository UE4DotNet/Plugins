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
        ///<summary>Cone constraint</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct ConeConstraint {
            [FieldOffset(20)] public float Swing1LimitDegrees;

            [FieldOffset(24)] public float Swing2LimitDegrees;

            [FieldOffset(28)] public byte Swing1Motion;

            [FieldOffset(29)] public byte Swing2Motion;

        }
}
