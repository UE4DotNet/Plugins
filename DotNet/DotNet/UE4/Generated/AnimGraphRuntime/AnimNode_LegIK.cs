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


namespace UE4.AnimGraphRuntime{
        ///<summary>Anim Node Leg IK</summary>
        [StructLayout( LayoutKind.Explicit, Size=384 )]
        public unsafe struct AnimNode_LegIK {
            [FieldOffset(336)] public float ReachPrecision;

            [FieldOffset(340)] public int MaxIterations;

            [FieldOffset(344)] byte LegsDefinition; //TODO: array TArray LegsDefinition

            [FieldOffset(360)] byte LegsData; //TODO: array TArray LegsData

        }
}
