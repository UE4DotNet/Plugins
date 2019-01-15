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
        ///<summary>Alpha Blend class that supports different blend options as well as custom curves</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct AlphaBlend {
            [FieldOffset(0)] byte BlendOption; //TODO: enum EAlphaBlendOption BlendOption

            [FieldOffset(8)] 
            private IntPtr  CustomCurve_field;
            ///<summary>If you're using Custom BlendOption, you can specify curve</summary>
            public CurveFloat CustomCurve {
                get {return CustomCurve_field;}
                set {CustomCurve_field = value;}
            }

            [FieldOffset(16)] public float BlendTime;

        }
}
