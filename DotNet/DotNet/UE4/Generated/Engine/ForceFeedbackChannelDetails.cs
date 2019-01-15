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
        ///<summary>Force Feedback Channel Details</summary>
        [StructLayout( LayoutKind.Explicit, Size=128 )]
        public unsafe struct ForceFeedbackChannelDetails {
            [FieldOffset(0)] public bool bAffectsLeftLarge;

            [FieldOffset(0)] public bool bAffectsLeftSmall;

            [FieldOffset(0)] public bool bAffectsRightLarge;

            [FieldOffset(0)] public bool bAffectsRightSmall;

            ///<summary>Curve</summary>
            [FieldOffset(8)] RuntimeFloatCurve Curve;

        }
}
