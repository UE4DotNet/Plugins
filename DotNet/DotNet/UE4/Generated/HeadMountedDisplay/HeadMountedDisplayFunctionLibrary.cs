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
using UE4.Engine;

namespace UE4.HeadMountedDisplay {
    ///<summary>Head Mounted Display Function Library</summary>
    public unsafe partial class HeadMountedDisplayFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Called to calibrate the offset transform between an external tracking source and the internal tracking source
        ///(e.
        ///</summary>
        ///<remarks>
        ///g. mocap tracker to and HMD tracker).  This should be called once per session, or when the physical relationship
        ///between the external tracker and internal tracker changes (e.g. it was bumped or reattached).  After calibration,
        ///calling UpdateExternalTrackingPosition will try to correct the internal tracker to the calibrated offset to prevent
        ///drift between the two systems
        ///
        ///@param ExternalTrackingTransform              The transform in world-coordinates, of the reference marker of the external tracking system
        ///</remarks>
        public static void CalibrateExternalTrackingToHMD(Transform ExternalTrackingTransform)  => 
            HeadMountedDisplayFunctionLibrary_methods.CalibrateExternalTrackingToHMD_method.Invoke(ExternalTrackingTransform);

        ///<summary>Switches to/from using HMD and stereo rendering.</summary>
        ///<remarks>
        ///@param bEnable                       (in) 'true' to enable HMD / stereo; 'false' otherwise
        ///@return (Boolean)            True, if the request was successful.
        ///</remarks>
        public static bool EnableHMD(bool bEnable)  => 
            HeadMountedDisplayFunctionLibrary_methods.EnableHMD_method.Invoke(bEnable);

        ///<summary>Switches between low and full persistence modes.</summary>
        ///<remarks>
        ///@param bEnable                       (in) 'true' to enable low persistence mode; 'false' otherwise
        ///</remarks>
        public static void EnableLowPersistenceMode(bool bEnable)  => 
            HeadMountedDisplayFunctionLibrary_methods.EnableLowPersistenceMode_method.Invoke(bEnable);

        ///<summary>Cross XR-System query that will list all XR devices currently being tracked.</summary>
        ///<remarks>
        ///@param  SystemId             (Optional) Specifies an explicit system to poll devices from (use if you want only devices belonging to one explicit XR ecosystem, e.g. 'OculusHMD', or 'SteamVR')
        ///@param  DeviceType   Specifies the type of device to query for - defaults to 'Any' (meaning 'All').
        ///
        ///@return A list of device identifiers matching the query. Use these to query and operate on the device (e.g. through GetDevicePose, AddDeviceVisualizationComponent, etc.)
        ///</remarks>
        public static IReadOnlyCollection<XRDeviceId> EnumerateTrackedDevices(Name SystemId, EXRTrackedDeviceType DeviceType)  => 
            HeadMountedDisplayFunctionLibrary_methods.EnumerateTrackedDevices_method.Invoke(SystemId, DeviceType);

        ///<summary>Cross XR-System query that returns a specific device's tracked position and orientation (in tracking space).</summary>
        ///<remarks>
        ///@param  XRDeviceId                           Specifies the device you're querying for.
        ///@param  bIsTracked                           [out] Details if the specified device is tracked (i.e. should the rest of the outputs be used)
        ///@param  Orientation                          [out] Represents the device's current rotation - NOTE: this value is not late updated and will be behind the render thread
        ///@param  bHasPositionalTracking       [out] Details if the specified device has positional tracking (i.e. if the position output should be used)
        ///@param  Position                                     [out] Represents the device's current position - NOTE: this value is not late updated and will be behind the render thread
        ///</remarks>
        public static (bool, Rotator, bool, Vector) GetDevicePose(XRDeviceId XRDeviceId)  => 
            HeadMountedDisplayFunctionLibrary_methods.GetDevicePose_method.Invoke(XRDeviceId);

        ///<summary>Cross XR-System query that returns a specific device's position and orientation in world space.</summary>
        ///<remarks>
        ///@param  XRDeviceId                           Specifies the device you're querying for.
        ///@param  bIsTracked                           [out] Details if the specified device is tracked (i.e. should the rest of the outputs be used)
        ///@param  Orientation                          [out] Represents the device's current rotation - NOTE: this value is not late updated and will be behind the render thread
        ///@param  bHasPositionalTracking       [out] Details if the specified device has positional tracking (i.e. if the position output should be used)
        ///@param  Position                                     [out] Represents the device's current position - NOTE: this value is not late updated and will be behind the render thread
        ///</remarks>
        public static (bool, Rotator, bool, Vector) GetDeviceWorldPose(UObject WorldContext, XRDeviceId XRDeviceId)  => 
            HeadMountedDisplayFunctionLibrary_methods.GetDeviceWorldPose_method.Invoke(WorldContext, XRDeviceId);

