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
        ///<summary>Modulator Continuous Params</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct ModulatorContinuousParams {
            [FieldOffset(0)] public Name ParameterName;

            [FieldOffset(12)] public float Default;

            [FieldOffset(16)] public float MinInput;

            [FieldOffset(20)] public float MaxInput;

            [FieldOffset(24)] public float MinOutput;

            [FieldOffset(28)] public float MaxOutput;

            [FieldOffset(32)] public byte ParamMode;

        }
}
