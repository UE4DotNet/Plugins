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
        ///<summary>Particle Curve Pair</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct ParticleCurvePair {
            [FieldOffset(0)] byte CurveName; //TODO: string FString CurveName

            [FieldOffset(16)] 
            private IntPtr  CurveObject_field;
            ///<summary>Curve Object</summary>
            public UObject CurveObject {
                get {return CurveObject_field;}
                set {CurveObject_field = value;}
            }

        }
}
