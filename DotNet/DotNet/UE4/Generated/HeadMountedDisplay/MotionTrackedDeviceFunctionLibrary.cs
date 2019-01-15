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
using UE4.HeadMountedDisplay.Native;
using UE4.InputCore;
using UE4.Engine;

namespace UE4.HeadMountedDisplay {
    ///<summary>Motion Tracked Device Function Library</summary>
    public unsafe partial class MotionTrackedDeviceFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Disable tracking of the specified controller, by player index and tracked device type.</summary>
        ///<remarks>
        ///@param MotionControllerComponent              (in) The motion controller component who's associated device is targeted.
        ///</remarks>
        public static void DisableMotionTrackingForComponent(MotionControllerComponent MotionControllerComponent)  => 
            MotionTrackedDeviceFunctionLibrary_methods.DisableMotionTrackingForComponent_method.Invoke(MotionControllerComponent);

        ///<summary>Disable tracking for all controllers.</summary>
        public static void DisableMotionTrackingOfAllControllers()  => 
            MotionTrackedDeviceFunctionLibrary_methods.DisableMotionTrackingOfAllControllers_method.Invoke();

        ///<summary>Disable tracking for all controllers associated with the specified player.</summary>
        ///<remarks>
        ///@param PlayerIndex                                    (in) The index of the player.
        ///</remarks>
        public static void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex)  => 
            MotionTrackedDeviceFunctionLibrary_methods.DisableMotionTrackingOfControllersForPlayer_method.Invoke(PlayerIndex);

        ///<summary>Disable tracking of the specified controller, by player index and tracked device type.</summary>
        ///<remarks>
        ///@param PlayerIndex                                   (in) The index of the player.
        ///@param Hand                                                  (in) The tracked device type.
        ///</remarks>
        public static void DisableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand)  => 
            MotionTrackedDeviceFunctionLibrary_methods.DisableMotionTrackingOfDevice_method.Invoke(PlayerIndex, Hand);

        ///<summary>Disable tracking of the specified controller, by player index and tracked device type.</summary>
        ///<remarks>
        ///@param PlayerIndex                                   (in) The index of the player.
        ///@param SourceName                                    (in) The tracked device id.
        ///</remarks>
        public static void DisableMotionTrackingOfSource(int PlayerIndex, Name SourceName)  => 
            MotionTrackedDeviceFunctionLibrary_methods.DisableMotionTrackingOfSource_method.Invoke(PlayerIndex, SourceName);

        ///<summary>Enable tracking of the specified controller, by player index and tracked device type.</summary>
        ///<remarks>
        ///@param MotionControllerComponent              (in) The motion controller component who's associated device is targeted.
        ///
        ///@return (Boolean) true if the specified device is now set to be tracked.  This could fail due to tracking limits, or on invalid input.
        ///</remarks>
        public static bool EnableMotionTrackingForComponent(MotionControllerComponent MotionControllerComponent)  => 
            MotionTrackedDeviceFunctionLibrary_methods.EnableMotionTrackingForComponent_method.Invoke(MotionControllerComponent);

        ///<summary>Enable tracking of the specified controller, by player index and tracked device type.</summary>
        ///<remarks>
        ///@param PlayerIndex                                   (in) The index of the player.
        ///@param Hand                                                  (in) The device type.
        ///
        ///@return (Boolean) true if the specified device is now set to be tracked.  This could fail due to tracking limits, or on invalid input.
        ///</remarks>
        public static bool EnableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand)  => 
            MotionTrackedDeviceFunctionLibrary_methods.EnableMotionTrackingOfDevice_method.Invoke(PlayerIndex, Hand);

        ///<summary>Enable tracking of the specified controller, by player index and tracked device type.</summary>
        ///<remarks>
        ///@param PlayerIndex                                   (in) The index of the player.
        ///@param SourceName                                    (in) The device id.
        ///
        ///@return (Boolean) true if the specified device is now set to be tracked.  This could fail due to tracking limits, or on invalid input.
        ///</remarks>
        public static bool EnableMotionTrackingOfSource(int PlayerIndex, Name SourceName)  => 
            MotionTrackedDeviceFunctionLibrary_methods.EnableMotionTrackingOfSource_method.Invoke(PlayerIndex, SourceName);

        ///<summary>
        ///Returns a list of all available motion sources (FNames associated with
        ///discrete tracking data that can be used to drive MotionControllerComponents).
        ///</summary>
        public static IReadOnlyCollection<Name> EnumerateMotionSources()  => 
            MotionTrackedDeviceFunctionLibrary_methods.EnumerateMotionSources_method.Invoke();

        ///<summary>Returns the system name used to distinguish the current tracking system.</summary>
        ///<remarks>If no XR tracking system is active, then the name 'None' is returned.</remarks>
        public static Name GetActiveTrackingSystemName()  => 
            MotionTrackedDeviceFunctionLibrary_methods.GetActiveTrackingSystemName_method.Invoke();

        ///<summary>Get the maximum number of controllers that can be tracked.</summary>
        ///<remarks>
        ///@return (int) number of controllers that can be tracked, or -1 if there is no limit (IsMotionTrackedDeviceCountManagementNecessary() should return false).
        ///</remarks>
        public static int GetMaximumMotionTrackedControllerCount()  => 
            MotionTrackedDeviceFunctionLibrary_methods.GetMaximumMotionTrackedControllerCount_method.Invoke();

        ///<summary>Get the number of controllers for which tracking is enabled.</summary>
        ///<remarks>
        ///@return (int) number of controllers tracked now, or -1 if this query is unsupported (IsMotionTrackedDeviceCountManagementNecessary() should return false).
        ///</remarks>
        public static int GetMotionTrackingEnabledControllerCount()  => 
            MotionTrackedDeviceFunctionLibrary_methods.GetMotionTrackingEnabledControllerCount_method.Invoke();

        ///<summary>Queries the specified source's tracking status and returns true if it has tracking.</summary>
        ///<remarks>
        ///@return Tracking status of the specified controller.
        ///</remarks>
        public static bool IsMotionSourceTracking(int PlayerIndex, Name SourceName)  => 
            MotionTrackedDeviceFunctionLibrary_methods.IsMotionSourceTracking_method.Invoke(PlayerIndex, SourceName);

        ///<summary>Returns true if it is necessary for the game to manage how many motion tracked devices it is asking to be tracked simultaneously.</summary>
        ///<remarks>
        ///On some platforms this is unnecessary because all supported devices can be tracked simultaneously.
        ///
        ///@return (Boolean) true if the game might need to manage which motion tracked devices are actively tracked.
        ///</remarks>
        public static bool IsMotionTrackedDeviceCountManagementNecessary()  => 
            MotionTrackedDeviceFunctionLibrary_methods.IsMotionTrackedDeviceCountManagementNecessary_method.Invoke();

        ///<summary>Returns true if tracking is enabled for the specified device.</summary>
        ///<remarks>
        ///@param MotionControllerComponent              (in) The motion controller component who's associated device is targeted.
        ///
        ///@return (Boolean) true if the specified device is set to be tracked.
        ///</remarks>
        public static bool IsMotionTrackingEnabledForComponent(MotionControllerComponent MotionControllerComponent)  => 
            MotionTrackedDeviceFunctionLibrary_methods.IsMotionTrackingEnabledForComponent_method.Invoke(MotionControllerComponent);

        ///<summary>Returns true if tracking is enabled for the specified device.</summary>
        ///<remarks>
        ///@param PlayerIndex                                   (in) The index of the player.
        ///@param Hand                                                  (in) The tracked device type.
        ///
        ///@return (Boolean) true if the specified device is set to be tracked.
        ///</remarks>
        public static bool IsMotionTrackingEnabledForDevice(int PlayerIndex, EControllerHand Hand)  => 
            MotionTrackedDeviceFunctionLibrary_methods.IsMotionTrackingEnabledForDevice_method.Invoke(PlayerIndex, Hand);

        ///<summary>Returns true if tracking is enabled for the specified device.</summary>
        ///<remarks>
        ///@param PlayerIndex                                   (in) The index of the player.
        ///@param SourceName                                    (in) The tracked device id.
        ///
        ///@return (Boolean) true if the specified device is set to be tracked.
        ///</remarks>
        public static bool IsMotionTrackingEnabledForSource(int PlayerIndex, Name SourceName)  => 
            MotionTrackedDeviceFunctionLibrary_methods.IsMotionTrackingEnabledForSource_method.Invoke(PlayerIndex, SourceName);

        ///<summary>Set whether motion tracked controllers activate on creation by default, or do not and must be explicitly activated.</summary>
        ///<remarks>
        ///@param Require                                        (in) True means controllers are enabled by default.  Enables beyond the controller count limit will fail.
        ///</remarks>
        public static void SetIsControllerMotionTrackingEnabledByDefault(bool Enable)  => 
            MotionTrackedDeviceFunctionLibrary_methods.SetIsControllerMotionTrackingEnabledByDefault_method.Invoke(Enable);
        static MotionTrackedDeviceFunctionLibrary() {
            StaticClass = Main.GetClass("MotionTrackedDeviceFunctionLibrary");
        }
        internal unsafe MotionTrackedDeviceFunctionLibrary_fields* MotionTrackedDeviceFunctionLibrary_ptr => (MotionTrackedDeviceFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MotionTrackedDeviceFunctionLibrary(IntPtr p) => UObject.Make<MotionTrackedDeviceFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MotionTrackedDeviceFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MotionTrackedDeviceFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
