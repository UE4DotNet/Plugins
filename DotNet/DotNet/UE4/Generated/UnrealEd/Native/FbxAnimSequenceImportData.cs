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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=224 )]
    internal unsafe struct FbxAnimSequenceImportData_fields {
        [FieldOffset(144)] public bool bImportMeshesInBoneHierarchy;
        [FieldOffset(145)] public byte AnimationLength;
        [FieldOffset(156)] public Int32Interval FrameImportRange;
        [FieldOffset(164)] public bool bUseDefaultSampleRate;
        [FieldOffset(168)] public int CustomSampleRate;
        [FieldOffset(176)] byte SourceAnimationName; //TODO: string FString SourceAnimationName
        [FieldOffset(192)] public bool bImportCustomAttribute;
        [FieldOffset(193)] public bool bImportBoneTracks;
        [FieldOffset(194)] public bool bSetMaterialDriveParameterOnCustomAttribute;
        [FieldOffset(200)] public NativeArray MaterialCurveSuffixes;
        [FieldOffset(216)] public bool bRemoveRedundantKeys;
        [FieldOffset(217)] public bool bDeleteExistingMorphTargetCurves;
        [FieldOffset(218)] public bool bDoNotImportCurveWithZero;
        [FieldOffset(219)] public bool bPreserveLocalTransform;
    }
    internal unsafe struct FbxAnimSequenceImportData_methods {
    }
    internal unsafe struct FbxAnimSequenceImportData_events {
    }
}
