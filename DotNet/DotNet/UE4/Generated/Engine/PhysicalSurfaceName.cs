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
        ///<summary>Structure that represents the name of physical surfaces.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct PhysicalSurfaceName {
            [FieldOffset(0)] public byte Type;

            [FieldOffset(4)] public Name Name;

        }
}
