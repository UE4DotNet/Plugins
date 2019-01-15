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
    ///<summary>Interp Track Inst Anim Control</summary>
    public unsafe partial class InterpTrackInstAnimControl : InterpTrackInst  {
        ///<summary>Last Update Position</summary>
        public unsafe float LastUpdatePosition {
            get {return InterpTrackInstAnimControl_ptr->LastUpdatePosition;}
            set {InterpTrackInstAnimControl_ptr->LastUpdatePosition = value;}
        }
        ///<summary>Init Position</summary>
        public unsafe Vector InitPosition {
            get {return InterpTrackInstAnimControl_ptr->InitPosition;}
            set {InterpTrackInstAnimControl_ptr->InitPosition = value;}
        }
        ///<summary>Init Rotation</summary>
        public unsafe Rotator InitRotation {
            get {return InterpTrackInstAnimControl_ptr->InitRotation;}
            set {InterpTrackInstAnimControl_ptr->InitRotation = value;}
        }
        static InterpTrackInstAnimControl() {
            StaticClass = Main.GetClass("InterpTrackInstAnimControl");
        }
        internal unsafe InterpTrackInstAnimControl_fields* InterpTrackInstAnimControl_ptr => (InterpTrackInstAnimControl_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstAnimControl(IntPtr p) => UObject.Make<InterpTrackInstAnimControl>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstAnimControl DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstAnimControl New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
