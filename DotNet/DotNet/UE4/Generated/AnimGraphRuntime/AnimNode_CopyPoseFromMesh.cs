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
        ///<summary>Simple controller to copy a bone's transform to another one.</summary>
        [StructLayout( LayoutKind.Explicit, Size=240 )]
        public unsafe struct AnimNode_CopyPoseFromMesh {
            [FieldOffset(56)] byte SourceMeshComponent; //TODO: weak object TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent

            [FieldOffset(64)] public bool bUseAttachedParent;

            [FieldOffset(65)] public bool bCopyCurves;

        }
}
