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
        ///<summary>Base class for any asset playing anim node</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct AnimNode_AssetPlayerBase {
            [FieldOffset(56)] public bool bIgnoreForRelevancyTest;

            [FieldOffset(60)] public int GroupIndex;

            [FieldOffset(64)] public byte GroupRole;

            [FieldOffset(68)] public float BlendWeight;

            [FieldOffset(72)] public float InternalTimeAccumulator;

        }
}
