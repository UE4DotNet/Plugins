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
    ///<summary>Defines an interface by which touch input can be controlled using any number of buttons and virtual joysticks</summary>
    public unsafe partial class TouchInterface : UObject  {
         //TODO: array not UObject TArray Controls
        ///<summary>Opacity (0.0 - 1.0) of all controls while any control is active</summary>
        public unsafe float ActiveOpacity {
            get {return TouchInterface_ptr->ActiveOpacity;}
            set {TouchInterface_ptr->ActiveOpacity = value;}
        }
        ///<summary>Opacity (0.0 - 1.0) of all controls while no controls are active</summary>
        public unsafe float InactiveOpacity {
            get {return TouchInterface_ptr->InactiveOpacity;}
            set {TouchInterface_ptr->InactiveOpacity = value;}
        }
        ///<summary>How long after user interaction will all controls fade out to Inactive Opacity</summary>
        public unsafe float TimeUntilDeactive {
            get {return TouchInterface_ptr->TimeUntilDeactive;}
            set {TouchInterface_ptr->TimeUntilDeactive = value;}
        }
        ///<summary>How long after going inactive will controls reset/recenter themselves (0.0 will disable this feature)</summary>
        public unsafe float TimeUntilReset {
            get {return TouchInterface_ptr->TimeUntilReset;}
            set {TouchInterface_ptr->TimeUntilReset = value;}
        }
        ///<summary>How long after joystick enabled for touch (0.0 will disable this feature)</summary>
        public unsafe float ActivationDelay {
            get {return TouchInterface_ptr->ActivationDelay;}
            set {TouchInterface_ptr->ActivationDelay = value;}
        }
        public bool bPreventRecenter {
            get {return Main.GetGetBoolPropertyByName(this, "bPreventRecenter"); }
            set {Main.SetGetBoolPropertyByName(this, "bPreventRecenter", value); }
        }
        ///<summary>Delay at startup before virtual joystick is drawn</summary>
        public unsafe float StartupDelay {
            get {return TouchInterface_ptr->StartupDelay;}
            set {TouchInterface_ptr->StartupDelay = value;}
        }
        static TouchInterface() {
            StaticClass = Main.GetClass("TouchInterface");
        }
        internal unsafe TouchInterface_fields* TouchInterface_ptr => (TouchInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TouchInterface(IntPtr p) => UObject.Make<TouchInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TouchInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TouchInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
