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
using UE4.EditableMesh.Native;
using UE4.Engine;

namespace UE4.EditableMesh {
    ///<summary>Editable Static Mesh Adapter</summary>
    public unsafe partial class EditableStaticMeshAdapter : EditableMeshAdapter  {
        ///<summary>The static mesh asset we're representing</summary>
        public unsafe StaticMesh StaticMesh {
            get {return EditableStaticMeshAdapter_ptr->StaticMesh;}
            set {EditableStaticMeshAdapter_ptr->StaticMesh = value;}
        }
        ///<summary>Original Static Mesh</summary>
        public unsafe StaticMesh OriginalStaticMesh {
            get {return EditableStaticMeshAdapter_ptr->OriginalStaticMesh;}
            set {EditableStaticMeshAdapter_ptr->OriginalStaticMesh = value;}
        }
        ///<summary>Static Mesh LODIndex</summary>
        public unsafe int StaticMeshLODIndex {
            get {return EditableStaticMeshAdapter_ptr->StaticMeshLODIndex;}
            set {EditableStaticMeshAdapter_ptr->StaticMeshLODIndex = value;}
        }
        static EditableStaticMeshAdapter() {
            StaticClass = Main.GetClass("EditableStaticMeshAdapter");
        }
        internal unsafe EditableStaticMeshAdapter_fields* EditableStaticMeshAdapter_ptr => (EditableStaticMeshAdapter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableStaticMeshAdapter(IntPtr p) => UObject.Make<EditableStaticMeshAdapter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableStaticMeshAdapter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableStaticMeshAdapter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
