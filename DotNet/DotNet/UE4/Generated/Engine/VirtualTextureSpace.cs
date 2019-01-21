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
    ///<summary>Virtual Texture Space</summary>
    public unsafe partial class VirtualTextureSpace : UObject  {
         //TODO: array not UObject TArray Layers
        ///<summary>Tile Size</summary>
        public unsafe int TileSize {
            get {return VirtualTextureSpace_ptr->TileSize;}
            set {VirtualTextureSpace_ptr->TileSize = value;}
        }
        ///<summary>Border Width</summary>
        public unsafe int BorderWidth {
            get {return VirtualTextureSpace_ptr->BorderWidth;}
            set {VirtualTextureSpace_ptr->BorderWidth = value;}
        }
        ///<summary>Size</summary>
        public unsafe int Size {
            get {return VirtualTextureSpace_ptr->Size;}
            set {VirtualTextureSpace_ptr->Size = value;}
        }
        ///<summary>Dimensions</summary>
        public unsafe int Dimensions {
            get {return VirtualTextureSpace_ptr->Dimensions;}
            set {VirtualTextureSpace_ptr->Dimensions = value;}
        }
        ///<summary>Format</summary>
        public unsafe byte Format {
            get {return VirtualTextureSpace_ptr->Format;}
            set {VirtualTextureSpace_ptr->Format = value;}
        }
        ///<summary>The VTPool is at the moment coupled at the Space</summary>
        public unsafe int PoolSize {
            get {return VirtualTextureSpace_ptr->PoolSize;}
            set {VirtualTextureSpace_ptr->PoolSize = value;}
        }
        static VirtualTextureSpace() {
            StaticClass = Main.GetClass("VirtualTextureSpace");
        }
        internal unsafe VirtualTextureSpace_fields* VirtualTextureSpace_ptr => (VirtualTextureSpace_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VirtualTextureSpace(IntPtr p) => UObject.Make<VirtualTextureSpace>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VirtualTextureSpace DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VirtualTextureSpace New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
