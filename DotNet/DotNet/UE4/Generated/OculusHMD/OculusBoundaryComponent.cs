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
using UE4.OculusHMD.Native;
using UE4.Engine;

namespace UE4.OculusHMD {
    ///<summary>Oculus Boundary Component</summary>
    public unsafe partial class OculusBoundaryComponent : ActorComponent  {

        ///<summary>@</summary>
        ///<remarks>
        ///param Point is 3D point in Unreal world coordinate space
        ///@return Information about distance from outer boundary, whether the boundary is triggered, etc.
        ///</remarks>
        public BoundaryTestResult CheckIfPointWithinOuterBounds(Vector Point)  => 
            OculusBoundaryComponent_methods.CheckIfPointWithinOuterBounds_method.Invoke(ObjPointer, Point);

        ///<summary>@</summary>
        ///<remarks>
        ///param Point is 3D point in Unreal world coordinate space
        ///@return Information about distance from play area boundary, whether the boundary is triggered, etc.
        ///</remarks>
        public BoundaryTestResult CheckIfPointWithinPlayArea(Vector Point)  => 
            OculusBoundaryComponent_methods.CheckIfPointWithinPlayArea_method.Invoke(ObjPointer, Point);

        ///<summary>@return Vector of outer boundary's axis aligned dimensions (width, height, length) in Unreal world coordinate space</summary>
        public Vector GetOuterBoundaryDimensions()  => 
            OculusBoundaryComponent_methods.GetOuterBoundaryDimensions_method.Invoke(ObjPointer);

        ///<summary>@</summary>
        ///<remarks>
        ///return Array of 3D points (clockwise order) defining outer boundary at floor height.
        ///Points are returned in Unreal world coordinate space.
        ///</remarks>
        public IReadOnlyCollection<Vector> GetOuterBoundaryPoints()  => 
            OculusBoundaryComponent_methods.GetOuterBoundaryPoints_method.Invoke(ObjPointer);

        ///<summary>@return Vector of play area's axis aligned dimensions (width, height, length) in Unreal world coordinate space</summary>
        public Vector GetPlayAreaDimensions()  => 
            OculusBoundaryComponent_methods.GetPlayAreaDimensions_method.Invoke(ObjPointer);

        ///<summary>@</summary>
        ///<remarks>
        ///return Array of 3D points (clockwise order) defining play area at floor height
        ///Points are returned in Unreal world coordinate space.
        ///</remarks>
        public IReadOnlyCollection<Vector> GetPlayAreaPoints()  => 
            OculusBoundaryComponent_methods.GetPlayAreaPoints_method.Invoke(ObjPointer);

        ///<summary>Getter for OuterBoundsInteractionList, an array of FBoundaryTestResults with info about interactions between outer boundary and devices triggering it.</summary>
        ///<remarks>
        ///Should only be called when outer boundary is being triggered. Otherwise, will return empty TArray.
        ///@return TArray of structs containing information about device/outer boundary interactions for each device triggering outer boundary
        ///</remarks>
        public IReadOnlyCollection<BoundaryTestResult> GetTriggeredOuterBoundaryInfo()  => 
            OculusBoundaryComponent_methods.GetTriggeredOuterBoundaryInfo_method.Invoke(ObjPointer);

        ///<summary>
        ///Tests for interaction between DeviceType and EBoundaryType::PlayArea
        ///@
        ///</summary>
        ///<remarks>return BoundaryTestResult struct containing information about device/play area interaction</remarks>
        public BoundaryTestResult GetTriggeredPlayAreaInfo(ETrackedDeviceType DeviceType)  => 
            OculusBoundaryComponent_methods.GetTriggeredPlayAreaInfo_method.Invoke(ObjPointer, DeviceType);

        ///<summary>@return true if outer boundary is currently displayed, i.e., Boundary System is triggered, application has sucessfully requested visible boundaries, or user has forced boundaries on</summary>
        public bool IsOuterBoundaryDisplayed()  => 
            OculusBoundaryComponent_methods.IsOuterBoundaryDisplayed_method.Invoke(ObjPointer);

        ///<summary>@return true only if Boundary System (outer boundary) is actually being triggered by a tracked device</summary>
        public bool IsOuterBoundaryTriggered()  => 
            OculusBoundaryComponent_methods.IsOuterBoundaryTriggered_method.Invoke(ObjPointer);

        ///<summary>Request that boundary system (outer boundary) become visible or cancel a previous request.</summary>
        ///<remarks>
        ///Can be overridden by boundary
        ///system or by user. Application cannot force outer boundaries to be invisible.
        ///@param BoundaryVisible: true to request outer boundaries be visible, false to cancel such a request
        ///@return true on success, false otherwise
        ///</remarks>
        public bool RequestOuterBoundaryVisible(bool BoundaryVisible)  => 
            OculusBoundaryComponent_methods.RequestOuterBoundaryVisible_method.Invoke(ObjPointer, BoundaryVisible);

        ///<summary>
        ///Restores the default color of the outer boundary walls
        ///@
        ///</summary>
        ///<remarks>return true on success, false on failure</remarks>
        public bool ResetOuterBoundaryColor()  => 
            OculusBoundaryComponent_methods.ResetOuterBoundaryColor_method.Invoke(ObjPointer);

        ///<summary>
        ///Sets the RGB color of the outer boundary walls that are displayed automatically when HMD or
        ///Touch controllers near edges of tracking space or when RequestBoundaryVisible(true) is called.
        ///</summary>
        ///<remarks>
        ///@param InBoundaryColor is desired boundary color. Alpha value is ignored by LibOVR
        ///@return true if setting color succeeded
        ///</remarks>
        public bool SetOuterBoundaryColor(Color InBoundaryColor)  => 
            OculusBoundaryComponent_methods.SetOuterBoundaryColor_method.Invoke(ObjPointer, InBoundaryColor);
         //TODO: multicast delegate FOculusOuterBoundaryTriggeredEvent OnOuterBoundaryTriggered
         //TODO: multicast delegate FOculusOuterBoundaryReturnedEvent OnOuterBoundaryReturned
        static OculusBoundaryComponent() {
            StaticClass = Main.GetClass("OculusBoundaryComponent");
        }
        internal unsafe OculusBoundaryComponent_fields* OculusBoundaryComponent_ptr => (OculusBoundaryComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OculusBoundaryComponent(IntPtr p) => UObject.Make<OculusBoundaryComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OculusBoundaryComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OculusBoundaryComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
