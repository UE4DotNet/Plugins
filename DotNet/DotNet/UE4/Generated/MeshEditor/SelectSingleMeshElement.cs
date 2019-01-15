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

namespace UE4.MeshEditor {
    ///<summary>Dummy selection modifier that doesn't actually modifies the selection.</summary>
    public unsafe partial class SelectSingleMeshElement : MeshEditorSelectionModifier  {
        static SelectSingleMeshElement() {
            StaticClass = Main.GetClass("SelectSingleMeshElement");
        }
        internal unsafe SelectSingleMeshElement_fields* SelectSingleMeshElement_ptr => (SelectSingleMeshElement_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SelectSingleMeshElement(IntPtr p) => UObject.Make<SelectSingleMeshElement>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SelectSingleMeshElement DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SelectSingleMeshElement New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
