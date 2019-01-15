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
    ///<summary>Streaming settings.</summary>
    public unsafe partial class StreamingSettings : DeveloperSettings  {
        public bool AsyncLoadingThreadEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "AsyncLoadingThreadEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "AsyncLoadingThreadEnabled", value); }
        }
        public bool WarnIfTimeLimitExceeded {
            get {return Main.GetGetBoolPropertyByName(this, "WarnIfTimeLimitExceeded"); }
            set {Main.SetGetBoolPropertyByName(this, "WarnIfTimeLimitExceeded", value); }
        }
        ///<summary>Multiplier for time limit exceeded warning time threshold.</summary>
        public unsafe float TimeLimitExceededMultiplier {
            get {return StreamingSettings_ptr->TimeLimitExceededMultiplier;}
            set {StreamingSettings_ptr->TimeLimitExceededMultiplier = value;}
        }
        ///<summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
        public unsafe float TimeLimitExceededMinTime {
            get {return StreamingSettings_ptr->TimeLimitExceededMinTime;}
            set {StreamingSettings_ptr->TimeLimitExceededMinTime = value;}
        }
        ///<summary>Minimum time the time limit exceeded warning will be triggered by.</summary>
        public unsafe int MinBulkDataSizeForAsyncLoading {
            get {return StreamingSettings_ptr->MinBulkDataSizeForAsyncLoading;}
            set {StreamingSettings_ptr->MinBulkDataSizeForAsyncLoading = value;}
        }
        public bool UseBackgroundLevelStreaming {
            get {return Main.GetGetBoolPropertyByName(this, "UseBackgroundLevelStreaming"); }
            set {Main.SetGetBoolPropertyByName(this, "UseBackgroundLevelStreaming", value); }
        }
        public bool AsyncLoadingUseFullTimeLimit {
            get {return Main.GetGetBoolPropertyByName(this, "AsyncLoadingUseFullTimeLimit"); }
            set {Main.SetGetBoolPropertyByName(this, "AsyncLoadingUseFullTimeLimit", value); }
        }
        ///<summary>Maximum amount of time to spend doing asynchronous loading (ms per frame).</summary>
        public unsafe float AsyncLoadingTimeLimit {
            get {return StreamingSettings_ptr->AsyncLoadingTimeLimit;}
            set {StreamingSettings_ptr->AsyncLoadingTimeLimit = value;}
        }
        ///<summary>Additional time to spend asynchronous loading during a high priority load.</summary>
        public unsafe float PriorityAsyncLoadingExtraTime {
            get {return StreamingSettings_ptr->PriorityAsyncLoadingExtraTime;}
            set {StreamingSettings_ptr->PriorityAsyncLoadingExtraTime = value;}
        }
        ///<summary>Maximum allowed time to spend for actor registration steps during level streaming (ms per frame).</summary>
        public unsafe float LevelStreamingActorsUpdateTimeLimit {
            get {return StreamingSettings_ptr->LevelStreamingActorsUpdateTimeLimit;}
            set {StreamingSettings_ptr->LevelStreamingActorsUpdateTimeLimit = value;}
        }
        ///<summary>Additional time to spend on actor registration steps during a high priority load.</summary>
        public unsafe float PriorityLevelStreamingActorsUpdateExtraTime {
            get {return StreamingSettings_ptr->PriorityLevelStreamingActorsUpdateExtraTime;}
            set {StreamingSettings_ptr->PriorityLevelStreamingActorsUpdateExtraTime = value;}
        }
        ///<summary>Batching granularity used to register actor components during level streaming.</summary>
        public unsafe int LevelStreamingComponentsRegistrationGranularity {
            get {return StreamingSettings_ptr->LevelStreamingComponentsRegistrationGranularity;}
            set {StreamingSettings_ptr->LevelStreamingComponentsRegistrationGranularity = value;}
        }
        ///<summary>Maximum allowed time to spend while unregistering components during level streaming (ms per frame).</summary>
        public unsafe float LevelStreamingUnregisterComponentsTimeLimit {
            get {return StreamingSettings_ptr->LevelStreamingUnregisterComponentsTimeLimit;}
            set {StreamingSettings_ptr->LevelStreamingUnregisterComponentsTimeLimit = value;}
        }
        ///<summary>Batching granularity used to unregister actor components during level streaming.</summary>
        public unsafe int LevelStreamingComponentsUnregistrationGranularity {
            get {return StreamingSettings_ptr->LevelStreamingComponentsUnregistrationGranularity;}
            set {StreamingSettings_ptr->LevelStreamingComponentsUnregistrationGranularity = value;}
        }
        public bool EventDrivenLoaderEnabled {
            get {return Main.GetGetBoolPropertyByName(this, "EventDrivenLoaderEnabled"); }
            set {Main.SetGetBoolPropertyByName(this, "EventDrivenLoaderEnabled", value); }
        }
        static StreamingSettings() {
            StaticClass = Main.GetClass("StreamingSettings");
        }
        internal unsafe StreamingSettings_fields* StreamingSettings_ptr => (StreamingSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator StreamingSettings(IntPtr p) => UObject.Make<StreamingSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static StreamingSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static StreamingSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
