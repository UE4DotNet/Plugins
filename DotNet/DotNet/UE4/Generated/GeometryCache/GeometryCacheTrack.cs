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
    ///<summary>Base class for GeometryCache tracks, stores matrix animation data and implements functionality for it</summary>
    public unsafe partial class GeometryCacheTrack : UObject  {
        ///<summary>The duration of this track's animation.</summary>
        ///<remarks>
        ///This is an open ended interval [0..Duration[.
        ///If the animation is looping this is also the length of the loop.
        ///
        ///Note: This is set by the importer possibly based on user preferences. There may be less actual frames available.
        ///E.g. the animation has data for the first 2 seconds, but duration is set to 5, so it will loop every 5 seconds
        ///with the last three seconds showing a static scene.
        ///</remarks>
        public unsafe float Duration {
            get {return GeometryCacheTrack_ptr->Duration;}
            set {GeometryCacheTrack_ptr->Duration = value;}
        }
        static GeometryCacheTrack() {
            StaticClass = Main.GetClass("GeometryCacheTrack");
        }
        internal unsafe GeometryCacheTrack_fields* GeometryCacheTrack_ptr => (GeometryCacheTrack_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GeometryCacheTrack(IntPtr p) => UObject.Make<GeometryCacheTrack>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GeometryCacheTrack DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GeometryCacheTrack New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
