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
    ///<remarks>
    ///\note FGeometryCacheTrackStreamableRenderResource keeps a reference to the track.
    ///Be sure to keep the implementation of this class valid so it properly releases
    ///the render resoruce before making any changes to this object that may affect the render thread.
    ///</remarks>
    public unsafe partial class GeometryCacheTrackStreamable : GeometryCacheTrack  {
        ///<summary>Codec for this track</summary>
        public unsafe GeometryCacheCodecBase Codec {
            get {return GeometryCacheTrackStreamable_ptr->Codec;}
            set {GeometryCacheTrackStreamable_ptr->Codec = value;}
        }
        ///<summary>Start Sample Time</summary>
        public unsafe float StartSampleTime {
            get {return GeometryCacheTrackStreamable_ptr->StartSampleTime;}
            set {GeometryCacheTrackStreamable_ptr->StartSampleTime = value;}
        }
        static GeometryCacheTrackStreamable() {
            StaticClass = Main.GetClass("GeometryCacheTrackStreamable");
        }
        internal unsafe GeometryCacheTrackStreamable_fields* GeometryCacheTrackStreamable_ptr => (GeometryCacheTrackStreamable_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheTrackStreamable(IntPtr p) => UObject.Make<GeometryCacheTrackStreamable>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheTrackStreamable DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheTrackStreamable New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
