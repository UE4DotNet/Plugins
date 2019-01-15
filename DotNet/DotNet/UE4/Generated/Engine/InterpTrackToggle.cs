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
    ///<summary>Interp Track Toggle</summary>
    public unsafe partial class InterpTrackToggle : InterpTrack  {
         //TODO: array not UObject TArray ToggleTrack
        public bool bActivateSystemEachUpdate {
            get {return Main.GetGetBoolPropertyByName(this, "bActivateSystemEachUpdate"); }
            set {Main.SetGetBoolPropertyByName(this, "bActivateSystemEachUpdate", value); }
        }
        public bool bActivateWithJustAttachedFlag {
            get {return Main.GetGetBoolPropertyByName(this, "bActivateWithJustAttachedFlag"); }
            set {Main.SetGetBoolPropertyByName(this, "bActivateWithJustAttachedFlag", value); }
        }
        public bool bFireEventsWhenForwards {
            get {return Main.GetGetBoolPropertyByName(this, "bFireEventsWhenForwards"); }
            set {Main.SetGetBoolPropertyByName(this, "bFireEventsWhenForwards", value); }
        }
        public bool bFireEventsWhenBackwards {
            get {return Main.GetGetBoolPropertyByName(this, "bFireEventsWhenBackwards"); }
            set {Main.SetGetBoolPropertyByName(this, "bFireEventsWhenBackwards", value); }
        }
        public bool bFireEventsWhenJumpingForwards {
            get {return Main.GetGetBoolPropertyByName(this, "bFireEventsWhenJumpingForwards"); }
            set {Main.SetGetBoolPropertyByName(this, "bFireEventsWhenJumpingForwards", value); }
        }
        static InterpTrackToggle() {
            StaticClass = Main.GetClass("InterpTrackToggle");
        }
        internal unsafe InterpTrackToggle_fields* InterpTrackToggle_ptr => (InterpTrackToggle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackToggle(IntPtr p) => UObject.Make<InterpTrackToggle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackToggle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackToggle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
