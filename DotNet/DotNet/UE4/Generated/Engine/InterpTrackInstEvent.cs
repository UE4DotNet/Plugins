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
    ///<summary>Interp Track Inst Event</summary>
    public unsafe partial class InterpTrackInstEvent : InterpTrackInst  {
        ///<summary>Position we were in last time we evaluated Events.</summary>
        ///<remarks>During UpdateTrack, events between this time and the current time will be fired.</remarks>
        public unsafe float LastUpdatePosition {
            get {return InterpTrackInstEvent_ptr->LastUpdatePosition;}
            set {InterpTrackInstEvent_ptr->LastUpdatePosition = value;}
        }
        static InterpTrackInstEvent() {
            StaticClass = Main.GetClass("InterpTrackInstEvent");
        }
        internal unsafe InterpTrackInstEvent_fields* InterpTrackInstEvent_ptr => (InterpTrackInstEvent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstEvent(IntPtr p) => UObject.Make<InterpTrackInstEvent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstEvent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstEvent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
