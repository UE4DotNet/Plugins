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


namespace UE4.ApexDestruction{
        ///<summary>Parameters to describe the application of U,V coordinates on a particular slice within a destructible.</summary>
        [StructLayout( LayoutKind.Explicit, Size=36 )]
        public unsafe struct FractureMaterial {
            ///<summary>The UV scale (geometric distance/unit texture distance) for interior materials.</summary>
            ///<remarks>Default = (100.0f,100.0f).</remarks>
            [FieldOffset(0)] Vector2D UVScale;

            ///<summary>A UV origin offset for interior materials.</summary>
            ///<remarks>Default = (0.0f,0.0f).</remarks>
            [FieldOffset(8)] Vector2D UVOffset;

            ///<summary>Object-space vector specifying surface tangent direction.</summary>
            ///<remarks>
            ///If this vector is (0.0f,0.0f,0.0f), then an arbitrary direction will be chosen.
            ///Default = (0.0f,0.0f,0.0f).
            ///</remarks>
            [FieldOffset(16)] Vector Tangent;

            [FieldOffset(28)] public float UAngle;

            [FieldOffset(32)] public int InteriorElementIndex;

        }
}
