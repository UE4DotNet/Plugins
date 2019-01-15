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
        ///<summary>Holds texture information with UV coordinates as well.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct CanvasIcon {
            [FieldOffset(0)] 
            private IntPtr  Texture_field;
            ///<summary>Source texture</summary>
            public Texture Texture {
                get {return Texture_field;}
                set {Texture_field = value;}
            }

            [FieldOffset(8)] public float U;

            [FieldOffset(12)] public float V;

            [FieldOffset(16)] public float UL;

            [FieldOffset(20)] public float VL;

        }
}