        ///<summary>
        ///Returns the name of the device, so scripts can modify their behaviour appropriately
        ///@
        ///</summary>
        ///<remarks>return      FName specific to the currently active HMD device type.  "None" implies no device, "Unknown" implies a device with no description.</remarks>
        public static Name GetHMDDeviceName()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetHMDDeviceName_method.Invoke();

        ///<summary>Returns the worn state of the device.</summary>
        ///<remarks>
        ///@return       Unknown, Worn, NotWorn.  If the platform does not detect this it will always return Unknown.
        ///</remarks>
        public static byte GetHMDWornState()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetHMDWornState_method.Invoke();

        ///<summary>If the HMD has multiple positional tracking sensors, return a total number of them currently connected.</summary>
        public static int GetNumOfTrackingSensors()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetNumOfTrackingSensors_method.Invoke();

        ///<summary>Grabs the current orientation and position for the HMD.</summary>
        ///<remarks>
        ///If positional tracking is not available, DevicePosition will be a zero vector
        ///
        ///@param DeviceRotation        (out) The device's current rotation
        ///@param DevicePosition        (out) The device's current position, in its own tracking space
        ///</remarks>
        public static (Rotator, Vector) GetOrientationAndPosition()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetOrientationAndPosition_method.Invoke();

        ///<summary>Returns the current VR pixel density.</summary>
        ///<remarks>
        ///Pixel density sets the VR render
        ///target texture size as a factor of recommended texture size. The recommended
        ///texture size is the size that will result in no under sampling in most
        ///distorted area of the view when computing the final image to be displayed
        ///on the device by the runtime compositor.
        ///
        ///@return (float)      The pixel density to be used in VR mode.
        ///</remarks>
        public static float GetPixelDensity()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetPixelDensity_method.Invoke();

        ///<summary>If the HMD has a positional sensor, this will return the game-world location of it, as well as the parameters for the bounding region of tracking.</summary>
        ///<remarks>
        ///This allows an in-game representation of the legal positional tracking range.  All values will be zeroed if the sensor is not available or the HMD does not support it.
        ///
        ///@param Origin                        (out) Origin, in world-space, of the sensor
        ///@param Rotation                      (out) Rotation, in world-space, of the sensor
        ///@param HFOV                          (out) Field-of-view, horizontal, in degrees, of the valid tracking zone of the sensor
        ///@param VFOV                          (out) Field-of-view, vertical, in degrees, of the valid tracking zone of the sensor
        ///@param CameraDistance        (out) Nominal distance to sensor, in world-space
        ///@param NearPlane                     (out) Near plane distance of the tracking volume, in world-space
        ///@param FarPlane                      (out) Far plane distance of the tracking volume, in world-space
        ///</remarks>
        public static (Vector, Rotator, float, float, float, float, float) GetPositionalTrackingCameraParameters()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetPositionalTrackingCameraParameters_method.Invoke();

        ///<summary>Get Screen Percentage</summary>
        public static float GetScreenPercentage()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetScreenPercentage_method.Invoke();

        ///<summary>Returns current tracking origin type (eye level or floor level).</summary>
        public static byte GetTrackingOrigin()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetTrackingOrigin_method.Invoke();

        ///<summary>If the HMD has a positional sensor, this will return the game-world location of it, as well as the parameters for the bounding region of tracking.</summary>
        ///<remarks>
        ///This allows an in-game representation of the legal positional tracking range.  All values will be zeroed if the sensor is not available or the HMD does not support it.
        ///
        ///@param Index                         (in) Index of the tracking sensor to query
        ///@param Origin                        (out) Origin, in world-space, of the sensor
        ///@param Rotation                      (out) Rotation, in world-space, of the sensor
        ///@param LeftFOV                       (out) Field-of-view, left from center, in degrees, of the valid tracking zone of the sensor
        ///@param RightFOV                      (out) Field-of-view, right from center, in degrees, of the valid tracking zone of the sensor
        ///@param TopFOV                        (out) Field-of-view, top from center, in degrees, of the valid tracking zone of the sensor
        ///@param BottomFOV                     (out) Field-of-view, bottom from center, in degrees, of the valid tracking zone of the sensor
        ///@param Distance                      (out) Nominal distance to sensor, in world-space
        ///@param NearPlane                     (out) Near plane distance of the tracking volume, in world-space
        ///@param FarPlane                      (out) Far plane distance of the tracking volume, in world-space
        ///@param IsActive                      (out) True, if the query for the specified sensor succeeded.
        ///</remarks>
        public static (Vector, Rotator, float, float, float, float, float, float, float, bool) GetTrackingSensorParameters(int Index)  => 
            HeadMountedDisplayFunctionLibrary_methods.GetTrackingSensorParameters_method.Invoke(Index);

