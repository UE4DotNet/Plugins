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

namespace UE4.FunctionalTesting{
        ///<summary>Trace Query Test Results Inner Most</summary>
        [StructLayout( LayoutKind.Explicit, Size=224 )]
        public unsafe struct TraceQueryTestResultsInnerMost {
            ///<summary>Result from doing a single sweep</summary>
            [FieldOffset(0)] HitResult SingleHit;

            ///<summary>Names found from doing a single sweep</summary>
            [FieldOffset(144)] TraceQueryTestNames SingleNames;

            [FieldOffset(180)] public bool bSingleResult;

            [FieldOffset(184)] byte MultiHits; //TODO: array TArray MultiHits

            [FieldOffset(200)] byte MultiNames; //TODO: array TArray MultiNames

            [FieldOffset(216)] public bool bMultiResult;

        }
}
