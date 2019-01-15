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
using UE4.MeshPaint.Native;

namespace UE4.MeshPaint {
    ///<summary>Mesh Paint Settings</summary>
    public unsafe partial class MeshPaintSettings : UObject  {
        ///<summary>Size of vertex points drawn when mesh painting is active.</summary>
        public unsafe float VertexPreviewSize {
            get {return MeshPaintSettings_ptr->VertexPreviewSize;}
            set {MeshPaintSettings_ptr->VertexPreviewSize = value;}
        }
        static MeshPaintSettings() {
            StaticClass = Main.GetClass("MeshPaintSettings");
        }
        internal unsafe MeshPaintSettings_fields* MeshPaintSettings_ptr => (MeshPaintSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshPaintSettings(IntPtr p) => UObject.Make<MeshPaintSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshPaintSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshPaintSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
