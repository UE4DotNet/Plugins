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
        ///<summary>A filter for a whole transform</summary>
        [StructLayout( LayoutKind.Explicit, Size=9 )]
        public unsafe struct TransformFilter {
            ///<summary>Translation Filter</summary>
            [FieldOffset(0)] FilterOptionPerAxis TranslationFilter;

            ///<summary>Rotation Filter</summary>
            [FieldOffset(3)] FilterOptionPerAxis RotationFilter;

            ///<summary>Scale Filter</summary>
            [FieldOffset(6)] FilterOptionPerAxis ScaleFilter;

        }
}
