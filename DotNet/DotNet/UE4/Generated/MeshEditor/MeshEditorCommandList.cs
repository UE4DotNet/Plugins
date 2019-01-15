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
    ///<summary>Mesh Editor Command List</summary>
    public unsafe partial class MeshEditorCommandList : UObject  {
        ///<summary>All of the mesh editor commands that were registered at startup</summary>
        public ObjectArrayField<MeshEditorCommand> MeshEditorCommands{ get {
            if(MeshEditorCommands_store == null) MeshEditorCommands_store = new ObjectArrayField<MeshEditorCommand> (&MeshEditorCommandList_ptr->MeshEditorCommands);
            return MeshEditorCommands_store;
        } }
        private ObjectArrayField<MeshEditorCommand> MeshEditorCommands_store;

        static MeshEditorCommandList() {
            StaticClass = Main.GetClass("MeshEditorCommandList");
        }
        internal unsafe MeshEditorCommandList_fields* MeshEditorCommandList_ptr => (MeshEditorCommandList_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorCommandList(IntPtr p) => UObject.Make<MeshEditorCommandList>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorCommandList DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorCommandList New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
