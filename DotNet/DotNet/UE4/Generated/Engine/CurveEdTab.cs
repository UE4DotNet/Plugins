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
        ///<summary>Curve Ed Tab</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct CurveEdTab {
            [FieldOffset(0)] byte TabName; //TODO: string FString TabName

            [FieldOffset(16)] byte Curves; //TODO: array TArray Curves

            [FieldOffset(32)] public float ViewStartInput;

            [FieldOffset(36)] public float ViewEndInput;

            [FieldOffset(40)] public float ViewStartOutput;

            [FieldOffset(44)] public float ViewEndOutput;

        }
}
