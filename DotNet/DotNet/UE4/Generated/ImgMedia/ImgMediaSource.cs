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
using UE4.ImgMedia.Native;
using UE4.Engine;
using UE4.MediaAssets;

namespace UE4.ImgMedia {
    ///<summary>Media source for EXR image sequences.</summary>
    ///<remarks>
    ///Image sequence media sources point to a directory that contains a series of
    ///image files in which each image represents a single frame of the sequence.
    ///BMP, EXR, PNG and JPG images are currently supported. EXR image sequences
    ///are optimized for performance. The first frame of an image sequence is used
    ///to determine the image dimensions (all formats) and frame rate (EXR only).
    ///
    ///The image sequence directory may contain sub-directories, which are called
    ///'proxies'. Proxies can be used to provide alternative media for playback
    ///during development and testing of a game. One common scenario is the use
    ///of low resolution versions of image sequence media on computers that are
    ///too slow or don't have enough storage to play the original high-res media.
    ///</remarks>
    public unsafe partial class ImgMediaSource : BaseMediaSource  {

        ///<summary>Get the names of available proxy directories.</summary>
        ///<remarks>
        ///@param OutProxies Will contain the names of available proxy directories, if any.
        ///@see GetSequencePath
        ///</remarks>
        public IReadOnlyCollection<string> GetProxies()  => 
            ImgMediaSource_methods.GetProxies_method.Invoke(ObjPointer);

        ///<summary>Get the path to the image sequence directory to be played.</summary>
        ///<remarks>
        ///@return The file path.
        ///@see SetSequencePath
        ///</remarks>
        public string GetSequencePath()  => 
            ImgMediaSource_methods.GetSequencePath_method.Invoke(ObjPointer);

        ///<summary>Set the path to the image sequence directory this source represents.</summary>
        ///<remarks>
        ///@param Path The path to set.
        ///@see GetSequencePath
        ///</remarks>
        public void SetSequencePath(string Path)  => 
            ImgMediaSource_methods.SetSequencePath_method.Invoke(ObjPointer, Path);
        ///<summary>Overrides the default frame rate stored in the image files (0/0 = do not override).</summary>
        public unsafe FrameRate FrameRateOverride {
            get {return ImgMediaSource_ptr->FrameRateOverride;}
            set {ImgMediaSource_ptr->FrameRateOverride = value;}
        }
         //TODO: string FString ProxyOverride
        ///<summary>The directory that contains the image sequence files.</summary>
        public unsafe DirectoryPath SequencePath {
            get {return ImgMediaSource_ptr->SequencePath;}
        }
        static ImgMediaSource() {
            StaticClass = Main.GetClass("ImgMediaSource");
        }
        internal unsafe ImgMediaSource_fields* ImgMediaSource_ptr => (ImgMediaSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImgMediaSource(IntPtr p) => UObject.Make<ImgMediaSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImgMediaSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImgMediaSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
