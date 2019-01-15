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
    ///<summary>A media source that selects other media sources based on target platform.</summary>
    ///<remarks>Use this asset to override media sources on a per-platform basis.</remarks>
    public unsafe partial class PlatformMediaSource : MediaSource  {
         //TODO: map TMap PlatformMediaSources
        ///<summary>Default media source.</summary>
        ///<remarks>This media source will be used if no source was specified for a target platform.</remarks>
        public unsafe MediaSource MediaSource {
            get {return PlatformMediaSource_ptr->MediaSource;}
            set {PlatformMediaSource_ptr->MediaSource = value;}
        }
        static PlatformMediaSource() {
            StaticClass = Main.GetClass("PlatformMediaSource");
        }
        internal unsafe PlatformMediaSource_fields* PlatformMediaSource_ptr => (PlatformMediaSource_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PlatformMediaSource(IntPtr p) => UObject.Make<PlatformMediaSource>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PlatformMediaSource DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PlatformMediaSource New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
