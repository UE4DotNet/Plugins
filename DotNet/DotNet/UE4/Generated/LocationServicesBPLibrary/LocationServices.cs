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
using UE4.LocationServicesBPLibrary.Native;
using UE4.Engine;

namespace UE4.LocationServicesBPLibrary {
    ///<summary>Location Services</summary>
    public unsafe partial class LocationServices : BlueprintFunctionLibrary  {

        ///<summary>
        ///Checks if the Location Services on the mobile device are enabled for this application
        ///@
        ///</summary>
        ///<remarks>return - true if the mobile device has enabled the appropriate service for the app</remarks>
        public static bool AreLocationServicesEnabled()  => 
            LocationServices_methods.AreLocationServicesEnabled_method.Invoke();

        ///<summary>Returns the last location information returned by the location service.</summary>
        ///<remarks>
        ///If no location update has been made, will return
        ///a default-value-filled struct.
        ///@return - the last known location from updates
        ///</remarks>
        public static LocationServicesData GetLastKnownLocation()  => 
            LocationServices_methods.GetLastKnownLocation_method.Invoke();

        ///<summary>* Returns the Location Services implementation object.</summary>
        ///<remarks>
        ///Intended to be used to set up the FLocationServicesData_OnLocationChanged
        ///* delegate in Blueprints.
        ///* @return - the Android or IOS impl object
        ///</remarks>
        public static LocationServicesImpl GetLocationServicesImpl()  => 
            LocationServices_methods.GetLocationServicesImpl_method.Invoke();

        ///<summary>
        ///Called to set up the Location Service before use
        ///@
        ///</summary>
        ///<remarks>
        ///param Accuracy - as seen in the enum above
        ///@param UpdateFrequency - in milliseconds. (Android only)
        ///@param MinDistance - minDistance before a location update, in meters. 0 here means "update asap"
        ///@return - true if Initialization was succesful
        ///</remarks>
        public static bool InitLocationServices(ELocationAccuracy Accuracy, float UpdateFrequency, float MinDistanceFilter)  => 
            LocationServices_methods.InitLocationServices_method.Invoke(Accuracy, UpdateFrequency, MinDistanceFilter);

        ///<summary>Checks if the supplied Accuracy is available on the current device.</summary>
        ///<remarks>
        ///@param Accuracy - the accuracy to check
        ///@return - true if the mobile device can support the Accuracy, false if it will use a different accuracy
        ///</remarks>
        public static bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy)  => 
            LocationServices_methods.IsLocationAccuracyAvailable_method.Invoke(Accuracy);

        ///<summary>
        ///Starts requesting location updates from the appropriate Location Service
        ///@
        ///</summary>
        ///<remarks>return - true if startup successful</remarks>
        public static bool StartLocationServices()  => 
            LocationServices_methods.StartLocationServices_method.Invoke();

        ///<summary>
        ///Stops the updates of location from the Location Service that was started with StartLocationService
        ///@
        ///</summary>
        ///<remarks>return - true if stop is successful</remarks>
        public static bool StopLocationServices()  => 
            LocationServices_methods.StopLocationServices_method.Invoke();
        static LocationServices() {
            StaticClass = Main.GetClass("LocationServices");
        }
        internal unsafe LocationServices_fields* LocationServices_ptr => (LocationServices_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LocationServices(IntPtr p) => UObject.Make<LocationServices>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LocationServices DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LocationServices New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
