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
    ///<summary>Health Snapshot Blueprint Library</summary>
    public unsafe partial class HealthSnapshotBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>Writes a snapshot to the log.</summary>
        ///<remarks>
        ///Captures memory stats by default. Also captures performance stats if called after StartHealthSnapshotChart and before SopHealthSnapshotChart.
        ///
        ///@param        SnapshotTitle                   The name to be given to the new HealthSnapshot.
        ///</remarks>
        public static void LogPerformanceSnapshot(string SnapshotTitle, bool bResetStats)  => 
            HealthSnapshotBlueprintLibrary_methods.LogPerformanceSnapshot_method.Invoke(SnapshotTitle, bResetStats);

        ///<summary>Begins capturing FPS charts that can be used to include performance data in a HealthSnapshot. If snapshots are already running clears all accumulated performance data</summary>
        public static void StartPerformanceSnapshots()  => 
            HealthSnapshotBlueprintLibrary_methods.StartPerformanceSnapshots_method.Invoke();

        ///<summary>Stops capturing FPS charts only if StartHealthSnapshotChart has first been called. Does nothing if FPS charts are not running. HealthSnapshots captured after this is called will not include performance stats.</summary>
        public static void StopPerformanceSnapshots()  => 
            HealthSnapshotBlueprintLibrary_methods.StopPerformanceSnapshots_method.Invoke();
        static HealthSnapshotBlueprintLibrary() {
            StaticClass = Main.GetClass("HealthSnapshotBlueprintLibrary");
        }
        internal unsafe HealthSnapshotBlueprintLibrary_fields* HealthSnapshotBlueprintLibrary_ptr => (HealthSnapshotBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HealthSnapshotBlueprintLibrary(IntPtr p) => UObject.Make<HealthSnapshotBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HealthSnapshotBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HealthSnapshotBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
