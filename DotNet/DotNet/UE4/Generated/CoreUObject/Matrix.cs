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
        ///<summary>* A 4x4 matrix.</summary>
        ///<remarks>* The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Matrix.h</remarks>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct Matrix {
            ///<summary>XPlane</summary>
            [FieldOffset(0)] Plane XPlane;

            ///<summary>YPlane</summary>
            [FieldOffset(16)] Plane YPlane;

            ///<summary>ZPlane</summary>
            [FieldOffset(32)] Plane ZPlane;

            ///<summary>WPlane</summary>
            [FieldOffset(48)] Plane WPlane;

        }
}
