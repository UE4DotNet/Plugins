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
    ///<summary>Image Tracker Function Library</summary>
    public unsafe partial class ImageTrackerFunctionLibrary : BlueprintFunctionLibrary  {

        ///<summary>If true, image tracker will detect and track targets.</summary>
        ///<remarks>
        ///When enabled Image Tracker will gain access to the camera and start
        ///trackingimages. Enabling image tracker is expensive, takes about 1500ms
        ///on the average.
        ///
        ///When disabled Image Tracker will release the camera and stop tracking
        ///images. Internal state of the tracker will be maintained (i.e. list of
        ///active/inactive argets and their target_handles).
        ///
        ///This is done automatically on application pause / resume.
        ///</remarks>
        public static void EnableImageTracking(bool bEnable)  => 
            ImageTrackerFunctionLibrary_methods.EnableImageTracking_method.Invoke(bEnable);

        ///<summary>Gets the maximum number of Image Targets that can be tracked at any given time.</summary>
        ///<remarks>
        ///@return The maximum number of Image Targets that can be tracked at any given time.
        ///</remarks>
        public static int GetMaxSimultaneousTargets()  => 
            ImageTrackerFunctionLibrary_methods.GetMaxSimultaneousTargets_method.Invoke();

        ///<summary>Gets the active state of the image tracking system.</summary>
        ///<remarks>
        ///@return True if image tracking is enabled, false otherwise.
        ///</remarks>
        public static bool IsImageTrackingEnabled()  => 
            ImageTrackerFunctionLibrary_methods.IsImageTrackingEnabled_method.Invoke();

        ///<summary>Set maximum number of Image Targets that can be tracked at any given time.</summary>
        ///<remarks>
        ///If the tracker is already tracking the maximum number of targets
        ///possible then it will stop searching for new targets which helps
        ///in reducing the load on the CPU. For example, if you are interested in
        ///tracking a maximum of x targets from a list y (x < y) targets then set this
        ///parameter to x.
        ///
        ///The valid range for this parameter is from 1 through 25.
        ///</remarks>
        public static void SetMaxSimultaneousTargets(int MaxSimultaneousTargets)  => 
            ImageTrackerFunctionLibrary_methods.SetMaxSimultaneousTargets_method.Invoke(MaxSimultaneousTargets);
        static ImageTrackerFunctionLibrary() {
            StaticClass = Main.GetClass("ImageTrackerFunctionLibrary");
        }
        internal unsafe ImageTrackerFunctionLibrary_fields* ImageTrackerFunctionLibrary_ptr => (ImageTrackerFunctionLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImageTrackerFunctionLibrary(IntPtr p) => UObject.Make<ImageTrackerFunctionLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImageTrackerFunctionLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImageTrackerFunctionLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
