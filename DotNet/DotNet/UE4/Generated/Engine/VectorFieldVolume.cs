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
    ///<summary>Vector Field Volume</summary>
    public unsafe partial class VectorFieldVolume : Actor  {
        ///<summary>Vector Field Component</summary>
        public unsafe VectorFieldComponent VectorFieldComponent {
            get {return VectorFieldVolume_ptr->VectorFieldComponent;}
        }
        ///<summary>Sprite Component</summary>
        public unsafe BillboardComponent SpriteComponent {
            get {return VectorFieldVolume_ptr->SpriteComponent;}
            set {VectorFieldVolume_ptr->SpriteComponent = value;}
        }
        static VectorFieldVolume() {
            StaticClass = Main.GetClass("VectorFieldVolume");
        }
        internal unsafe VectorFieldVolume_fields* VectorFieldVolume_ptr => (VectorFieldVolume_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VectorFieldVolume(IntPtr p) => UObject.Make<VectorFieldVolume>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VectorFieldVolume DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VectorFieldVolume New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
