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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Gizmo Active Actor</summary>
    public unsafe partial class LandscapeGizmoActiveActor : LandscapeGizmoActor  {
        ///<summary>Data Type</summary>
        public unsafe byte DataType {
            get {return LandscapeGizmoActiveActor_ptr->DataType;}
            set {LandscapeGizmoActiveActor_ptr->DataType = value;}
        }
        ///<summary>Gizmo Texture</summary>
        public unsafe Texture2D GizmoTexture {
            get {return LandscapeGizmoActiveActor_ptr->GizmoTexture;}
            set {LandscapeGizmoActiveActor_ptr->GizmoTexture = value;}
        }
        ///<summary>Texture Scale</summary>
        public unsafe Vector2D TextureScale {
            get {return LandscapeGizmoActiveActor_ptr->TextureScale;}
            set {LandscapeGizmoActiveActor_ptr->TextureScale = value;}
        }
         //TODO: array not UObject TArray SampledHeight
         //TODO: array not UObject TArray SampledNormal
        ///<summary>Sample Size X</summary>
        public unsafe int SampleSizeX {
            get {return LandscapeGizmoActiveActor_ptr->SampleSizeX;}
            set {LandscapeGizmoActiveActor_ptr->SampleSizeX = value;}
        }
        ///<summary>Sample Size Y</summary>
        public unsafe int SampleSizeY {
            get {return LandscapeGizmoActiveActor_ptr->SampleSizeY;}
            set {LandscapeGizmoActiveActor_ptr->SampleSizeY = value;}
        }
        ///<summary>Cached Width</summary>
        public unsafe float CachedWidth {
            get {return LandscapeGizmoActiveActor_ptr->CachedWidth;}
            set {LandscapeGizmoActiveActor_ptr->CachedWidth = value;}
        }
        ///<summary>Cached Height</summary>
        public unsafe float CachedHeight {
            get {return LandscapeGizmoActiveActor_ptr->CachedHeight;}
            set {LandscapeGizmoActiveActor_ptr->CachedHeight = value;}
        }
        ///<summary>Cached Scale XY</summary>
        public unsafe float CachedScaleXY {
            get {return LandscapeGizmoActiveActor_ptr->CachedScaleXY;}
            set {LandscapeGizmoActiveActor_ptr->CachedScaleXY = value;}
        }
        ///<summary>Frustum Verts</summary>
        public unsafe Vector FrustumVerts {
            get {return LandscapeGizmoActiveActor_ptr->FrustumVerts;}
            set {LandscapeGizmoActiveActor_ptr->FrustumVerts = value;}
        }
        ///<summary>Gizmo Material</summary>
        public unsafe Material GizmoMaterial {
            get {return LandscapeGizmoActiveActor_ptr->GizmoMaterial;}
            set {LandscapeGizmoActiveActor_ptr->GizmoMaterial = value;}
        }
        ///<summary>Gizmo Data Material</summary>
        public unsafe MaterialInstance GizmoDataMaterial {
            get {return LandscapeGizmoActiveActor_ptr->GizmoDataMaterial;}
            set {LandscapeGizmoActiveActor_ptr->GizmoDataMaterial = value;}
        }
        ///<summary>Gizmo Mesh Material</summary>
        public unsafe Material GizmoMeshMaterial {
            get {return LandscapeGizmoActiveActor_ptr->GizmoMeshMaterial;}
            set {LandscapeGizmoActiveActor_ptr->GizmoMeshMaterial = value;}
        }
        ///<summary>Layer Infos</summary>
        public ObjectArrayField<LandscapeLayerInfoObject> LayerInfos{ get {
            if(LayerInfos_store == null) LayerInfos_store = new ObjectArrayField<LandscapeLayerInfoObject> (&LandscapeGizmoActiveActor_ptr->LayerInfos);
            return LayerInfos_store;
        } }
        private ObjectArrayField<LandscapeLayerInfoObject> LayerInfos_store;

        public bool bSnapToLandscapeGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bSnapToLandscapeGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bSnapToLandscapeGrid", value); }
        }
        ///<summary>Unsnapped Rotation</summary>
        public unsafe Rotator UnsnappedRotation {
            get {return LandscapeGizmoActiveActor_ptr->UnsnappedRotation;}
            set {LandscapeGizmoActiveActor_ptr->UnsnappedRotation = value;}
        }
        static LandscapeGizmoActiveActor() {
            StaticClass = Main.GetClass("LandscapeGizmoActiveActor");
        }
        internal unsafe LandscapeGizmoActiveActor_fields* LandscapeGizmoActiveActor_ptr => (LandscapeGizmoActiveActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeGizmoActiveActor(IntPtr p) => UObject.Make<LandscapeGizmoActiveActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeGizmoActiveActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeGizmoActiveActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
