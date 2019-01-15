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
        ///<summary>Configurable properties for control axes.</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct InputAxisConfigEntry {
            [FieldOffset(0)] public Name AxisKeyName;

            ///<summary>Properties for the Axis Key</summary>
            [FieldOffset(12)] InputAxisProperties AxisProperties;

        }
}
