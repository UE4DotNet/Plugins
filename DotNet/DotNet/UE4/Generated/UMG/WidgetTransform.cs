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


namespace UE4.UMG{
        ///<summary>Describes the standard transformation of a widget</summary>
        [StructLayout( LayoutKind.Explicit, Size=28 )]
        public unsafe struct WidgetTransform {
            ///<summary>The amount to translate the widget in slate units</summary>
            [FieldOffset(0)] Vector2D Translation;

            ///<summary>The scale to apply to the widget</summary>
            [FieldOffset(8)] Vector2D Scale;

            ///<summary>The amount to shear the widget in slate units</summary>
            [FieldOffset(16)] Vector2D Shear;

            [FieldOffset(24)] public float Angle;

        }
}
