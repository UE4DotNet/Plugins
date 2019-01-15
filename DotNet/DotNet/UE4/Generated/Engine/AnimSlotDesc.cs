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
        ///<summary>Used to indicate each slot name and how many channels they have.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct AnimSlotDesc {
            [FieldOffset(0)] public Name SlotName;

            [FieldOffset(12)] public int NumChannels;

        }
}
