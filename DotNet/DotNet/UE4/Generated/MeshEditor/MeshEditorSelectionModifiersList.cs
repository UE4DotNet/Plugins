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
    ///<summary>Mesh Editor Selection Modifiers List</summary>
    public unsafe partial class MeshEditorSelectionModifiersList : UObject  {
        ///<summary>All of the selection modifiers that were registered at startup</summary>
        public ObjectArrayField<MeshEditorSelectionModifier> SelectionModifiers{ get {
            if(SelectionModifiers_store == null) SelectionModifiers_store = new ObjectArrayField<MeshEditorSelectionModifier> (&MeshEditorSelectionModifiersList_ptr->SelectionModifiers);
            return SelectionModifiers_store;
        } }
        private ObjectArrayField<MeshEditorSelectionModifier> SelectionModifiers_store;

        static MeshEditorSelectionModifiersList() {
            StaticClass = Main.GetClass("MeshEditorSelectionModifiersList");
        }
        internal unsafe MeshEditorSelectionModifiersList_fields* MeshEditorSelectionModifiersList_ptr => (MeshEditorSelectionModifiersList_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorSelectionModifiersList(IntPtr p) => UObject.Make<MeshEditorSelectionModifiersList>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorSelectionModifiersList DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorSelectionModifiersList New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
