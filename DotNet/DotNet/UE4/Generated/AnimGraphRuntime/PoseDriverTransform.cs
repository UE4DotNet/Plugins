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


namespace UE4.AnimGraphRuntime{
        ///<summary>Translation and rotation for a particular bone at a particular target</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct PoseDriverTransform {
            ///<summary>Translation of this target</summary>
            [FieldOffset(0)] Vector TargetTranslation;

            ///<summary>Rotation of this target</summary>
            [FieldOffset(12)] Rotator TargetRotation;

        }
}
