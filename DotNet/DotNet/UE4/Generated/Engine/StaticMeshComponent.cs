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
    ///<summary>StaticMeshComponent is used to create an instance of a UStaticMesh.</summary>
    ///<remarks>
    ///A static mesh is a piece of geometry that consists of a static set of polygons.
    ///
    ///@see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/StaticMeshes/
    ///@see UStaticMesh
    ///</remarks>
    public unsafe partial class StaticMeshComponent : MeshComponent  {

        ///<summary>Get Local bounds</summary>
        public (Vector, Vector) GetLocalBounds()  => 
            StaticMeshComponent_methods.GetLocalBounds_method.Invoke(ObjPointer);

        ///<summary>Sets the component's DistanceFieldSelfShadowBias.  bOverrideDistanceFieldSelfShadowBias must be enabled for this to have an effect.</summary>
        public void SetDistanceFieldSelfShadowBias(float NewValue)  => 
            StaticMeshComponent_methods.SetDistanceFieldSelfShadowBias_method.Invoke(ObjPointer, NewValue);

        ///<summary>Set Forced Lod Model</summary>
        public void SetForcedLodModel(int NewForcedLodModel)  => 
            StaticMeshComponent_methods.SetForcedLodModel_method.Invoke(ObjPointer, NewForcedLodModel);

        ///<summary>Set forced reverse culling</summary>
        public void SetReverseCulling(bool ReverseCulling)  => 
            StaticMeshComponent_methods.SetReverseCulling_method.Invoke(ObjPointer, ReverseCulling);

        ///<summary>Change the StaticMesh used by this instance.</summary>
        public bool SetStaticMesh(StaticMesh NewMesh)  => 
            StaticMeshComponent_methods.SetStaticMesh_method.Invoke(ObjPointer, NewMesh);
        ///<summary>If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).</summary>
        public unsafe int ForcedLodModel {
            get {return StaticMeshComponent_ptr->ForcedLodModel;}
        }
        ///<summary>LOD that was desired for rendering this StaticMeshComponent last frame.</summary>
        public unsafe int PreviousLODLevel {
            get {return StaticMeshComponent_ptr->PreviousLODLevel;}
            set {StaticMeshComponent_ptr->PreviousLODLevel = value;}
        }
        ///<summary>Specifies the smallest LOD that will be used for this component.</summary>
        ///<remarks>This is ignored if ForcedLodModel is enabled.</remarks>
        public unsafe int MinLOD {
            get {return StaticMeshComponent_ptr->MinLOD;}
        }
        ///<summary>Subdivision step size for static vertex lighting.</summary>
        public unsafe int SubDivisionStepSize {
            get {return StaticMeshComponent_ptr->SubDivisionStepSize;}
            set {StaticMeshComponent_ptr->SubDivisionStepSize = value;}
        }
        ///<summary>Static Mesh</summary>
        public unsafe StaticMesh StaticMesh {
            get {return StaticMeshComponent_ptr->StaticMesh;}
        }
        ///<summary>Wireframe color to use if bOverrideWireframeColor is true</summary>
        public unsafe Color WireframeColorOverride {
            get {return StaticMeshComponent_ptr->WireframeColorOverride;}
        }
        ///<summary>The section currently selected in the Editor. Used for highlighting</summary>
        public unsafe int SelectedEditorSection {
            get {return StaticMeshComponent_ptr->SelectedEditorSection;}
            set {StaticMeshComponent_ptr->SelectedEditorSection = value;}
        }
        ///<summary>The material currently selected in the Editor. Used for highlighting</summary>
        public unsafe int SelectedEditorMaterial {
            get {return StaticMeshComponent_ptr->SelectedEditorMaterial;}
            set {StaticMeshComponent_ptr->SelectedEditorMaterial = value;}
        }
        ///<summary>Index of the section to preview. If set to INDEX_NONE, all section will be rendered. Used for isolating in Static Mesh Tool *</summary>
        public unsafe int SectionIndexPreview {
            get {return StaticMeshComponent_ptr->SectionIndexPreview;}
            set {StaticMeshComponent_ptr->SectionIndexPreview = value;}
        }
        ///<summary>Index of the material to preview. If set to INDEX_NONE, all section will be rendered. Used for isolating in Static Mesh Tool *</summary>
        public unsafe int MaterialIndexPreview {
            get {return StaticMeshComponent_ptr->MaterialIndexPreview;}
            set {StaticMeshComponent_ptr->MaterialIndexPreview = value;}
        }
        ///<summary>
        ///* The import version of the static mesh when it was assign this is update when:
        ///* - The user assign a new staticmesh to the component
        ///* - The component is serialize (IsSaving)
        ///* - Default value is BeforeImportStaticMeshVersionWasAdded
        ///*
        ///* If when the component get load (PostLoad) the version of the attach staticmesh is newer
        ///* then this value, we will remap the material override because the order of the materials list
        ///* in the staticmesh can be changed.
        ///</summary>
        ///<remarks>Hopefully there is a remap table save in the staticmesh.</remarks>
        public unsafe int StaticMeshImportVersion {
            get {return StaticMeshComponent_ptr->StaticMeshImportVersion;}
            set {StaticMeshComponent_ptr->StaticMeshImportVersion = value;}
        }
        public bool bOverrideWireframeColor {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideWireframeColor"); }
        }
        public bool bOverrideMinLOD {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideMinLOD"); }
        }
        public bool bOverrideNavigationExport {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideNavigationExport"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverrideNavigationExport", value); }
        }
        public bool bForceNavigationObstacle {
            get {return Main.GetGetBoolPropertyByName(this, "bForceNavigationObstacle"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceNavigationObstacle", value); }
        }
        public bool bDisallowMeshPaintPerInstance {
            get {return Main.GetGetBoolPropertyByName(this, "bDisallowMeshPaintPerInstance"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisallowMeshPaintPerInstance", value); }
        }
        public bool bIgnoreInstanceForTextureStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "bIgnoreInstanceForTextureStreaming"); }
            set {Main.SetGetBoolPropertyByName(this, "bIgnoreInstanceForTextureStreaming", value); }
        }
        public bool bOverrideLightMapRes {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideLightMapRes"); }
        }
        public bool bCastDistanceFieldIndirectShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastDistanceFieldIndirectShadow"); }
        }
        public bool bOverrideDistanceFieldSelfShadowBias {
            get {return Main.GetGetBoolPropertyByName(this, "bOverrideDistanceFieldSelfShadowBias"); }
        }
        public bool bUseSubDivisions {
            get {return Main.GetGetBoolPropertyByName(this, "bUseSubDivisions"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseSubDivisions", value); }
        }
        public bool bUseDefaultCollision {
            get {return Main.GetGetBoolPropertyByName(this, "bUseDefaultCollision"); }
            set {Main.SetGetBoolPropertyByName(this, "bUseDefaultCollision", value); }
        }
        public bool bCustomOverrideVertexColorPerLOD {
            get {return Main.GetGetBoolPropertyByName(this, "bCustomOverrideVertexColorPerLOD"); }
            set {Main.SetGetBoolPropertyByName(this, "bCustomOverrideVertexColorPerLOD", value); }
        }
        public bool bDisplayVertexColors {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayVertexColors"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayVertexColors", value); }
        }
        public bool bReverseCulling {
            get {return Main.GetGetBoolPropertyByName(this, "bReverseCulling"); }
        }
        ///<summary>Light map resolution to use on this component, used if bOverrideLightMapRes is true and there is a valid StaticMesh.</summary>
        public unsafe int OverriddenLightMapRes {
            get {return StaticMeshComponent_ptr->OverriddenLightMapRes;}
        }
        ///<summary>Controls how dark the dynamic indirect shadow can be.</summary>
        public unsafe float DistanceFieldIndirectShadowMinVisibility {
            get {return StaticMeshComponent_ptr->DistanceFieldIndirectShadowMinVisibility;}
        }
        ///<summary>Useful for reducing self shadowing from distance field methods when using world position offset to animate the mesh's vertices.</summary>
        public unsafe float DistanceFieldSelfShadowBias {
            get {return StaticMeshComponent_ptr->DistanceFieldSelfShadowBias;}
        }
        ///<summary>Allows adjusting the desired resolution of streaming textures that uses UV 0.  1.0 is the default, whereas a higher value increases the streamed-in resolution.</summary>
        public unsafe float StreamingDistanceMultiplier {
            get {return StaticMeshComponent_ptr->StreamingDistanceMultiplier;}
            set {StaticMeshComponent_ptr->StreamingDistanceMultiplier = value;}
        }
         //TODO: array not UObject TArray LODData
         //TODO: array not UObject TArray StreamingTextureData
         //TODO: string FString StaticMeshDerivedDataKey
         //TODO: array not UObject TArray MaterialStreamingRelativeBoxes
        ///<summary>The Lightmass settings for this object.</summary>
        public unsafe LightmassPrimitiveSettings LightmassSettings {
            get {return StaticMeshComponent_ptr->LightmassSettings;}
            set {StaticMeshComponent_ptr->LightmassSettings = value;}
        }
        static StaticMeshComponent() {
            StaticClass = Main.GetClass("StaticMeshComponent");
        }
        internal unsafe StaticMeshComponent_fields* StaticMeshComponent_ptr => (StaticMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StaticMeshComponent(IntPtr p) => UObject.Make<StaticMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StaticMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StaticMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
