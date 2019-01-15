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
    ///<summary>Interp Track Inst Slomo</summary>
    public unsafe partial class InterpTrackInstSlomo : InterpTrackInst  {
        ///<summary>Backup of initial LevelInfo MatineeTimeDilation setting when interpolation started.</summary>
        public unsafe float OldTimeDilation {
            get {return InterpTrackInstSlomo_ptr->OldTimeDilation;}
            set {InterpTrackInstSlomo_ptr->OldTimeDilation = value;}
        }
        static InterpTrackInstSlomo() {
            StaticClass = Main.GetClass("InterpTrackInstSlomo");
        }
        internal unsafe InterpTrackInstSlomo_fields* InterpTrackInstSlomo_ptr => (InterpTrackInstSlomo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstSlomo(IntPtr p) => UObject.Make<InterpTrackInstSlomo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstSlomo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstSlomo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
