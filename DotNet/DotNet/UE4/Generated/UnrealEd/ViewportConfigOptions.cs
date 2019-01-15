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


namespace UE4.UnrealEd{
        ///<summary>Persistent per-viewport options</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct ViewportConfigOptions {
            [FieldOffset(0)] public byte ViewModeIndex;

            [FieldOffset(4)] public float ViewFOV;

            [FieldOffset(8)] byte CameraFollowMode; //TODO: enum EAnimationViewportCameraFollowMode CameraFollowMode

            [FieldOffset(12)] public Name CameraFollowBoneName;

        }
}
