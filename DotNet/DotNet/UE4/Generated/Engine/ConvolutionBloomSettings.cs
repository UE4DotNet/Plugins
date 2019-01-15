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
        ///<summary>Convolution Bloom Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct ConvolutionBloomSettings {
            [FieldOffset(0)] 
            private IntPtr  Texture_field;
            ///<summary>Texture to replace default convolution bloom kernel</summary>
            public Texture2D Texture {
                get {return Texture_field;}
                set {Texture_field = value;}
            }

            [FieldOffset(8)] public float Size;

            ///<summary>The UV location of the center of the kernel.  Should be very close to (.5,.5)</summary>
            [FieldOffset(12)] Vector2D CenterUV;

            [FieldOffset(20)] public float PreFilterMin;

            [FieldOffset(24)] public float PreFilterMax;

            [FieldOffset(28)] public float PreFilterMult;

            [FieldOffset(32)] public float BufferScale;

        }
}
