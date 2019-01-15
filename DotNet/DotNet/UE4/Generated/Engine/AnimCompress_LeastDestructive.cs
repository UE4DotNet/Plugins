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
    ///<summary>Anim Compress Least Destructive</summary>
    public unsafe partial class AnimCompress_LeastDestructive : AnimCompress  {
        static AnimCompress_LeastDestructive() {
            StaticClass = Main.GetClass("AnimCompress_LeastDestructive");
        }
        internal unsafe AnimCompress_LeastDestructive_fields* AnimCompress_LeastDestructive_ptr => (AnimCompress_LeastDestructive_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator AnimCompress_LeastDestructive(IntPtr p) => UObject.Make<AnimCompress_LeastDestructive>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static AnimCompress_LeastDestructive DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static AnimCompress_LeastDestructive New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
