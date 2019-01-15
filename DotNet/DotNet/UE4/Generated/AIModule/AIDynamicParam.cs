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


namespace UE4.AIModule{
        ///<summary>AIDynamic Param</summary>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct AIDynamicParam {
            [FieldOffset(0)] public Name ParamName;

            [FieldOffset(12)] byte ParamType; //TODO: enum EAIParamType ParamType

            [FieldOffset(16)] public float Value;

            ///<summary>BBKey</summary>
            [FieldOffset(24)] BlackboardKeySelector BBKey;

        }
}
