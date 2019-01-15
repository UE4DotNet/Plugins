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
    ///<summary>Interface for assets/objects that can own UserData *</summary>
    public unsafe partial class GeometryCacheCodecBase : UObject  {
         //TODO: array not UObject TArray TopologyRanges
        static GeometryCacheCodecBase() {
            StaticClass = Main.GetClass("GeometryCacheCodecBase");
        }
        internal unsafe GeometryCacheCodecBase_fields* GeometryCacheCodecBase_ptr => (GeometryCacheCodecBase_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheCodecBase(IntPtr p) => UObject.Make<GeometryCacheCodecBase>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheCodecBase DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheCodecBase New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
