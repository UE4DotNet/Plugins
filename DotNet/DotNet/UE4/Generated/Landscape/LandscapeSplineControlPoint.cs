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
    ///<summary>Landscape Spline Control Point</summary>
    public unsafe partial class LandscapeSplineControlPoint : UObject  {
        ///<summary>Location in Landscape-space</summary>
        public unsafe Vector Location {
            get {return LandscapeSplineControlPoint_ptr->Location;}
            set {LandscapeSplineControlPoint_ptr->Location = value;}
        }
        ///<summary>Rotation of tangent vector at this point (in landscape-space)</summary>
        public unsafe Rotator Rotation {
            get {return LandscapeSplineControlPoint_ptr->Rotation;}
            set {LandscapeSplineControlPoint_ptr->Rotation = value;}
        }
        ///<summary>Width of the spline at this point.</summary>
        public unsafe float Width {
            get {return LandscapeSplineControlPoint_ptr->Width;}
            set {LandscapeSplineControlPoint_ptr->Width = value;}
        }
        ///<summary>Falloff at the sides of the spline at this point.</summary>
        public unsafe float SideFalloff {
            get {return LandscapeSplineControlPoint_ptr->SideFalloff;}
            set {LandscapeSplineControlPoint_ptr->SideFalloff = value;}
        }
        ///<summary>Falloff at the start/end of the spline (if this point is a start or end point, otherwise ignored).</summary>
        public unsafe float EndFalloff {
            get {return LandscapeSplineControlPoint_ptr->EndFalloff;}
            set {LandscapeSplineControlPoint_ptr->EndFalloff = value;}
        }
        ///<summary>Vertical offset of the spline segment mesh. Useful for a river's surface, among other things.</summary>
        public unsafe float SegmentMeshOffset {
            get {return LandscapeSplineControlPoint_ptr->SegmentMeshOffset;}
            set {LandscapeSplineControlPoint_ptr->SegmentMeshOffset = value;}
        }
        ///<summary>Name of blend layer to paint when applying spline to landscape</summary>
        ///<remarks>If "none", no layer is painted</remarks>
        public unsafe Name LayerName {
            get {return LandscapeSplineControlPoint_ptr->LayerName;}
            set {LandscapeSplineControlPoint_ptr->LayerName = value;}
        }
        public bool bRaiseTerrain {
            get {return Main.GetGetBoolPropertyByName(this, "bRaiseTerrain"); }
            set {Main.SetGetBoolPropertyByName(this, "bRaiseTerrain", value); }
        }
        public bool bLowerTerrain {
            get {return Main.GetGetBoolPropertyByName(this, "bLowerTerrain"); }
            set {Main.SetGetBoolPropertyByName(this, "bLowerTerrain", value); }
        }
        ///<summary>Mesh to use on the control point</summary>
        public unsafe StaticMesh Mesh {
            get {return LandscapeSplineControlPoint_ptr->Mesh;}
            set {LandscapeSplineControlPoint_ptr->Mesh = value;}
        }
        ///<summary>Overrides mesh's materials</summary>
        public ObjectArrayField<MaterialInterface> MaterialOverrides{ get {
            if(MaterialOverrides_store == null) MaterialOverrides_store = new ObjectArrayField<MaterialInterface> (&LandscapeSplineControlPoint_ptr->MaterialOverrides);
            return MaterialOverrides_store;
        } }
        private ObjectArrayField<MaterialInterface> MaterialOverrides_store;

        ///<summary>Scale of the control point mesh</summary>
        public unsafe Vector MeshScale {
            get {return LandscapeSplineControlPoint_ptr->MeshScale;}
            set {LandscapeSplineControlPoint_ptr->MeshScale = value;}
        }
        public bool bHiddenInGame {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenInGame"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenInGame", value); }
        }
        ///<summary>Name of the collision profile to use for this spline</summary>
        public unsafe Name CollisionProfileName {
            get {return LandscapeSplineControlPoint_ptr->CollisionProfileName;}
            set {LandscapeSplineControlPoint_ptr->CollisionProfileName = value;}
        }
        public bool bCastShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastShadow"); }
            set {Main.SetGetBoolPropertyByName(this, "bCastShadow", value); }
        }
        ///<summary>Max draw distance for the mesh used on this control point</summary>
        public unsafe float LDMaxDrawDistance {
            get {return LandscapeSplineControlPoint_ptr->LDMaxDrawDistance;}
            set {LandscapeSplineControlPoint_ptr->LDMaxDrawDistance = value;}
        }
        ///<summary>Translucent objects with a lower sort priority draw behind objects with a higher priority.</summary>
        ///<remarks>
        ///Translucent objects with the same priority are rendered from back-to-front based on their bounds origin.
        ///
        ///Ignored if the object is not translucent.  The default priority is zero.
        ///Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly.
        ///</remarks>
        public unsafe int TranslucencySortPriority {
            get {return LandscapeSplineControlPoint_ptr->TranslucencySortPriority;}
            set {LandscapeSplineControlPoint_ptr->TranslucencySortPriority = value;}
        }
        public bool bPlaceSplineMeshesInStreamingLevels {
            get {return Main.GetGetBoolPropertyByName(this, "bPlaceSplineMeshesInStreamingLevels"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlaceSplineMeshesInStreamingLevels", value); }
        }
        ///<summary>Mesh Collision Settings</summary>
        public unsafe BodyInstance BodyInstance {
            get {return LandscapeSplineControlPoint_ptr->BodyInstance;}
        }
        public bool bSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelected", value); }
        }
        public bool bNavDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bNavDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bNavDirty", value); }
        }
         //TODO: array not UObject TArray ConnectedSegments
         //TODO: array not UObject TArray Points
        ///<summary>Bounds of points</summary>
        public unsafe Box Bounds {
            get {return LandscapeSplineControlPoint_ptr->Bounds;}
            set {LandscapeSplineControlPoint_ptr->Bounds = value;}
        }
        ///<summary>Control point mesh</summary>
        public unsafe ControlPointMeshComponent LocalMeshComponent {
            get {return LandscapeSplineControlPoint_ptr->LocalMeshComponent;}
            set {LandscapeSplineControlPoint_ptr->LocalMeshComponent = value;}
        }
         //TODO: soft object TSoftObjectPtr<UWorld> ForeignWorld
        ///<summary>Key for tracking whether this segment has been modified relative to the mesh component stored in another streaming level</summary>
        public unsafe FGuid ModificationKey {
            get {return LandscapeSplineControlPoint_ptr->ModificationKey;}
            set {LandscapeSplineControlPoint_ptr->ModificationKey = value;}
        }
        static LandscapeSplineControlPoint() {
            StaticClass = Main.GetClass("LandscapeSplineControlPoint");
        }
        internal unsafe LandscapeSplineControlPoint_fields* LandscapeSplineControlPoint_ptr => (LandscapeSplineControlPoint_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeSplineControlPoint(IntPtr p) => UObject.Make<LandscapeSplineControlPoint>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeSplineControlPoint DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeSplineControlPoint New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
