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
    ///<summary>Anim Compress Bitwise Compress Only</summary>
    public unsafe partial class AnimCompress_BitwiseCompressOnly : AnimCompress  {
        static AnimCompress_BitwiseCompressOnly() {
            StaticClass = Main.GetClass("AnimCompress_BitwiseCompressOnly");
        }
        internal unsafe AnimCompress_BitwiseCompressOnly_fields* AnimCompress_BitwiseCompressOnly_ptr => (AnimCompress_BitwiseCompressOnly_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress_BitwiseCompressOnly(IntPtr p) => UObject.Make<AnimCompress_BitwiseCompressOnly>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress_BitwiseCompressOnly DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress_BitwiseCompressOnly New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
