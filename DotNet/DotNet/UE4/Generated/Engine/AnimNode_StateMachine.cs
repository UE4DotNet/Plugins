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
        ///<summary>State machine node</summary>
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        public unsafe struct AnimNode_StateMachine {
            [FieldOffset(56)] public int StateMachineIndexInClass;

            [FieldOffset(60)] public int MaxTransitionsPerFrame;

            [FieldOffset(64)] public bool bSkipFirstUpdateTransition;

            [FieldOffset(65)] public bool bReinitializeOnBecomingRelevant;

            [FieldOffset(80)] public int CurrentState;

            [FieldOffset(84)] public float ElapsedTime;

        }
}
