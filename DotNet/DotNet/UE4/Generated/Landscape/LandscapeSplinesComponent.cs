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
    ///<summary>ULandscapeSplinesComponent</summary>
    public unsafe partial class LandscapeSplinesComponent : PrimitiveComponent  {
        ///<summary>Resolution of the spline, in distance per point</summary>
        public unsafe float SplineResolution {
            get {return LandscapeSplinesComponent_ptr->SplineResolution;}
            set {LandscapeSplinesComponent_ptr->SplineResolution = value;}
        }
        ///<summary>Color to use to draw the splines</summary>
        public unsafe Color SplineColor {
            get {return LandscapeSplinesComponent_ptr->SplineColor;}
            set {LandscapeSplinesComponent_ptr->SplineColor = value;}
        }
        ///<summary>Sprite used to draw control points</summary>
        public unsafe Texture2D ControlPointSprite {
            get {return LandscapeSplinesComponent_ptr->ControlPointSprite;}
            set {LandscapeSplinesComponent_ptr->ControlPointSprite = value;}
        }
        ///<summary>Mesh used to draw splines that have no mesh</summary>
        public unsafe StaticMesh SplineEditorMesh {
            get {return LandscapeSplinesComponent_ptr->SplineEditorMesh;}
            set {LandscapeSplinesComponent_ptr->SplineEditorMesh = value;}
        }
        public bool bShowSplineEditorMesh {
            get {return Main.GetGetBoolPropertyByName(this, "bShowSplineEditorMesh"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowSplineEditorMesh", value); }
        }
        ///<summary>Control Points</summary>
        public ObjectArrayField<LandscapeSplineControlPoint> ControlPoints{ get {
            if(ControlPoints_store == null) ControlPoints_store = new ObjectArrayField<LandscapeSplineControlPoint> (&LandscapeSplinesComponent_ptr->ControlPoints);
            return ControlPoints_store;
        } }
        private ObjectArrayField<LandscapeSplineControlPoint> ControlPoints_store;

        ///<summary>Segments</summary>
        public ObjectArrayField<LandscapeSplineSegment> Segments{ get {
            if(Segments_store == null) Segments_store = new ObjectArrayField<LandscapeSplineSegment> (&LandscapeSplinesComponent_ptr->Segments);
            return Segments_store;
        } }
        private ObjectArrayField<LandscapeSplineSegment> Segments_store;

         //TODO: map TMap ForeignWorldSplineDataMap
        ///<summary>References to components owned by landscape splines in other levels</summary>
        ///<remarks>for cooked build (uncooked keeps references via ForeignWorldSplineDataMap)</remarks>
        public ObjectArrayField<MeshComponent> CookedForeignMeshComponents{ get {
            if(CookedForeignMeshComponents_store == null) CookedForeignMeshComponents_store = new ObjectArrayField<MeshComponent> (&LandscapeSplinesComponent_ptr->CookedForeignMeshComponents);
            return CookedForeignMeshComponents_store;
        } }
        private ObjectArrayField<MeshComponent> CookedForeignMeshComponents_store;

        static LandscapeSplinesComponent() {
            StaticClass = Main.GetClass("LandscapeSplinesComponent");
        }
        internal unsafe LandscapeSplinesComponent_fields* LandscapeSplinesComponent_ptr => (LandscapeSplinesComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeSplinesComponent(IntPtr p) => UObject.Make<LandscapeSplinesComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeSplinesComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeSplinesComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
