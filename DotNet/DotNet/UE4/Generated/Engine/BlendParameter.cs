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
        ///<summary>Blend Parameter</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct BlendParameter {
            [FieldOffset(0)] byte DisplayName; //TODO: string FString DisplayName

            [FieldOffset(16)] public float Min;

            [FieldOffset(20)] public float Max;

            [FieldOffset(24)] public int GridNum;

        }
}
