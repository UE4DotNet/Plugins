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
        ///<summary>An integral curve, which holds the key time and the key value</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct IntegralCurve {
            [FieldOffset(88)] byte Keys; //TODO: array TArray Keys

            [FieldOffset(104)] public int DefaultValue;

            [FieldOffset(108)] public bool bUseDefaultValueBeforeFirstKey;

        }
}
