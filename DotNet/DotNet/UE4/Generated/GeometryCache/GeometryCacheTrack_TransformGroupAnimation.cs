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
    ///<summary>Derived GeometryCacheTrack class, used for Transform animation.</summary>
    public unsafe partial class GeometryCacheTrack_TransformGroupAnimation : GeometryCacheTrack  {
        static GeometryCacheTrack_TransformGroupAnimation() {
            StaticClass = Main.GetClass("GeometryCacheTrack_TransformGroupAnimation");
        }
        internal unsafe GeometryCacheTrack_TransformGroupAnimation_fields* GeometryCacheTrack_TransformGroupAnimation_ptr => (GeometryCacheTrack_TransformGroupAnimation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheTrack_TransformGroupAnimation(IntPtr p) => UObject.Make<GeometryCacheTrack_TransformGroupAnimation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheTrack_TransformGroupAnimation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheTrack_TransformGroupAnimation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
