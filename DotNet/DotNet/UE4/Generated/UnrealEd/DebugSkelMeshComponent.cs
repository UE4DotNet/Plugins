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
using UE4.UnrealEd.Native;
using UE4.Engine;
using UE4.AnimGraph;

namespace UE4.UnrealEd {
    ///<summary>Debug Skel Mesh Component</summary>
    public unsafe partial class DebugSkelMeshComponent : SkeletalMeshComponent  {
        public bool bRenderRawSkeleton {
            get {return Main.GetGetBoolPropertyByName(this, "bRenderRawSkeleton"); }
            set {Main.SetGetBoolPropertyByName(this, "bRenderRawSkeleton", value); }
        }
        public bool bDrawMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawMesh", value); }
        }
        public bool bShowBoneNames {
            get {return Main.GetGetBoolPropertyByName(this, "bShowBoneNames"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowBoneNames", value); }
        }
        public bool bDrawBoneInfluences {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawBoneInfluences"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawBoneInfluences", value); }
        }
        public bool bDrawMorphTargetVerts {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawMorphTargetVerts"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawMorphTargetVerts", value); }
        }
        public bool bDrawNormals {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawNormals"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawNormals", value); }
        }
        public bool bDrawTangents {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawTangents"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawTangents", value); }
        }
        public bool bDrawBinormals {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawBinormals"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawBinormals", value); }
        }
        public bool bDrawSockets {
            get {return Main.GetGetBoolPropertyByName(this, "bDrawSockets"); }
            set {Main.SetGetBoolPropertyByName(this, "bDrawSockets", value); }
        }
        public bool bSkeletonSocketsVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bSkeletonSocketsVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bSkeletonSocketsVisible", value); }
        }
        public bool bMeshSocketsVisible {
            get {return Main.GetGetBoolPropertyByName(this, "bMeshSocketsVisible"); }
            set {Main.SetGetBoolPropertyByName(this, "bMeshSocketsVisible", value); }
        }
        public bool bDisplayRawAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayRawAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayRawAnimation", value); }
        }
        public bool bDisplayNonRetargetedPose {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayNonRetargetedPose"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayNonRetargetedPose", value); }
        }
        public bool bDisplayAdditiveBasePose {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayAdditiveBasePose"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayAdditiveBasePose", value); }
        }
        public bool bDisplayBakedAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayBakedAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayBakedAnimation", value); }
        }
        public bool bDisplaySourceAnimation {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplaySourceAnimation"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplaySourceAnimation", value); }
        }
        public bool bDisplayBound {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayBound"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayBound", value); }
        }
        public bool bDisplayVertexColors {
            get {return Main.GetGetBoolPropertyByName(this, "bDisplayVertexColors"); }
            set {Main.SetGetBoolPropertyByName(this, "bDisplayVertexColors", value); }
        }
        public bool bPreviewRootMotion {
            get {return Main.GetGetBoolPropertyByName(this, "bPreviewRootMotion"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreviewRootMotion", value); }
        }
        public bool bShowClothData {
            get {return Main.GetGetBoolPropertyByName(this, "bShowClothData"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowClothData", value); }
        }
        ///<summary>Min Cloth Property View</summary>
        public unsafe float MinClothPropertyView {
            get {return DebugSkelMeshComponent_ptr->MinClothPropertyView;}
            set {DebugSkelMeshComponent_ptr->MinClothPropertyView = value;}
        }
        ///<summary>Max Cloth Property View</summary>
        public unsafe float MaxClothPropertyView {
            get {return DebugSkelMeshComponent_ptr->MaxClothPropertyView;}
            set {DebugSkelMeshComponent_ptr->MaxClothPropertyView = value;}
        }
        ///<summary>Cloth Mesh Opacity</summary>
        public unsafe float ClothMeshOpacity {
            get {return DebugSkelMeshComponent_ptr->ClothMeshOpacity;}
            set {DebugSkelMeshComponent_ptr->ClothMeshOpacity = value;}
        }
        public bool bClothFlipNormal {
            get {return Main.GetGetBoolPropertyByName(this, "bClothFlipNormal"); }
            set {Main.SetGetBoolPropertyByName(this, "bClothFlipNormal", value); }
        }
        public bool bClothCullBackface {
            get {return Main.GetGetBoolPropertyByName(this, "bClothCullBackface"); }
            set {Main.SetGetBoolPropertyByName(this, "bClothCullBackface", value); }
        }
         //TODO: array not UObject TArray BonesOfInterest
        ///<summary>Array of morphtargets to render verts for</summary>
        public ObjectArrayField<MorphTarget> MorphTargetOfInterests{ get {
            if(MorphTargetOfInterests_store == null) MorphTargetOfInterests_store = new ObjectArrayField<MorphTarget> (&DebugSkelMeshComponent_ptr->MorphTargetOfInterests);
            return MorphTargetOfInterests_store;
        } }
        private ObjectArrayField<MorphTarget> MorphTargetOfInterests_store;

        ///<summary>Array of materials to restore when not rendering blend weights</summary>
        public ObjectArrayField<MaterialInterface> SkelMaterials{ get {
            if(SkelMaterials_store == null) SkelMaterials_store = new ObjectArrayField<MaterialInterface> (&DebugSkelMeshComponent_ptr->SkelMaterials);
            return SkelMaterials_store;
        } }
        private ObjectArrayField<MaterialInterface> SkelMaterials_store;

        ///<summary>Preview Instance</summary>
        public unsafe AnimPreviewInstance PreviewInstance {
            get {return DebugSkelMeshComponent_ptr->PreviewInstance;}
            set {DebugSkelMeshComponent_ptr->PreviewInstance = value;}
        }
        ///<summary>Saved Anim Script Instance</summary>
        public unsafe AnimInstance SavedAnimScriptInstance {
            get {return DebugSkelMeshComponent_ptr->SavedAnimScriptInstance;}
            set {DebugSkelMeshComponent_ptr->SavedAnimScriptInstance = value;}
        }
        public bool bIsUsingInGameBounds {
            get {return Main.GetGetBoolPropertyByName(this, "bIsUsingInGameBounds"); }
            set {Main.SetGetBoolPropertyByName(this, "bIsUsingInGameBounds", value); }
        }
        public bool bPerformSingleClothingTick {
            get {return Main.GetGetBoolPropertyByName(this, "bPerformSingleClothingTick"); }
            set {Main.SetGetBoolPropertyByName(this, "bPerformSingleClothingTick", value); }
        }
        public bool bPauseClothingSimulationWithAnim {
            get {return Main.GetGetBoolPropertyByName(this, "bPauseClothingSimulationWithAnim"); }
            set {Main.SetGetBoolPropertyByName(this, "bPauseClothingSimulationWithAnim", value); }
        }
        static DebugSkelMeshComponent() {
            StaticClass = Main.GetClass("DebugSkelMeshComponent");
        }
        internal unsafe DebugSkelMeshComponent_fields* DebugSkelMeshComponent_ptr => (DebugSkelMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DebugSkelMeshComponent(IntPtr p) => UObject.Make<DebugSkelMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DebugSkelMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DebugSkelMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
