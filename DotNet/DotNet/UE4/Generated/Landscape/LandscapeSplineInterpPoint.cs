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


namespace UE4.Landscape{
        ///<summary>Landscape Spline Interp Point</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct LandscapeSplineInterpPoint {
            ///<summary>Center Point</summary>
            [FieldOffset(0)] Vector Center;

            ///<summary>Left Point</summary>
            [FieldOffset(12)] Vector Left;

            ///<summary>Right Point</summary>
            [FieldOffset(24)] Vector Right;

            ///<summary>Left Falloff Point</summary>
            [FieldOffset(36)] Vector FalloffLeft;

            ///<summary>Right FalloffPoint</summary>
            [FieldOffset(48)] Vector FalloffRight;

            [FieldOffset(60)] public float StartEndFalloff;

        }
}
