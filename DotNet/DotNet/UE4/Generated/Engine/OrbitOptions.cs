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
        ///<summary>Container struct for holding options on the data updating for the module.</summary>
        [StructLayout( LayoutKind.Explicit, Size=4 )]
        public unsafe struct OrbitOptions {
            [FieldOffset(0)] public bool bProcessDuringSpawn;

            [FieldOffset(0)] public bool bProcessDuringUpdate;

            [FieldOffset(0)] public bool bUseEmitterTime;

        }
}
