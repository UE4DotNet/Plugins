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
using UE4.AnimationCore;

namespace UE4.AnimGraphRuntime{
        ///<summary>Reference Bone Frame</summary>
        [StructLayout( LayoutKind.Explicit, Size=40 )]
        public unsafe struct ReferenceBoneFrame {
            ///<summary>Bone</summary>
            [FieldOffset(0)] BoneReference Bone;

            ///<summary>Axis</summary>
            [FieldOffset(24)] Axis Axis;

        }
}
