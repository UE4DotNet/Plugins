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
        ///<summary>
        ///This is the offset for constraint
        ///Saves individual component (translation, rotation, scale or parent)
        ///</summary>
        ///<remarks>Used by Constraint for saving the offset, and recovering the offset</remarks>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct ConstraintOffset {
            ///<summary>Translation</summary>
            [FieldOffset(0)] Vector Translation;

            ///<summary>Rotation</summary>
            [FieldOffset(16)] Quat Rotation;

            ///<summary>Scale</summary>
            [FieldOffset(32)] Vector Scale;

            ///<summary>Parent</summary>
            [FieldOffset(48)] Transform Parent;

        }
}
