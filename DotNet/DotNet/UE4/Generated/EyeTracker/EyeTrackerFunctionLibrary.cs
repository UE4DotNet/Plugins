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
using UE4.EyeTracker.Native;
using UE4.Engine;

namespace UE4.EyeTracker {
    ///<summary>Eye Tracker Function Library</summary>
    public unsafe partial class EyeTrackerFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Returns unfied gaze data from the eye tracker.</summary>
        ///<remarks>
        ///This is a single gaze ray, representing the fusion of both eyes.
        ///@param PlayerController              The player for whom we are tracking. Null can be ok for some devices, but this may be necessary for others to determine viewport properties, etc.
        ///@return                                              True if the returned gaze data is valid, false otherwise. A false return is likely to be common (e.g. the when user blinks).
        ///</remarks>
        public static (EyeTrackerGazeData, bool) GetGazeData()  => 
            EyeTrackerFunctionLibrary_methods.GetGazeData_method.Invoke();

        ///<summary>Returns stereo gaze data from the eye tracker.</summary>
        ///<remarks>
        ///This includes a gaze ray per eye, as well as a fixation point.
        ///@param PlayerController              The player for whom we are tracking. Null can be ok for some devices, but this may be necessary for others to determine viewport properties, etc.
        ///@return                                              True if the returned gaze data is valid, false otherwise. A false return is likely to be common (e.g. the when user blinks).
        ///</remarks>
        public static (EyeTrackerStereoGazeData, bool) GetStereoGazeData()  => 
            EyeTrackerFunctionLibrary_methods.GetStereoGazeData_method.Invoke();

        ///<summary>Returns whether or not the eye-tracking hardware is connected and ready to use.</summary>
        ///<remarks>
        ///It may or may not actually be in use.
        ///@return (Boolean)  true if eye tracker is connected and ready to use, false otherwise
        ///</remarks>
        public static bool IsEyeTrackerConnected()  => 
            EyeTrackerFunctionLibrary_methods.IsEyeTrackerConnected_method.Invoke();

        ///<summary>Returns whether or not the eye-tracking hardware is connected and ready to use.</summary>
        ///<remarks>
        ///It may or may not actually be in use.
        ///@return true if the connected eye tracker supports per-eye gaze data, false otherwise
        ///</remarks>
        public static bool IsStereoGazeDataAvailable()  => 
            EyeTrackerFunctionLibrary_methods.IsStereoGazeDataAvailable_method.Invoke();

        ///<summary>Specifies player being eye-tracked.</summary>
        ///<remarks>
        ///This is not necessary for all devices, but is necessary for some to determine viewport properties, etc.
        ///@param PlayerController              The player for whom we are tracking. Null can be ok for some devices, but this may be necessary for others to determine viewport properties, etc.
        ///</remarks>
        public static void SetEyeTrackedPlayer(PlayerController PlayerController)  => 
            EyeTrackerFunctionLibrary_methods.SetEyeTrackedPlayer_method.Invoke(PlayerController);
        static EyeTrackerFunctionLibrary() {
            StaticClass = Main.GetClass("EyeTrackerFunctionLibrary");
        }
        internal unsafe EyeTrackerFunctionLibrary_fields* EyeTrackerFunctionLibrary_ptr => (EyeTrackerFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EyeTrackerFunctionLibrary(IntPtr p) => UObject.Make<EyeTrackerFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EyeTrackerFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EyeTrackerFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
