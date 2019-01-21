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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=1904 )]
    internal unsafe struct SkinnedMeshComponent_fields {
        [FieldOffset(1544)]  public IntPtr  SkeletalMesh;
        [FieldOffset(1552)] byte MasterPoseComponent; //TODO: weak object TWeakObjectPtr<USkinnedMeshComponent> MasterPoseComponent
        [FieldOffset(1752)]  public IntPtr  PhysicsAssetOverride;
        [FieldOffset(1760)] public int ForcedLodModel;
        [FieldOffset(1764)] public int MinLodModel;
        [FieldOffset(1780)] public float StreamingDistanceMultiplier;
        [FieldOffset(1784)] public NativeArray LODInfo;
        [FieldOffset(1816)] byte VisibilityBasedAnimTickOption; //TODO: enum EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption
        [FieldOffset(1832)] public bool bOverrideMinLod;
        [FieldOffset(1832)] public bool bUseBoundsFromMasterPoseComponent;
        [FieldOffset(1832)] public bool bForceWireframe;
        [FieldOffset(1832)] public bool bDisableMorphTarget;
        [FieldOffset(1832)] public bool bHideSkin;
        [FieldOffset(1832)] public bool bPerBoneMotionBlur;
        [FieldOffset(1833)] public bool bComponentUseFixedSkelBounds;
        [FieldOffset(1833)] public bool bConsiderAllBodiesForBounds;
        [FieldOffset(1833)] public bool bSyncAttachParentLOD;
        [FieldOffset(1833)] public bool bCanHighlightSelectedSections;
        [FieldOffset(1833)] public bool bRecentlyRendered;
        [FieldOffset(1833)] public bool bCastCapsuleDirectShadow;
        [FieldOffset(1833)] public bool bCastCapsuleIndirectShadow;
        [FieldOffset(1833)] public bool bCPUSkinning;
        [FieldOffset(1834)] public bool bEnableUpdateRateOptimizations;
        [FieldOffset(1834)] public bool bDisplayDebugUpdateRateOptimizations;
        [FieldOffset(1834)] public bool bRenderStatic;
        [FieldOffset(1834)] public bool bCachedLocalBoundsUpToDate;
        [FieldOffset(1834)] public bool bForceMeshObjectUpdate;
        [FieldOffset(1836)] public float CapsuleIndirectShadowMinVisibility;
        [FieldOffset(1848)] public BoxSphereBounds CachedLocalBounds;
    }
    internal unsafe struct SkinnedMeshComponent_methods {
        internal struct BoneIsChildOf_method {
            static internal IntPtr BoneIsChildOf_ptr;
            static BoneIsChildOf_method() {
                BoneIsChildOf_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "BoneIsChildOf");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name BoneName, Name ParentBoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Name*)(b+12)) = ParentBoneName;
                Main.GetProcessEvent(obj, BoneIsChildOf_ptr, new IntPtr(p)); ;
                return *((bool*)(b+24));
            }
        }
        internal struct ClearSkinWeightOverride_method {
            static internal IntPtr ClearSkinWeightOverride_ptr;
            static ClearSkinWeightOverride_method() {
                ClearSkinWeightOverride_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "ClearSkinWeightOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, int LODIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = LODIndex;
                Main.GetProcessEvent(obj, ClearSkinWeightOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ClearVertexColorOverride_method {
            static internal IntPtr ClearVertexColorOverride_ptr;
            static ClearVertexColorOverride_method() {
                ClearVertexColorOverride_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "ClearVertexColorOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, int LODIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = LODIndex;
                Main.GetProcessEvent(obj, ClearVertexColorOverride_ptr, new IntPtr(p)); ;
            }
        }
        internal struct FindClosestBone_K2_method {
            static internal IntPtr FindClosestBone_K2_ptr;
            static FindClosestBone_K2_method() {
                FindClosestBone_K2_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "FindClosestBone_K2");
            }

            internal static unsafe (Vector, Name) Invoke(IntPtr obj, Vector TestLocation, float IgnoreScale, bool bRequirePhysicsAsset) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Vector*)(b+0)) = TestLocation;
                *((float*)(b+24)) = IgnoreScale;
                *((bool*)(b+28)) = bRequirePhysicsAsset;
                Main.GetProcessEvent(obj, FindClosestBone_K2_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+12)),*((Name*)(b+32)));
            }
        }
        internal struct GetBoneIndex_method {
            static internal IntPtr GetBoneIndex_ptr;
            static GetBoneIndex_method() {
                GetBoneIndex_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetBoneIndex");
            }

            internal static unsafe int Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetBoneIndex_ptr, new IntPtr(p)); ;
                return *((int*)(b+12));
            }
        }
        internal struct GetBoneName_method {
            static internal IntPtr GetBoneName_ptr;
            static GetBoneName_method() {
                GetBoneName_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetBoneName");
            }

            internal static unsafe Name Invoke(IntPtr obj, int BoneIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = BoneIndex;
                Main.GetProcessEvent(obj, GetBoneName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+4));
            }
        }
        internal struct GetDeltaTransformFromRefPose_method {
            static internal IntPtr GetDeltaTransformFromRefPose_ptr;
            static GetDeltaTransformFromRefPose_method() {
                GetDeltaTransformFromRefPose_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetDeltaTransformFromRefPose");
            }

            internal static unsafe Transform Invoke(IntPtr obj, Name BoneName, Name BaseName) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Name*)(b+12)) = BaseName;
                Main.GetProcessEvent(obj, GetDeltaTransformFromRefPose_ptr, new IntPtr(p)); ;
                return *((Transform*)(b+32));
            }
        }
        internal struct GetNumBones_method {
            static internal IntPtr GetNumBones_ptr;
            static GetNumBones_method() {
                GetNumBones_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetNumBones");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumBones_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetNumLODs_method {
            static internal IntPtr GetNumLODs_ptr;
            static GetNumLODs_method() {
                GetNumLODs_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetNumLODs");
            }

            internal static unsafe int Invoke(IntPtr obj) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                Main.GetProcessEvent(obj, GetNumLODs_ptr, new IntPtr(p)); ;
                return *((int*)(b+0));
            }
        }
        internal struct GetParentBone_method {
            static internal IntPtr GetParentBone_ptr;
            static GetParentBone_method() {
                GetParentBone_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetParentBone");
            }

            internal static unsafe Name Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, GetParentBone_ptr, new IntPtr(p)); ;
                return *((Name*)(b+12));
            }
        }
        internal struct GetRefPosePosition_method {
            static internal IntPtr GetRefPosePosition_ptr;
            static GetRefPosePosition_method() {
                GetRefPosePosition_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetRefPosePosition");
            }

            internal static unsafe Vector Invoke(IntPtr obj, int BoneIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = BoneIndex;
                Main.GetProcessEvent(obj, GetRefPosePosition_ptr, new IntPtr(p)); ;
                return *((Vector*)(b+4));
            }
        }
        internal struct GetSocketBoneName_method {
            static internal IntPtr GetSocketBoneName_ptr;
            static GetSocketBoneName_method() {
                GetSocketBoneName_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "GetSocketBoneName");
            }

            internal static unsafe Name Invoke(IntPtr obj, Name InSocketName) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = InSocketName;
                Main.GetProcessEvent(obj, GetSocketBoneName_ptr, new IntPtr(p)); ;
                return *((Name*)(b+12));
            }
        }
        internal struct HideBoneByName_method {
            static internal IntPtr HideBoneByName_ptr;
            static HideBoneByName_method() {
                HideBoneByName_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "HideBoneByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName, byte PhysBodyOption) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *(b+12) = PhysBodyOption;
                Main.GetProcessEvent(obj, HideBoneByName_ptr, new IntPtr(p)); ;
            }
        }
        internal struct IsBoneHiddenByName_method {
            static internal IntPtr IsBoneHiddenByName_ptr;
            static IsBoneHiddenByName_method() {
                IsBoneHiddenByName_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "IsBoneHiddenByName");
            }

            internal static unsafe bool Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, IsBoneHiddenByName_ptr, new IntPtr(p)); ;
                return *((bool*)(b+12));
            }
        }
        internal struct IsMaterialSectionShown_method {
            static internal IntPtr IsMaterialSectionShown_ptr;
            static IsMaterialSectionShown_method() {
                IsMaterialSectionShown_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "IsMaterialSectionShown");
            }

            internal static unsafe bool Invoke(IntPtr obj, int MaterialID, int LODIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MaterialID;
                *((int*)(b+4)) = LODIndex;
                Main.GetProcessEvent(obj, IsMaterialSectionShown_ptr, new IntPtr(p)); ;
                return *((bool*)(b+8));
            }
        }
        internal struct SetCapsuleIndirectShadowMinVisibility_method {
            static internal IntPtr SetCapsuleIndirectShadowMinVisibility_ptr;
            static SetCapsuleIndirectShadowMinVisibility_method() {
                SetCapsuleIndirectShadowMinVisibility_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetCapsuleIndirectShadowMinVisibility");
            }

            internal static unsafe void Invoke(IntPtr obj, float NewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((float*)(b+0)) = NewValue;
                Main.GetProcessEvent(obj, SetCapsuleIndirectShadowMinVisibility_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCastCapsuleDirectShadow_method {
            static internal IntPtr SetCastCapsuleDirectShadow_ptr;
            static SetCastCapsuleDirectShadow_method() {
                SetCastCapsuleDirectShadow_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetCastCapsuleDirectShadow");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetCastCapsuleDirectShadow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetCastCapsuleIndirectShadow_method {
            static internal IntPtr SetCastCapsuleIndirectShadow_ptr;
            static SetCastCapsuleIndirectShadow_method() {
                SetCastCapsuleIndirectShadow_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetCastCapsuleIndirectShadow");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetCastCapsuleIndirectShadow_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetForcedLOD_method {
            static internal IntPtr SetForcedLOD_ptr;
            static SetForcedLOD_method() {
                SetForcedLOD_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetForcedLOD");
            }

            internal static unsafe void Invoke(IntPtr obj, int InNewForcedLOD) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InNewForcedLOD;
                Main.GetProcessEvent(obj, SetForcedLOD_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMasterPoseComponent_method {
            static internal IntPtr SetMasterPoseComponent_ptr;
            static SetMasterPoseComponent_method() {
                SetMasterPoseComponent_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetMasterPoseComponent");
            }

            internal static unsafe void Invoke(IntPtr obj, SkinnedMeshComponent NewMasterBoneComponent, bool bForceUpdate) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewMasterBoneComponent;
                *((bool*)(b+8)) = bForceUpdate;
                Main.GetProcessEvent(obj, SetMasterPoseComponent_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetMinLOD_method {
            static internal IntPtr SetMinLOD_ptr;
            static SetMinLOD_method() {
                SetMinLOD_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetMinLOD");
            }

            internal static unsafe void Invoke(IntPtr obj, int InNewMinLOD) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = InNewMinLOD;
                Main.GetProcessEvent(obj, SetMinLOD_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetPhysicsAsset_method {
            static internal IntPtr SetPhysicsAsset_ptr;
            static SetPhysicsAsset_method() {
                SetPhysicsAsset_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetPhysicsAsset");
            }

            internal static unsafe void Invoke(IntPtr obj, PhysicsAsset NewPhysicsAsset, bool bForceReInit) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewPhysicsAsset;
                *((bool*)(b+8)) = bForceReInit;
                Main.GetProcessEvent(obj, SetPhysicsAsset_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetRenderStatic_method {
            static internal IntPtr SetRenderStatic_ptr;
            static SetRenderStatic_method() {
                SetRenderStatic_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetRenderStatic");
            }

            internal static unsafe void Invoke(IntPtr obj, bool bNewValue) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((bool*)(b+0)) = bNewValue;
                Main.GetProcessEvent(obj, SetRenderStatic_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSkeletalMesh_method {
            static internal IntPtr SetSkeletalMesh_ptr;
            static SetSkeletalMesh_method() {
                SetSkeletalMesh_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetSkeletalMesh");
            }

            internal static unsafe void Invoke(IntPtr obj, SkeletalMesh NewMesh, bool bReinitPose) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((IntPtr*)(b+0)) = NewMesh;
                *((bool*)(b+8)) = bReinitPose;
                Main.GetProcessEvent(obj, SetSkeletalMesh_ptr, new IntPtr(p)); ;
            }
        }
        internal struct SetSkinWeightOverride_method {
            static internal IntPtr SetSkinWeightOverride_ptr;
            static SetSkinWeightOverride_method() {
                SetSkinWeightOverride_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetSkinWeightOverride");
            }

            internal static unsafe void Invoke(IntPtr obj, int LODIndex, byte SkinWeights /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = LODIndex;
                throw new NotImplementedException(); //TODO: array TArray SkinWeights
                Main.GetProcessEvent(obj, SetSkinWeightOverride_ptr, new IntPtr(p)); ;
                 //TODO: array TArray SkinWeights
            }
        }
        internal struct SetVertexColorOverride_LinearColor_method {
            static internal IntPtr SetVertexColorOverride_LinearColor_ptr;
            static SetVertexColorOverride_LinearColor_method() {
                SetVertexColorOverride_LinearColor_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "SetVertexColorOverride_LinearColor");
            }

            internal static unsafe void Invoke(IntPtr obj, int LODIndex, byte VertexColors /*TODO: array TArray */) {
                long* p = stackalloc long[] {0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = LODIndex;
                throw new NotImplementedException(); //TODO: array TArray VertexColors
                Main.GetProcessEvent(obj, SetVertexColorOverride_LinearColor_ptr, new IntPtr(p)); ;
                 //TODO: array TArray VertexColors
            }
        }
        internal struct ShowAllMaterialSections_method {
            static internal IntPtr ShowAllMaterialSections_ptr;
            static ShowAllMaterialSections_method() {
                ShowAllMaterialSections_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "ShowAllMaterialSections");
            }

            internal static unsafe void Invoke(IntPtr obj, int LODIndex) {
                long* p = stackalloc long[] {0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = LODIndex;
                Main.GetProcessEvent(obj, ShowAllMaterialSections_ptr, new IntPtr(p)); ;
            }
        }
        internal struct ShowMaterialSection_method {
            static internal IntPtr ShowMaterialSection_ptr;
            static ShowMaterialSection_method() {
                ShowMaterialSection_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "ShowMaterialSection");
            }

            internal static unsafe void Invoke(IntPtr obj, int MaterialID, bool bShow, int LODIndex) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((int*)(b+0)) = MaterialID;
                *((bool*)(b+4)) = bShow;
                *((int*)(b+8)) = LODIndex;
                Main.GetProcessEvent(obj, ShowMaterialSection_ptr, new IntPtr(p)); ;
            }
        }
        internal struct TransformFromBoneSpace_method {
            static internal IntPtr TransformFromBoneSpace_ptr;
            static TransformFromBoneSpace_method() {
                TransformFromBoneSpace_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "TransformFromBoneSpace");
            }

            internal static unsafe (Vector, Rotator) Invoke(IntPtr obj, Name BoneName, Vector InPosition, Rotator InRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Vector*)(b+12)) = InPosition;
                *((Rotator*)(b+24)) = InRotation;
                Main.GetProcessEvent(obj, TransformFromBoneSpace_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+36)),*((Rotator*)(b+48)));
            }
        }
        internal struct TransformToBoneSpace_method {
            static internal IntPtr TransformToBoneSpace_ptr;
            static TransformToBoneSpace_method() {
                TransformToBoneSpace_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "TransformToBoneSpace");
            }

            internal static unsafe (Vector, Rotator) Invoke(IntPtr obj, Name BoneName, Vector InPosition, Rotator InRotation) {
                long* p = stackalloc long[] {0L,0L,0L,0L,0L,0L,0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                *((Vector*)(b+12)) = InPosition;
                *((Rotator*)(b+24)) = InRotation;
                Main.GetProcessEvent(obj, TransformToBoneSpace_ptr, new IntPtr(p)); ;
                return (*((Vector*)(b+36)),*((Rotator*)(b+48)));
            }
        }
        internal struct UnHideBoneByName_method {
            static internal IntPtr UnHideBoneByName_ptr;
            static UnHideBoneByName_method() {
                UnHideBoneByName_ptr = Main.GetMethodUFunction(SkinnedMeshComponent.StaticClass, "UnHideBoneByName");
            }

            internal static unsafe void Invoke(IntPtr obj, Name BoneName) {
                long* p = stackalloc long[] {0L,0L,0L};
                byte* b = (byte*) p;
                *((Name*)(b+0)) = BoneName;
                Main.GetProcessEvent(obj, UnHideBoneByName_ptr, new IntPtr(p)); ;
            }
        }
    }
    internal unsafe struct SkinnedMeshComponent_events {
    }
}
