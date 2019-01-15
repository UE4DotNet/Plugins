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
        ///<summary>Anim Montage Instance</summary>
        [StructLayout( LayoutKind.Explicit, Size=432 )]
        public unsafe struct AnimMontageInstance {
            [FieldOffset(0)] 
            private IntPtr  Montage_field;
            ///<summary>Montage reference</summary>
            public AnimMontage Montage {
                get {return Montage_field;}
                set {Montage_field = value;}
            }

            [FieldOffset(40)] public bool bPlaying;

            [FieldOffset(44)] public float DefaultBlendTimeMultiplier;

            [FieldOffset(232)] byte NextSections; //TODO: array TArray NextSections

            [FieldOffset(248)] byte PrevSections; //TODO: array TArray PrevSections

            [FieldOffset(280)] byte ActiveStateBranchingPoints; //TODO: array TArray ActiveStateBranchingPoints

            [FieldOffset(296)] public float Position;

            [FieldOffset(300)] public float PlayRate;

            ///<summary>Blend</summary>
            [FieldOffset(304)] AlphaBlend Blend;

            [FieldOffset(392)] public int DisableRootMotionCount;

        }
}
