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
    ///<summary>Compressed Image Sequence Protocol</summary>
    public unsafe partial class CompressedImageSequenceProtocol : ImageSequenceProtocol  {
        ///<summary>Level of compression to apply to the image, between 1 (worst quality, best compression) and 100 (best quality, worst compression)</summary>
        public unsafe int CompressionQuality {
            get {return CompressedImageSequenceProtocol_ptr->CompressionQuality;}
            set {CompressedImageSequenceProtocol_ptr->CompressionQuality = value;}
        }
        static CompressedImageSequenceProtocol() {
            StaticClass = Main.GetClass("CompressedImageSequenceProtocol");
        }
        internal unsafe CompressedImageSequenceProtocol_fields* CompressedImageSequenceProtocol_ptr => (CompressedImageSequenceProtocol_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CompressedImageSequenceProtocol(IntPtr p) => UObject.Make<CompressedImageSequenceProtocol>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CompressedImageSequenceProtocol DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CompressedImageSequenceProtocol New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
