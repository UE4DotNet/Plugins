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
using UE4.MediaAssets.Native;
using UE4.Engine;

namespace UE4.MediaAssets {
    ///<summary>Blueprint library for Media related functions.</summary>
    public unsafe partial class MediaBlueprintFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>Enumerate available audio capture devices.</summary>
        ///<remarks>
        ///To filter for a specific subset of devices, use the MakeBitmask node
        ///with EMediaAudioCaptureDeviceFilter as the Bitmask Enum.
        ///
        ///@param OutDevices Will contain the available capture devices.
        ///@param Filter The types of capture devices to return (-1 = all).
        ///</remarks>
        public static IReadOnlyCollection<MediaCaptureDevice> EnumerateAudioCaptureDevices(int Filter)  => 
            MediaBlueprintFunctionLibrary_methods.EnumerateAudioCaptureDevices_method.Invoke(Filter);

        ///<summary>Enumerate available audio capture devices.</summary>
        ///<remarks>
        ///To filter for a specific subset of devices, use the MakeBitmask node
        ///with EMediaVideoCaptureDeviceFilter as the Bitmask Enum.
        ///
        ///@param OutDevices Will contain the available capture devices.
        ///@param Filter The types of capture devices to return (-1 = all).
        ///</remarks>
        public static IReadOnlyCollection<MediaCaptureDevice> EnumerateVideoCaptureDevices(int Filter)  => 
            MediaBlueprintFunctionLibrary_methods.EnumerateVideoCaptureDevices_method.Invoke(Filter);

        ///<summary>Enumerate available audio capture devices.</summary>
        ///<remarks>
        ///To filter for a specific subset of devices, use the MakeBitmask node
        ///with EMediaWebcamCaptureDeviceFilter as the Bitmask Enum.
        ///
        ///@param OutDevices Will contain the available capture devices.
        ///@param Filter The types of capture devices to return (-1 = all).
        ///</remarks>
        public static IReadOnlyCollection<MediaCaptureDevice> EnumerateWebcamCaptureDevices(int Filter)  => 
            MediaBlueprintFunctionLibrary_methods.EnumerateWebcamCaptureDevices_method.Invoke(Filter);
        static MediaBlueprintFunctionLibrary() {
            StaticClass = Main.GetClass("MediaBlueprintFunctionLibrary");
        }
        internal unsafe MediaBlueprintFunctionLibrary_fields* MediaBlueprintFunctionLibrary_ptr => (MediaBlueprintFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MediaBlueprintFunctionLibrary(IntPtr p) => UObject.Make<MediaBlueprintFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MediaBlueprintFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MediaBlueprintFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
