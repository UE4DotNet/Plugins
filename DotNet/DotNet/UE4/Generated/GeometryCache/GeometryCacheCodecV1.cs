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
    ///<summary>Geometry Cache Codec V1</summary>
    public unsafe partial class GeometryCacheCodecV1 : GeometryCacheCodecBase  {
        static GeometryCacheCodecV1() {
            StaticClass = Main.GetClass("GeometryCacheCodecV1");
        }
        internal unsafe GeometryCacheCodecV1_fields* GeometryCacheCodecV1_ptr => (GeometryCacheCodecV1_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheCodecV1(IntPtr p) => UObject.Make<GeometryCacheCodecV1>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheCodecV1 DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheCodecV1 New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
