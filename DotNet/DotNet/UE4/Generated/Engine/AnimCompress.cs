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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Anim Compress</summary>
    public unsafe partial class AnimCompress : UObject  {
         //TODO: string FString Description
        public bool bNeedsSkeleton {
            get {return Main.GetGetBoolPropertyByName(this, "bNeedsSkeleton"); }
            set {Main.SetGetBoolPropertyByName(this, "bNeedsSkeleton", value); }
        }
        public bool bEnableSegmenting {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableSegmenting"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableSegmenting", value); }
        }
         //TODO: numeric uint32 IdealNumFramesPerSegment
         //TODO: numeric uint32 MaxNumFramesPerSegment
        ///<summary>Format for bitwise compression of translation data.</summary>
        public unsafe byte TranslationCompressionFormat {
            get {return AnimCompress_ptr->TranslationCompressionFormat;}
            set {AnimCompress_ptr->TranslationCompressionFormat = value;}
        }
        ///<summary>Format for bitwise compression of rotation data.</summary>
        public unsafe byte RotationCompressionFormat {
            get {return AnimCompress_ptr->RotationCompressionFormat;}
            set {AnimCompress_ptr->RotationCompressionFormat = value;}
        }
        ///<summary>Format for bitwise compression of scale data.</summary>
        public unsafe byte ScaleCompressionFormat {
            get {return AnimCompress_ptr->ScaleCompressionFormat;}
            set {AnimCompress_ptr->ScaleCompressionFormat = value;}
        }
        ///<summary>Max error for compression of curves using remove redundant keys</summary>
        public unsafe float MaxCurveError {
            get {return AnimCompress_ptr->MaxCurveError;}
            set {AnimCompress_ptr->MaxCurveError = value;}
        }
        static AnimCompress() {
            StaticClass = Main.GetClass("AnimCompress");
        }
        internal unsafe AnimCompress_fields* AnimCompress_ptr => (AnimCompress_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress(IntPtr p) => UObject.Make<AnimCompress>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
