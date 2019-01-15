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


namespace UE4.CoreUObject{
        ///<summary>Structure for arbitrarily oriented boxes (i.</summary>
        ///<remarks>
        ///e. not necessarily axis-aligned).
        ///The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\OrientedBox.h
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=60 )]
        public unsafe struct OrientedBox {
            ///<summary>Center</summary>
            [FieldOffset(0)] Vector Center;

            ///<summary>Axis X</summary>
            [FieldOffset(12)] Vector AxisX;

            ///<summary>Axis Y</summary>
            [FieldOffset(24)] Vector AxisY;

            ///<summary>Axis Z</summary>
            [FieldOffset(36)] Vector AxisZ;

            [FieldOffset(48)] public float ExtentX;

            [FieldOffset(52)] public float ExtentY;

            [FieldOffset(56)] public float ExtentZ;

        }
}
