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
        ///<summary>This represents a baked transition</summary>
        [StructLayout( LayoutKind.Explicit, Size=120 )]
        public unsafe struct AnimNode_MultiWayBlend {
            [FieldOffset(56)] byte Poses; //TODO: array TArray Poses

            [FieldOffset(72)] byte DesiredAlphas; //TODO: array TArray DesiredAlphas

            [FieldOffset(88)] public bool bAdditiveNode;

            [FieldOffset(89)] public bool bNormalizeAlpha;

            ///<summary>Alpha Scale Bias</summary>
            [FieldOffset(92)] InputScaleBias AlphaScaleBias;

        }
}
