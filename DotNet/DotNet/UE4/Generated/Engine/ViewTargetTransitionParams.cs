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
        ///<summary>A set of parameters to describe how to transition between view targets.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct ViewTargetTransitionParams {
            [FieldOffset(0)] public float BlendTime;

            [FieldOffset(4)] public byte BlendFunction;

            [FieldOffset(8)] public float BlendExp;

            [FieldOffset(12)] public bool bLockOutgoing;

        }
}
