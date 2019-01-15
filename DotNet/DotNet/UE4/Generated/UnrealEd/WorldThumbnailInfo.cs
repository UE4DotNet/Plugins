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

namespace UE4.UnrealEd {
    ///<summary>World Thumbnail Info</summary>
    public unsafe partial class WorldThumbnailInfo : SceneThumbnailInfo  {
        ///<summary>The type of projection to use</summary>
        public unsafe byte CameraMode {
            get {return WorldThumbnailInfo_ptr->CameraMode;}
            set {WorldThumbnailInfo_ptr->CameraMode = value;}
        }
        ///<summary>The direction of the camera when in Orthographic CameraMode</summary>
        public unsafe byte OrthoDirection {
            get {return WorldThumbnailInfo_ptr->OrthoDirection;}
            set {WorldThumbnailInfo_ptr->OrthoDirection = value;}
        }
        static WorldThumbnailInfo() {
            StaticClass = Main.GetClass("WorldThumbnailInfo");
        }
        internal unsafe WorldThumbnailInfo_fields* WorldThumbnailInfo_ptr => (WorldThumbnailInfo_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WorldThumbnailInfo(IntPtr p) => UObject.Make<WorldThumbnailInfo>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WorldThumbnailInfo DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WorldThumbnailInfo New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
