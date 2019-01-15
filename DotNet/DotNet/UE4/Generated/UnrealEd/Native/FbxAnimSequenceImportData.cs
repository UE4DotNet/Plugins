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
    [StructLayout( LayoutKind.Explicit, Size=216 )]
    internal unsafe struct FbxAnimSequenceImportData_fields {
        [FieldOffset(144)] public bool bImportMeshesInBoneHierarchy;
        [FieldOffset(145)] public byte AnimationLength;
        [FieldOffset(156)] public Int32Interval FrameImportRange;
        [FieldOffset(164)] public bool bUseDefaultSampleRate;
        [FieldOffset(168)] byte SourceAnimationName; //TODO: string FString SourceAnimationName
        [FieldOffset(184)] public bool bImportCustomAttribute;
        [FieldOffset(185)] public bool bImportBoneTracks;
        [FieldOffset(186)] public bool bSetMaterialDriveParameterOnCustomAttribute;
        [FieldOffset(192)] public NativeArray MaterialCurveSuffixes;
        [FieldOffset(208)] public bool bRemoveRedundantKeys;
        [FieldOffset(209)] public bool bDeleteExistingMorphTargetCurves;
        [FieldOffset(210)] public bool bDoNotImportCurveWithZero;
        [FieldOffset(211)] public bool bPreserveLocalTransform;
    }
    internal unsafe struct FbxAnimSequenceImportData_methods {
    }
    internal unsafe struct FbxAnimSequenceImportData_events {
    }
}
