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
    ///<summary>Texture Render Target</summary>
    public unsafe partial class TextureRenderTarget : Texture  {
        ///<summary>Will override FTextureRenderTarget2DResource::GetDisplayGamma if > 0.</summary>
        public unsafe float TargetGamma {
            get {return TextureRenderTarget_ptr->TargetGamma;}
            set {TextureRenderTarget_ptr->TargetGamma = value;}
        }
        static TextureRenderTarget() {
            StaticClass = Main.GetClass("TextureRenderTarget");
        }
        internal unsafe TextureRenderTarget_fields* TextureRenderTarget_ptr => (TextureRenderTarget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureRenderTarget(IntPtr p) => UObject.Make<TextureRenderTarget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureRenderTarget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureRenderTarget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
