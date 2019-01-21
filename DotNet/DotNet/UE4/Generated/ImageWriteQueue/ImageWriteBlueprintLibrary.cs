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
using UE4.ImageWriteQueue.Native;
using UE4.Engine;

namespace UE4.ImageWriteQueue {
    ///<summary>Function library containing utility methods for writing images on a global async queue</summary>
    public unsafe partial class ImageWriteBlueprintLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Export the specified texture to disk
        ///@
        ///</summary>
        ///<remarks>
        ///param Texture         The texture or render target to export
        ///@param Filename        The filename on disk to save as
        ///@param Options         Parameters defining the various export options
        ///</remarks>
        public static void ExportToDisk(Texture Texture, string Filename, ImageWriteOptions Options)  => 
            ImageWriteBlueprintLibrary_methods.ExportToDisk_method.Invoke(Texture, Filename, Options);
        static ImageWriteBlueprintLibrary() {
            StaticClass = Main.GetClass("ImageWriteBlueprintLibrary");
        }
        internal unsafe ImageWriteBlueprintLibrary_fields* ImageWriteBlueprintLibrary_ptr => (ImageWriteBlueprintLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImageWriteBlueprintLibrary(IntPtr p) => UObject.Make<ImageWriteBlueprintLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImageWriteBlueprintLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImageWriteBlueprintLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
