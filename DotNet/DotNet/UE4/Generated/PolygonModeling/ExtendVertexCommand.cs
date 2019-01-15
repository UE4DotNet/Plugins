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
using UE4.PolygonModeling.Native;
using UE4.MeshEditor;

namespace UE4.PolygonModeling {
    ///<summary>Extend a vertex by making a copy of it, creating new polygons to join the geometry together</summary>
    public unsafe partial class ExtendVertexCommand : MeshEditorEditCommand  {
        static ExtendVertexCommand() {
            StaticClass = Main.GetClass("ExtendVertexCommand");
        }
        internal unsafe ExtendVertexCommand_fields* ExtendVertexCommand_ptr => (ExtendVertexCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ExtendVertexCommand(IntPtr p) => UObject.Make<ExtendVertexCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ExtendVertexCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ExtendVertexCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
