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
        ///<summary>Simple controller to copy a bone's transform to another one.</summary>
        [StructLayout( LayoutKind.Explicit, Size=392 )]
        public unsafe struct AnimNode_CopyBone {
            ///<summary>Source Bone Name to get transform from</summary>
            [FieldOffset(336)] BoneReference SourceBone;

            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(360)] BoneReference TargetBone;

            [FieldOffset(384)] public bool bCopyTranslation;

            [FieldOffset(385)] public bool bCopyRotation;

            [FieldOffset(386)] public bool bCopyScale;

            [FieldOffset(387)] public byte ControlSpace;

        }
}
