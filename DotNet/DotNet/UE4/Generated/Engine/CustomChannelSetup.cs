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
        ///<summary>Structure for custom channel setup information.</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct CustomChannelSetup {
            [FieldOffset(0)] public byte Channel;

            [FieldOffset(4)] public Name Name;

            [FieldOffset(16)] public byte DefaultResponse;

            [FieldOffset(17)] public bool bTraceType;

            [FieldOffset(18)] public bool bStaticObject;

        }
}
