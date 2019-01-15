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
using UE4.Paper2DEditor.Native;
using UE4.UnrealEd;

namespace UE4.Paper2DEditor {
    ///<summary>Paper Sprite Thumbnail Renderer</summary>
    public unsafe partial class PaperSpriteThumbnailRenderer : DefaultSizedThumbnailRenderer  {
        static PaperSpriteThumbnailRenderer() {
            StaticClass = Main.GetClass("PaperSpriteThumbnailRenderer");
        }
        internal unsafe PaperSpriteThumbnailRenderer_fields* PaperSpriteThumbnailRenderer_ptr => (PaperSpriteThumbnailRenderer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperSpriteThumbnailRenderer(IntPtr p) => UObject.Make<PaperSpriteThumbnailRenderer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperSpriteThumbnailRenderer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperSpriteThumbnailRenderer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
