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
        ///<summary>Provide a snapshot pose, either from the internal named pose cache or via a supplied snapshot</summary>
        [StructLayout( LayoutKind.Explicit, Size=208 )]
        public unsafe struct AnimNode_PoseSnapshot {
            [FieldOffset(56)] byte Mode; //TODO: enum ESnapshotSourceMode Mode

            [FieldOffset(60)] public Name SnapshotName;

            ///<summary>Snapshot to use. This should be populated at first by calling SnapshotPose</summary>
            [FieldOffset(72)] PoseSnapshot Snapshot;

        }
}
