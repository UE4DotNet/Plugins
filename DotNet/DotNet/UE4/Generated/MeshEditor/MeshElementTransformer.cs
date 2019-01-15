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
using UE4.ViewportInteraction;

namespace UE4.MeshEditor {
    ///<summary>Mesh Element Transformer</summary>
    public unsafe partial class MeshElementTransformer : ViewportTransformer  {
        static MeshElementTransformer() {
            StaticClass = Main.GetClass("MeshElementTransformer");
        }
        internal unsafe MeshElementTransformer_fields* MeshElementTransformer_ptr => (MeshElementTransformer_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshElementTransformer(IntPtr p) => UObject.Make<MeshElementTransformer>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshElementTransformer DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshElementTransformer New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
