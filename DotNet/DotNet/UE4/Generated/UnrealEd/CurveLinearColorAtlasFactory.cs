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
    ///<summary>Curve Linear Color Atlas Factory</summary>
    public unsafe partial class CurveLinearColorAtlasFactory : Factory  {
        ///<summary>Width of the texture render target</summary>
        public unsafe int Width {
            get {return CurveLinearColorAtlasFactory_ptr->Width;}
            set {CurveLinearColorAtlasFactory_ptr->Width = value;}
        }
        ///<summary>Height of the texture render target</summary>
        public unsafe int Height {
            get {return CurveLinearColorAtlasFactory_ptr->Height;}
            set {CurveLinearColorAtlasFactory_ptr->Height = value;}
        }
        ///<summary>Pixel format of the texture render target</summary>
        public unsafe byte Format {
            get {return CurveLinearColorAtlasFactory_ptr->Format;}
            set {CurveLinearColorAtlasFactory_ptr->Format = value;}
        }
        static CurveLinearColorAtlasFactory() {
            StaticClass = Main.GetClass("CurveLinearColorAtlasFactory");
        }
        internal unsafe CurveLinearColorAtlasFactory_fields* CurveLinearColorAtlasFactory_ptr => (CurveLinearColorAtlasFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveLinearColorAtlasFactory(IntPtr p) => UObject.Make<CurveLinearColorAtlasFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveLinearColorAtlasFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveLinearColorAtlasFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
