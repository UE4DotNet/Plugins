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
        ///<summary>Color Grade Per Range Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct ColorGradePerRangeSettings {
            ///<summary>Saturation</summary>
            [FieldOffset(0)] Vector4 Saturation;

            ///<summary>Contrast</summary>
            [FieldOffset(16)] Vector4 Contrast;

            ///<summary>Gamma</summary>
            [FieldOffset(32)] Vector4 Gamma;

            ///<summary>Gain</summary>
            [FieldOffset(48)] Vector4 Gain;

            ///<summary>Offset</summary>
            [FieldOffset(64)] Vector4 Offset;

        }
}
