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
    [StructLayout( LayoutKind.Explicit, Size=3568 )]
    internal unsafe struct DebugSkelMeshComponent_fields {
        [FieldOffset(3264)] public bool bRenderRawSkeleton;
        [FieldOffset(3264)] public bool bDrawMesh;
        [FieldOffset(3264)] public bool bShowBoneNames;
        [FieldOffset(3264)] public bool bDrawBoneInfluences;
        [FieldOffset(3264)] public bool bDrawMorphTargetVerts;
        [FieldOffset(3264)] public bool bDrawNormals;
        [FieldOffset(3264)] public bool bDrawTangents;
        [FieldOffset(3264)] public bool bDrawBinormals;
        [FieldOffset(3265)] public bool bDrawSockets;
        [FieldOffset(3265)] public bool bSkeletonSocketsVisible;
        [FieldOffset(3265)] public bool bMeshSocketsVisible;
        [FieldOffset(3265)] public bool bDisplayRawAnimation;
        [FieldOffset(3265)] public bool bDisplayNonRetargetedPose;
        [FieldOffset(3265)] public bool bDisplayAdditiveBasePose;
        [FieldOffset(3265)] public bool bDisplayBakedAnimation;
        [FieldOffset(3265)] public bool bDisplaySourceAnimation;
        [FieldOffset(3268)] public bool bDisplayBound;
        [FieldOffset(3269)] public bool bDisplayVertexColors;
        [FieldOffset(3272)] public bool bPreviewRootMotion;
        [FieldOffset(3272)] public bool bShowClothData;
        [FieldOffset(3276)] public float MinClothPropertyView;
        [FieldOffset(3280)] public float MaxClothPropertyView;
        [FieldOffset(3284)] public float ClothMeshOpacity;
        [FieldOffset(3288)] public bool bClothFlipNormal;
        [FieldOffset(3289)] public bool bClothCullBackface;
        [FieldOffset(3400)] public NativeArray BonesOfInterest;
        [FieldOffset(3416)] public NativeArray MorphTargetOfInterests;
        [FieldOffset(3432)] public NativeArray SkelMaterials;
        [FieldOffset(3448)]  public IntPtr  PreviewInstance;
        [FieldOffset(3456)]  public IntPtr  SavedAnimScriptInstance;
        [FieldOffset(3464)] public bool bIsUsingInGameBounds;
        [FieldOffset(3465)] public bool bPerformSingleClothingTick;
        [FieldOffset(3466)] public bool bPauseClothingSimulationWithAnim;
    }
    internal unsafe struct DebugSkelMeshComponent_methods {
    }
    internal unsafe struct DebugSkelMeshComponent_events {
    }
}
