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
        ///<summary>Supply curves from some external source (e.g. audio)</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct AnimNode_CurveSource {
            ///<summary>Source Pose</summary>
            [FieldOffset(56)] PoseLink SourcePose;

            [FieldOffset(80)] public Name SourceBinding;

            [FieldOffset(92)] public float Alpha;

            [FieldOffset(96)] byte CurveSource; //TODO: interface TScriptInterface CurveSource

        }
}
