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
    ///<summary>Mesh Editor Mode Proxy Object</summary>
    public unsafe partial class MeshEditorModeProxyObject : UObject  {
        static MeshEditorModeProxyObject() {
            StaticClass = Main.GetClass("MeshEditorModeProxyObject");
        }
        internal unsafe MeshEditorModeProxyObject_fields* MeshEditorModeProxyObject_ptr => (MeshEditorModeProxyObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator MeshEditorModeProxyObject(IntPtr p) => UObject.Make<MeshEditorModeProxyObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static MeshEditorModeProxyObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static MeshEditorModeProxyObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
