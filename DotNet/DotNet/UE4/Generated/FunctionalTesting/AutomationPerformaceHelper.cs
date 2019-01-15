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
using UE4.FunctionalTesting.Native;

namespace UE4.FunctionalTesting {
    ///<summary>Class for use with functional tests which provides various performance measuring features.</summary>
    ///<remarks>
    ///Recording of basic, unintrusive performance stats.
    ///Automatic captures using external CPU and GPU profilers.
    ///Triggering and ending of writing full stats to a file.
    ///</remarks>
    public unsafe partial class AutomationPerformaceHelper : UObject  {

        ///<summary>Begins recording a new named performance stats record. We start by recording the baseline.</summary>
        public void BeginRecording(string RecordName, float InGPUBudget, float InRenderThreadBudget, float InGameThreadBudget)  => 
            AutomationPerformaceHelper_methods.BeginRecording_method.Invoke(ObjPointer, RecordName, InGPUBudget, InRenderThreadBudget, InGameThreadBudget);

        ///<summary>Begins recording a new named performance stats record. We start by recording the baseline</summary>
        public void BeginRecordingBaseline(string RecordName)  => 
            AutomationPerformaceHelper_methods.BeginRecordingBaseline_method.Invoke(ObjPointer, RecordName);

        ///<summary>Begins recording stats to a file.</summary>
        public void BeginStatsFile(string RecordName)  => 
            AutomationPerformaceHelper_methods.BeginStatsFile_method.Invoke(ObjPointer, RecordName);

        ///<summary>Stops recording performance stats.</summary>
        public void EndRecording()  => 
            AutomationPerformaceHelper_methods.EndRecording_method.Invoke(ObjPointer);

        ///<summary>Stops recording the baseline and moves to the main record.</summary>
        public void EndRecordingBaseline()  => 
            AutomationPerformaceHelper_methods.EndRecordingBaseline_method.Invoke(ObjPointer);

        ///<summary>Ends recording stats to a file.</summary>
        public void EndStatsFile()  => 
            AutomationPerformaceHelper_methods.EndStatsFile_method.Invoke(ObjPointer);

        ///<summary>Is Current Record Within Game Thread Budget</summary>
        public bool IsCurrentRecordWithinGameThreadBudget()  => 
            AutomationPerformaceHelper_methods.IsCurrentRecordWithinGameThreadBudget_method.Invoke(ObjPointer);

        ///<summary>Is Current Record Within GPUBudget</summary>
        public bool IsCurrentRecordWithinGPUBudget()  => 
            AutomationPerformaceHelper_methods.IsCurrentRecordWithinGPUBudget_method.Invoke(ObjPointer);

        ///<summary>Is Current Record Within Render Thread Budget</summary>
        public bool IsCurrentRecordWithinRenderThreadBudget()  => 
            AutomationPerformaceHelper_methods.IsCurrentRecordWithinRenderThreadBudget_method.Invoke(ObjPointer);

        ///<summary>Returns true if this stats tracker is currently recording performance stats.</summary>
        public bool IsRecording()  => 
            AutomationPerformaceHelper_methods.IsRecording_method.Invoke(ObjPointer);

        ///<summary>Does any final work needed as all tests are complete.</summary>
        public void OnAllTestsComplete()  => 
            AutomationPerformaceHelper_methods.OnAllTestsComplete_method.Invoke(ObjPointer);

        ///<summary>Does any init work across all tests..</summary>
        public void OnBeginTests()  => 
            AutomationPerformaceHelper_methods.OnBeginTests_method.Invoke(ObjPointer);

        ///<summary>Adds a sample to the stats counters for the current performance stats record.</summary>
        public void Sample(float DeltaSeconds)  => 
            AutomationPerformaceHelper_methods.Sample_method.Invoke(ObjPointer, DeltaSeconds);

        ///<summary>Communicates with external profiler to being a CPU capture.</summary>
        public void StartCPUProfiling()  => 
            AutomationPerformaceHelper_methods.StartCPUProfiling_method.Invoke(ObjPointer);

        ///<summary>Communicates with external profiler to end a CPU capture.</summary>
        public void StopCPUProfiling()  => 
            AutomationPerformaceHelper_methods.StopCPUProfiling_method.Invoke(ObjPointer);

        ///<summary>Begin basic stat recording</summary>
        public void Tick(float DeltaSeconds)  => 
            AutomationPerformaceHelper_methods.Tick_method.Invoke(ObjPointer, DeltaSeconds);

        ///<summary>Will trigger a GPU trace next time the current test falls below GPU budget.</summary>
        public void TriggerGPUTraceIfRecordFallsBelowBudget()  => 
            AutomationPerformaceHelper_methods.TriggerGPUTraceIfRecordFallsBelowBudget_method.Invoke(ObjPointer);

        ///<summary>Writes the current set of performance stats records to a csv file in the profiling directory. An additional directory and an extension override can also be used.</summary>
        public void WriteLogFile(string CaptureDir, string CaptureExtension)  => 
            AutomationPerformaceHelper_methods.WriteLogFile_method.Invoke(ObjPointer, CaptureDir, CaptureExtension);
        static AutomationPerformaceHelper() {
            StaticClass = Main.GetClass("AutomationPerformaceHelper");
        }
        internal unsafe AutomationPerformaceHelper_fields* AutomationPerformaceHelper_ptr => (AutomationPerformaceHelper_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AutomationPerformaceHelper(IntPtr p) => UObject.Make<AutomationPerformaceHelper>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AutomationPerformaceHelper DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AutomationPerformaceHelper New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
