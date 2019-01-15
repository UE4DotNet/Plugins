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
    ///<summary>Interp Track Inst Color Scale</summary>
    public unsafe partial class InterpTrackInstColorScale : InterpTrackInst  {
        static InterpTrackInstColorScale() {
            StaticClass = Main.GetClass("InterpTrackInstColorScale");
        }
        internal unsafe InterpTrackInstColorScale_fields* InterpTrackInstColorScale_ptr => (InterpTrackInstColorScale_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpTrackInstColorScale(IntPtr p) => UObject.Make<InterpTrackInstColorScale>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpTrackInstColorScale DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpTrackInstColorScale New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
