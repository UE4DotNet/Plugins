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
    ///<summary>Oculus Function Library</summary>
    public unsafe partial class OculusFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Adds loading splash screen with parameters
        ///@
        ///</summary>
        ///<remarks>
        ///param Texture                       (in) A texture asset to be used for the splash. Gear VR uses it as a path for loading icon; all other params are currently ignored by Gear VR.
        ///@param TranslationInMeters (in) Initial translation of the center of the splash screen (in meters).
        ///@param Rotation                      (in) Initial rotation of the splash screen, with the origin at the center of the splash screen.
        ///@param SizeInMeters          (in) Size, in meters, of the quad with the splash screen.
        ///@param DeltaRotation         (in) Incremental rotation, that is added each 2nd frame to the quad transform. The quad is rotated around the center of the quad.
        ///@param bClearBeforeAdd       (in) If true, clears splashes before adding a new one.
        ///</remarks>
        public static void AddLoadingSplashScreen(Texture2D Texture, Vector TranslationInMeters, Rotator Rotation, Vector2D SizeInMeters, Rotator DeltaRotation, bool bClearBeforeAdd)  => 
            OculusFunctionLibrary_methods.AddLoadingSplashScreen_method.Invoke(Texture, TranslationInMeters, Rotation, SizeInMeters, DeltaRotation, bClearBeforeAdd);

        ///<summary>Removes all the splash screens.</summary>
        public static void ClearLoadingSplashScreens()  => 
            OculusFunctionLibrary_methods.ClearLoadingSplashScreens_method.Invoke();

        ///<summary>Enables/disables splash screen to be automatically shown when LoadMap is called.</summary>
        ///<remarks>
        ///@param       bAutoShowEnabled        (in)    True, if automatic showing of splash screens is enabled when map is being loaded.
        ///</remarks>
        public static void EnableAutoLoadingSplashScreen(bool bAutoShowEnabled)  => 
            OculusFunctionLibrary_methods.EnableAutoLoadingSplashScreen_method.Invoke(bAutoShowEnabled);

        ///<summary>Enables/disables orientation tracking on devices that support it.</summary>
        public static void EnableOrientationTracking(bool bOrientationTracking)  => 
            OculusFunctionLibrary_methods.EnableOrientationTracking_method.Invoke(bOrientationTracking);

        ///<summary>Enables/disables positional tracking on devices that support it.</summary>
        public static void EnablePositionTracking(bool bPositionTracking)  => 
            OculusFunctionLibrary_methods.EnablePositionTracking_method.Invoke(bPositionTracking);

        ///<summary>Returns the current available frequencies</summary>
        public static IReadOnlyCollection<float> GetAvailableDisplayFrequencies()  => 
            OculusFunctionLibrary_methods.GetAvailableDisplayFrequencies_method.Invoke();

        ///<summary>Returns current base rotation and base offset.</summary>
        ///<remarks>
        ///The base offset is currently used base position offset, previously set by the
        ///ResetPosition or SetBasePositionOffset calls. It represents a vector that translates the HMD's position
        ///into (0,0,0) point, in meters.
        ///The axis of the vector are the same as in Unreal: X - forward, Y - right, Z - up.
        ///
        ///@param OutRotation                    (out) Rotator object with base rotation
        ///@param OutBaseOffsetInMeters  (out) base position offset, vector, in meters.
        ///</remarks>
        public static (Rotator, Vector) GetBaseRotationAndBaseOffsetInMeters()  => 
            OculusFunctionLibrary_methods.GetBaseRotationAndBaseOffsetInMeters_method.Invoke();

        ///<summary>Returns current base rotation and position offset.</summary>
        ///<remarks>
        ///@param OutRot                        (out) Rotator object with base rotation
        ///@param OutPosOffset          (out) the vector with previously set position offset.
        ///</remarks>
        public static (Rotator, Vector) GetBaseRotationAndPositionOffset()  => 
            OculusFunctionLibrary_methods.GetBaseRotationAndPositionOffset_method.Invoke();

        ///<summary>Returns the current display frequency</summary>
        public static float GetCurrentDisplayFrequency()  => 
            OculusFunctionLibrary_methods.GetCurrentDisplayFrequency_method.Invoke();

        ///<summary>Returns the current device's name</summary>
        public static string GetDeviceName()  => 
            OculusFunctionLibrary_methods.GetDeviceName_method.Invoke();

        ///<summary>Returns the GPU frame time on supported mobile platforms (Go for now)</summary>
        public static float GetGPUFrameTime()  => 
            OculusFunctionLibrary_methods.GetGPUFrameTime_method.Invoke();

        ///<summary>Returns the GPU utilization availability and value</summary>
        public static (bool, float) GetGPUUtilization()  => 
            OculusFunctionLibrary_methods.GetGPUUtilization_method.Invoke();

        ///<summary>
        ///Returns the dimensions in UE world space of the requested Boundary Type
        ///@
        ///</summary>
        ///<remarks>param BoundaryType                   (in) An enum representing the boundary type requested, either Outer Boundary (exact guardian bounds) or PlayArea (rectangle inside the Outer Boundary)</remarks>
        public static Vector GetGuardianDimensions(EBoundaryType BoundaryType)  => 
            OculusFunctionLibrary_methods.GetGuardianDimensions_method.Invoke(BoundaryType);

        ///<summary>
        ///Returns the list of points in UE world space of the requested Boundary Type
        ///@
        ///</summary>
        ///<remarks>param BoundaryType                   (in) An enum representing the boundary type requested, either Outer Boundary (exact guardian bounds) or PlayArea (rectangle inside the Outer Boundary)</remarks>
        public static IReadOnlyCollection<Vector> GetGuardianPoints(EBoundaryType BoundaryType)  => 
            OculusFunctionLibrary_methods.GetGuardianPoints_method.Invoke(BoundaryType);

        ///<summary>Returns loading splash screen parameters.</summary>
        ///<remarks>
        ///@param TexturePath           (out) A path to the texture asset to be used for the splash. Gear VR uses it as a path for loading icon; all other params are currently ignored by Gear VR.
        ///@param DistanceInMeters      (out) Distance, in meters, to the center of the splash screen.
        ///@param SizeInMeters          (out) Size, in meters, of the quad with the splash screen.
        ///@param RotationAxes          (out) A vector that specifies the axis of the splash screen rotation (if RotationDelta is specified).
        ///@param RotationDeltaInDeg (out) Rotation delta, in degrees, that is added each 2nd frame to the quad transform. The quad is rotated around the vector "RotationAxes".
        ///</remarks>
        public static (string, Vector, Vector2D, Vector, float) GetLoadingSplashParams()  => 
            OculusFunctionLibrary_methods.GetLoadingSplashParams_method.Invoke();

        ///<summary>
        ///Get the intersection result between a tracked device (HMD or controllers) and a guardian boundary
        ///@
        ///</summary>
        ///<remarks>
        ///param DeviceType             (in) Tracked Device type to test against guardian boundaries
        ///@param BoundaryType                   (in) An enum representing the boundary type requested, either Outer Boundary (exact guardian bounds) or PlayArea (rectangle inside the Outer Boundary)
        ///</remarks>
        public static GuardianTestResult GetNodeGuardianIntersection(ETrackedDeviceType DeviceType, EBoundaryType BoundaryType)  => 
            OculusFunctionLibrary_methods.GetNodeGuardianIntersection_method.Invoke(DeviceType, BoundaryType);

        ///<summary>Returns the transform of the play area rectangle, defining its position, rotation and scale to apply to a unit cube to match it with the play area.</summary>
        public static Transform GetPlayAreaTransform()  => 
            OculusFunctionLibrary_methods.GetPlayAreaTransform_method.Invoke();

        ///<summary>
        ///Get the intersection result between a UE4 coordinate and a guardian boundary
        ///@
        ///</summary>
        ///<remarks>
        ///param Point                                  (in) Point in UE space to test against guardian boundaries
        ///@param BoundaryType                   (in) An enum representing the boundary type requested, either Outer Boundary (exact guardian bounds) or PlayArea (rectangle inside the Outer Boundary)
        ///</remarks>
        public static GuardianTestResult GetPointGuardianIntersection(Vector Point, EBoundaryType BoundaryType)  => 
            OculusFunctionLibrary_methods.GetPointGuardianIntersection_method.Invoke(Point, BoundaryType);

        ///<summary>Grabs the current orientation and position for the HMD.</summary>
        ///<remarks>
        ///If positional tracking is not available, DevicePosition will be a zero vector
        ///
        ///@param DeviceRotation        (out) The device's current rotation
        ///@param DevicePosition        (out) The device's current position, in its own tracking space
        ///@param NeckPosition          (out) The estimated neck position, calculated using NeckToEye vector from User Profile. Same coordinate space as DevicePosition.
        ///@param bUseOrienationForPlayerCamera (in) Should be set to 'true' if the orientation is going to be used to update orientation of the camera manually.
        ///@param bUsePositionForPlayerCamera   (in) Should be set to 'true' if the position is going to be used to update position of the camera manually.
        ///@param PositionScale         (in) The 3D scale that will be applied to position.
        ///</remarks>
        public static (Rotator, Vector, Vector) GetPose(bool bUseOrienationForPlayerCamera, bool bUsePositionForPlayerCamera, Vector PositionScale)  => 
            OculusFunctionLibrary_methods.GetPose_method.Invoke(bUseOrienationForPlayerCamera, bUsePositionForPlayerCamera, PositionScale);

        ///<summary>Reports raw sensor data.</summary>
        ///<remarks>
        ///If HMD doesn't support any of the parameters then it will be set to zero.
        ///
        ///@param AngularAcceleration    (out) Angular acceleration in radians per second per second.
        ///@param LinearAcceleration             (out) Acceleration in meters per second per second.
        ///@param AngularVelocity                (out) Angular velocity in radians per second.
        ///@param LinearVelocity                 (out) Velocity in meters per second.
        ///@param TimeInSeconds                  (out) Time when the reported IMU reading took place, in seconds.
        ///</remarks>
        public static (Vector, Vector, Vector, Vector, float) GetRawSensorData(ETrackedDeviceType DeviceType)  => 
            OculusFunctionLibrary_methods.GetRawSensorData_method.Invoke(DeviceType);

        ///<summary>Returns the current multiresolution level</summary>
        public static ETiledMultiResLevel GetTiledMultiresLevel()  => 
            OculusFunctionLibrary_methods.GetTiledMultiresLevel_method.Invoke();

        ///<summary>Returns current user profile.</summary>
        ///<remarks>
        ///@param Profile                (out) Structure to hold current user profile.
        ///@return (boolean)     True, if user profile was acquired.
        ///</remarks>
        public static (HmdUserProfile, bool) GetUserProfile()  => 
            OculusFunctionLibrary_methods.GetUserProfile_method.Invoke();

        ///<summary>Returns true, if the app has input focus.</summary>
        public static bool HasInputFocus()  => 
            OculusFunctionLibrary_methods.HasInputFocus_method.Invoke();

        ///<summary>Returns true, if the system overlay is present.</summary>
        public static bool HasSystemOverlayPresent()  => 
            OculusFunctionLibrary_methods.HasSystemOverlayPresent_method.Invoke();

        ///<summary>Clears the loading icon. This call will clear all the splashes.</summary>
        public static void HideLoadingIcon()  => 
            OculusFunctionLibrary_methods.HideLoadingIcon_method.Invoke();

        ///<summary>Hides loading splash screen.</summary>
        ///<remarks>
        ///@param       bClear  (in) Clear all splash screens after hide.
        ///</remarks>
        public static void HideLoadingSplashScreen(bool bClear)  => 
            OculusFunctionLibrary_methods.HideLoadingSplashScreen_method.Invoke(bClear);

        ///<summary>Returns true, if the splash screen is automatically shown when LoadMap is called.</summary>
        public static bool IsAutoLoadingSplashScreenEnabled()  => 
            OculusFunctionLibrary_methods.IsAutoLoadingSplashScreenEnabled_method.Invoke();

        ///<summary>Returns if the device is currently tracked by the runtime or not.</summary>
        public static bool IsDeviceTracked(ETrackedDeviceType DeviceType)  => 
            OculusFunctionLibrary_methods.IsDeviceTracked_method.Invoke(DeviceType);

        ///<summary>Returns true if the Guardian Outer Boundary is being displayed</summary>
        public static bool IsGuardianDisplayed()  => 
            OculusFunctionLibrary_methods.IsGuardianDisplayed_method.Invoke();

        ///<summary>Returns true, if the splash screen is in loading icon mode.</summary>
        public static bool IsLoadingIconEnabled()  => 
            OculusFunctionLibrary_methods.IsLoadingIconEnabled_method.Invoke();

        ///<summary>
        ///Sets 'base rotation' - the rotation that will be subtracted from
        ///the actual HMD orientation.
        ///</summary>
        ///<remarks>
        ///Sets base position offset (in meters). The base position offset is the distance from the physical (0, 0, 0) position
        ///to current HMD position (bringing the (0, 0, 0) point to the current HMD position)
        ///Note, this vector is set by ResetPosition call; use this method with care.
        ///The axis of the vector are the same as in Unreal: X - forward, Y - right, Z - up.
        ///
        ///@param Rotation                       (in) Rotator object with base rotation
        ///@param BaseOffsetInMeters (in) the vector to be set as base offset, in meters.
        ///@param Options                        (in) specifies either position, orientation or both should be set.
        ///</remarks>
        public static void SetBaseRotationAndBaseOffsetInMeters(Rotator Rotation, Vector BaseOffsetInMeters, byte Options)  => 
            OculusFunctionLibrary_methods.SetBaseRotationAndBaseOffsetInMeters_method.Invoke(Rotation, BaseOffsetInMeters, Options);

        ///<summary>
        ///Sets 'base rotation' - the rotation that will be subtracted from
        ///the actual HMD orientation.
        ///</summary>
        ///<remarks>
        ///The position offset might be added to current HMD position,
        ///effectively moving the virtual camera by the specified offset. The addition
        ///occurs after the HMD orientation and position are applied.
        ///
        ///@param BaseRot                       (in) Rotator object with base rotation
        ///@param PosOffset                     (in) the vector to be added to HMD position.
        ///@param Options                       (in) specifies either position, orientation or both should be set.
        ///</remarks>
        public static void SetBaseRotationAndPositionOffset(Rotator BaseRot, Vector PosOffset, byte Options)  => 
            OculusFunctionLibrary_methods.SetBaseRotationAndPositionOffset_method.Invoke(BaseRot, PosOffset, Options);

        ///<summary>Returns if the device is currently tracked by the runtime or not.</summary>
        public static void SetCPUAndGPULevels(int CPULevel, int GPULevel)  => 
            OculusFunctionLibrary_methods.SetCPUAndGPULevels_method.Invoke(CPULevel, GPULevel);

        ///<summary>Sets the requested display frequency</summary>
        public static void SetDisplayFrequency(float RequestedFrequency)  => 
            OculusFunctionLibrary_methods.SetDisplayFrequency_method.Invoke(RequestedFrequency);

        ///<summary>
        ///Forces the runtime to render guardian at all times or not
        ///@
        ///</summary>
        ///<remarks>param GuardianVisible                        (in) True will display guardian, False will hide it</remarks>
        public static void SetGuardianVisibility(bool GuardianVisible)  => 
            OculusFunctionLibrary_methods.SetGuardianVisibility_method.Invoke(GuardianVisible);

        ///<summary>Sets loading splash screen parameters.</summary>
        ///<remarks>
        ///@param TexturePath           (in) A path to the texture asset to be used for the splash. Gear VR uses it as a path for loading icon; all other params are currently ignored by Gear VR.
        ///@param DistanceInMeters      (in) Distance, in meters, to the center of the splash screen.
        ///@param SizeInMeters          (in) Size, in meters, of the quad with the splash screen.
        ///@param RotationAxes          (in) A vector that specifies the axis of the splash screen rotation (if RotationDelta is specified).
        ///@param RotationDeltaInDeg (in) Rotation delta, in degrees, that is added each 2nd frame to the quad transform. The quad is rotated around the vector "RotationAxes".
        ///</remarks>
        public static void SetLoadingSplashParams(string TexturePath, Vector DistanceInMeters, Vector2D SizeInMeters, Vector RotationAxis, float RotationDeltaInDeg)  => 
            OculusFunctionLibrary_methods.SetLoadingSplashParams_method.Invoke(TexturePath, DistanceInMeters, SizeInMeters, RotationAxis, RotationDeltaInDeg);

        ///<summary>Scales the HMD position that gets added to the virtual camera position.</summary>
        ///<remarks>
        ///@param PosScale3D    (in) the scale to apply to the HMD position.
        ///</remarks>
        public static void SetPositionScale3D(Vector PosScale3D)  => 
            OculusFunctionLibrary_methods.SetPositionScale3D_method.Invoke(PosScale3D);

        ///<summary>
        ///Sets the HMD recenter behavior to a mode that specifies HMD recentering behavior when a
        ///controller recenter is performed.
        ///</summary>
        ///<remarks>
        ///If the recenterMode specified is 1, the HMD will recenter
        ///on controller recenter; if it's 0, only the controller will recenter. Returns false if not
        ///supported.
        ///</remarks>
        public static void SetReorientHMDOnControllerRecenter(bool recenterMode)  => 
            OculusFunctionLibrary_methods.SetReorientHMDOnControllerRecenter_method.Invoke(recenterMode);

        ///<summary>Set the requested multiresolution level for the next frame</summary>
        public static void SetTiledMultiresLevel(ETiledMultiResLevel level)  => 
            OculusFunctionLibrary_methods.SetTiledMultiresLevel_method.Invoke(level);

        ///<summary>Sets a texture for loading icon mode and shows it. This call will clear all the splashes.</summary>
        public static void ShowLoadingIcon(Texture2D Texture)  => 
            OculusFunctionLibrary_methods.ShowLoadingIcon_method.Invoke(Texture);

        ///<summary>Shows loading splash screen.</summary>
        public static void ShowLoadingSplashScreen()  => 
            OculusFunctionLibrary_methods.ShowLoadingSplashScreen_method.Invoke();
        static OculusFunctionLibrary() {
            StaticClass = Main.GetClass("OculusFunctionLibrary");
        }
        internal unsafe OculusFunctionLibrary_fields* OculusFunctionLibrary_ptr => (OculusFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator OculusFunctionLibrary(IntPtr p) => UObject.Make<OculusFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static OculusFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static OculusFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
