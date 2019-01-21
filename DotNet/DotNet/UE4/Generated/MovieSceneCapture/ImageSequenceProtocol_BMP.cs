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
    ///<summary>Image Sequence Protocol BMP</summary>
    public unsafe partial class ImageSequenceProtocol_BMP : ImageSequenceProtocol  {
        static ImageSequenceProtocol_BMP() {
            StaticClass = Main.GetClass("ImageSequenceProtocol_BMP");
        }
        internal unsafe ImageSequenceProtocol_BMP_fields* ImageSequenceProtocol_BMP_ptr => (ImageSequenceProtocol_BMP_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImageSequenceProtocol_BMP(IntPtr p) => UObject.Make<ImageSequenceProtocol_BMP>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImageSequenceProtocol_BMP DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImageSequenceProtocol_BMP New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
