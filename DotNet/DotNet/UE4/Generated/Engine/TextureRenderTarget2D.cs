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
    ///<summary>
    ///TextureRenderTarget2D
    ///2D render target texture resource.
    ///</summary>
    ///<remarks>
    ///This can be used as a target
    ///for rendering as well as rendered as a regular 2D texture resource.
    ///</remarks>
    public unsafe partial class TextureRenderTarget2D : TextureRenderTarget  {
        ///<summary>The width of the texture.</summary>
        public unsafe int SizeX {
            get {return TextureRenderTarget2D_ptr->SizeX;}
        }
        ///<summary>The height of the texture.</summary>
        public unsafe int SizeY {
            get {return TextureRenderTarget2D_ptr->SizeY;}
        }
        ///<summary>the color the texture is cleared to</summary>
        public unsafe LinearColor ClearColor {
            get {return TextureRenderTarget2D_ptr->ClearColor;}
        }
        ///<summary>The addressing mode to use for the X axis.</summary>
        public unsafe byte AddressX {
            get {return TextureRenderTarget2D_ptr->AddressX;}
            set {TextureRenderTarget2D_ptr->AddressX = value;}
        }
        ///<summary>The addressing mode to use for the Y axis.</summary>
        public unsafe byte AddressY {
            get {return TextureRenderTarget2D_ptr->AddressY;}
            set {TextureRenderTarget2D_ptr->AddressY = value;}
        }
        public bool bForceLinearGamma {
            get {return Main.GetGetBoolPropertyByName(this, "bForceLinearGamma"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceLinearGamma", value); }
        }
        public bool bGPUSharedFlag {
            get {return Main.GetGetBoolPropertyByName(this, "bGPUSharedFlag"); }
        }
        public bool bAutoGenerateMips {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoGenerateMips"); }
        }
        ///<summary>Format of the texture render target.</summary>
        ///<remarks>
        ///Data written to the render target will be quantized to this format, which can limit the range and precision.
        ///The largest format (RTF_RGBA32f) uses 16x more memory and bandwidth than the smallest (RTF_R8) and can greatly affect performance.
        ///Use the smallest format that has enough precision and range for what you are doing.
        ///</remarks>
        public unsafe byte RenderTargetFormat {
            get {return TextureRenderTarget2D_ptr->RenderTargetFormat;}
        }
        ///<summary>Normally the format is derived from RenderTargetFormat, this allows code to set the format explicitly.</summary>
        public unsafe byte OverrideFormat {
            get {return TextureRenderTarget2D_ptr->OverrideFormat;}
            set {TextureRenderTarget2D_ptr->OverrideFormat = value;}
        }
        static TextureRenderTarget2D() {
            StaticClass = Main.GetClass("TextureRenderTarget2D");
        }
        internal unsafe TextureRenderTarget2D_fields* TextureRenderTarget2D_ptr => (TextureRenderTarget2D_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureRenderTarget2D(IntPtr p) => UObject.Make<TextureRenderTarget2D>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureRenderTarget2D DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureRenderTarget2D New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
