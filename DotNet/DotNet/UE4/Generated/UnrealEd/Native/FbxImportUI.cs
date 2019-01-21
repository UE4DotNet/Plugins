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
    [StructLayout( LayoutKind.Explicit, Size=520 )]
    internal unsafe struct FbxImportUI_fields {
        [FieldOffset(64)] public bool bIsObjImport;
        [FieldOffset(65)] public byte OriginalImportType;
        [FieldOffset(66)] public byte MeshTypeToImport;
        [FieldOffset(68)] public bool bOverrideFullName;
        [FieldOffset(72)] public bool bImportAsSkeletal;
        [FieldOffset(73)] public bool bImportMesh;
        [FieldOffset(80)]  public IntPtr  Skeleton;
        [FieldOffset(88)] public bool bCreatePhysicsAsset;
        [FieldOffset(96)]  public IntPtr  PhysicsAsset;
        [FieldOffset(104)] public bool bAutoComputeLodDistances;
        [FieldOffset(108)] public float LodDistance0;
        [FieldOffset(112)] public float LodDistance1;
        [FieldOffset(116)] public float LodDistance2;
        [FieldOffset(120)] public float LodDistance3;
        [FieldOffset(124)] public float LodDistance4;
        [FieldOffset(128)] public float LodDistance5;
        [FieldOffset(132)] public float LodDistance6;
        [FieldOffset(136)] public float LodDistance7;
        [FieldOffset(140)] public int MinimumLodNumber;
        [FieldOffset(144)] public int LodNumber;
        [FieldOffset(148)] public bool bImportAnimations;
        [FieldOffset(152)] byte OverrideAnimationName; //TODO: string FString OverrideAnimationName
        [FieldOffset(168)] public bool bImportRigidMesh;
        [FieldOffset(168)] public bool bImportMaterials;
        [FieldOffset(168)] public bool bImportTextures;
        [FieldOffset(176)]  public IntPtr  StaticMeshImportData;
        [FieldOffset(184)]  public IntPtr  SkeletalMeshImportData;
        [FieldOffset(192)]  public IntPtr  AnimSequenceImportData;
        [FieldOffset(200)]  public IntPtr  TextureImportData;
        [FieldOffset(208)] public bool bAutomatedImportShouldDetectType;
        [FieldOffset(392)] byte FileVersion; //TODO: string FString FileVersion
        [FieldOffset(408)] byte FileCreator; //TODO: string FString FileCreator
        [FieldOffset(424)] byte FileCreatorApplication; //TODO: string FString FileCreatorApplication
        [FieldOffset(440)] byte FileUnits; //TODO: string FString FileUnits
        [FieldOffset(456)] byte FileAxisDirection; //TODO: string FString FileAxisDirection
        [FieldOffset(472)] byte FileSampleRate; //TODO: string FString FileSampleRate
        [FieldOffset(488)] byte AnimStartFrame; //TODO: string FString AnimStartFrame
        [FieldOffset(504)] byte AnimEndFrame; //TODO: string FString AnimEndFrame
    }
    internal unsafe struct FbxImportUI_methods {
        internal struct ResetToDefault_method {
            static internal IntPtr ResetToDefault_ptr;
            static ResetToDefault_method() {
                ResetToDefault_ptr = Main.GetMethodUFunction(FbxImportUI.StaticClass, "ResetToDefault");
            }

            internal static unsafe void Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, ResetToDefault_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct FbxImportUI_events {
    }
}
