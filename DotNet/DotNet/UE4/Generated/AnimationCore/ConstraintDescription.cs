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


namespace UE4.AnimationCore{
        ///<summary>A description of how to apply a simple transform constraint</summary>
        [StructLayout( LayoutKind.Explicit, Size=13 )]
        public unsafe struct ConstraintDescription {
            [FieldOffset(0)] public bool bTranslation;

            [FieldOffset(1)] public bool bRotation;

            [FieldOffset(2)] public bool bScale;

            [FieldOffset(3)] public bool bParent;

            ///<summary>Translation Axes</summary>
            [FieldOffset(4)] FilterOptionPerAxis TranslationAxes;

            ///<summary>Rotation Axes</summary>
            [FieldOffset(7)] FilterOptionPerAxis RotationAxes;

            ///<summary>Scale Axes</summary>
            [FieldOffset(10)] FilterOptionPerAxis ScaleAxes;

        }
}
