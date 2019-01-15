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
        ///<summary>Abc Geometry Cache Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=12 )]
        public unsafe struct AbcGeometryCacheSettings {
            [FieldOffset(0)] public bool bFlattenTracks;

            [FieldOffset(1)] public bool bApplyConstantTopologyOptimizations;

            [FieldOffset(2)] public bool bCalculateMotionVectorsDuringImport;

            [FieldOffset(3)] public bool bOptimizeIndexBuffers;

            [FieldOffset(4)] public float CompressedPositionPrecision;

            [FieldOffset(8)] public int CompressedTextureCoordinatesNumberOfBits;

        }
}
