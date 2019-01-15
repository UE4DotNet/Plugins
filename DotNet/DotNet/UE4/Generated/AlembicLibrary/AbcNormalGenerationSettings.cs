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


namespace UE4.AlembicLibrary{
        ///<summary>Abc Normal Generation Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct AbcNormalGenerationSettings {
            [FieldOffset(0)] public bool bForceOneSmoothingGroupPerObject;

            [FieldOffset(4)] public float HardEdgeAngleThreshold;

            [FieldOffset(8)] public bool bRecomputeNormals;

            [FieldOffset(9)] public bool bIgnoreDegenerateTriangles;

        }
}
