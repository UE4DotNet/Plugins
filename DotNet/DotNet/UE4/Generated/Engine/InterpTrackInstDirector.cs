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
    ///<summary>Interp Track Inst Director</summary>
    public unsafe partial class InterpTrackInstDirector : InterpTrackInst  {
        ///<summary>Old View Target</summary>
        public unsafe Actor OldViewTarget {
            get {return InterpTrackInstDirector_ptr->OldViewTarget;}
            set {InterpTrackInstDirector_ptr->OldViewTarget = value;}
        }
        static InterpTrackInstDirector() {
            StaticClass = Main.GetClass("InterpTrackInstDirector");
        }
        internal unsafe InterpTrackInstDirector_fields* InterpTrackInstDirector_ptr => (InterpTrackInstDirector_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstDirector(IntPtr p) => UObject.Make<InterpTrackInstDirector>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstDirector DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstDirector New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
