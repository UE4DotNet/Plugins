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
        ///<summary>Easy way to modify curve values on a pose</summary>
        [StructLayout( LayoutKind.Explicit, Size=144 )]
        public unsafe struct AnimNode_ModifyCurve {
            ///<summary>Source Pose</summary>
            [FieldOffset(56)] PoseLink SourcePose;

            [FieldOffset(80)] byte ApplyMode; //TODO: enum EModifyCurveApplyMode ApplyMode

            [FieldOffset(88)] byte CurveValues; //TODO: array TArray CurveValues

            [FieldOffset(104)] byte LastCurveValues; //TODO: array TArray LastCurveValues

            [FieldOffset(120)] byte CurveNames; //TODO: array TArray CurveNames

            [FieldOffset(136)] public float Alpha;

        }
}
