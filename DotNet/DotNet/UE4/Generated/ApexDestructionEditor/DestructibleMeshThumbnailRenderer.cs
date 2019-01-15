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
using UE4.ApexDestructionEditor.Native;
using UE4.UnrealEd;

namespace UE4.ApexDestructionEditor {
    ///<summary>Destructible Mesh Thumbnail Renderer</summary>
    public unsafe partial class DestructibleMeshThumbnailRenderer : DefaultSizedThumbnailRenderer  {
        static DestructibleMeshThumbnailRenderer() {
            StaticClass = Main.GetClass("DestructibleMeshThumbnailRenderer");
        }
        internal unsafe DestructibleMeshThumbnailRenderer_fields* DestructibleMeshThumbnailRenderer_ptr => (DestructibleMeshThumbnailRenderer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DestructibleMeshThumbnailRenderer(IntPtr p) => UObject.Make<DestructibleMeshThumbnailRenderer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DestructibleMeshThumbnailRenderer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DestructibleMeshThumbnailRenderer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
