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

namespace UE4.EditableMesh {
    ///<summary>Editable Mesh Adapter</summary>
    public unsafe partial class EditableMeshAdapter : UObject  {
        static EditableMeshAdapter() {
            StaticClass = Main.GetClass("EditableMeshAdapter");
        }
        internal unsafe EditableMeshAdapter_fields* EditableMeshAdapter_ptr => (EditableMeshAdapter_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableMeshAdapter(IntPtr p) => UObject.Make<EditableMeshAdapter>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableMeshAdapter DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableMeshAdapter New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
