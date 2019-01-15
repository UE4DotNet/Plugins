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
        ///<summary>Abc Compression Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct AbcCompressionSettings {
            [FieldOffset(0)] public bool bMergeMeshes;

            [FieldOffset(1)] public bool bBakeMatrixAnimation;

            [FieldOffset(2)] byte BaseCalculationType; //TODO: enum EBaseCalculationType BaseCalculationType

            [FieldOffset(4)] public float PercentageOfTotalBases;

            [FieldOffset(8)] public int MaxNumberOfBases;

            [FieldOffset(12)] public float MinimumNumberOfVertexInfluencePercentage;

        }
}
