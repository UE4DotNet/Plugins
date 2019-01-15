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
        ///<summary>Baked Animation State Machine</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct BakedAnimationStateMachine {
            [FieldOffset(0)] public Name MachineName;

            [FieldOffset(12)] public int InitialState;

            [FieldOffset(16)] byte States; //TODO: array TArray States

            [FieldOffset(32)] byte Transitions; //TODO: array TArray Transitions

        }
}
