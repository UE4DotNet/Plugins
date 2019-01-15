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


namespace UE4.AlembicLibrary{
        ///<summary>Abc Conversion Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct AbcConversionSettings {
            [FieldOffset(0)] byte Preset; //TODO: enum EAbcConversionPreset Preset

            [FieldOffset(1)] public bool bFlipU;

            [FieldOffset(2)] public bool bFlipV;

            ///<summary>Scale value that should be applied</summary>
            [FieldOffset(4)] Vector Scale;

            ///<summary>Rotation in Euler angles that should be applied</summary>
            [FieldOffset(16)] Vector Rotation;

        }
}
