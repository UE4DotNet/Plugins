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


namespace UE4.MagicLeapEyeTracker{
        ///<summary>Magic Leap Fixation Comfort</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct MagicLeapFixationComfort {
            [FieldOffset(0)] public bool FixationDepthIsUncomfortable;

            [FieldOffset(1)] public bool FixationDepthViolationHasOccurred;

            [FieldOffset(4)] public float RemainingTimeAtUncomfortableDepth;

        }
}
