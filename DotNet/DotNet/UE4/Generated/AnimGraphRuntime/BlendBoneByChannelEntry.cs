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
        ///<summary>Blend Bone by Channel Entry</summary>
        [StructLayout( LayoutKind.Explicit, Size=52 )]
        public unsafe struct BlendBoneByChannelEntry {
            ///<summary>Bone to take Transform from</summary>
            [FieldOffset(0)] BoneReference SourceBone;

            ///<summary>Bone to apply Transform to</summary>
            [FieldOffset(24)] BoneReference TargetBone;

            [FieldOffset(48)] public bool bBlendTranslation;

            [FieldOffset(49)] public bool bBlendRotation;

            [FieldOffset(50)] public bool bBlendScale;

        }
}
