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
    ///<summary>Canvas Render Target 2DFactory New</summary>
    public unsafe partial class CanvasRenderTarget2DFactoryNew : Factory  {
        ///<summary>Width of the texture render target</summary>
        public unsafe int Width {
            get {return CanvasRenderTarget2DFactoryNew_ptr->Width;}
            set {CanvasRenderTarget2DFactoryNew_ptr->Width = value;}
        }
        ///<summary>Height of the texture render target</summary>
        public unsafe int Height {
            get {return CanvasRenderTarget2DFactoryNew_ptr->Height;}
            set {CanvasRenderTarget2DFactoryNew_ptr->Height = value;}
        }
        ///<summary>Pixel format of the texture render target</summary>
        public unsafe byte Format {
            get {return CanvasRenderTarget2DFactoryNew_ptr->Format;}
            set {CanvasRenderTarget2DFactoryNew_ptr->Format = value;}
        }
        static CanvasRenderTarget2DFactoryNew() {
            StaticClass = Main.GetClass("CanvasRenderTarget2DFactoryNew");
        }
        internal unsafe CanvasRenderTarget2DFactoryNew_fields* CanvasRenderTarget2DFactoryNew_ptr => (CanvasRenderTarget2DFactoryNew_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CanvasRenderTarget2DFactoryNew(IntPtr p) => UObject.Make<CanvasRenderTarget2DFactoryNew>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CanvasRenderTarget2DFactoryNew DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CanvasRenderTarget2DFactoryNew New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
