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
        ///<summary>Common data for all widgets that use shaped text.</summary>
        ///<remarks>Contains the common options that should be exposed for the underlying Slate widget.</remarks>
        [StructLayout( LayoutKind.Explicit, Size=3 )]
        public unsafe struct ShapedTextOptions {
            [FieldOffset(0)] public bool bOverride_TextShapingMethod;

            [FieldOffset(0)] public bool bOverride_TextFlowDirection;

            [FieldOffset(1)] byte TextShapingMethod; //TODO: enum ETextShapingMethod TextShapingMethod

            [FieldOffset(2)] byte TextFlowDirection; //TODO: enum ETextFlowDirection TextFlowDirection

        }
}
