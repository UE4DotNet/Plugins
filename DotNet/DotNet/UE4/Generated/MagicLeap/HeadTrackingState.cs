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


namespace UE4.MagicLeap{
        ///<summary>Head Tracking State</summary>
        [StructLayout( LayoutKind.Explicit, Size=8 )]
        public unsafe struct HeadTrackingState {
            [FieldOffset(0)] byte Mode; //TODO: enum EHeadTrackingMode Mode

            [FieldOffset(1)] byte Error; //TODO: enum EHeadTrackingError Error

            [FieldOffset(4)] public float Confidence;

        }
}
