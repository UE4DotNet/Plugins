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
    ///<summary>Landscape Spline Segment</summary>
    public unsafe partial class LandscapeSplineSegment : UObject  {
        ///<summary>Directly editable data:</summary>
        public unsafe LandscapeSplineSegmentConnection Connections {
            get {return LandscapeSplineSegment_ptr->Connections;}
            set {LandscapeSplineSegment_ptr->Connections = value;}
        }
        ///<summary>Name of blend layer to paint when applying spline to landscape</summary>
        ///<remarks>If "none", no layer is painted</remarks>
        public unsafe Name LayerName {
            get {return LandscapeSplineSegment_ptr->LayerName;}
            set {LandscapeSplineSegment_ptr->LayerName = value;}
        }
        public bool bRaiseTerrain {
            get {return Main.GetGetBoolPropertyByName(this, "bRaiseTerrain"); }
            set {Main.SetGetBoolPropertyByName(this, "bRaiseTerrain", value); }
        }
        public bool bLowerTerrain {
            get {return Main.GetGetBoolPropertyByName(this, "bLowerTerrain"); }
            set {Main.SetGetBoolPropertyByName(this, "bLowerTerrain", value); }
        }
         //TODO: array not UObject TArray SplineMeshes
        ///<summary>
        ///Name of the collision profile to use for this spline //
        ///// TODO: This field does not have proper Slate customization.
        ///</summary>
        ///<remarks>
        ///// Instead of a text field, this should be a dropdown with the
        ///// default option.
        /////
        ///</remarks>
        public unsafe Name CollisionProfileName {
            get {return LandscapeSplineSegment_ptr->CollisionProfileName;}
            set {LandscapeSplineSegment_ptr->CollisionProfileName = value;}
        }
        public bool bCastShadow {
            get {return Main.GetGetBoolPropertyByName(this, "bCastShadow"); }
            set {Main.SetGetBoolPropertyByName(this, "bCastShadow", value); }
        }
        ///<summary>Random seed used for choosing which order to use spline meshes. Ignored if only one mesh is set.</summary>
        public unsafe int RandomSeed {
            get {return LandscapeSplineSegment_ptr->RandomSeed;}
            set {LandscapeSplineSegment_ptr->RandomSeed = value;}
        }
        ///<summary>Max draw distance for all the mesh pieces used in this spline</summary>
        public unsafe float LDMaxDrawDistance {
            get {return LandscapeSplineSegment_ptr->LDMaxDrawDistance;}
            set {LandscapeSplineSegment_ptr->LDMaxDrawDistance = value;}
        }
        ///<summary>Translucent objects with a lower sort priority draw behind objects with a higher priority.</summary>
        ///<remarks>
        ///Translucent objects with the same priority are rendered from back-to-front based on their bounds origin.
        ///
        ///Ignored if the object is not translucent.  The default priority is zero.
        ///Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly.
        ///</remarks>
        public unsafe int TranslucencySortPriority {
            get {return LandscapeSplineSegment_ptr->TranslucencySortPriority;}
            set {LandscapeSplineSegment_ptr->TranslucencySortPriority = value;}
        }
        public bool bHiddenInGame {
            get {return Main.GetGetBoolPropertyByName(this, "bHiddenInGame"); }
            set {Main.SetGetBoolPropertyByName(this, "bHiddenInGame", value); }
        }
        public bool bPlaceSplineMeshesInStreamingLevels {
            get {return Main.GetGetBoolPropertyByName(this, "bPlaceSplineMeshesInStreamingLevels"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlaceSplineMeshesInStreamingLevels", value); }
        }
        ///<summary>Mesh Collision Settings</summary>
        public unsafe BodyInstance BodyInstance {
            get {return LandscapeSplineSegment_ptr->BodyInstance;}
        }
        public bool bSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bSelected", value); }
        }
        public bool bNavDirty {
            get {return Main.GetGetBoolPropertyByName(this, "bNavDirty"); }
            set {Main.SetGetBoolPropertyByName(this, "bNavDirty", value); }
        }
        ///<summary>Actual data for spline.</summary>
        public unsafe InterpCurveVector SplineInfo {
            get {return LandscapeSplineSegment_ptr->SplineInfo;}
            set {LandscapeSplineSegment_ptr->SplineInfo = value;}
        }
         //TODO: array not UObject TArray Points
        ///<summary>Bounds of points</summary>
        public unsafe Box Bounds {
            get {return LandscapeSplineSegment_ptr->Bounds;}
            set {LandscapeSplineSegment_ptr->Bounds = value;}
        }
        ///<summary>Spline meshes</summary>
        public ObjectArrayField<SplineMeshComponent> LocalMeshComponents{ get {
            if(LocalMeshComponents_store == null) LocalMeshComponents_store = new ObjectArrayField<SplineMeshComponent> (&LandscapeSplineSegment_ptr->LocalMeshComponents);
            return LocalMeshComponents_store;
        } }
        private ObjectArrayField<SplineMeshComponent> LocalMeshComponents_store;

         //TODO: array not UObject TArray ForeignWorlds
        ///<summary>Key for tracking whether this segment has been modified relative to the mesh components stored in other streaming levels</summary>
        public unsafe FGuid ModificationKey {
            get {return LandscapeSplineSegment_ptr->ModificationKey;}
            set {LandscapeSplineSegment_ptr->ModificationKey = value;}
        }
        static LandscapeSplineSegment() {
            StaticClass = Main.GetClass("LandscapeSplineSegment");
        }
        internal unsafe LandscapeSplineSegment_fields* LandscapeSplineSegment_ptr => (LandscapeSplineSegment_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeSplineSegment(IntPtr p) => UObject.Make<LandscapeSplineSegment>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeSplineSegment DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeSplineSegment New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
