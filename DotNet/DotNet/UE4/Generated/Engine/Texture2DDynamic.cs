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
    ///<summary>Texture 2DDynamic</summary>
    public unsafe partial class Texture2DDynamic : Texture  {
        ///<summary>The format of the texture.</summary>
        public unsafe byte Format {
            get {return Texture2DDynamic_ptr->Format;}
            set {Texture2DDynamic_ptr->Format = value;}
        }
        static Texture2DDynamic() {
            StaticClass = Main.GetClass("Texture2DDynamic");
        }
        internal unsafe Texture2DDynamic_fields* Texture2DDynamic_ptr => (Texture2DDynamic_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Texture2DDynamic(IntPtr p) => UObject.Make<Texture2DDynamic>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Texture2DDynamic DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Texture2DDynamic New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
