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
        ///<summary>Animation State</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct AnimationState {
            [FieldOffset(16)] byte Transitions; //TODO: array TArray Transitions

            [FieldOffset(32)] public int StateRootNodeIndex;

            [FieldOffset(36)] public int StartNotify;

            [FieldOffset(40)] public int EndNotify;

            [FieldOffset(44)] public int FullyBlendedNotify;

        }
}
