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
        ///<summary>Sphere shape used for collision</summary>
        [StructLayout( LayoutKind.Explicit, Size=48 )]
        public unsafe struct KShapeElem {
            [FieldOffset(8)] public float RestOffset;

            [FieldOffset(12)] public Name Name;

            [FieldOffset(28)] public bool bContributeToMass;

        }
}
