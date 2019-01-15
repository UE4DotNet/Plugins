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


namespace UE4.MaterialBaking{
        ///<summary>Structure to represent a single property the user wants to bake out for a given set of materials</summary>
        [StructLayout( LayoutKind.Explicit, Size=20 )]
        public unsafe struct PropertyEntry {
            [FieldOffset(0)] public byte Property;

            [FieldOffset(1)] public bool bUseCustomSize;

            ///<summary>Defines the size of the output textures for the baked out material properties</summary>
            [FieldOffset(4)] IntPoint CustomSize;

            [FieldOffset(12)] public bool bUseConstantValue;

            [FieldOffset(16)] public float ConstantValue;

        }
}
