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
        ///<summary>Transform Curve</summary>
        [StructLayout( LayoutKind.Explicit, Size=1136 )]
        public unsafe struct TransformCurve {
            ///<summary>Curve data for each transform.</summary>
            [FieldOffset(32)] VectorCurve TranslationCurve;

            ///<summary>
            ///Rotation curve - right now we use euler because quat also doesn't provide linear interpolation - curve editor can't handle quat interpolation
            ///If you hit gimbal lock, you should add extra key to fix it.
            ///</summary>
            ///<remarks>
            ///This will cause gimbal lock.
            ///@TODO: Eventually we'll need FRotationCurve that would contain rotation curve - that will interpolate as slerp or as quaternion
            ///</remarks>
            [FieldOffset(400)] VectorCurve RotationCurve;

            ///<summary>Scale Curve</summary>
            [FieldOffset(768)] VectorCurve ScaleCurve;

        }
}
