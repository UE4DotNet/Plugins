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
using UE4.MacTargetPlatform.Native;

namespace UE4.MacTargetPlatform {
    ///<summary>Implements the settings for the Mac target platform.</summary>
    public unsafe partial class MacTargetSettings : UObject  {
         //TODO: array not UObject TArray TargetedRHIs
        ///<summary>The maximum supported Metal shader langauge version.</summary>
        ///<remarks>This defines what features may be used and OS versions supported.</remarks>
        public unsafe byte MaxShaderLanguageVersion {
            get {return MacTargetSettings_ptr->MaxShaderLanguageVersion;}
            set {MacTargetSettings_ptr->MaxShaderLanguageVersion = value;}
        }
        public bool UseFastIntrinsics {
            get {return Main.GetGetBoolPropertyByName(this, "UseFastIntrinsics"); }
            set {Main.SetGetBoolPropertyByName(this, "UseFastIntrinsics", value); }
        }
        public bool EnableMathOptimisations {
            get {return Main.GetGetBoolPropertyByName(this, "EnableMathOptimisations"); }
            set {Main.SetGetBoolPropertyByName(this, "EnableMathOptimisations", value); }
        }
        ///<summary>Sample rate to run the audio mixer with.</summary>
        public unsafe int AudioSampleRate {
            get {return MacTargetSettings_ptr->AudioSampleRate;}
            set {MacTargetSettings_ptr->AudioSampleRate = value;}
        }
        ///<summary>The amount of audio to compute each callback block. Lower values decrease latency but may increase CPU cost.</summary>
        public unsafe int AudioCallbackBufferFrameSize {
            get {return MacTargetSettings_ptr->AudioCallbackBufferFrameSize;}
            set {MacTargetSettings_ptr->AudioCallbackBufferFrameSize = value;}
        }
        ///<summary>The number of buffers to keep enqueued. More buffers increases latency, but can compensate for variable compute availability in audio callbacks on some platforms.</summary>
        public unsafe int AudioNumBuffersToEnqueue {
            get {return MacTargetSettings_ptr->AudioNumBuffersToEnqueue;}
            set {MacTargetSettings_ptr->AudioNumBuffersToEnqueue = value;}
        }
        ///<summary>The max number of channels (voices) to limit for this platform. The max channels used will be the minimum of this value and the global audio quality settings. A value of 0 will not apply a platform channel count max.</summary>
        public unsafe int AudioMaxChannels {
            get {return MacTargetSettings_ptr->AudioMaxChannels;}
            set {MacTargetSettings_ptr->AudioMaxChannels = value;}
        }
        ///<summary>The number of workers to use to compute source audio. Will only use up to the max number of sources. Will evenly divide sources to each source worker.</summary>
        public unsafe int AudioNumSourceWorkers {
            get {return MacTargetSettings_ptr->AudioNumSourceWorkers;}
            set {MacTargetSettings_ptr->AudioNumSourceWorkers = value;}
        }
         //TODO: string FString SpatializationPlugin
         //TODO: string FString ReverbPlugin
         //TODO: string FString OcclusionPlugin
        static MacTargetSettings() {
            StaticClass = Main.GetClass("MacTargetSettings");
        }
        internal unsafe MacTargetSettings_fields* MacTargetSettings_ptr => (MacTargetSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MacTargetSettings(IntPtr p) => UObject.Make<MacTargetSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MacTargetSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MacTargetSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
