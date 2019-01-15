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
    ///<summary>Default Sized Thumbnail Renderer</summary>
    public unsafe partial class DefaultSizedThumbnailRenderer : ThumbnailRenderer  {
        ///<summary>The default width of this thumbnail</summary>
        public unsafe int DefaultSizeX {
            get {return DefaultSizedThumbnailRenderer_ptr->DefaultSizeX;}
            set {DefaultSizedThumbnailRenderer_ptr->DefaultSizeX = value;}
        }
        ///<summary>The default height of this thumbnail</summary>
        public unsafe int DefaultSizeY {
            get {return DefaultSizedThumbnailRenderer_ptr->DefaultSizeY;}
            set {DefaultSizedThumbnailRenderer_ptr->DefaultSizeY = value;}
        }
        static DefaultSizedThumbnailRenderer() {
            StaticClass = Main.GetClass("DefaultSizedThumbnailRenderer");
        }
        internal unsafe DefaultSizedThumbnailRenderer_fields* DefaultSizedThumbnailRenderer_ptr => (DefaultSizedThumbnailRenderer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DefaultSizedThumbnailRenderer(IntPtr p) => UObject.Make<DefaultSizedThumbnailRenderer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DefaultSizedThumbnailRenderer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DefaultSizedThumbnailRenderer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
