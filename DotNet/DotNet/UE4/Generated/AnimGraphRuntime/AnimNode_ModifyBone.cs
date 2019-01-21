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
        [StructLayout( LayoutKind.Explicit, Size=408 )]
        public unsafe struct AnimNode_ModifyBone {
            ///<summary>Name of bone to control. This is the main bone chain to modify from. *</summary>
            [FieldOffset(336)] BoneReference BoneToModify;

            ///<summary>New translation of bone to apply.</summary>
            [FieldOffset(360)] Vector Translation;

            ///<summary>New rotation of bone to apply.</summary>
            [FieldOffset(372)] Rotator Rotation;

            ///<summary>New Scale of bone to apply. This is only worldspace.</summary>
            [FieldOffset(384)] Vector Scale;

            [FieldOffset(396)] public byte TranslationMode;

            [FieldOffset(397)] public byte RotationMode;

            [FieldOffset(398)] public byte ScaleMode;

            [FieldOffset(399)] public byte TranslationSpace;

            [FieldOffset(400)] public byte RotationSpace;

            [FieldOffset(401)] public byte ScaleSpace;

        }
}
