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
        ///<summary>Lens Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=224 )]
        public unsafe struct LensSettings {
            ///<summary>Bloom</summary>
            [FieldOffset(0)] LensBloomSettings Bloom;

            ///<summary>Imperfections</summary>
            [FieldOffset(184)] LensImperfectionSettings Imperfections;

            [FieldOffset(216)] public float ChromaticAberration;

        }
}
