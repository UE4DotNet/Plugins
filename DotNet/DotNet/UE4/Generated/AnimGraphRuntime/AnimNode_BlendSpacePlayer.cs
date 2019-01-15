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
        ///<summary>@TODO: Comment</summary>
        [StructLayout( LayoutKind.Explicit, Size=304 )]
        public unsafe struct AnimNode_BlendSpacePlayer {
            [FieldOffset(96)] public float X;

            [FieldOffset(100)] public float Y;

            [FieldOffset(104)] public float Z;

            [FieldOffset(108)] public float PlayRate;

            [FieldOffset(112)] public bool bLoop;

            [FieldOffset(116)] public float StartPosition;

            [FieldOffset(120)] 
            private IntPtr  BlendSpace_field;
            ///<summary>The blendspace asset to play</summary>
            public BlendSpaceBase BlendSpace {
                get {return BlendSpace_field;}
                set {BlendSpace_field = value;}
            }

            [FieldOffset(128)] public bool bResetPlayTimeWhenBlendSpaceChanges;

            ///<summary>Blend Filter</summary>
            [FieldOffset(136)] BlendFilter BlendFilter;

            [FieldOffset(280)] byte BlendSampleDataCache; //TODO: array TArray BlendSampleDataCache

            [FieldOffset(296)] 
            private IntPtr  PreviousBlendSpace_field;
            ///<summary>Previous Blend Space</summary>
            public BlendSpaceBase PreviousBlendSpace {
                get {return PreviousBlendSpace_field;}
                set {PreviousBlendSpace_field = value;}
            }

        }
}
