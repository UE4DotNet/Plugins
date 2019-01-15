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
        ///<summary>Lens Imperfection Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct LensImperfectionSettings {
            [FieldOffset(0)] 
            private IntPtr  DirtMask_field;
            ///<summary>Texture that defines the dirt on the camera lens where the light of very bright objects is scattered.</summary>
            public Texture DirtMask {
                get {return DirtMask_field;}
                set {DirtMask_field = value;}
            }

            [FieldOffset(8)] public float DirtMaskIntensity;

            ///<summary>BloomDirtMask tint color</summary>
            [FieldOffset(12)] LinearColor DirtMaskTint;

        }
}
