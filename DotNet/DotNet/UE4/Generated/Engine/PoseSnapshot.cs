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
        ///<summary>A pose for a skeletal mesh</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct PoseSnapshot {
            [FieldOffset(0)] byte LocalTransforms; //TODO: array TArray LocalTransforms

            [FieldOffset(16)] byte BoneNames; //TODO: array TArray BoneNames

            [FieldOffset(32)] public Name SkeletalMeshName;

            [FieldOffset(44)] public Name SnapshotName;

            [FieldOffset(56)] public bool bIsValid;

        }
}
