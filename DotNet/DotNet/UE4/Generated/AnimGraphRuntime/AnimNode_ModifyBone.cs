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
        ///<summary>Simple controller that replaces or adds to the translation/rotation of a single bone.</summary>
        [StructLayout( LayoutKind.Explicit, Size=432 )]
        public unsafe struct AnimNode_ModifyBone {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(360)] BoneReference BoneToModify;

            ///<summary>New translation of bone to apply.</summary>
            [FieldOffset(384)] Vector Translation;

            ///<summary>New rotation of bone to apply.</summary>
            [FieldOffset(396)] Rotator Rotation;

            ///<summary>New Scale of bone to apply. This is only worldspace.</summary>
            [FieldOffset(408)] Vector Scale;

            [FieldOffset(420)] public byte TranslationMode;

            [FieldOffset(421)] public byte RotationMode;

            [FieldOffset(422)] public byte ScaleMode;

            [FieldOffset(423)] public byte TranslationSpace;

            [FieldOffset(424)] public byte RotationSpace;

            [FieldOffset(425)] public byte ScaleSpace;

        }
}
