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
using UE4.ImgMediaFactory.Native;

namespace UE4.ImgMediaFactory {
    ///<summary>Settings for the ImgMedia module.</summary>
    public unsafe partial class ImgMediaSettings : UObject  {
        ///<summary>Default frame rate to use if none was specified in image sequence or media source (default = 1/24).</summary>
        public unsafe FrameRate DefaultFrameRate {
            get {return ImgMediaSettings_ptr->DefaultFrameRate;}
            set {ImgMediaSettings_ptr->DefaultFrameRate = value;}
        }
        ///<summary>Percentage of cache to use for frames behind the play head (default = 25%).</summary>
        public unsafe float CacheBehindPercentage {
            get {return ImgMediaSettings_ptr->CacheBehindPercentage;}
            set {ImgMediaSettings_ptr->CacheBehindPercentage = value;}
        }
        ///<summary>Maximum size of the look-ahead cache (in GB; default = 1 GB).</summary>
        public unsafe float CacheSizeGB {
            get {return ImgMediaSettings_ptr->CacheSizeGB;}
            set {ImgMediaSettings_ptr->CacheSizeGB = value;}
        }
        ///<summary>Maximum number of image caching threads to use (0 = number of cores, default = 8).</summary>
        public unsafe int CacheThreads {
            get {return ImgMediaSettings_ptr->CacheThreads;}
            set {ImgMediaSettings_ptr->CacheThreads = value;}
        }
        ///<summary>Size of the stack for each caching thread (in kB; default = 128).</summary>
        public unsafe int CacheThreadStackSizeKB {
            get {return ImgMediaSettings_ptr->CacheThreadStackSizeKB;}
            set {ImgMediaSettings_ptr->CacheThreadStackSizeKB = value;}
        }
         //TODO: numeric uint32 ExrDecoderThreads
         //TODO: string FString DefaultProxy
        public bool UseDefaultProxy {
            get {return Main.GetGetBoolPropertyByName(this, "UseDefaultProxy"); }
            set {Main.SetGetBoolPropertyByName(this, "UseDefaultProxy", value); }
        }
        static ImgMediaSettings() {
            StaticClass = Main.GetClass("ImgMediaSettings");
        }
        internal unsafe ImgMediaSettings_fields* ImgMediaSettings_ptr => (ImgMediaSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ImgMediaSettings(IntPtr p) => UObject.Make<ImgMediaSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ImgMediaSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ImgMediaSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
