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


namespace UE4.MovieScene{
        ///<summary>Movie Scene Float Value</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct MovieSceneFloatValue {
            [FieldOffset(0)] public float Value;

            [FieldOffset(4)] public byte InterpMode;

            [FieldOffset(5)] public byte TangentMode;

            ///<summary>Tangent</summary>
            [FieldOffset(8)] MovieSceneTangentData Tangent;

        }
}
