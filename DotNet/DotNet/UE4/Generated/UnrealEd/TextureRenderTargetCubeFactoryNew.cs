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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Texture Render Target Cube Factory New</summary>
    public unsafe partial class TextureRenderTargetCubeFactoryNew : Factory  {
        ///<summary>Width of the texture render target</summary>
        public unsafe int Width {
            get {return TextureRenderTargetCubeFactoryNew_ptr->Width;}
            set {TextureRenderTargetCubeFactoryNew_ptr->Width = value;}
        }
        ///<summary>Pixel format of the texture render target</summary>
        public unsafe byte Format {
            get {return TextureRenderTargetCubeFactoryNew_ptr->Format;}
            set {TextureRenderTargetCubeFactoryNew_ptr->Format = value;}
        }
        static TextureRenderTargetCubeFactoryNew() {
            StaticClass = Main.GetClass("TextureRenderTargetCubeFactoryNew");
        }
        internal unsafe TextureRenderTargetCubeFactoryNew_fields* TextureRenderTargetCubeFactoryNew_ptr => (TextureRenderTargetCubeFactoryNew_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureRenderTargetCubeFactoryNew(IntPtr p) => UObject.Make<TextureRenderTargetCubeFactoryNew>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureRenderTargetCubeFactoryNew DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureRenderTargetCubeFactoryNew New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
