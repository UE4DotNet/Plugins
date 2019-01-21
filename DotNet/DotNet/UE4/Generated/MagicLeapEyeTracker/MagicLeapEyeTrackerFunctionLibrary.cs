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
using UE4.MagicLeapEyeTracker.Native;
using UE4.Engine;

namespace UE4.MagicLeapEyeTracker {
    ///<summary>Magic Leap Eye Tracker Function Library</summary>
    public unsafe partial class MagicLeapEyeTrackerFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Get Calibration Status</summary>
        public static EMagicLeapEyeTrackingCalibrationStatus GetCalibrationStatus()  => 
            MagicLeapEyeTrackerFunctionLibrary_methods.GetCalibrationStatus_method.Invoke();

        ///<summary>Get Eye Blink State</summary>
        public static (MagicLeapEyeBlinkState, bool) GetEyeBlinkState()  => 
            MagicLeapEyeTrackerFunctionLibrary_methods.GetEyeBlinkState_method.Invoke();

        ///<summary>Get Fixation Comfort</summary>
        public static (MagicLeapFixationComfort, bool) GetFixationComfort()  => 
            MagicLeapEyeTrackerFunctionLibrary_methods.GetFixationComfort_method.Invoke();

        ///<summary>False if the calibration status is none, otherwise returns true, even with a bad calibration.</summary>
        ///<remarks>If not, user should be advised to run the Eye Calibrator app on the device.</remarks>
        public static bool IsEyeTrackerCalibrated()  => 
            MagicLeapEyeTrackerFunctionLibrary_methods.IsEyeTrackerCalibrated_method.Invoke();
        static MagicLeapEyeTrackerFunctionLibrary() {
            StaticClass = Main.GetClass("MagicLeapEyeTrackerFunctionLibrary");
        }
        internal unsafe MagicLeapEyeTrackerFunctionLibrary_fields* MagicLeapEyeTrackerFunctionLibrary_ptr => (MagicLeapEyeTrackerFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapEyeTrackerFunctionLibrary(IntPtr p) => UObject.Make<MagicLeapEyeTrackerFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapEyeTrackerFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapEyeTrackerFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
