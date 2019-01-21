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
using UE4.ClothingSystemRuntimeInterface;

namespace UE4.Engine {
    ///<summary>SkeletalMesh is geometry bound to a hierarchical skeleton of bones which can be animated for the purpose of deforming the mesh.</summary>
    ///<remarks>
    ///Skeletal Meshes are built up of two parts; a set of polygons composed to make up the surface of the mesh, and a hierarchical skeleton which can be used to animate the polygons.
    ///The 3D models, rigging, and animations are created in an external modeling and animation application (3DSMax, Maya, Softimage, etc).
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/SkeletalMeshes/
    ///</remarks>
    public unsafe partial class SkeletalMesh : UObject  {

        ///<summary>Find a socket object in this SkeletalMesh by name.</summary>
        ///<remarks>Entering NAME_None will return NULL. If there are multiple sockets with the same name, will return the first one.</remarks>
        public SkeletalMeshSocket FindSocket(Name InSocketName)  => 
            SkeletalMesh_methods.FindSocket_method.Invoke(ObjPointer, InSocketName);

        ///<summary>Find a socket object in this SkeletalMesh by name.</summary>
        ///<remarks>
        ///Entering NAME_None will return NULL. If there are multiple sockets with the same name, will return the first one.
        ///Also returns the index for the socket allowing for future fast access via GetSocketByIndex()
        ///</remarks>
        public (int, SkeletalMeshSocket) FindSocketAndIndex(Name InSocketName)  => 
            SkeletalMesh_methods.FindSocketAndIndex_method.Invoke(ObjPointer, InSocketName);

        ///<summary>Get the extended bounds of this mesh (imported bounds plus bounds extension)</summary>
        public BoxSphereBounds GetBounds()  => 
            SkeletalMesh_methods.GetBounds_method.Invoke(ObjPointer);

        ///<summary>Get the original imported bounds of the skel mesh</summary>
        public BoxSphereBounds GetImportedBounds()  => 
            SkeletalMesh_methods.GetImportedBounds_method.Invoke(ObjPointer);

        ///<summary>Get Node Mapping Container</summary>
        public NodeMappingContainer GetNodeMappingContainer(Blueprint SourceAsset)  => 
            SkeletalMesh_methods.GetNodeMappingContainer_method.Invoke(ObjPointer, SourceAsset);

        ///<summary>Returns a socket by index. Max index is NumSockets(). The meshes sockets are accessed first, then the skeletons.</summary>
        public SkeletalMeshSocket GetSocketByIndex(int Index)  => 
            SkeletalMesh_methods.GetSocketByIndex_method.Invoke(ObjPointer, Index);

        ///<summary>Checks whether the provided section is using APEX cloth.</summary>
        ///<remarks>
        ///if bCheckCorrespondingSections is true
        ///disabled sections will defer to correspond sections to see if they use cloth (non-cloth sections
        ///are disabled and another section added when cloth is enabled, using this flag allows for a check
        ///on the original section to succeed)
        ///@param InSectionIndex Index to check
        ///@param bCheckCorrespondingSections Whether to check corresponding sections for disabled sections
        ///</remarks>
        public bool IsSectionUsingCloth(int InSectionIndex, bool bCheckCorrespondingSections)  => 
            SkeletalMesh_methods.IsSectionUsingCloth_method.Invoke(ObjPointer, InSectionIndex, bCheckCorrespondingSections);

        ///<summary>Returns the number of sockets available. Both on this mesh and it's skeleton.</summary>
        public int NumSockets()  => 
            SkeletalMesh_methods.NumSockets_method.Invoke(ObjPointer);

