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
    ///<summary>Magic Leap HMDFunction Library</summary>
    public unsafe partial class MagicLeapHMDFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Get Head Tracking State</summary>
        public static (HeadTrackingState, bool) GetHeadTrackingState()  => 
            MagicLeapHMDFunctionLibrary_methods.GetHeadTrackingState_method.Invoke();

        ///<summary>Get MLSDKVersion</summary>
        public static string GetMLSDKVersion()  => 
            MagicLeapHMDFunctionLibrary_methods.GetMLSDKVersion_method.Invoke();

        ///<summary>Get MLSDKVersion Major</summary>
        public static int GetMLSDKVersionMajor()  => 
            MagicLeapHMDFunctionLibrary_methods.GetMLSDKVersionMajor_method.Invoke();

        ///<summary>Get MLSDKVersion Minor</summary>
        public static int GetMLSDKVersionMinor()  => 
            MagicLeapHMDFunctionLibrary_methods.GetMLSDKVersionMinor_method.Invoke();

        ///<summary>Get MLSDKVersion Revision</summary>
        public static int GetMLSDKVersionRevision()  => 
            MagicLeapHMDFunctionLibrary_methods.GetMLSDKVersionRevision_method.Invoke();

        ///<summary>Returns true if this code is executing on the ML HMD, false otherwise (e.g. it's executing on PC)</summary>
        public static bool IsRunningOnMagicLeapHMD()  => 
            MagicLeapHMDFunctionLibrary_methods.IsRunningOnMagicLeapHMD_method.Invoke();

        ///<summary>Set Base Orientation</summary>
        public static void SetBaseOrientation(Quat InBaseOrientation)  => 
            MagicLeapHMDFunctionLibrary_methods.SetBaseOrientation_method.Invoke(InBaseOrientation);

        ///<summary>Set Base Position</summary>
        public static void SetBasePosition(Vector InBasePosition)  => 
            MagicLeapHMDFunctionLibrary_methods.SetBasePosition_method.Invoke(InBasePosition);

        ///<summary>Set Base Rotation</summary>
        public static void SetBaseRotation(Rotator InBaseRotation)  => 
            MagicLeapHMDFunctionLibrary_methods.SetBaseRotation_method.Invoke(InBaseRotation);

        ///<summary>Set the actor whose location is used as the focus point. The focus distance is the distance from the HMD to the focus point.</summary>
        public static void SetFocusActor(Actor InFocusActor)  => 
            MagicLeapHMDFunctionLibrary_methods.SetFocusActor_method.Invoke(InFocusActor);
        static MagicLeapHMDFunctionLibrary() {
            StaticClass = Main.GetClass("MagicLeapHMDFunctionLibrary");
        }
        internal unsafe MagicLeapHMDFunctionLibrary_fields* MagicLeapHMDFunctionLibrary_ptr => (MagicLeapHMDFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapHMDFunctionLibrary(IntPtr p) => UObject.Make<MagicLeapHMDFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapHMDFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapHMDFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
