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
    ///<summary>Virtual Texture</summary>
    public unsafe partial class VirtualTexture : UObject  {
        ///<summary>Layers</summary>
        public ObjectArrayField<Texture> Layers{ get {
            if(Layers_store == null) Layers_store = new ObjectArrayField<Texture> (&VirtualTexture_ptr->Layers);
            return Layers_store;
        } }
        private ObjectArrayField<Texture> Layers_store;

        ///<summary>Space</summary>
        public unsafe VirtualTextureSpace Space {
            get {return VirtualTexture_ptr->Space;}
            set {VirtualTexture_ptr->Space = value;}
        }
        public bool Rebuild {
            get {return Main.GetGetBoolPropertyByName(this, "Rebuild"); }
            set {Main.SetGetBoolPropertyByName(this, "Rebuild", value); }
        }
        static VirtualTexture() {
            StaticClass = Main.GetClass("VirtualTexture");
        }
        internal unsafe VirtualTexture_fields* VirtualTexture_ptr => (VirtualTexture_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VirtualTexture(IntPtr p) => UObject.Make<VirtualTexture>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VirtualTexture DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VirtualTexture New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
