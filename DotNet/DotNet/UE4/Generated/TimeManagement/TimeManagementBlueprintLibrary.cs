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

        ///<summary>Addition (FrameNumber A + FrameNumber B)</summary>
        public static FrameNumber Add_FrameNumberFrameNumber(FrameNumber A, FrameNumber B)  => 
            TimeManagementBlueprintLibrary_methods.Add_FrameNumberFrameNumber_method.Invoke(A, B);

        ///<summary>Addition (FrameNumber A + int B)</summary>
        public static FrameNumber Add_FrameNumberInteger(FrameNumber A, int B)  => 
            TimeManagementBlueprintLibrary_methods.Add_FrameNumberInteger_method.Invoke(A, B);

        ///<summary>Converts a FrameNumber to an int32 for use in functions that take int32 frame counts for convenience.</summary>
        public static int Conv_FrameNumberToInteger(FrameNumber InFrameNumber)  => 
            TimeManagementBlueprintLibrary_methods.Conv_FrameNumberToInteger_method.Invoke(InFrameNumber);

        ///<summary>Converts an FrameRate to a float ie: 1/30 returns 0.0333333</summary>
        public static float Conv_FrameRateToSeconds(FrameRate InFrameRate)  => 
            TimeManagementBlueprintLibrary_methods.Conv_FrameRateToSeconds_method.Invoke(InFrameRate);

        ///<summary>Converts an QualifiedFrameTime to seconds.</summary>
        public static float Conv_QualifiedFrameTimeToSeconds(QualifiedFrameTime InFrameTime)  => 
            TimeManagementBlueprintLibrary_methods.Conv_QualifiedFrameTimeToSeconds_method.Invoke(InFrameTime);

        ///<summary>Converts an Timecode to a string (hh:mm:ss:ff). If bForceSignDisplay then the number sign will always be prepended instead of just when expressing a negative time.</summary>
        public static string Conv_TimecodeToString(Timecode InTimecode, bool bForceSignDisplay)  => 
            TimeManagementBlueprintLibrary_methods.Conv_TimecodeToString_method.Invoke(InTimecode, bForceSignDisplay);

        ///<summary>Divide (FrameNumber A / B)</summary>
        public static FrameNumber Divide_FrameNumberInteger(FrameNumber A, int B)  => 
            TimeManagementBlueprintLibrary_methods.Divide_FrameNumberInteger_method.Invoke(A, B);

        ///<summary>Get the Timecode from the TimeManagement's TimecodeProvider.</summary>
        ///<remarks>
        ///@return true if the Timecode is valid. The timecode is valid when the TimecodeProfier is Synchronized.
        ///</remarks>
        public static Timecode GetTimecode()  => 
            TimeManagementBlueprintLibrary_methods.GetTimecode_method.Invoke();

        ///<summary>Verifies that this is a valid framerate with a non-zero denominator.</summary>
        public static bool IsValid_Framerate(FrameRate InFrameRate)  => 
            TimeManagementBlueprintLibrary_methods.IsValid_Framerate_method.Invoke(InFrameRate);

        ///<summary>Checks if this framerate is an even multiple of another framerate, ie: 60 is a multiple of 30, but 59.94 is not.</summary>
        public static bool IsValid_MultipleOf(FrameRate InFrameRate, FrameRate OtherFramerate)  => 
            TimeManagementBlueprintLibrary_methods.IsValid_MultipleOf_method.Invoke(InFrameRate, OtherFramerate);

        ///<summary>Multiply (FrameNumber A * B)</summary>
        public static FrameNumber Multiply_FrameNumberInteger(FrameNumber A, int B)  => 
            TimeManagementBlueprintLibrary_methods.Multiply_FrameNumberInteger_method.Invoke(A, B);

        ///<summary>Multiplies a value in seconds against a FrameRate to get a new FrameTime.</summary>
        public static FrameTime Multiply_SecondsFrameRate(float TimeInSeconds, FrameRate FrameRate)  => 
            TimeManagementBlueprintLibrary_methods.Multiply_SecondsFrameRate_method.Invoke(TimeInSeconds, FrameRate);

        ///<summary>Snaps the given SourceTime to the nearest frame in the specified Destination Framerate. Useful for determining the nearest frame for another resolution. Returns the frame time in the destination frame rate.</summary>
        public static FrameTime SnapFrameTimeToRate(FrameTime SourceTime, FrameRate SourceRate, FrameRate SnapToRate)  => 
            TimeManagementBlueprintLibrary_methods.SnapFrameTimeToRate_method.Invoke(SourceTime, SourceRate, SnapToRate);

        ///<summary>Subtraction (FrameNumber A - FrameNumber B)</summary>
        public static FrameNumber Subtract_FrameNumberFrameNumber(FrameNumber A, FrameNumber B)  => 
            TimeManagementBlueprintLibrary_methods.Subtract_FrameNumberFrameNumber_method.Invoke(A, B);

        ///<summary>Subtraction (FrameNumber A - int B)</summary>
        public static FrameNumber Subtract_FrameNumberInteger(FrameNumber A, int B)  => 
            TimeManagementBlueprintLibrary_methods.Subtract_FrameNumberInteger_method.Invoke(A, B);

        ///<summary>Converts the specified time from one framerate to another framerate. This is useful for converting between tick resolution and display rate.</summary>
        public static FrameTime TransformTime(FrameTime SourceTime, FrameRate SourceRate, FrameRate DestinationRate)  => 
            TimeManagementBlueprintLibrary_methods.TransformTime_method.Invoke(SourceTime, SourceRate, DestinationRate);
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
