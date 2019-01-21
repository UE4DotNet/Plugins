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
using UE4.PIEPreviewDeviceProfileSelector.Native;

namespace UE4.PIEPreviewDeviceProfileSelector {
    ///<summary>PIEPreview Settings</summary>
    public unsafe partial class PIEPreviewSettings : UObject  {
        ///<summary>Window Pos X</summary>
        public unsafe int WindowPosX {
            get {return PIEPreviewSettings_ptr->WindowPosX;}
            set {PIEPreviewSettings_ptr->WindowPosX = value;}
        }
        ///<summary>Window Pos Y</summary>
        public unsafe int WindowPosY {
            get {return PIEPreviewSettings_ptr->WindowPosY;}
            set {PIEPreviewSettings_ptr->WindowPosY = value;}
        }
        ///<summary>Window Scaling Factor</summary>
        public unsafe float WindowScalingFactor {
            get {return PIEPreviewSettings_ptr->WindowScalingFactor;}
            set {PIEPreviewSettings_ptr->WindowScalingFactor = value;}
        }
        static PIEPreviewSettings() {
            StaticClass = Main.GetClass("PIEPreviewSettings");
        }
        internal unsafe PIEPreviewSettings_fields* PIEPreviewSettings_ptr => (PIEPreviewSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PIEPreviewSettings(IntPtr p) => UObject.Make<PIEPreviewSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PIEPreviewSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PIEPreviewSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
