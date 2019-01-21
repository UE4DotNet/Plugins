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
using UE4.LiveLinkInterface.Native;

namespace UE4.LiveLinkInterface {
    ///<summary>Base class for live link source settings (can be replaced by sources themselves)</summary>
    public unsafe partial class LiveLinkSourceSettings : UObject  {
         //TODO: enum ELiveLinkSourceMode Mode
        ///<summary>Only used when Mode is set to Interpolated.</summary>
        public unsafe LiveLinkInterpolationSettings InterpolationSettings {
            get {return LiveLinkSourceSettings_ptr->InterpolationSettings;}
            set {LiveLinkSourceSettings_ptr->InterpolationSettings = value;}
        }
        ///<summary>Only used when Mode is set to TimeSynchronized.</summary>
        public unsafe LiveLinkTimeSynchronizationSettings TimeSynchronizationSettings {
            get {return LiveLinkSourceSettings_ptr->TimeSynchronizationSettings;}
            set {LiveLinkSourceSettings_ptr->TimeSynchronizationSettings = value;}
        }
        static LiveLinkSourceSettings() {
            StaticClass = Main.GetClass("LiveLinkSourceSettings");
        }
        internal unsafe LiveLinkSourceSettings_fields* LiveLinkSourceSettings_ptr => (LiveLinkSourceSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LiveLinkSourceSettings(IntPtr p) => UObject.Make<LiveLinkSourceSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LiveLinkSourceSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LiveLinkSourceSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
