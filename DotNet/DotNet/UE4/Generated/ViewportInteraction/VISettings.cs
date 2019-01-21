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
using UE4.ViewportInteraction.Native;

namespace UE4.ViewportInteraction {
    ///<summary>Implements the settings for Viewport Interaction and VR Mode. Note that this is primarily a base class for anything that needs to be accessed in the VI module.</summary>
    public unsafe partial class VISettings : UObject  {
        public bool bScaleWorldFromFloor {
            get {return Main.GetGetBoolPropertyByName(this, "bScaleWorldFromFloor"); }
            set {Main.SetGetBoolPropertyByName(this, "bScaleWorldFromFloor", value); }
        }
        public bool bScaleWorldWithDynamicPivot {
            get {return Main.GetGetBoolPropertyByName(this, "bScaleWorldWithDynamicPivot"); }
            set {Main.SetGetBoolPropertyByName(this, "bScaleWorldWithDynamicPivot", value); }
        }
        public bool bAllowSimultaneousWorldScalingAndRotation {
            get {return Main.GetGetBoolPropertyByName(this, "bAllowSimultaneousWorldScalingAndRotation"); }
            set {Main.SetGetBoolPropertyByName(this, "bAllowSimultaneousWorldScalingAndRotation", value); }
        }
        static VISettings() {
            StaticClass = Main.GetClass("VISettings");
        }
        internal unsafe VISettings_fields* VISettings_ptr => (VISettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VISettings(IntPtr p) => UObject.Make<VISettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VISettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VISettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
