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
    ///<summary>Interface Post Process Volume</summary>
    public unsafe partial class Interface_PostProcessVolume : Interface  {
        static Interface_PostProcessVolume() {
            StaticClass = Main.GetClass("Interface_PostProcessVolume");
        }
        internal unsafe Interface_PostProcessVolume_fields* Interface_PostProcessVolume_ptr => (Interface_PostProcessVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Interface_PostProcessVolume(IntPtr p) => UObject.Make<Interface_PostProcessVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Interface_PostProcessVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Interface_PostProcessVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
