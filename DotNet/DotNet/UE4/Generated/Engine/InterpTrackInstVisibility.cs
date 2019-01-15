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
    ///<summary>Interp Track Inst Visibility</summary>
    public unsafe partial class InterpTrackInstVisibility : InterpTrackInst  {
        ///<summary>Action</summary>
        public unsafe byte Action {
            get {return InterpTrackInstVisibility_ptr->Action;}
            set {InterpTrackInstVisibility_ptr->Action = value;}
        }
        ///<summary>Position we were in last time we evaluated.</summary>
        ///<remarks>During UpdateTrack, events between this time and the current time will be processed.</remarks>
        public unsafe float LastUpdatePosition {
            get {return InterpTrackInstVisibility_ptr->LastUpdatePosition;}
            set {InterpTrackInstVisibility_ptr->LastUpdatePosition = value;}
        }
        static InterpTrackInstVisibility() {
            StaticClass = Main.GetClass("InterpTrackInstVisibility");
        }
        internal unsafe InterpTrackInstVisibility_fields* InterpTrackInstVisibility_ptr => (InterpTrackInstVisibility_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstVisibility(IntPtr p) => UObject.Make<InterpTrackInstVisibility>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstVisibility DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstVisibility New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
