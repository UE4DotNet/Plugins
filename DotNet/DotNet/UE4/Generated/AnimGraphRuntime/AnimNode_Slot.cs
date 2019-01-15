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

using UE4.Engine;

namespace UE4.AnimGraphRuntime{
        ///<summary>
        ///An animation slot node normally acts as a passthru, but a montage or PlaySlotAnimation call from
        ///game code can cause an animation to blend in and be played on the slot temporarily, overriding the
        ///Source input.
        ///</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct AnimNode_Slot {
            ///<summary>The source input, passed thru to the output unless a montage or slot animation is currently playing</summary>
            [FieldOffset(56)] PoseLink Source;

            [FieldOffset(80)] public Name SlotName;

            [FieldOffset(92)] public bool bAlwaysUpdateSourcePose;

        }
}
