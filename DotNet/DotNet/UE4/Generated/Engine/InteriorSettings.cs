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
        ///<summary>Struct encapsulating settings for interior areas.</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct InteriorSettings {
            [FieldOffset(0)] public bool bIsWorldSettings;

            [FieldOffset(4)] public float ExteriorVolume;

            [FieldOffset(8)] public float ExteriorTime;

            [FieldOffset(12)] public float ExteriorLPF;

            [FieldOffset(16)] public float ExteriorLPFTime;

            [FieldOffset(20)] public float InteriorVolume;

            [FieldOffset(24)] public float InteriorTime;

            [FieldOffset(28)] public float InteriorLPF;

            [FieldOffset(32)] public float InteriorLPFTime;

        }
}
