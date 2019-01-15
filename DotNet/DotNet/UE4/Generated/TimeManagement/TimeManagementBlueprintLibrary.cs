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
using UE4.TimeManagement.Native;
using UE4.Engine;

namespace UE4.TimeManagement {
    ///<summary>Time Management Blueprint Library</summary>
    public unsafe partial class TimeManagementBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Converts an FrameRate to a float ie: 1/30 returns 0.0333333</summary>
        public static float Conv_FrameRateToSeconds(FrameRate InFrameRate)  => 
            TimeManagementBlueprintLibrary_methods.Conv_FrameRateToSeconds_method.Invoke(InFrameRate);

        ///<summary>Converts an QualifiedFrameTime to seconds.</summary>
        public static float Conv_QualifiedFrameTimeToSeconds(QualifiedFrameTime InFrameTime)  => 
            TimeManagementBlueprintLibrary_methods.Conv_QualifiedFrameTimeToSeconds_method.Invoke(InFrameTime);

        ///<summary>Converts an Timecode to a string ie: hh:mm:ss</summary>
        public static string Conv_TimecodeToString(Timecode InTimecode, bool bForceSignDisplay)  => 
            TimeManagementBlueprintLibrary_methods.Conv_TimecodeToString_method.Invoke(InTimecode, bForceSignDisplay);

        ///<summary>Get the Timecode from the TimeManagement's TimecodeProvider.</summary>
        ///<remarks>
        ///@return true if the Timecode is valid. The timecode is valid when the TimecodeProfier is Synchronized.
        ///</remarks>
        public static Timecode GetTimecode()  => 
            TimeManagementBlueprintLibrary_methods.GetTimecode_method.Invoke();

        ///<summary>Multiplies a value in seconds against a FrameRate to get a new FrameTime.</summary>
        public static FrameTime Multiply_SecondsFrameRate(float TimeInSeconds, FrameRate FrameRate)  => 
            TimeManagementBlueprintLibrary_methods.Multiply_SecondsFrameRate_method.Invoke(TimeInSeconds, FrameRate);
        static TimeManagementBlueprintLibrary() {
            StaticClass = Main.GetClass("TimeManagementBlueprintLibrary");
        }
        internal unsafe TimeManagementBlueprintLibrary_fields* TimeManagementBlueprintLibrary_ptr => (TimeManagementBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TimeManagementBlueprintLibrary(IntPtr p) => UObject.Make<TimeManagementBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TimeManagementBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TimeManagementBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
