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
        ///<summary>Bone Socket Target</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct BoneSocketTarget {
            [FieldOffset(0)] public bool bUseSocket;

            ///<summary>Bone Reference</summary>
            [FieldOffset(4)] BoneReference BoneReference;

            ///<summary>Socket Reference</summary>
            [FieldOffset(32)] SocketReference SocketReference;

        }
}
