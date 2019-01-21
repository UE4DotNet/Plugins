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


namespace UE4.LiveLinkInterface{
        ///<summary>Live Link Curve Element</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct LiveLinkCurveElement {
            [FieldOffset(0)] public Name CurveName;

            [FieldOffset(12)] public float CurveValue;

        }
}
