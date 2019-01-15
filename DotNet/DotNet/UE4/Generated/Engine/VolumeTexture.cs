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
    ///<summary>Volume Texture</summary>
    public unsafe partial class VolumeTexture : Texture  {
        ///<summary>A (optional) reference texture from which the volume texture was built</summary>
        public unsafe Texture2D Source2DTexture {
            get {return VolumeTexture_ptr->Source2DTexture;}
            set {VolumeTexture_ptr->Source2DTexture = value;}
        }
        ///<summary>The lighting Guid of the source 2D texture, used to trigger rebuild when the source changes.</summary>
        public unsafe FGuid SourceLightingGuid {
            get {return VolumeTexture_ptr->SourceLightingGuid;}
            set {VolumeTexture_ptr->SourceLightingGuid = value;}
        }
        ///<summary>The reference texture tile size X</summary>
        public unsafe int Source2DTileSizeX {
            get {return VolumeTexture_ptr->Source2DTileSizeX;}
            set {VolumeTexture_ptr->Source2DTileSizeX = value;}
        }
        ///<summary>The reference texture tile size Y</summary>
        public unsafe int Source2DTileSizeY {
            get {return VolumeTexture_ptr->Source2DTileSizeY;}
            set {VolumeTexture_ptr->Source2DTileSizeY = value;}
        }
        static VolumeTexture() {
            StaticClass = Main.GetClass("VolumeTexture");
        }
        internal unsafe VolumeTexture_fields* VolumeTexture_ptr => (VolumeTexture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VolumeTexture(IntPtr p) => UObject.Make<VolumeTexture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VolumeTexture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VolumeTexture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
