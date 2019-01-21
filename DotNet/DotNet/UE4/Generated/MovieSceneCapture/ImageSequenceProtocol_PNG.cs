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
using UE4.MovieSceneCapture.Native;

namespace UE4.MovieSceneCapture {
    ///<summary>Image Sequence Protocol PNG</summary>
    public unsafe partial class ImageSequenceProtocol_PNG : CompressedImageSequenceProtocol  {
        static ImageSequenceProtocol_PNG() {
            StaticClass = Main.GetClass("ImageSequenceProtocol_PNG");
        }
        internal unsafe ImageSequenceProtocol_PNG_fields* ImageSequenceProtocol_PNG_ptr => (ImageSequenceProtocol_PNG_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImageSequenceProtocol_PNG(IntPtr p) => UObject.Make<ImageSequenceProtocol_PNG>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImageSequenceProtocol_PNG DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImageSequenceProtocol_PNG New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
