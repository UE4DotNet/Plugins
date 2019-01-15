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
        ///<summary>Defines FVector oscillation.</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct VOscillator {
            ///<summary>Oscillation in the X axis.</summary>
            [FieldOffset(0)] FOscillator X;

            ///<summary>Oscillation in the Y axis.</summary>
            [FieldOffset(12)] FOscillator Y;

            ///<summary>Oscillation in the Z axis.</summary>
            [FieldOffset(24)] FOscillator Z;

        }
}
