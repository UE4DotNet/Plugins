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
    ///<summary>A volume which blocks the Camera channel by default.</summary>
    public unsafe partial class CameraBlockingVolume : Volume  {
        static CameraBlockingVolume() {
            StaticClass = Main.GetClass("CameraBlockingVolume");
        }
        internal unsafe CameraBlockingVolume_fields* CameraBlockingVolume_ptr => (CameraBlockingVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CameraBlockingVolume(IntPtr p) => UObject.Make<CameraBlockingVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CameraBlockingVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CameraBlockingVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
