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
    ///<summary>Mesh Editor Static Mesh Adapter</summary>
    public unsafe partial class MeshEditorStaticMeshAdapter : EditableMeshAdapter  {
        ///<summary>The wireframe mesh asset we're representing</summary>
        public unsafe WireframeMesh WireframeMesh {
            get {return MeshEditorStaticMeshAdapter_ptr->WireframeMesh;}
            set {MeshEditorStaticMeshAdapter_ptr->WireframeMesh = value;}
        }
        ///<summary>Static Mesh LODIndex</summary>
        public unsafe int StaticMeshLODIndex {
            get {return MeshEditorStaticMeshAdapter_ptr->StaticMeshLODIndex;}
            set {MeshEditorStaticMeshAdapter_ptr->StaticMeshLODIndex = value;}
        }
        static MeshEditorStaticMeshAdapter() {
            StaticClass = Main.GetClass("MeshEditorStaticMeshAdapter");
        }
        internal unsafe MeshEditorStaticMeshAdapter_fields* MeshEditorStaticMeshAdapter_ptr => (MeshEditorStaticMeshAdapter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorStaticMeshAdapter(IntPtr p) => UObject.Make<MeshEditorStaticMeshAdapter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorStaticMeshAdapter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorStaticMeshAdapter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
