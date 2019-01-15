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
    ///<summary>Particle System Thumbnail Renderer</summary>
    public unsafe partial class ParticleSystemThumbnailRenderer : TextureThumbnailRenderer  {
        ///<summary>No Image</summary>
        public unsafe Texture2D NoImage {
            get {return ParticleSystemThumbnailRenderer_ptr->NoImage;}
            set {ParticleSystemThumbnailRenderer_ptr->NoImage = value;}
        }
        ///<summary>Out Of Date</summary>
        public unsafe Texture2D OutOfDate {
            get {return ParticleSystemThumbnailRenderer_ptr->OutOfDate;}
            set {ParticleSystemThumbnailRenderer_ptr->OutOfDate = value;}
        }
        static ParticleSystemThumbnailRenderer() {
            StaticClass = Main.GetClass("ParticleSystemThumbnailRenderer");
        }
        internal unsafe ParticleSystemThumbnailRenderer_fields* ParticleSystemThumbnailRenderer_ptr => (ParticleSystemThumbnailRenderer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ParticleSystemThumbnailRenderer(IntPtr p) => UObject.Make<ParticleSystemThumbnailRenderer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ParticleSystemThumbnailRenderer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ParticleSystemThumbnailRenderer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
