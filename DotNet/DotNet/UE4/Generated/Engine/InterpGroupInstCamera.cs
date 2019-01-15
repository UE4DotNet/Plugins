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
    ///<summary>Interp Group Inst Camera</summary>
    public unsafe partial class InterpGroupInstCamera : InterpGroupInst  {
        static InterpGroupInstCamera() {
            StaticClass = Main.GetClass("InterpGroupInstCamera");
        }
        internal unsafe InterpGroupInstCamera_fields* InterpGroupInstCamera_ptr => (InterpGroupInstCamera_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InterpGroupInstCamera(IntPtr p) => UObject.Make<InterpGroupInstCamera>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InterpGroupInstCamera DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InterpGroupInstCamera New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
