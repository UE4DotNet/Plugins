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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Visual Logger Kismet Library</summary>
    public unsafe partial class VisualLoggerKismetLibrary : BlueprintFunctionLibrary  {

        ///<summary>Enable Recording</summary>
        public static void EnableRecording(bool bEnabled)  => 
            VisualLoggerKismetLibrary_methods.EnableRecording_method.Invoke(bEnabled);

        ///<summary>Logs box shape - recording for Visual Logs has to be enabled to record this data</summary>
        public static void LogBox(UObject WorldContextObject, Box BoxShape, string Text, LinearColor ObjectColor, Name LogCategory, bool bAddToMessageLog)  => 
            VisualLoggerKismetLibrary_methods.LogBox_method.Invoke(WorldContextObject, BoxShape, Text, ObjectColor, LogCategory, bAddToMessageLog);

        ///<summary>Logs location as sphere with given radius - recording for Visual Logs has to be enabled to record this data</summary>
        public static void LogLocation(UObject WorldContextObject, Vector Location, string Text, LinearColor ObjectColor, float Radius, Name LogCategory, bool bAddToMessageLog)  => 
            VisualLoggerKismetLibrary_methods.LogLocation_method.Invoke(WorldContextObject, Location, Text, ObjectColor, Radius, LogCategory, bAddToMessageLog);

        ///<summary>Log Segment</summary>
        public static void LogSegment(UObject WorldContextObject, Vector SegmentStart, Vector SegmentEnd, string Text, LinearColor ObjectColor, float Thickness, Name CategoryName, bool bAddToMessageLog)  => 
            VisualLoggerKismetLibrary_methods.LogSegment_method.Invoke(WorldContextObject, SegmentStart, SegmentEnd, Text, ObjectColor, Thickness, CategoryName, bAddToMessageLog);

        ///<summary>Logs simple text string with Visual Logger - recording for Visual Logs has to be enabled to record this data</summary>
        public static void LogText(UObject WorldContextObject, string Text, Name LogCategory, bool bAddToMessageLog)  => 
            VisualLoggerKismetLibrary_methods.LogText_method.Invoke(WorldContextObject, Text, LogCategory, bAddToMessageLog);

        ///<summary>Makes SourceOwner log to DestinationOwner's vislog</summary>
        public static void RedirectVislog(UObject SourceOwner, UObject DestinationOwner)  => 
            VisualLoggerKismetLibrary_methods.RedirectVislog_method.Invoke(SourceOwner, DestinationOwner);
        static VisualLoggerKismetLibrary() {
            StaticClass = Main.GetClass("VisualLoggerKismetLibrary");
        }
        internal unsafe VisualLoggerKismetLibrary_fields* VisualLoggerKismetLibrary_ptr => (VisualLoggerKismetLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VisualLoggerKismetLibrary(IntPtr p) => UObject.Make<VisualLoggerKismetLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VisualLoggerKismetLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VisualLoggerKismetLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
