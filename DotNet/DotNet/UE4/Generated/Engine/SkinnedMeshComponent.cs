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

#pragma warning disable CS0108
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Skinned mesh component that supports bone skinned mesh rendering.</summary>
    ///<remarks>
    ///This class does not support animation.
    ///
    ///@see USkeletalMeshComponent
    ///</remarks>
    public unsafe partial class SkinnedMeshComponent : MeshComponent  {

        ///<summary>Tests if BoneName is child of (or equal to) ParentBoneName.</summary>
        ///<remarks>
        ///@param BoneName Name of the bone
        ///@param ParentBone Name to check
        ///
        ///@return true if child (strictly, not same). false otherwise
        ///Note - will return false if ChildBoneIndex is the same as ParentBoneIndex ie. must be strictly a child.
        ///</remarks>
        public bool BoneIsChildOf(Name BoneName, Name ParentBoneName)  => 
            SkinnedMeshComponent_methods.BoneIsChildOf_method.Invoke(ObjPointer, BoneName, ParentBoneName);

        ///<summary>Clear any applied skin weight override</summary>
        public void ClearSkinWeightOverride(int LODIndex)  => 
            SkinnedMeshComponent_methods.ClearSkinWeightOverride_method.Invoke(ObjPointer, LODIndex);

        ///<summary>Clear any applied vertex color override</summary>
        public void ClearVertexColorOverride(int LODIndex)  => 
            SkinnedMeshComponent_methods.ClearVertexColorOverride_method.Invoke(ObjPointer, LODIndex);

        ///<summary>
        ///finds the closest bone to the given location
        ///@
        ///</summary>
        ///<remarks>
        ///param TestLocation the location to test against
        ///@param BoneLocation (optional, out) if specified, set to the world space location of the bone that was found, or (0,0,0) if no bone was found
        ///@param IgnoreScale (optional) if specified, only bones with scaling larger than the specified factor are considered
        ///@param bRequirePhysicsAsset (optional) if true, only bones with physics will be considered
        ///
        ///@return the name of the bone that was found, or 'None' if no bone was found
        ///</remarks>
        public (Vector, Name) FindClosestBone_K2(Vector TestLocation, float IgnoreScale, bool bRequirePhysicsAsset)  => 
            SkinnedMeshComponent_methods.FindClosestBone_K2_method.Invoke(ObjPointer, TestLocation, IgnoreScale, bRequirePhysicsAsset);

        ///<summary>Find the index of bone by name.</summary>
        ///<remarks>
        ///Looks in the current SkeletalMesh being used by this SkeletalMeshComponent.
        ///
        ///@param BoneName Name of bone to look up
        ///
        ///@return Index of the named bone in the current SkeletalMesh. Will return INDEX_NONE if bone not found.
        ///
        ///@see USkeletalMesh::GetBoneIndex.
        ///</remarks>
        public int GetBoneIndex(Name BoneName)  => 
            SkinnedMeshComponent_methods.GetBoneIndex_method.Invoke(ObjPointer, BoneName);

        ///<summary>
        ///Get Bone Name from index
        ///@
        ///</summary>
        ///<remarks>
        ///param BoneIndex Index of the bone
        ///
        ///@return the name of the bone at the specified index
        ///</remarks>
        public Name GetBoneName(int BoneIndex)  => 
            SkinnedMeshComponent_methods.GetBoneName_method.Invoke(ObjPointer, BoneIndex);

        ///<summary>Returns the number of bones in the skeleton.</summary>
        public int GetNumBones()  => 
            SkinnedMeshComponent_methods.GetNumBones_method.Invoke(ObjPointer);

        ///<summary>Get the number of LODs on this component</summary>
        public int GetNumLODs()  => 
            SkinnedMeshComponent_methods.GetNumLODs_method.Invoke(ObjPointer);

        ///<summary>
        ///Get Parent Bone of the input bone
        ///@
        ///</summary>
        ///<remarks>
        ///param BoneName Name of the bone
        ///
        ///@return the name of the parent bone for the specified bone. Returns 'None' if the bone does not exist or it is the root bone
        ///</remarks>
        public Name GetParentBone(Name BoneName)  => 
            SkinnedMeshComponent_methods.GetParentBone_method.Invoke(ObjPointer, BoneName);

        ///<summary>Gets the local-space position of a bone in the reference pose.</summary>
        ///<remarks>
        ///@param BoneIndex Index of the bone
        ///
        ///@return Local space reference position
        ///</remarks>
        public Vector GetRefPosePosition(int BoneIndex)  => 
            SkinnedMeshComponent_methods.GetRefPosePosition_method.Invoke(ObjPointer, BoneIndex);

        ///<summary>Returns bone name linked to a given named socket on the skeletal mesh component.</summary>
        ///<remarks>
        ///If you're unsure to deal with sockets or bones names, you can use this function to filter through, and always return the bone name.
        ///
        ///@param       bone name or socket name
        ///
        ///@return      bone name
        ///</remarks>
        public Name GetSocketBoneName(Name InSocketName)  => 
            SkinnedMeshComponent_methods.GetSocketBoneName_method.Invoke(ObjPointer, InSocketName);

        ///<summary>Hides the specified bone with name.</summary>
        ///<remarks>
        ///Currently this just enforces a scale of 0 for the hidden bones.
        ///Compoared to HideBone By Index - This keeps track of list of bones and update when LOD changes
        ///
        ///@param  BoneName            Name of bone to hide
        ///@param  PhysBodyOption          Option for physics bodies that attach to the bones to be hidden
        ///</remarks>
        public void HideBoneByName(Name BoneName, byte PhysBodyOption)  => 
            SkinnedMeshComponent_methods.HideBoneByName_method.Invoke(ObjPointer, BoneName, PhysBodyOption);

        ///<summary>Determines if the specified bone is hidden.</summary>
        ///<remarks>
        ///@param  BoneName            Name of bone to check
        ///
        ///@return true if hidden
        ///</remarks>
        public bool IsBoneHiddenByName(Name BoneName)  => 
            SkinnedMeshComponent_methods.IsBoneHiddenByName_method.Invoke(ObjPointer, BoneName);

        ///<summary>Returns whether a specific material section is currently hidden on this component (by using ShowMaterialSection)</summary>
        public bool IsMaterialSectionShown(int MaterialID, int LODIndex)  => 
            SkinnedMeshComponent_methods.IsMaterialSectionShown_method.Invoke(ObjPointer, MaterialID, LODIndex);

        ///<summary>Set Capsule Indirect Shadow Min Visibility</summary>
        public void SetCapsuleIndirectShadowMinVisibility(float NewValue)  => 
            SkinnedMeshComponent_methods.SetCapsuleIndirectShadowMinVisibility_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Cast Capsule Direct Shadow</summary>
        public void SetCastCapsuleDirectShadow(bool bNewValue)  => 
            SkinnedMeshComponent_methods.SetCastCapsuleDirectShadow_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Set Cast Capsule Indirect Shadow</summary>
        public void SetCastCapsuleIndirectShadow(bool bNewValue)  => 
            SkinnedMeshComponent_methods.SetCastCapsuleIndirectShadow_method.Invoke(ObjPointer, bNewValue);

        ///<summary>
        ///Set MinLodModel of the mesh component
        ///@
        ///</summary>
        ///<remarks>param       InNewForcedLOD  Set new ForcedLODModel that forces to set the incoming LOD. Range from [1, Max Number of LOD]. This will affect in the next tick update.</remarks>
        public void SetForcedLOD(int InNewForcedLOD)  => 
            SkinnedMeshComponent_methods.SetForcedLOD_method.Invoke(ObjPointer, InNewForcedLOD);

        ///<summary>
        ///Set MasterPoseComponent for this component
        ///@
        ///</summary>
        ///<remarks>param NewMasterBoneComponent New MasterPoseComponent</remarks>
        public void SetMasterPoseComponent(SkinnedMeshComponent NewMasterBoneComponent, bool bForceUpdate)  => 
            SkinnedMeshComponent_methods.SetMasterPoseComponent_method.Invoke(ObjPointer, NewMasterBoneComponent, bForceUpdate);

        ///<summary>
        ///Set MinLodModel of the mesh component
        ///@
        ///</summary>
        ///<remarks>param       InNewMinLOD     Set new MinLodModel that make sure the LOD does not go below of this value. Range from [0, Max Number of LOD - 1]. This will affect in the next tick update.</remarks>
        public void SetMinLOD(int InNewMinLOD)  => 
            SkinnedMeshComponent_methods.SetMinLOD_method.Invoke(ObjPointer, InNewMinLOD);

        ///<summary>Override the Physics Asset of the mesh.</summary>
        ///<remarks>
        ///It uses SkeletalMesh.PhysicsAsset, but if you'd like to override use this function
        ///
        ///@param       NewPhysicsAsset New PhysicsAsset
        ///@param       bForceReInit    Force reinitialize
        ///</remarks>
        public void SetPhysicsAsset(PhysicsAsset NewPhysicsAsset, bool bForceReInit)  => 
            SkinnedMeshComponent_methods.SetPhysicsAsset_method.Invoke(ObjPointer, NewPhysicsAsset, bForceReInit);

        ///<summary>
        ///Set whether this skinned mesh should be rendered as static mesh in a reference pose
        ///@
        ///</summary>
        ///<remarks>param       whether this skinned mesh should be rendered as static</remarks>
        public void SetRenderStatic(bool bNewValue)  => 
            SkinnedMeshComponent_methods.SetRenderStatic_method.Invoke(ObjPointer, bNewValue);

        ///<summary>Change the SkeletalMesh that is rendered for this Component.</summary>
        ///<remarks>
        ///Will re-initialize the animation tree etc.
        ///
        ///@param NewMesh New mesh to set for this component
        ///@param bReinitPose Whether we should keep current pose or reinitialize.
        ///</remarks>
        public void SetSkeletalMesh(SkeletalMesh NewMesh, bool bReinitPose)  => 
            SkinnedMeshComponent_methods.SetSkeletalMesh_method.Invoke(ObjPointer, NewMesh, bReinitPose);

        ///<summary>Allow override of skin weights on a per-component basis.</summary>
        public void SetSkinWeightOverride(int LODIndex, byte SkinWeights /*TODO: array TArray */)  => 
            SkinnedMeshComponent_methods.SetSkinWeightOverride_method.Invoke(ObjPointer, LODIndex, SkinWeights);

        ///<summary>Allow override of vertex colors on a per-component basis, taking array of Blueprint-friendly LinearColors.</summary>
        public void SetVertexColorOverride_LinearColor(int LODIndex, byte VertexColors /*TODO: array TArray */)  => 
            SkinnedMeshComponent_methods.SetVertexColorOverride_LinearColor_method.Invoke(ObjPointer, LODIndex, VertexColors);

        ///<summary>Clear any material visibility modifications made by ShowMaterialSection</summary>
        public void ShowAllMaterialSections(int LODIndex)  => 
            SkinnedMeshComponent_methods.ShowAllMaterialSections_method.Invoke(ObjPointer, LODIndex);

        ///<summary>Allows hiding of a particular material (by ID) on this instance of a SkeletalMesh.</summary>
        ///<remarks>
        ///@param MaterialID - Index of the material show/hide
        ///@param bShow - True to show the material, false to hide it
        ///@param LODIndex - Index of the LOD to modify material visibility within
        ///</remarks>
        public void ShowMaterialSection(int MaterialID, bool bShow, int LODIndex)  => 
            SkinnedMeshComponent_methods.ShowMaterialSection_method.Invoke(ObjPointer, MaterialID, bShow, LODIndex);

        ///<summary>Transform a location/rotation in bone relative space to world space.</summary>
        ///<remarks>
        ///@param BoneName Name of bone
        ///@param InPosition Input position
        ///@param InRotation Input rotation
        ///@param OutPosition (out) Transformed position
        ///@param OutRotation (out) Transformed rotation
        ///</remarks>
        public (Vector, Rotator) TransformFromBoneSpace(Name BoneName, Vector InPosition, Rotator InRotation)  => 
            SkinnedMeshComponent_methods.TransformFromBoneSpace_method.Invoke(ObjPointer, BoneName, InPosition, InRotation);

        ///<summary>Transform a location/rotation from world space to bone relative space.</summary>
        ///<remarks>
        ///This is handy if you know the location in world space for a bone attachment, as AttachComponent takes location/rotation in bone-relative space.
        ///
        ///@param BoneName Name of bone
        ///@param InPosition Input position
        ///@param InRotation Input rotation
        ///@param OutPosition (out) Transformed position
        ///@param OutRotation (out) Transformed rotation
        ///</remarks>
        public (Vector, Rotator) TransformToBoneSpace(Name BoneName, Vector InPosition, Rotator InRotation)  => 
            SkinnedMeshComponent_methods.TransformToBoneSpace_method.Invoke(ObjPointer, BoneName, InPosition, InRotation);

        ///<summary>UnHide the specified bone with name.</summary>
        ///<remarks>
        ///Currently this just enforces a scale of 0 for the hidden bones.
        ///Compoared to HideBone By Index - This keeps track of list of bones and update when LOD changes
        ///@param  BoneName            Name of bone to unhide
        ///</remarks>
        public void UnHideBoneByName(Name BoneName)  => 
            SkinnedMeshComponent_methods.UnHideBoneByName_method.Invoke(ObjPointer, BoneName);
        ///<summary>The skeletal mesh used by this component.</summary>
        public unsafe SkeletalMesh SkeletalMesh {
            get {return SkinnedMeshComponent_ptr->SkeletalMesh;}
        }
         //TODO: weak object TWeakObjectPtr<USkinnedMeshComponent> MasterPoseComponent
        ///<summary>PhysicsAsset is set in SkeletalMesh by default, but you can override with this value</summary>
        public unsafe PhysicsAsset PhysicsAssetOverride {
            get {return SkinnedMeshComponent_ptr->PhysicsAssetOverride;}
        }
        ///<summary>If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).</summary>
        public unsafe int ForcedLodModel {
            get {return SkinnedMeshComponent_ptr->ForcedLodModel;}
        }
        public bool bOverrideMinLod {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideMinLod"); }
        }
        ///<summary>This is the min LOD that this component will use.</summary>
        ///<remarks>
        ///(e.g. if set to 2 then only 2+ LOD Models will be used.) This is useful to set on
        ///meshes which are known to be a certain distance away and still want to have better LODs when zoomed in on them.
        ///</remarks>
        public unsafe int MinLodModel {
            get {return SkinnedMeshComponent_ptr->MinLodModel;}
        }
        ///<summary>Allows adjusting the desired streaming distance of streaming textures that uses UV 0.</summary>
        ///<remarks>
        ///1.0 is the default, whereas a higher value makes the textures stream in sooner from far away.
        ///A lower value (0.0-1.0) makes the textures stream in later (you have to be closer).
        ///Value can be < 0 (from legcay content, or code changes)
        ///</remarks>
        public unsafe float StreamingDistanceMultiplier {
            get {return SkinnedMeshComponent_ptr->StreamingDistanceMultiplier;}
            set {SkinnedMeshComponent_ptr->StreamingDistanceMultiplier = value;}
        }
         //TODO: array not UObject TArray LODInfo
        ///<summary>
        ///This is update frequency flag even when our Owner has not been rendered recently
        ///SMU_AlwaysTickPoseAndRefreshBones,                   // Always Tick and Refresh BoneTransforms whether rendered or not
        ///SMU_AlwaysTickPose,                                                  // Always Tick, but Refresh BoneTransforms only when rendered
        ///</summary>
        ///<remarks>SMU_OnlyTickPoseWhenRendered,                                // Tick only when rendered, and it will only RefreshBoneTransforms when rendered</remarks>
        public unsafe byte MeshComponentUpdateFlag {
            get {return SkinnedMeshComponent_ptr->MeshComponentUpdateFlag;}
            set {SkinnedMeshComponent_ptr->MeshComponentUpdateFlag = value;}
        }
        public bool bUseBoundsFromMasterPoseComponent {
            get {return Main.GetGetBoolPropertyByName(this, "bUseBoundsFromMasterPoseComponent"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseBoundsFromMasterPoseComponent", value); }
        }
        public bool bForceWireframe {
            get {return Main.GetGetBoolPropertyByName(this, "bForceWireframe"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceWireframe", value); }
        }
        public bool bDisableMorphTarget {
            get {return Main.GetGetBoolPropertyByName(this, "bDisableMorphTarget"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisableMorphTarget", value); }
        }
        public bool bHideSkin {
            get {return Main.GetGetBoolPropertyByName(this, "bHideSkin"); }
            set {Main.SetGetBoolPropertyByName(this, "bHideSkin", value); }
        }
        public bool bPerBoneMotionBlur {
            get {return Main.GetGetBoolPropertyByName(this, "bPerBoneMotionBlur"); }
        }
        public bool bComponentUseFixedSkelBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bComponentUseFixedSkelBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bComponentUseFixedSkelBounds", value); }
        }
        public bool bConsiderAllBodiesForBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bConsiderAllBodiesForBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bConsiderAllBodiesForBounds", value); }
        }
        public bool bSyncAttachParentLOD {
            get {return Main.GetGetBoolPropertyByName(this, "bSyncAttachParentLOD"); }
            set {Main.SetGetBoolPropertyByName(this, "bSyncAttachParentLOD", value); }
        }
        public bool bCanHighlightSelectedSections {
            get {return Main.GetGetBoolPropertyByName(this, "bCanHighlightSelectedSections"); }
            set {Main.SetGetBoolPropertyByName(this, "bCanHighlightSelectedSections", value); }
        }
        public bool bRecentlyRendered {
            get {return Main.GetGetBoolPropertyByName(this, "bRecentlyRendered"); }
            set {Main.SetGetBoolPropertyByName(this, "bRecentlyRendered", value); }
        }
        public bool bCastCapsuleDirectShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastCapsuleDirectShadow"); }
        }
        public bool bCastCapsuleIndirectShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastCapsuleIndirectShadow"); }
        }
        public bool bCPUSkinning {
            get {return Main.GetGetBoolPropertyByName(this, "bCPUSkinning"); }
            set {Main.SetGetBoolPropertyByName(this, "bCPUSkinning", value); }
        }
        public bool bEnableUpdateRateOptimizations {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableUpdateRateOptimizations"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableUpdateRateOptimizations", value); }
        }
        public bool bDisplayDebugUpdateRateOptimizations {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayDebugUpdateRateOptimizations"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayDebugUpdateRateOptimizations", value); }
        }
        public bool bRenderStatic {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderStatic"); }
        }
        public bool bCachedLocalBoundsUpToDate {
            get {return Main.GetGetBoolPropertyByName(this, "bCachedLocalBoundsUpToDate"); }
            set {Main.SetGetBoolPropertyByName(this, "bCachedLocalBoundsUpToDate", value); }
        }
        public bool bForceMeshObjectUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bForceMeshObjectUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceMeshObjectUpdate", value); }
        }
        ///<summary>Controls how dark the capsule indirect shadow can be.</summary>
        public unsafe float CapsuleIndirectShadowMinVisibility {
            get {return SkinnedMeshComponent_ptr->CapsuleIndirectShadowMinVisibility;}
        }
        ///<summary>LocalBounds cached, so they're computed just once.</summary>
        public unsafe BoxSphereBounds CachedLocalBounds {
            get {return SkinnedMeshComponent_ptr->CachedLocalBounds;}
            set {SkinnedMeshComponent_ptr->CachedLocalBounds = value;}
        }
        static SkinnedMeshComponent() {
            StaticClass = Main.GetClass("SkinnedMeshComponent");
        }
        internal unsafe SkinnedMeshComponent_fields* SkinnedMeshComponent_ptr => (SkinnedMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkinnedMeshComponent(IntPtr p) => UObject.Make<SkinnedMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkinnedMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkinnedMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
