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
    ///<summary>Skeletal Mesh Thumbnail Renderer</summary>
    public unsafe partial class SkeletalMeshThumbnailRenderer : DefaultSizedThumbnailRenderer  {
        static SkeletalMeshThumbnailRenderer() {
            StaticClass = Main.GetClass("SkeletalMeshThumbnailRenderer");
        }
        internal unsafe SkeletalMeshThumbnailRenderer_fields* SkeletalMeshThumbnailRenderer_ptr => (SkeletalMeshThumbnailRenderer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SkeletalMeshThumbnailRenderer(IntPtr p) => UObject.Make<SkeletalMeshThumbnailRenderer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SkeletalMeshThumbnailRenderer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SkeletalMeshThumbnailRenderer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
