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
        ///<summary>Data about a particular target in the RBF, including scaling factor</summary>
        [StructLayout( LayoutKind.Explicit, Size=136 )]
        public unsafe struct RBFTarget {
            [FieldOffset(16)] public float ScaleFactor;

            [FieldOffset(20)] public bool bApplyCustomCurve;

            ///<summary>Custom curve to apply to activation of this target, if bApplyCustomCurve is true</summary>
            [FieldOffset(24)] RichCurve CustomCurve;

        }
}
