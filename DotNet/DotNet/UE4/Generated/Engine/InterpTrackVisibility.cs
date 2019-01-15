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
    ///<summary>Interp Track Visibility</summary>
    public unsafe partial class InterpTrackVisibility : InterpTrack  {
         //TODO: array not UObject TArray VisibilityTrack
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
        static InterpTrackVisibility() {
            StaticClass = Main.GetClass("InterpTrackVisibility");
        }
        internal unsafe InterpTrackVisibility_fields* InterpTrackVisibility_ptr => (InterpTrackVisibility_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackVisibility(IntPtr p) => UObject.Make<InterpTrackVisibility>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackVisibility DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackVisibility New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
