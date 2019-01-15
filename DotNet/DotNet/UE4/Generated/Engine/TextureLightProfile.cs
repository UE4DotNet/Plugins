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
    ///<summary>Texture Light Profile</summary>
    public unsafe partial class TextureLightProfile : Texture2D  {
        ///<summary>Light brightness in Candelas, imported from IES profile, <= 0 if the profile is used for masking only. Use with InverseSquareFalloff.</summary>
        public unsafe float Brightness {
            get {return TextureLightProfile_ptr->Brightness;}
            set {TextureLightProfile_ptr->Brightness = value;}
        }
        ///<summary>Multiplier to map texture value to result to integrate over the sphere to 1.0f</summary>
        public unsafe float TextureMultiplier {
            get {return TextureLightProfile_ptr->TextureMultiplier;}
            set {TextureLightProfile_ptr->TextureMultiplier = value;}
        }
        static TextureLightProfile() {
            StaticClass = Main.GetClass("TextureLightProfile");
        }
        internal unsafe TextureLightProfile_fields* TextureLightProfile_ptr => (TextureLightProfile_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextureLightProfile(IntPtr p) => UObject.Make<TextureLightProfile>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextureLightProfile DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextureLightProfile New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
