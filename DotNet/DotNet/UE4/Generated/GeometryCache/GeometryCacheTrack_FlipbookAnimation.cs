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
    public unsafe partial class GeometryCacheTrack_FlipbookAnimation : GeometryCacheTrack  {
         //TODO: numeric uint32 NumMeshSamples
        static GeometryCacheTrack_FlipbookAnimation() {
            StaticClass = Main.GetClass("GeometryCacheTrack_FlipbookAnimation");
        }
        internal unsafe GeometryCacheTrack_FlipbookAnimation_fields* GeometryCacheTrack_FlipbookAnimation_ptr => (GeometryCacheTrack_FlipbookAnimation_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheTrack_FlipbookAnimation(IntPtr p) => UObject.Make<GeometryCacheTrack_FlipbookAnimation>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheTrack_FlipbookAnimation DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheTrack_FlipbookAnimation New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
