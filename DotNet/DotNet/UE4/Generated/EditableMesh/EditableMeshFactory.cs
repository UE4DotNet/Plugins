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
    ///<summary>@todo mesheditor: Comment these classes and enums!</summary>
    public unsafe partial class EditableMeshFactory : UObject  {

        ///<summary>Make Editable Mesh</summary>
        public static UE4.EditableMesh.EditableMesh MakeEditableMesh(PrimitiveComponent PrimitiveComponent, int LODIndex)  => 
            EditableMeshFactory_methods.MakeEditableMesh_method.Invoke(PrimitiveComponent, LODIndex);
        static EditableMeshFactory() {
            StaticClass = Main.GetClass("EditableMeshFactory");
        }
        internal unsafe EditableMeshFactory_fields* EditableMeshFactory_ptr => (EditableMeshFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableMeshFactory(IntPtr p) => UObject.Make<EditableMeshFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableMeshFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableMeshFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
