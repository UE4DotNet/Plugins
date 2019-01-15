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
using UE4.MediaAssets.Native;

namespace UE4.MediaAssets {
    ///<summary>Abstract base class for media sources.</summary>
    ///<remarks>
    ///Media sources describe the location and/or settings of media objects that can
    ///be played in a media player, such as a video file on disk, a video stream on
    ///the internet, or a web cam attached to or built into the target device. The
    ///location is encoded as a media URL string, whose URI scheme and optional file
    ///extension will be used to locate a suitable media player.
    ///</remarks>
    public unsafe partial class MediaSource : UObject  {

        ///<summary>Get the media source's URL string (must be implemented in child classes).</summary>
        ///<remarks>
        ///@return The media URL.
        ///@see GetProxies
        ///</remarks>
        public string GetUrl()  => 
            MediaSource_methods.GetUrl_method.Invoke(ObjPointer);

        ///<summary>Validate the media source settings (must be implemented in child classes).</summary>
        ///<remarks>
        ///@return true if validation passed, false otherwise.
        ///</remarks>
        public bool Validate()  => 
            MediaSource_methods.Validate_method.Invoke(ObjPointer);
        static MediaSource() {
            StaticClass = Main.GetClass("MediaSource");
        }
        internal unsafe MediaSource_fields* MediaSource_ptr => (MediaSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MediaSource(IntPtr p) => UObject.Make<MediaSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MediaSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MediaSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