        ///<summary>Set LODSettings</summary>
        public void SetLODSettings(SkeletalMeshLODSettings InLODSettings)  => 
            SkeletalMesh_methods.SetLODSettings_method.Invoke(ObjPointer, InLODSettings);
        ///<summary>Skeleton of this skeletal mesh *</summary>
        public unsafe Skeleton Skeleton {
            get {return SkeletalMesh_ptr->Skeleton;}
        }
        ///<summary>Original imported mesh bounds</summary>
        public unsafe BoxSphereBounds ImportedBounds {
            get {return SkeletalMesh_ptr->ImportedBounds;}
            set {SkeletalMesh_ptr->ImportedBounds = value;}
        }
        ///<summary>Bounds extended by user values below</summary>
        public unsafe BoxSphereBounds ExtendedBounds {
            get {return SkeletalMesh_ptr->ExtendedBounds;}
            set {SkeletalMesh_ptr->ExtendedBounds = value;}
        }
        ///<summary>
        ///Bound extension values in addition to imported bound in the positive direction of XYZ,
        ///    positive value increases bound size and negative value decreases bound size.
        ///</summary>
        ///<remarks>The final bound would be from [Imported Bound - Negative Bound] to [Imported Bound + Positive Bound].</remarks>
        public unsafe Vector PositiveBoundsExtension {
            get {return SkeletalMesh_ptr->PositiveBoundsExtension;}
        }
        ///<summary>
        ///Bound extension values in addition to imported bound in the negative direction of XYZ,
        ///    positive value increases bound size and negative value decreases bound size.
        ///</summary>
        ///<remarks>The final bound would be from [Imported Bound - Negative Bound] to [Imported Bound + Positive Bound].</remarks>
        public unsafe Vector NegativeBoundsExtension {
            get {return SkeletalMesh_ptr->NegativeBoundsExtension;}
        }
         //TODO: array not UObject TArray Materials
         //TODO: array not UObject TArray SkelMirrorTable
         //TODO: array not UObject TArray LODInfo
        ///<summary>Minimum LOD to render. Can be overridden per component as well as set here for all mesh instances here</summary>
        public unsafe PerPlatformInt MinLod {
            get {return SkeletalMesh_ptr->MinLod;}
            set {SkeletalMesh_ptr->MinLod = value;}
        }
        ///<summary>LODSettings</summary>
        public unsafe SkeletalMeshLODSettings LODSettings {
            get {return SkeletalMesh_ptr->LODSettings;}
            set {SkeletalMesh_ptr->LODSettings = value;}
        }
        ///<summary>Skel Mirror Axis</summary>
        public unsafe byte SkelMirrorAxis {
            get {return SkeletalMesh_ptr->SkelMirrorAxis;}
            set {SkeletalMesh_ptr->SkelMirrorAxis = value;}
        }
        ///<summary>Skel Mirror Flip Axis</summary>
        public unsafe byte SkelMirrorFlipAxis {
            get {return SkeletalMesh_ptr->SkelMirrorFlipAxis;}
            set {SkeletalMesh_ptr->SkelMirrorFlipAxis = value;}
        }
        public bool bUseFullPrecisionUVs {
            get {return Main.GetGetBoolPropertyByName(this, "bUseFullPrecisionUVs"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseFullPrecisionUVs", value); }
        }
        public bool bUseHighPrecisionTangentBasis {
            get {return Main.GetGetBoolPropertyByName(this, "bUseHighPrecisionTangentBasis"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseHighPrecisionTangentBasis", value); }
        }
        public bool bHasBeenSimplified {
            get {return Main.GetGetBoolPropertyByName(this, "bHasBeenSimplified"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasBeenSimplified", value); }
        }
        public bool bHasVertexColors {
            get {return Main.GetGetBoolPropertyByName(this, "bHasVertexColors"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasVertexColors", value); }
        }
        public bool bEnablePerPolyCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bEnablePerPolyCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnablePerPolyCollision", value); }
        }
        ///<summary>The guid to compute the ddc key, it must be dirty when we change the vertex color.</summary>
        public unsafe FGuid VertexColorGuid {
            get {return SkeletalMesh_ptr->VertexColorGuid;}
            set {SkeletalMesh_ptr->VertexColorGuid = value;}
        }
        ///<summary>Physics data for the per poly collision case. In 99% of cases you will not need this and are better off using simple ragdoll collision (physics asset)</summary>
        public unsafe BodySetup BodySetup {
            get {return SkeletalMesh_ptr->BodySetup;}
            set {SkeletalMesh_ptr->BodySetup = value;}
        }
        ///<summary>Physics and collision information used for this USkeletalMesh, set up in Physics Asset Editor.</summary>
        ///<remarks>This is used for per-bone hit detection, accurate bounding box calculation and ragdoll physics for example.</remarks>
        public unsafe PhysicsAsset PhysicsAsset {
            get {return SkeletalMesh_ptr->PhysicsAsset;}
        }
        ///<summary>Physics asset whose shapes will be used for shadowing when components have bCastCharacterCapsuleDirectShadow or bCastCharacterCapsuleIndirectShadow enabled.</summary>
        ///<remarks>Only spheres and sphyl shapes in the physics asset can be supported.  The more shapes used, the higher the cost of the capsule shadows will be.</remarks>
        public unsafe PhysicsAsset ShadowPhysicsAsset {
            get {return SkeletalMesh_ptr->ShadowPhysicsAsset;}
        }
        ///<summary>Mapping data that is saved</summary>
        public ObjectArrayField<NodeMappingContainer> NodeMappingData{ get {
            if(NodeMappingData_store == null) NodeMappingData_store = new ObjectArrayField<NodeMappingContainer> (&SkeletalMesh_ptr->NodeMappingData);
            return NodeMappingData_store;
        } }
        private ObjectArrayField<NodeMappingContainer> NodeMappingData_store;

        ///<summary>Importing data and options used for this mesh</summary>
        public unsafe AssetImportData AssetImportData {
            get {return SkeletalMesh_ptr->AssetImportData;}
            set {SkeletalMesh_ptr->AssetImportData = value;}
        }
        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return SkeletalMesh_ptr->ThumbnailInfo;}
            set {SkeletalMesh_ptr->ThumbnailInfo = value;}
        }
        public bool bHasCustomDefaultEditorCamera {
            get {return Main.GetGetBoolPropertyByName(this, "bHasCustomDefaultEditorCamera"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasCustomDefaultEditorCamera", value); }
        }
        ///<summary>Default camera location</summary>
        public unsafe Vector DefaultEditorCameraLocation {
            get {return SkeletalMesh_ptr->DefaultEditorCameraLocation;}
            set {SkeletalMesh_ptr->DefaultEditorCameraLocation = value;}
        }
        ///<summary>Default camera rotation</summary>
        public unsafe Rotator DefaultEditorCameraRotation {
            get {return SkeletalMesh_ptr->DefaultEditorCameraRotation;}
            set {SkeletalMesh_ptr->DefaultEditorCameraRotation = value;}
        }
        ///<summary>Default camera look at</summary>
        public unsafe Vector DefaultEditorCameraLookAt {
            get {return SkeletalMesh_ptr->DefaultEditorCameraLookAt;}
            set {SkeletalMesh_ptr->DefaultEditorCameraLookAt = value;}
        }
        ///<summary>Default camera ortho zoom</summary>
        public unsafe float DefaultEditorCameraOrthoZoom {
            get {return SkeletalMesh_ptr->DefaultEditorCameraOrthoZoom;}
            set {SkeletalMesh_ptr->DefaultEditorCameraOrthoZoom = value;}
        }
        ///<summary>Attached assets component for this mesh</summary>
        public unsafe PreviewAssetAttachContainer PreviewAttachedAssetContainer {
            get {return SkeletalMesh_ptr->PreviewAttachedAssetContainer;}
            set {SkeletalMesh_ptr->PreviewAttachedAssetContainer = value;}
        }
        ///<summary>Morph Targets</summary>
        public ObjectArrayField<MorphTarget> MorphTargets{ get {
            if(MorphTargets_store == null) MorphTargets_store = new ObjectArrayField<MorphTarget> (&SkeletalMesh_ptr->MorphTargets);
            return MorphTargets_store;
        } }
        private ObjectArrayField<MorphTarget> MorphTargets_store;

        ///<summary>Height offset for the floor mesh in the editor</summary>
        public unsafe float FloorOffset {
            get {return SkeletalMesh_ptr->FloorOffset;}
            set {SkeletalMesh_ptr->FloorOffset = value;}
        }
         //TODO: array not UObject TArray RetargetBasePose
        ///<summary>Animation Blueprint class to run as a post process for this mesh.</summary>
        ///<remarks>
        ///This blueprint will be ran before physics, but after the main
        ///anim instance for any skeletal mesh component using this mesh.
        ///</remarks>
        public unsafe SubclassOf<AnimInstance> PostProcessAnimBlueprint {
            get {return SkeletalMesh_ptr->PostProcessAnimBlueprint;}
        }
        ///<summary>Clothing assets imported to this mesh.</summary>
        ///<remarks>
        ///May or may not be in use currently on the mesh.
        ///Ordering not guaranteed, use the provided getters to access elements in this array
        ///whenever possible
        ///</remarks>
        public ObjectArrayField<ClothingAssetBase> MeshClothingAssets{ get {
            if(MeshClothingAssets_store == null) MeshClothingAssets_store = new ObjectArrayField<ClothingAssetBase> (&SkeletalMesh_ptr->MeshClothingAssets);
            return MeshClothingAssets_store;
        } }
        private ObjectArrayField<ClothingAssetBase> MeshClothingAssets_store;

        ///<summary>Defines if and how to generate a set of precomputed data allowing targeted and fast sampling of this mesh on the CPU.</summary>
        public unsafe SkeletalMeshSamplingInfo SamplingInfo {
            get {return SkeletalMesh_ptr->SamplingInfo;}
            set {SkeletalMesh_ptr->SamplingInfo = value;}
        }
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&SkeletalMesh_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        ///<summary>
        ///Array of named socket locations, set up in editor and used as a shortcut instead of specifying
        ///everything explicitly to AttachComponent in the SkeletalMeshComponent.
        ///</summary>
        public ObjectArrayField<SkeletalMeshSocket> Sockets{ get {
            if(Sockets_store == null) Sockets_store = new ObjectArrayField<SkeletalMeshSocket> (&SkeletalMesh_ptr->Sockets);
            return Sockets_store;
        } }
        private ObjectArrayField<SkeletalMeshSocket> Sockets_store;

        static SkeletalMesh() {
            StaticClass = Main.GetClass("SkeletalMesh");
        }
        internal unsafe SkeletalMesh_fields* SkeletalMesh_ptr => (SkeletalMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalMesh(IntPtr p) => UObject.Make<SkeletalMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
