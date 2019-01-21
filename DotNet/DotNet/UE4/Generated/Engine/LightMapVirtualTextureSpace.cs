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
    ///<summary>Light Map Virtual Texture Space</summary>
    public unsafe partial class LightMapVirtualTextureSpace : VirtualTextureSpace  {
        static LightMapVirtualTextureSpace() {
            StaticClass = Main.GetClass("LightMapVirtualTextureSpace");
        }
        internal unsafe LightMapVirtualTextureSpace_fields* LightMapVirtualTextureSpace_ptr => (LightMapVirtualTextureSpace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LightMapVirtualTextureSpace(IntPtr p) => UObject.Make<LightMapVirtualTextureSpace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LightMapVirtualTextureSpace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LightMapVirtualTextureSpace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