        ///<summary>Returns a transform that can be used to convert points from tracking space to world space.</summary>
        ///<remarks>Does NOT include the set WorldToMeters scale, as that is added in by the backing XR system to their tracking space poses.</remarks>
        public static Transform GetTrackingToWorldTransform(UObject WorldContext)  => 
            HeadMountedDisplayFunctionLibrary_methods.GetTrackingToWorldTransform_method.Invoke(WorldContext);

        ///<summary>Returns current state of VR focus.</summary>
        ///<remarks>
        ///@param bUseFocus             (out) if set to true, then this App does use VR focus.
        ///@param bHasFocus             (out) if set to true, then this App currently has VR focus.
        ///</remarks>
        public static (bool, bool) GetVRFocusState()  => 
            HeadMountedDisplayFunctionLibrary_methods.GetVRFocusState_method.Invoke();

        ///<summary>
        ///Returns the World to Meters scale, which corresponds to the scale of the world as perceived by the player
        ///@
        ///</summary>
        ///<remarks>return       How many Unreal units correspond to one meter in the real world</remarks>
        public static float GetWorldToMetersScale(UObject WorldContext)  => 
            HeadMountedDisplayFunctionLibrary_methods.GetWorldToMetersScale_method.Invoke(WorldContext);

        ///<summary>If the HMD supports positional tracking, whether or not we are currently being tracked</summary>
        public static bool HasValidTrackingPosition()  => 
            HeadMountedDisplayFunctionLibrary_methods.HasValidTrackingPosition_method.Invoke();

        ///<summary>Cross XR-System query that returns whether the specified device is tracked or not.</summary>
        ///<remarks>
        ///@param  XRDeviceId   Specifies the device you're querying for.
        ///</remarks>
        public static bool IsDeviceTracking(XRDeviceId XRDeviceId)  => 
            HeadMountedDisplayFunctionLibrary_methods.IsDeviceTracking_method.Invoke(XRDeviceId);

        ///<summary>Returns whether or not the HMD hardware is connected and ready to use.</summary>
        ///<remarks>
        ///It may or may not actually be in use.
        ///
        ///@return (Boolean)  status whether the HMD hardware is connected and ready to use.  It may or may not actually be in use.
        ///</remarks>
        public static bool IsHeadMountedDisplayConnected()  => 
            HeadMountedDisplayFunctionLibrary_methods.IsHeadMountedDisplayConnected_method.Invoke();

        ///<summary>Returns whether or not we are currently using the head mounted display.</summary>
        ///<remarks>
        ///@return (Boolean)  status of HMD
        ///</remarks>
        public static bool IsHeadMountedDisplayEnabled()  => 
            HeadMountedDisplayFunctionLibrary_methods.IsHeadMountedDisplayEnabled_method.Invoke();

        ///<summary>Returns true, if HMD is in low persistence mode. 'false' otherwise.</summary>
        public static bool IsInLowPersistenceMode()  => 
            HeadMountedDisplayFunctionLibrary_methods.IsInLowPersistenceMode_method.Invoke();

        ///<summary>Return true if spectator screen mode control is available.</summary>
        public static bool IsSpectatorScreenModeControllable()  => 
            HeadMountedDisplayFunctionLibrary_methods.IsSpectatorScreenModeControllable_method.Invoke();

        ///<summary>
        ///Resets orientation by setting roll and pitch to 0, assuming that current yaw is forward direction and assuming
        ///current position as a 'zero-point' (for positional tracking).
        ///</summary>
        ///<remarks>
        ///@param Yaw                           (in) the desired yaw to be set after orientation reset.
        ///@param Options                       (in) specifies either position, orientation or both should be reset.
        ///</remarks>
        public static void ResetOrientationAndPosition(float Yaw, byte Options)  => 
            HeadMountedDisplayFunctionLibrary_methods.ResetOrientationAndPosition_method.Invoke(Yaw, Options);

