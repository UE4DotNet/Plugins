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
using UE4.WindowsTargetPlatform.Native;

namespace UE4.WindowsTargetPlatform {
    ///<summary>Implements the settings for the Windows target platform.</summary>
    ///<remarks>
    ///The first instance of this class is initialized in
    ///WindowsTargetPlatform, really early during the startup sequence before the CDO has been constructed, so its config
    ///settings are read manually from there.
    ///</remarks>
    public unsafe partial class WindowsTargetSettings : UObject  {
         //TODO: enum ECompilerVersion Compiler
         //TODO: array not UObject TArray TargetedRHIs
         //TODO: enum EMinimumSupportedOS MinimumOSVersion
         //TODO: string FString AudioDevice
        ///<summary>Sample rate to run the audio mixer with.</summary>
        public unsafe int AudioSampleRate {
            get {return WindowsTargetSettings_ptr->AudioSampleRate;}
            set {WindowsTargetSettings_ptr->AudioSampleRate = value;}
        }
        ///<summary>The amount of audio to compute each callback block. Lower values decrease latency but may increase CPU cost.</summary>
        public unsafe int AudioCallbackBufferFrameSize {
            get {return WindowsTargetSettings_ptr->AudioCallbackBufferFrameSize;}
            set {WindowsTargetSettings_ptr->AudioCallbackBufferFrameSize = value;}
        }
        ///<summary>The number of buffers to keep enqueued. More buffers increases latency, but can compensate for variable compute availability in audio callbacks on some platforms.</summary>
        public unsafe int AudioNumBuffersToEnqueue {
            get {return WindowsTargetSettings_ptr->AudioNumBuffersToEnqueue;}
            set {WindowsTargetSettings_ptr->AudioNumBuffersToEnqueue = value;}
        }
        ///<summary>The max number of channels (voices) to limit for this platform. The max channels used will be the minimum of this value and the global audio quality settings. A value of 0 will not apply a platform channel count max.</summary>
        public unsafe int AudioMaxChannels {
            get {return WindowsTargetSettings_ptr->AudioMaxChannels;}
            set {WindowsTargetSettings_ptr->AudioMaxChannels = value;}
        }
        ///<summary>The number of workers to use to compute source audio. Will only use up to the max number of sources. Will evenly divide sources to each source worker.</summary>
        public unsafe int AudioNumSourceWorkers {
            get {return WindowsTargetSettings_ptr->AudioNumSourceWorkers;}
            set {WindowsTargetSettings_ptr->AudioNumSourceWorkers = value;}
        }
         //TODO: string FString SpatializationPlugin
         //TODO: string FString ReverbPlugin
         //TODO: string FString OcclusionPlugin
        static WindowsTargetSettings() {
            StaticClass = Main.GetClass("WindowsTargetSettings");
        }
        internal unsafe WindowsTargetSettings_fields* WindowsTargetSettings_ptr => (WindowsTargetSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WindowsTargetSettings(IntPtr p) => UObject.Make<WindowsTargetSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WindowsTargetSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WindowsTargetSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
