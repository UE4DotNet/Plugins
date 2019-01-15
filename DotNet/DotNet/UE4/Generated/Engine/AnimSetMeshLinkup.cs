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
        ///<summary>This is a mapping table between each bone in a particular skeletal mesh and the tracks of this animation set.</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct AnimSetMeshLinkup {
            [FieldOffset(0)] byte BoneToTrackTable; //TODO: array TArray BoneToTrackTable

        }
}
