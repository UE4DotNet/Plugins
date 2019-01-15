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
        ///<summary>Struct used for passing information from Matinee to an Actor for blending animations during a sequence.</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct AnimSlotInfo {
            [FieldOffset(0)] public Name SlotName;

            [FieldOffset(16)] byte ChannelWeights; //TODO: array TArray ChannelWeights

        }
}
