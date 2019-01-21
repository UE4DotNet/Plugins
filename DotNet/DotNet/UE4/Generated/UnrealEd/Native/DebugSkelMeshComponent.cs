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
    [StructLayout( LayoutKind.Explicit, Size=3472 )]
    internal unsafe struct DebugSkelMeshComponent_fields {
        [FieldOffset(3168)] public bool bRenderRawSkeleton;
        [FieldOffset(3168)] public bool bDrawMesh;
        [FieldOffset(3168)] public bool bShowBoneNames;
        [FieldOffset(3168)] public bool bDrawBoneInfluences;
        [FieldOffset(3168)] public bool bDrawMorphTargetVerts;
        [FieldOffset(3168)] public bool bDrawNormals;
        [FieldOffset(3168)] public bool bDrawTangents;
        [FieldOffset(3168)] public bool bDrawBinormals;
        [FieldOffset(3169)] public bool bDrawSockets;
        [FieldOffset(3169)] public bool bSkeletonSocketsVisible;
        [FieldOffset(3169)] public bool bMeshSocketsVisible;
        [FieldOffset(3169)] public bool bDisplayRawAnimation;
        [FieldOffset(3169)] public bool bDisplayNonRetargetedPose;
        [FieldOffset(3169)] public bool bDisplayAdditiveBasePose;
        [FieldOffset(3169)] public bool bDisplayBakedAnimation;
        [FieldOffset(3169)] public bool bDisplaySourceAnimation;
        [FieldOffset(3172)] public bool bDisplayBound;
        [FieldOffset(3173)] public bool bDisplayVertexColors;
        [FieldOffset(3176)] public bool bPreviewRootMotion;
        [FieldOffset(3176)] public bool bShowClothData;
        [FieldOffset(3180)] public float MinClothPropertyView;
        [FieldOffset(3184)] public float MaxClothPropertyView;
        [FieldOffset(3188)] public float ClothMeshOpacity;
        [FieldOffset(3192)] public bool bClothFlipNormal;
        [FieldOffset(3193)] public bool bClothCullBackface;
        [FieldOffset(3304)] public NativeArray BonesOfInterest;
        [FieldOffset(3320)] public NativeArray MorphTargetOfInterests;
        [FieldOffset(3336)] public NativeArray SkelMaterials;
        [FieldOffset(3352)]  public IntPtr  PreviewInstance;
        [FieldOffset(3360)]  public IntPtr  SavedAnimScriptInstance;
        [FieldOffset(3368)] public bool bIsUsingInGameBounds;
        [FieldOffset(3369)] public bool bPerformSingleClothingTick;
        [FieldOffset(3370)] public bool bPauseClothingSimulationWithAnim;
    }
    internal unsafe struct DebugSkelMeshComponent_methods {
    }
    internal unsafe struct DebugSkelMeshComponent_events {
    }
}
