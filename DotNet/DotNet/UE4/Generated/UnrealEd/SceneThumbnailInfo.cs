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
using UE4.UnrealEd.Native;
using UE4.Engine;

namespace UE4.UnrealEd {
    ///<summary>Scene Thumbnail Info</summary>
    public unsafe partial class SceneThumbnailInfo : ThumbnailInfo  {
        ///<summary>The pitch of the orbit camera around the asset</summary>
        public unsafe float OrbitPitch {
            get {return SceneThumbnailInfo_ptr->OrbitPitch;}
            set {SceneThumbnailInfo_ptr->OrbitPitch = value;}
        }
        ///<summary>The yaw of the orbit camera around the asset</summary>
        public unsafe float OrbitYaw {
            get {return SceneThumbnailInfo_ptr->OrbitYaw;}
            set {SceneThumbnailInfo_ptr->OrbitYaw = value;}
        }
        ///<summary>The offset from the bounds sphere distance from the asset</summary>
        public unsafe float OrbitZoom {
            get {return SceneThumbnailInfo_ptr->OrbitZoom;}
            set {SceneThumbnailInfo_ptr->OrbitZoom = value;}
        }
        static SceneThumbnailInfo() {
            StaticClass = Main.GetClass("SceneThumbnailInfo");
        }
        internal unsafe SceneThumbnailInfo_fields* SceneThumbnailInfo_ptr => (SceneThumbnailInfo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SceneThumbnailInfo(IntPtr p) => UObject.Make<SceneThumbnailInfo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SceneThumbnailInfo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SceneThumbnailInfo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