        ///<summary>Sets near and far clipping planes (NCP and FCP) for stereo rendering.</summary>
        ///<remarks>
        ///Similar to 'stereo ncp= fcp' console command, but NCP and FCP set by this
        ///call won't be saved in .ini file.
        ///
        ///@param Near                          (in) Near clipping plane, in centimeters
        ///@param Far                           (in) Far clipping plane, in centimeters
        ///</remarks>
        public static void SetClippingPlanes(float Near, float Far)  => 
            HeadMountedDisplayFunctionLibrary_methods.SetClippingPlanes_method.Invoke(Near, Far);

        ///<summary>Sets the social screen mode.</summary>
        ///<remarks>
        ///@param Mode                           (in) The social screen Mode.
        ///</remarks>
        public static void SetSpectatorScreenMode(ESpectatorScreenMode Mode)  => 
            HeadMountedDisplayFunctionLibrary_methods.SetSpectatorScreenMode_method.Invoke(Mode);

        ///<summary>Setup the layout for ESpectatorScreenMode::TexturePlusEye.</summary>
        ///<remarks>
        ///@param        EyeRectMin: min of screen rectangle the eye will be drawn in.  0-1 normalized.
        ///@param        EyeRectMax: max of screen rectangle the eye will be drawn in.  0-1 normalized.
        ///@param        TextureRectMin: min of screen rectangle the texture will be drawn in.  0-1 normalized.
        ///@param        TextureRectMax: max of screen rectangle the texture will be drawn in.  0-1 normalized.
        ///@param        bDrawEyeFirst: if true the eye is drawn before the texture, if false the reverse.
        ///@param        bClearBlack: if true the render target will be drawn black before either rect is drawn.
        ///</remarks>
        public static void SetSpectatorScreenModeTexturePlusEyeLayout(Vector2D EyeRectMin, Vector2D EyeRectMax, Vector2D TextureRectMin, Vector2D TextureRectMax, bool bDrawEyeFirst, bool bClearBlack, bool bUseAlpha)  => 
            HeadMountedDisplayFunctionLibrary_methods.SetSpectatorScreenModeTexturePlusEyeLayout_method.Invoke(EyeRectMin, EyeRectMax, TextureRectMin, TextureRectMax, bDrawEyeFirst, bClearBlack, bUseAlpha);

        ///<summary>
        ///Change the texture displayed on the social screen
        ///@
        ///</summary>
        ///<remarks>param        InTexture: new Texture2D</remarks>
        public static void SetSpectatorScreenTexture(Texture InTexture)  => 
            HeadMountedDisplayFunctionLibrary_methods.SetSpectatorScreenTexture_method.Invoke(InTexture);

        ///<summary>Sets current tracking origin type (eye level or floor level).</summary>
        public static void SetTrackingOrigin(byte Origin)  => 
            HeadMountedDisplayFunctionLibrary_methods.SetTrackingOrigin_method.Invoke(Origin);

        ///<summary>
        ///Sets the World to Meters scale, which changes the scale of the world as perceived by the player
        ///@
        ///</summary>
        ///<remarks>param NewScale       Specifies how many Unreal units correspond to one meter in the real world</remarks>
        public static void SetWorldToMetersScale(UObject WorldContext, float NewScale)  => 
            HeadMountedDisplayFunctionLibrary_methods.SetWorldToMetersScale_method.Invoke(WorldContext, NewScale);

        ///<summary>Called after calibration to attempt to pull the internal tracker (e.</summary>
        ///<remarks>
        ///g. HMD tracking) in line with the external tracker
        ///(e.g. mocap tracker).  This will set the internal tracker's base offset and rotation to match and realign the two systems.
        ///This can be called every tick, or whenever realignment is desired.  Note that this may cause choppy movement if the two
        ///systems diverge relative to each other, or a big jump if called infrequently when there has been significant drift
        ///
        ///@param ExternalTrackingTransform              The transform in world-coordinates, of the reference marker of the external tracking system
        ///</remarks>
        public static void UpdateExternalTrackingHMDPosition(Transform ExternalTrackingTransform)  => 
            HeadMountedDisplayFunctionLibrary_methods.UpdateExternalTrackingHMDPosition_method.Invoke(ExternalTrackingTransform);
        static HeadMountedDisplayFunctionLibrary() {
            StaticClass = Main.GetClass("HeadMountedDisplayFunctionLibrary");
        }
        internal unsafe HeadMountedDisplayFunctionLibrary_fields* HeadMountedDisplayFunctionLibrary_ptr => (HeadMountedDisplayFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HeadMountedDisplayFunctionLibrary(IntPtr p) => UObject.Make<HeadMountedDisplayFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HeadMountedDisplayFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HeadMountedDisplayFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
