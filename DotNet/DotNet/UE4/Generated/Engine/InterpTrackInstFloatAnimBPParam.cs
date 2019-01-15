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
    ///<summary>Interp Track Inst Float Anim BPParam</summary>
    public unsafe partial class InterpTrackInstFloatAnimBPParam : InterpTrackInst  {
        ///<summary>MIDs we're using to set the desired parameter.</summary>
        public unsafe AnimInstance AnimScriptInstance {
            get {return InterpTrackInstFloatAnimBPParam_ptr->AnimScriptInstance;}
            set {InterpTrackInstFloatAnimBPParam_ptr->AnimScriptInstance = value;}
        }
        ///<summary>Saved values for restoring state when exiting Matinee.</summary>
        public unsafe float ResetFloat {
            get {return InterpTrackInstFloatAnimBPParam_ptr->ResetFloat;}
            set {InterpTrackInstFloatAnimBPParam_ptr->ResetFloat = value;}
        }
        static InterpTrackInstFloatAnimBPParam() {
            StaticClass = Main.GetClass("InterpTrackInstFloatAnimBPParam");
        }
        internal unsafe InterpTrackInstFloatAnimBPParam_fields* InterpTrackInstFloatAnimBPParam_ptr => (InterpTrackInstFloatAnimBPParam_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstFloatAnimBPParam(IntPtr p) => UObject.Make<InterpTrackInstFloatAnimBPParam>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstFloatAnimBPParam DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstFloatAnimBPParam New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
