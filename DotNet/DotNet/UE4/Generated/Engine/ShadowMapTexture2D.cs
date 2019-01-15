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
    ///<summary>Shadow Map Texture 2D</summary>
    public unsafe partial class ShadowMapTexture2D : Texture2D  {
        ///<summary>Bit-field with shadowmap flags.</summary>
        public unsafe byte ShadowmapFlags {
            get {return ShadowMapTexture2D_ptr->ShadowmapFlags;}
            set {ShadowMapTexture2D_ptr->ShadowmapFlags = value;}
        }
        static ShadowMapTexture2D() {
            StaticClass = Main.GetClass("ShadowMapTexture2D");
        }
        internal unsafe ShadowMapTexture2D_fields* ShadowMapTexture2D_ptr => (ShadowMapTexture2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ShadowMapTexture2D(IntPtr p) => UObject.Make<ShadowMapTexture2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ShadowMapTexture2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ShadowMapTexture2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
