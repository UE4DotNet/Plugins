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
        ///<summary>Structure for recording float values and displaying them as an Histogram through DrawDebugFloatHistory.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct DebugFloatHistory {
            [FieldOffset(0)] byte Samples; //TODO: array TArray Samples

            [FieldOffset(16)] public float MaxSamples;

            [FieldOffset(20)] public float MinValue;

            [FieldOffset(24)] public float MaxValue;

            [FieldOffset(28)] public bool bAutoAdjustMinMax;

        }
}
