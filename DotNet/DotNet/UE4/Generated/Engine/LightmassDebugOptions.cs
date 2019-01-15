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
        ///<summary>Debug options for Lightmass</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct LightmassDebugOptions {
            [FieldOffset(0)] public bool bDebugMode;

            [FieldOffset(0)] public bool bStatsEnabled;

            [FieldOffset(0)] public bool bGatherBSPSurfacesAcrossComponents;

            [FieldOffset(4)] public float CoplanarTolerance;

            [FieldOffset(8)] public bool bUseImmediateImport;

            [FieldOffset(8)] public bool bImmediateProcessMappings;

            [FieldOffset(8)] public bool bSortMappings;

            [FieldOffset(8)] public bool bDumpBinaryFiles;

            [FieldOffset(8)] public bool bDebugMaterials;

            [FieldOffset(8)] public bool bPadMappings;

            [FieldOffset(8)] public bool bDebugPaddings;

            [FieldOffset(8)] public bool bOnlyCalcDebugTexelMappings;

            [FieldOffset(9)] public bool bUseRandomColors;

            [FieldOffset(9)] public bool bColorBordersGreen;

            [FieldOffset(9)] public bool bColorByExecutionTime;

            [FieldOffset(12)] public float ExecutionTimeDivisor;

        }
}
