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
using UE4.MagicLeapEmulator.Native;

namespace UE4.MagicLeapEmulator {
    ///<summary>Magic Leap Emulator Settings</summary>
    public unsafe partial class MagicLeapEmulatorSettings : UObject  {
        public bool bEnableMagicLeapEmulation {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableMagicLeapEmulation"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableMagicLeapEmulation", value); }
        }
        public bool bEnableCollisionWithBackground {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableCollisionWithBackground"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableCollisionWithBackground", value); }
        }
        public bool bLimitForegroundFOV {
            get {return Main.GetGetBoolPropertyByName(this, "bLimitForegroundFOV"); }
            set {Main.SetGetBoolPropertyByName(this, "bLimitForegroundFOV", value); }
        }
        ///<summary>Assumed aspect ratio of the ML display, to simulate the limited FOV. Ignored if bLimitForegroundFOV is false.</summary>
        public unsafe float ForegroundAspectRatio {
            get {return MagicLeapEmulatorSettings_ptr->ForegroundAspectRatio;}
            set {MagicLeapEmulatorSettings_ptr->ForegroundAspectRatio = value;}
        }
        ///<summary>In degrees. Ignored if bLimitForegroundFOV is false</summary>
        public unsafe float ForegroundHorizontalFOV {
            get {return MagicLeapEmulatorSettings_ptr->ForegroundHorizontalFOV;}
            set {MagicLeapEmulatorSettings_ptr->ForegroundHorizontalFOV = value;}
        }
        ///<summary>Emulator Compositing Material</summary>
        public unsafe SoftObjectPath EmulatorCompositingMaterial {
            get {return MagicLeapEmulatorSettings_ptr->EmulatorCompositingMaterial;}
            set {MagicLeapEmulatorSettings_ptr->EmulatorCompositingMaterial = value;}
        }
        static MagicLeapEmulatorSettings() {
            StaticClass = Main.GetClass("MagicLeapEmulatorSettings");
        }
        internal unsafe MagicLeapEmulatorSettings_fields* MagicLeapEmulatorSettings_ptr => (MagicLeapEmulatorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MagicLeapEmulatorSettings(IntPtr p) => UObject.Make<MagicLeapEmulatorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MagicLeapEmulatorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MagicLeapEmulatorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
