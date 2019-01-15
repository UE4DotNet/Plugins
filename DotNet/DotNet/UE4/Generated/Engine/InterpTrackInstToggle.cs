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
    ///<summary>Interp Track Inst Toggle</summary>
    public unsafe partial class InterpTrackInstToggle : InterpTrackInst  {
        ///<summary>Action</summary>
        public unsafe byte Action {
            get {return InterpTrackInstToggle_ptr->Action;}
            set {InterpTrackInstToggle_ptr->Action = value;}
        }
        ///<summary>Position we were in last time we evaluated.</summary>
        ///<remarks>During UpdateTrack, toggles between this time and the current time will be processed.</remarks>
        public unsafe float LastUpdatePosition {
            get {return InterpTrackInstToggle_ptr->LastUpdatePosition;}
            set {InterpTrackInstToggle_ptr->LastUpdatePosition = value;}
        }
        public bool bSavedActiveState {
            get {return Main.GetGetBoolPropertyByName(this, "bSavedActiveState"); }
            set {Main.SetGetBoolPropertyByName(this, "bSavedActiveState", value); }
        }
        static InterpTrackInstToggle() {
            StaticClass = Main.GetClass("InterpTrackInstToggle");
        }
        internal unsafe InterpTrackInstToggle_fields* InterpTrackInstToggle_ptr => (InterpTrackInstToggle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstToggle(IntPtr p) => UObject.Make<InterpTrackInstToggle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstToggle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstToggle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
