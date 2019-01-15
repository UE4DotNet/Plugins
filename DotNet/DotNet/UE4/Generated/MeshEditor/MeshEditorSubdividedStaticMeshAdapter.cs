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
using UE4.EditableMesh;

namespace UE4.MeshEditor {
    ///<summary>Mesh Editor Subdivided Static Mesh Adapter</summary>
    public unsafe partial class MeshEditorSubdividedStaticMeshAdapter : EditableMeshAdapter  {
        ///<summary>The wireframe mesh asset we're representing</summary>
        public unsafe WireframeMesh WireframeMesh {
            get {return MeshEditorSubdividedStaticMeshAdapter_ptr->WireframeMesh;}
            set {MeshEditorSubdividedStaticMeshAdapter_ptr->WireframeMesh = value;}
        }
        ///<summary>Static Mesh LODIndex</summary>
        public unsafe int StaticMeshLODIndex {
            get {return MeshEditorSubdividedStaticMeshAdapter_ptr->StaticMeshLODIndex;}
            set {MeshEditorSubdividedStaticMeshAdapter_ptr->StaticMeshLODIndex = value;}
        }
        static MeshEditorSubdividedStaticMeshAdapter() {
            StaticClass = Main.GetClass("MeshEditorSubdividedStaticMeshAdapter");
        }
        internal unsafe MeshEditorSubdividedStaticMeshAdapter_fields* MeshEditorSubdividedStaticMeshAdapter_ptr => (MeshEditorSubdividedStaticMeshAdapter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorSubdividedStaticMeshAdapter(IntPtr p) => UObject.Make<MeshEditorSubdividedStaticMeshAdapter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorSubdividedStaticMeshAdapter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorSubdividedStaticMeshAdapter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
