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
        ///<summary>FPerPlatformFloat - float property with per-platform overrides</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct PerPlatformFloat {
            [FieldOffset(0)] public float Default;

            [FieldOffset(8)] byte PerPlatform; //TODO: map TMap PerPlatform

        }
}
