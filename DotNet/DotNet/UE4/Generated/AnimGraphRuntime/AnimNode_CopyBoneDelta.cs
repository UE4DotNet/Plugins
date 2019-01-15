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
        ///<summary>Simple controller to copy a transform relative to the ref pose to the target bone,</summary>
        ///<remarks>instead of the copy bone node which copies the absolute transform</remarks>
        [StructLayout( LayoutKind.Explicit, Size=424 )]
        public unsafe struct AnimNode_CopyBoneDelta {
            ///<summary>Source Bone</summary>
            [FieldOffset(360)] BoneReference SourceBone;

            ///<summary>Target Bone</summary>
            [FieldOffset(384)] BoneReference TargetBone;

            [FieldOffset(408)] public bool bCopyTranslation;

            [FieldOffset(409)] public bool bCopyRotation;

            [FieldOffset(410)] public bool bCopyScale;

            [FieldOffset(411)] byte CopyMode; //TODO: enum CopyBoneDeltaMode CopyMode

            [FieldOffset(412)] public float TranslationMultiplier;

            [FieldOffset(416)] public float RotationMultiplier;

            [FieldOffset(420)] public float ScaleMultiplier;

        }
}
