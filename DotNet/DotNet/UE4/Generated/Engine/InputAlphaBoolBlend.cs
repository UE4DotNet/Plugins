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
        ///<summary>Input Alpha Bool Blend</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct InputAlphaBoolBlend {
            [FieldOffset(0)] public float BlendInTime;

            [FieldOffset(4)] public float BlendOutTime;

            [FieldOffset(8)] byte BlendOption; //TODO: enum EAlphaBlendOption BlendOption

            [FieldOffset(9)] public bool bInitialized;

            [FieldOffset(16)] 
            private IntPtr  CustomCurve_field;
            ///<summary>Custom Curve</summary>
            public CurveFloat CustomCurve {
                get {return CustomCurve_field;}
                set {CustomCurve_field = value;}
            }

            ///<summary>Alpha Blend</summary>
            [FieldOffset(24)] AlphaBlend AlphaBlend;

        }
}
