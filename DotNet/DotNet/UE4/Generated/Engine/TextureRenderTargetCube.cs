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
    ///TextureRenderTargetCube
    ///Cube render target texture resource.
    ///</summary>
    ///<remarks>
    ///This can be used as a target
    ///for rendering as well as rendered as a regular cube texture resource.
    ///</remarks>
    public unsafe partial class TextureRenderTargetCube : TextureRenderTarget  {
        ///<summary>The width of the texture.</summary>
        public unsafe int SizeX {
            get {return TextureRenderTargetCube_ptr->SizeX;}
            set {TextureRenderTargetCube_ptr->SizeX = value;}
        }
        ///<summary>the color the texture is cleared to</summary>
        public unsafe LinearColor ClearColor {
            get {return TextureRenderTargetCube_ptr->ClearColor;}
            set {TextureRenderTargetCube_ptr->ClearColor = value;}
        }
        ///<summary>Normally the format is derived from bHDR, this allows code to set the format explicitly.</summary>
        public unsafe byte OverrideFormat {
            get {return TextureRenderTargetCube_ptr->OverrideFormat;}
            set {TextureRenderTargetCube_ptr->OverrideFormat = value;}
        }
        public bool bHDR {
            get {return Main.GetGetBoolPropertyByName(this, "bHDR"); }
        }
        public bool bForceLinearGamma {
            get {return Main.GetGetBoolPropertyByName(this, "bForceLinearGamma"); }
            set {Main.SetGetBoolPropertyByName(this, "bForceLinearGamma", value); }
        }
        static TextureRenderTargetCube() {
            StaticClass = Main.GetClass("TextureRenderTargetCube");
        }
        internal unsafe TextureRenderTargetCube_fields* TextureRenderTargetCube_ptr => (TextureRenderTargetCube_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureRenderTargetCube(IntPtr p) => UObject.Make<TextureRenderTargetCube>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureRenderTargetCube DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureRenderTargetCube New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
