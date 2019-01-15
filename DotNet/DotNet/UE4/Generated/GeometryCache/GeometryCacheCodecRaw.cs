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
using UE4.GeometryCache.Native;

namespace UE4.GeometryCache {
    ///<summary>Geometry Cache Codec Raw</summary>
    public unsafe partial class GeometryCacheCodecRaw : GeometryCacheCodecBase  {
        ///<summary>Dummy Property</summary>
        public unsafe int DummyProperty {
            get {return GeometryCacheCodecRaw_ptr->DummyProperty;}
            set {GeometryCacheCodecRaw_ptr->DummyProperty = value;}
        }
        static GeometryCacheCodecRaw() {
            StaticClass = Main.GetClass("GeometryCacheCodecRaw");
        }
        internal unsafe GeometryCacheCodecRaw_fields* GeometryCacheCodecRaw_ptr => (GeometryCacheCodecRaw_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheCodecRaw(IntPtr p) => UObject.Make<GeometryCacheCodecRaw>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheCodecRaw DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheCodecRaw New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
