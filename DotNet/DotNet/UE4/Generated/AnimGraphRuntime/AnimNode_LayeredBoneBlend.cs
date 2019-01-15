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
        ///<summary>Layered blend (per bone); has dynamic number of blendposes that can blend per different bone sets</summary>
        [StructLayout( LayoutKind.Explicit, Size=232 )]
        public unsafe struct AnimNode_LayeredBoneBlend {
            ///<summary>The source pose</summary>
            [FieldOffset(56)] PoseLink BasePose;

            [FieldOffset(80)] byte BlendPoses; //TODO: array TArray BlendPoses

            [FieldOffset(96)] byte LayerSetup; //TODO: array TArray LayerSetup

            [FieldOffset(112)] byte BlendWeights; //TODO: array TArray BlendWeights

            [FieldOffset(128)] public bool bMeshSpaceRotationBlend;

            [FieldOffset(129)] public byte CurveBlendOption;

            [FieldOffset(130)] public bool bBlendRootMotionBasedOnRootBone;

            [FieldOffset(131)] public bool bHasRelevantPoses;

            [FieldOffset(132)] public int LODThreshold;

            [FieldOffset(136)] byte PerBoneBlendWeights; //TODO: array TArray PerBoneBlendWeights

            ///<summary>Skeleton Guid</summary>
            [FieldOffset(152)] FGuid SkeletonGuid;

            ///<summary>Virtual Bone Guid</summary>
            [FieldOffset(168)] FGuid VirtualBoneGuid;

        }
}
