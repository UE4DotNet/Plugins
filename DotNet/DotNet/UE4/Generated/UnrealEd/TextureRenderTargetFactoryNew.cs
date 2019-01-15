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
    ///<summary>Texture Render Target Factory New</summary>
    public unsafe partial class TextureRenderTargetFactoryNew : Factory  {
        ///<summary>Width of the texture render target</summary>
        public unsafe int Width {
            get {return TextureRenderTargetFactoryNew_ptr->Width;}
            set {TextureRenderTargetFactoryNew_ptr->Width = value;}
        }
        ///<summary>Height of the texture render target</summary>
        public unsafe int Height {
            get {return TextureRenderTargetFactoryNew_ptr->Height;}
            set {TextureRenderTargetFactoryNew_ptr->Height = value;}
        }
        ///<summary>Pixel format of the texture render target</summary>
        public unsafe byte Format {
            get {return TextureRenderTargetFactoryNew_ptr->Format;}
            set {TextureRenderTargetFactoryNew_ptr->Format = value;}
        }
        static TextureRenderTargetFactoryNew() {
            StaticClass = Main.GetClass("TextureRenderTargetFactoryNew");
        }
        internal unsafe TextureRenderTargetFactoryNew_fields* TextureRenderTargetFactoryNew_ptr => (TextureRenderTargetFactoryNew_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureRenderTargetFactoryNew(IntPtr p) => UObject.Make<TextureRenderTargetFactoryNew>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureRenderTargetFactoryNew DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureRenderTargetFactoryNew New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
