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
        ///<summary>Structure storing Data for pre-computation</summary>
        [StructLayout( LayoutKind.Explicit, Size=44 )]
        public unsafe struct AtmospherePrecomputeParameters {
            [FieldOffset(0)] public float DensityHeight;

            [FieldOffset(8)] public int MaxScatteringOrder;

            [FieldOffset(12)] public int TransmittanceTexWidth;

            [FieldOffset(16)] public int TransmittanceTexHeight;

            [FieldOffset(20)] public int IrradianceTexWidth;

            [FieldOffset(24)] public int IrradianceTexHeight;

            [FieldOffset(28)] public int InscatterAltitudeSampleNum;

            [FieldOffset(32)] public int InscatterMuNum;

            [FieldOffset(36)] public int InscatterMuSNum;

            [FieldOffset(40)] public int InscatterNuNum;

        }
}
