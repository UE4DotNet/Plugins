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
        ///<summary>Skeletal Mesh Sampling Info</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct SkeletalMeshSamplingInfo {
            [FieldOffset(0)] byte Regions; //TODO: array TArray Regions

            ///<summary>Built Data</summary>
            [FieldOffset(16)] SkeletalMeshSamplingBuiltData BuiltData;

        }
}
