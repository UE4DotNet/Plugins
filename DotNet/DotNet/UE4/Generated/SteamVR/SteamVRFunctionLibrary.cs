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
using UE4.SteamVR.Native;
using UE4.InputCore;
using UE4.Engine;

namespace UE4.SteamVR {
    ///<summary>SteamVR Extensions Function Library</summary>
    public unsafe partial class SteamVRFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Given a controller index and a hand, returns the position and orientation of the controller
        ///@
        ///</summary>
        ///<remarks>
        ///param       ControllerIndex Index of the controller to get the tracked device ID for
        ///@param       Hand                    Which hand's controller to get the position and orientation for
        ///@param       OutPosition             (out) Current position of the device
        ///@param       OutRotation             (out) Current rotation of the device
        ///@return      True if the specified controller index has a valid tracked device ID
        ///</remarks>
        public static (Vector, Rotator, bool) GetHandPositionAndOrientation(int ControllerIndex, EControllerHand Hand)  => 
            SteamVRFunctionLibrary_methods.GetHandPositionAndOrientation_method.Invoke(ControllerIndex, Hand);

        ///<summary>
        ///Gets the orientation and position (in device space) of the device with the specified ID
        ///@
        ///</summary>
        ///<remarks>
        ///param       DeviceId                Id of the device to get tracking info for
        ///@param       OutPosition             (out) Current position of the device
        ///@param       OutOrientation  (out) Current orientation of the device
        ///@return      True if the specified device id had a valid tracking pose this frame, false otherwise
        ///</remarks>
        public static (Vector, Rotator, bool) GetTrackedDevicePositionAndOrientation(int DeviceId)  => 
            SteamVRFunctionLibrary_methods.GetTrackedDevicePositionAndOrientation_method.Invoke(DeviceId);

        ///<summary>
        ///Returns an array of the currently tracked device IDs
        ///@
        ///</summary>
        ///<remarks>
        ///param       DeviceType      Which class of device (e.g. controller, tracking devices) to get Device Ids for
        ///@param       OutTrackedDeviceIds     (out) Array containing the ID of each device that's currently tracked
        ///</remarks>
        public static IReadOnlyCollection<int> GetValidTrackedDeviceIds(ESteamVRTrackedDeviceType DeviceType)  => 
            SteamVRFunctionLibrary_methods.GetValidTrackedDeviceIds_method.Invoke(DeviceType);
        static SteamVRFunctionLibrary() {
            StaticClass = Main.GetClass("SteamVRFunctionLibrary");
        }
        internal unsafe SteamVRFunctionLibrary_fields* SteamVRFunctionLibrary_ptr => (SteamVRFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SteamVRFunctionLibrary(IntPtr p) => UObject.Make<SteamVRFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SteamVRFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SteamVRFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
