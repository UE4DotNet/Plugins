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
using UE4.MagicLeap.Native;
using UE4.Engine;

namespace UE4.MagicLeap {
    ///<summary>The PlanesComponent class manages requests for planes, processes the results and provides them to the calling system.</summary>
    ///<remarks>
    ///The calling system is able request planes within a specified area.  Various other search criteria can be set via this
    ///class's public properties.  Planes requests are processed on a separate thread.  Once a planes request has been processed
    ///the calling system will be notified via an FPlaneResultDelegate broadcast.
    ///</remarks>
    public unsafe partial class PlanesComponent : SceneComponent  {

        ///<summary>Requests planes with the current value of QueryFlags, SearchVolume and MaxResults.</summary>
        ///<remarks>
        ///@param UserData User data for this request. The same data will be included in the result for query identification.
        ///@param ResultDelegate Delegate which will be called when the planes result is ready.
        ///@returns True if the planes query was successfully placed, false otherwise.
        ///</remarks>
        public bool RequestPlanes(int UserData, byte ResultDelegate /*TODO: delegate FPlaneResultDelegate */)  => 
            PlanesComponent_methods.RequestPlanes_method.Invoke(ObjPointer, UserData, ResultDelegate);
         //TODO: array not UObject TArray QueryFlags
        ///<summary>Bounding box for searching planes in.</summary>
        public unsafe BoxComponent SearchVolume {
            get {return PlanesComponent_ptr->SearchVolume;}
            set {PlanesComponent_ptr->SearchVolume = value;}
        }
        ///<summary>The maximum number of planes that should be returned in the result.</summary>
        public unsafe int MaxResults {
            get {return PlanesComponent_ptr->MaxResults;}
            set {PlanesComponent_ptr->MaxResults = value;}
        }
        ///<summary>
        ///If EPlaneQueryFlags::IgnoreHoles is not a query flag then holes with a perimeter (in Unreal Units)
        ///smaller than this value will be ignored, and can be part of the plane.
        ///</summary>
        public unsafe float MinHolePerimeter {
            get {return PlanesComponent_ptr->MinHolePerimeter;}
            set {PlanesComponent_ptr->MinHolePerimeter = value;}
        }
        ///<summary>The minimum area (in squared Unreal Units) of planes to be returned.</summary>
        ///<remarks>This value cannot be lower than 400 (lower values will be capped to this minimum).</remarks>
        public unsafe float MinPlaneArea {
            get {return PlanesComponent_ptr->MinPlaneArea;}
            set {PlanesComponent_ptr->MinPlaneArea = value;}
        }
        public bool IgnoreBoundingVolume {
            get {return Main.GetGetBoolPropertyByName(this, "IgnoreBoundingVolume"); }
            set {Main.SetGetBoolPropertyByName(this, "IgnoreBoundingVolume", value); }
        }
        static PlanesComponent() {
            StaticClass = Main.GetClass("PlanesComponent");
        }
        internal unsafe PlanesComponent_fields* PlanesComponent_ptr => (PlanesComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlanesComponent(IntPtr p) => UObject.Make<PlanesComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlanesComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlanesComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
