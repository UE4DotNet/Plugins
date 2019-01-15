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
        ///<summary>Helper structure for displaying the parameter.</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct EmitterDynamicParameter {
            [FieldOffset(0)] public Name ParamName;

            [FieldOffset(12)] public bool bUseEmitterTime;

            [FieldOffset(12)] public bool bSpawnTimeOnly;

            [FieldOffset(16)] public byte ValueMethod;

            [FieldOffset(20)] public bool bScaleVelocityByParamValue;

            ///<summary>The distriubtion for the parameter value.</summary>
            [FieldOffset(24)] RawDistributionFloat ParamValue;

        }
}
