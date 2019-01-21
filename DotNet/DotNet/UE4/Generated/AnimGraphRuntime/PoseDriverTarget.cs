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
        ///<summary>Information about each target in the PoseDriver</summary>
        [StructLayout( LayoutKind.Explicit, Size=176 )]
        public unsafe struct PoseDriverTarget {
            [FieldOffset(0)] byte BoneTransforms; //TODO: array TArray BoneTransforms

            ///<summary>Rotation of this target</summary>
            [FieldOffset(16)] Rotator TargetRotation;

            [FieldOffset(28)] public float TargetScale;

            [FieldOffset(32)] public bool bApplyCustomCurve;

            ///<summary>Custom curve mapping to apply if bApplyCustomCurve is true</summary>
            [FieldOffset(40)] RichCurve CustomCurve;

            [FieldOffset(152)] public Name DrivenName;

        }
}
