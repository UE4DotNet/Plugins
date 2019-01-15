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
using UE4.MeshEditor.Native;
using UE4.Engine;

namespace UE4.MeshEditor {
    ///<summary>Wireframe Mesh Component</summary>
    public unsafe partial class WireframeMeshComponent : MeshComponent  {
        ///<summary>Wireframe Mesh</summary>
        public unsafe WireframeMesh WireframeMesh {
            get {return WireframeMeshComponent_ptr->WireframeMesh;}
            set {WireframeMeshComponent_ptr->WireframeMesh = value;}
        }
        static WireframeMeshComponent() {
            StaticClass = Main.GetClass("WireframeMeshComponent");
        }
        internal unsafe WireframeMeshComponent_fields* WireframeMeshComponent_ptr => (WireframeMeshComponent_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WireframeMeshComponent(IntPtr p) => UObject.Make<WireframeMeshComponent>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WireframeMeshComponent DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WireframeMeshComponent New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
