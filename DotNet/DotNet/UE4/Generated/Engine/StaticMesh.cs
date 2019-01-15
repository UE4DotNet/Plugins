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
    ///<summary>A StaticMesh is a piece of geometry that consists of a static set of polygons.</summary>
    ///<remarks>
    ///Static Meshes can be translated, rotated, and scaled, but they cannot have their vertices animated in any way. As such, they are more efficient
    ///to render than other types of geometry such as USkeletalMesh, and they are often the basic building block of levels created in the engine.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/StaticMeshes/
    ///@see AStaticMeshActor, UStaticMeshComponent
    ///</remarks>
    public unsafe partial class StaticMesh : UObject  {

        ///<summary>Returns the bounding box, in local space including bounds extension(s), of the StaticMesh asset</summary>
        public Box GetBoundingBox()  => 
            StaticMesh_methods.GetBoundingBox_method.Invoke(ObjPointer);

        ///<summary>Returns the number of bounds of the mesh.</summary>
        ///<remarks>
        ///@return      The bounding box represented as box origin with extents and also a sphere that encapsulates that box
        ///</remarks>
        public BoxSphereBounds GetBounds()  => 
            StaticMesh_methods.GetBounds_method.Invoke(ObjPointer);

        ///<summary>
        ///Gets a Material given a Material Index and an LOD number
        ///@
        ///</summary>
        ///<remarks>return Requested material</remarks>
        public MaterialInterface GetMaterial(int MaterialIndex)  => 
            StaticMesh_methods.GetMaterial_method.Invoke(ObjPointer, MaterialIndex);

        ///<summary>
        ///Gets a Material index given a slot name
        ///@
        ///</summary>
        ///<remarks>return Requested material</remarks>
        public int GetMaterialIndex(Name MaterialSlotName)  => 
            StaticMesh_methods.GetMaterialIndex_method.Invoke(ObjPointer, MaterialSlotName);

        ///<summary>Returns the number of LODs used by the mesh.</summary>
        public int GetNumLODs()  => 
            StaticMesh_methods.GetNumLODs_method.Invoke(ObjPointer);

        ///<summary>Returns number of Sections that this StaticMesh has, in the supplied LOD (LOD 0 is the highest)</summary>
        public int GetNumSections(int InLOD)  => 
            StaticMesh_methods.GetNumSections_method.Invoke(ObjPointer, InLOD);

        ///<summary>
        ///Sets a Material given a Material Index
        ///@
        ///</summary>
        ///<remarks>note Only available in editor.</remarks>
        public void SetMaterial(int MaterialIndex, MaterialInterface NewMaterial)  => 
            StaticMesh_methods.SetMaterial_method.Invoke(ObjPointer, MaterialIndex, NewMaterial);
         //TODO: array not UObject TArray SourceModels
        ///<summary>Container holding mesh descriptions for each LOD</summary>
        public unsafe StaticMeshDescriptions MeshDescriptions {
            get {return StaticMesh_ptr->MeshDescriptions;}
            set {StaticMesh_ptr->MeshDescriptions = value;}
        }
        ///<summary>Map of LOD+Section index to per-section info.</summary>
        public unsafe MeshSectionInfoMap SectionInfoMap {
            get {return StaticMesh_ptr->SectionInfoMap;}
            set {StaticMesh_ptr->SectionInfoMap = value;}
        }
        ///<summary>We need the OriginalSectionInfoMap to be able to build mesh in a non destructive way.</summary>
        ///<remarks>
        ///Reduce has to play with SectionInfoMap in case some sections disappear.
        ///This member will be update in the following situation
        ///1. After a static mesh import/reimport
        ///2. Postload, if the OriginalSectionInfoMap is empty, we will fill it with the current SectionInfoMap
        ///
        ///We do not update it when the user shuffle section in the staticmesh editor because the OriginalSectionInfoMap must always be in sync with the saved rawMesh bulk data.
        ///</remarks>
        public unsafe MeshSectionInfoMap OriginalSectionInfoMap {
            get {return StaticMesh_ptr->OriginalSectionInfoMap;}
            set {StaticMesh_ptr->OriginalSectionInfoMap = value;}
        }
        ///<summary>The LOD group to which this mesh belongs.</summary>
        public unsafe Name LODGroup {
            get {return StaticMesh_ptr->LODGroup;}
            set {StaticMesh_ptr->LODGroup = value;}
        }
        public bool bAutoComputeLODScreenSize {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoComputeLODScreenSize"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoComputeLODScreenSize", value); }
        }
        ///<summary>The last import version</summary>
        public unsafe int ImportVersion {
            get {return StaticMesh_ptr->ImportVersion;}
            set {StaticMesh_ptr->ImportVersion = value;}
        }
         //TODO: array not UObject TArray MaterialRemapIndexPerImportVersion
        ///<summary>The lightmap UV generation version used during the last derived data build</summary>
        public unsafe int LightmapUVVersion {
            get {return StaticMesh_ptr->LightmapUVVersion;}
            set {StaticMesh_ptr->LightmapUVVersion = value;}
        }
        ///<summary>Minimum LOD to use for rendering.  This is the default setting for the mesh and can be overridden by component settings.</summary>
        public unsafe PerPlatformInt MinLOD {
            get {return StaticMesh_ptr->MinLOD;}
            set {StaticMesh_ptr->MinLOD = value;}
        }
         //TODO: array not UObject TArray StaticMaterials
        ///<summary>Lightmap UVDensity</summary>
        public unsafe float LightmapUVDensity {
            get {return StaticMesh_ptr->LightmapUVDensity;}
            set {StaticMesh_ptr->LightmapUVDensity = value;}
        }
        ///<summary>The light map resolution</summary>
        public unsafe int LightMapResolution {
            get {return StaticMesh_ptr->LightMapResolution;}
            set {StaticMesh_ptr->LightMapResolution = value;}
        }
        ///<summary>The light map coordinate index</summary>
        public unsafe int LightMapCoordinateIndex {
            get {return StaticMesh_ptr->LightMapCoordinateIndex;}
            set {StaticMesh_ptr->LightMapCoordinateIndex = value;}
        }
        ///<summary>Useful for reducing self shadowing from distance field methods when using world position offset to animate the mesh's vertices.</summary>
        public unsafe float DistanceFieldSelfShadowBias {
            get {return StaticMesh_ptr->DistanceFieldSelfShadowBias;}
            set {StaticMesh_ptr->DistanceFieldSelfShadowBias = value;}
        }
        public bool bGenerateMeshDistanceField {
            get {return Main.GetGetBoolPropertyByName(this, "bGenerateMeshDistanceField"); }
            set {Main.SetGetBoolPropertyByName(this, "bGenerateMeshDistanceField", value); }
        }
        ///<summary>Physics data.</summary>
        public unsafe BodySetup BodySetup {
            get {return StaticMesh_ptr->BodySetup;}
            set {StaticMesh_ptr->BodySetup = value;}
        }
        ///<summary>Specifies which mesh LOD to use for complex (per-poly) collision.</summary>
        ///<remarks>
        ///Sometimes it can be desirable to use a lower poly representation for collision to reduce memory usage, improve performance and behaviour.
        ///Collision representation does not change based on distance to camera.
        ///</remarks>
        public unsafe int LODForCollision {
            get {return StaticMesh_ptr->LODForCollision;}
            set {StaticMesh_ptr->LODForCollision = value;}
        }
        public bool bHasNavigationData {
            get {return Main.GetGetBoolPropertyByName(this, "bHasNavigationData"); }
            set {Main.SetGetBoolPropertyByName(this, "bHasNavigationData", value); }
        }
        public bool bSupportUniformlyDistributedSampling {
            get {return Main.GetGetBoolPropertyByName(this, "bSupportUniformlyDistributedSampling"); }
            set {Main.SetGetBoolPropertyByName(this, "bSupportUniformlyDistributedSampling", value); }
        }
        ///<summary>Bias multiplier for Light Propagation Volume lighting</summary>
        public unsafe float LpvBiasMultiplier {
            get {return StaticMesh_ptr->LpvBiasMultiplier;}
        }
        public bool bAllowCPUAccess {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowCPUAccess"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowCPUAccess", value); }
        }
        ///<summary>Importing data and options used for this mesh</summary>
        public unsafe AssetImportData AssetImportData {
            get {return StaticMesh_ptr->AssetImportData;}
            set {StaticMesh_ptr->AssetImportData = value;}
        }
        ///<summary>Information for thumbnail rendering</summary>
        public unsafe ThumbnailInfo ThumbnailInfo {
            get {return StaticMesh_ptr->ThumbnailInfo;}
            set {StaticMesh_ptr->ThumbnailInfo = value;}
        }
        ///<summary>The stored camera position to use as a default for the static mesh editor</summary>
        public unsafe AssetEditorOrbitCameraPosition EditorCameraPosition {
            get {return StaticMesh_ptr->EditorCameraPosition;}
            set {StaticMesh_ptr->EditorCameraPosition = value;}
        }
        public bool bCustomizedCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bCustomizedCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bCustomizedCollision", value); }
        }
        ///<summary>Specifies which mesh LOD to use as occluder geometry for software occlusion</summary>
        ///<remarks>Set to -1 to not use this mesh as occluder</remarks>
        public unsafe int LODForOccluderMesh {
            get {return StaticMesh_ptr->LODForOccluderMesh;}
            set {StaticMesh_ptr->LODForOccluderMesh = value;}
        }
        ///<summary>
        ///Array of named socket locations, set up in editor and used as a shortcut instead of specifying
        ///everything explicitly to AttachComponent in the StaticMeshComponent.
        ///</summary>
        public ObjectArrayField<StaticMeshSocket> Sockets{ get {
            if(Sockets_store == null) Sockets_store = new ObjectArrayField<StaticMeshSocket> (&StaticMesh_ptr->Sockets);
            return Sockets_store;
        } }
        private ObjectArrayField<StaticMeshSocket> Sockets_store;

        ///<summary>Bound extension values in the positive direction of XYZ, positive value increases bound size</summary>
        public unsafe Vector PositiveBoundsExtension {
            get {return StaticMesh_ptr->PositiveBoundsExtension;}
            set {StaticMesh_ptr->PositiveBoundsExtension = value;}
        }
        ///<summary>Bound extension values in the negative direction of XYZ, positive value increases bound size</summary>
        public unsafe Vector NegativeBoundsExtension {
            get {return StaticMesh_ptr->NegativeBoundsExtension;}
            set {StaticMesh_ptr->NegativeBoundsExtension = value;}
        }
        ///<summary>Original mesh bounds extended with Positive/NegativeBoundsExtension</summary>
        public unsafe BoxSphereBounds ExtendedBounds {
            get {return StaticMesh_ptr->ExtendedBounds;}
            set {StaticMesh_ptr->ExtendedBounds = value;}
        }
        ///<summary>Index of an element to ignore while gathering streaming texture factors.</summary>
        ///<remarks>This is useful to disregard automatically generated vertex data which breaks texture factor heuristics.</remarks>
        public unsafe int ElementToIgnoreForTexFactor {
            get {return StaticMesh_ptr->ElementToIgnoreForTexFactor;}
            set {StaticMesh_ptr->ElementToIgnoreForTexFactor = value;}
        }
        ///<summary>Array of user data stored with the asset</summary>
        public ObjectArrayField<AssetUserData> AssetUserData{ get {
            if(AssetUserData_store == null) AssetUserData_store = new ObjectArrayField<AssetUserData> (&StaticMesh_ptr->AssetUserData);
            return AssetUserData_store;
        } }
        private ObjectArrayField<AssetUserData> AssetUserData_store;

        ///<summary>The editable mesh representation of this static mesh // @todo: Maybe we don't want this visible in the details panel in the end; for now, this might aid debugging.</summary>
        public unsafe UObject EditableMesh {
            get {return StaticMesh_ptr->EditableMesh;}
            set {StaticMesh_ptr->EditableMesh = value;}
        }
        ///<summary>Pre-build navigation collision</summary>
        public unsafe NavCollisionBase NavCollision {
            get {return StaticMesh_ptr->NavCollision;}
            set {StaticMesh_ptr->NavCollision = value;}
        }
        static StaticMesh() {
            StaticClass = Main.GetClass("StaticMesh");
        }
        internal unsafe StaticMesh_fields* StaticMesh_ptr => (StaticMesh_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StaticMesh(IntPtr p) => UObject.Make<StaticMesh>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StaticMesh DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StaticMesh New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
