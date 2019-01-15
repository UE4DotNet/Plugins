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
    ///<summary>Texture 2DFactory New</summary>
    public unsafe partial class Texture2DFactoryNew : Factory  {
        ///<summary>width of new texture</summary>
        public unsafe int Width {
            get {return Texture2DFactoryNew_ptr->Width;}
            set {Texture2DFactoryNew_ptr->Width = value;}
        }
        ///<summary>height of new texture</summary>
        public unsafe int Height {
            get {return Texture2DFactoryNew_ptr->Height;}
            set {Texture2DFactoryNew_ptr->Height = value;}
        }
        static Texture2DFactoryNew() {
            StaticClass = Main.GetClass("Texture2DFactoryNew");
        }
        internal unsafe Texture2DFactoryNew_fields* Texture2DFactoryNew_ptr => (Texture2DFactoryNew_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Texture2DFactoryNew(IntPtr p) => UObject.Make<Texture2DFactoryNew>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Texture2DFactoryNew DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Texture2DFactoryNew New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
