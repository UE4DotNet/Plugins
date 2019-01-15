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
    ///<summary>Mesh Editor Selection Modifier</summary>
    public unsafe partial class MeshEditorSelectionModifier : UObject  {
        static MeshEditorSelectionModifier() {
            StaticClass = Main.GetClass("MeshEditorSelectionModifier");
        }
        internal unsafe MeshEditorSelectionModifier_fields* MeshEditorSelectionModifier_ptr => (MeshEditorSelectionModifier_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorSelectionModifier(IntPtr p) => UObject.Make<MeshEditorSelectionModifier>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorSelectionModifier DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorSelectionModifier New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
