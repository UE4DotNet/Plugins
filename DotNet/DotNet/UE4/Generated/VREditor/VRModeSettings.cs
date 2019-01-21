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
using UE4.VREditor.Native;
using UE4.ViewportInteraction;

namespace UE4.VREditor {
    ///<summary>Implements the settings for VR Mode.</summary>
    public unsafe partial class VRModeSettings : VISettings  {
        public bool bEnableAutoVREditMode {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableAutoVREditMode"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableAutoVREditMode", value); }
        }
        public bool bAutokeySequences {
            get {return Main.GetGetBoolPropertyByName(this, "bAutokeySequences"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutokeySequences", value); }
        }
         //TODO: enum EInteractorHand InteractorHand
        public bool bShowWorldMovementGrid {
            get {return Main.GetGetBoolPropertyByName(this, "bShowWorldMovementGrid"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowWorldMovementGrid", value); }
        }
        public bool bShowWorldMovementPostProcess {
            get {return Main.GetGetBoolPropertyByName(this, "bShowWorldMovementPostProcess"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowWorldMovementPostProcess", value); }
        }
        public bool bShowWorldScaleProgressBar {
            get {return Main.GetGetBoolPropertyByName(this, "bShowWorldScaleProgressBar"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowWorldScaleProgressBar", value); }
        }
        ///<summary>Adjusts the brightness of the UI panels</summary>
        public unsafe float UIBrightness {
            get {return VRModeSettings_ptr->UIBrightness;}
            set {VRModeSettings_ptr->UIBrightness = value;}
        }
        ///<summary>The size of the transform gizmo</summary>
        public unsafe float GizmoScale {
            get {return VRModeSettings_ptr->GizmoScale;}
            set {VRModeSettings_ptr->GizmoScale = value;}
        }
        ///<summary>The maximum time in seconds between two clicks for a double-click to register</summary>
        public unsafe float DoubleClickTime {
            get {return VRModeSettings_ptr->DoubleClickTime;}
            set {VRModeSettings_ptr->DoubleClickTime = value;}
        }
        ///<summary>The amount (between 0-1) you have to depress the Vive controller trigger to register a press</summary>
        public unsafe float TriggerPressedThreshold_Vive {
            get {return VRModeSettings_ptr->TriggerPressedThreshold_Vive;}
            set {VRModeSettings_ptr->TriggerPressedThreshold_Vive = value;}
        }
        ///<summary>The amount (between 0-1) you have to depress the Oculus Touch controller trigger to register a press</summary>
        public unsafe float TriggerPressedThreshold_Rift {
            get {return VRModeSettings_ptr->TriggerPressedThreshold_Rift;}
            set {VRModeSettings_ptr->TriggerPressedThreshold_Rift = value;}
        }
        static VRModeSettings() {
            StaticClass = Main.GetClass("VRModeSettings");
        }
        internal unsafe VRModeSettings_fields* VRModeSettings_ptr => (VRModeSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VRModeSettings(IntPtr p) => UObject.Make<VRModeSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VRModeSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VRModeSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
