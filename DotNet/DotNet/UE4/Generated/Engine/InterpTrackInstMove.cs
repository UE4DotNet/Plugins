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
    ///<summary>Interp Track Inst Move</summary>
    public unsafe partial class InterpTrackInstMove : InterpTrackInst  {
        ///<summary>Saved position. Used in editor for resetting when quitting Matinee.</summary>
        public unsafe Vector ResetLocation {
            get {return InterpTrackInstMove_ptr->ResetLocation;}
            set {InterpTrackInstMove_ptr->ResetLocation = value;}
        }
        ///<summary>Saved rotation. Used in editor for resetting when quitting Matinee.</summary>
        public unsafe Rotator ResetRotation {
            get {return InterpTrackInstMove_ptr->ResetRotation;}
            set {InterpTrackInstMove_ptr->ResetRotation = value;}
        }
        static InterpTrackInstMove() {
            StaticClass = Main.GetClass("InterpTrackInstMove");
        }
        internal unsafe InterpTrackInstMove_fields* InterpTrackInstMove_ptr => (InterpTrackInstMove_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstMove(IntPtr p) => UObject.Make<InterpTrackInstMove>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstMove DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstMove New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
