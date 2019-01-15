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
    ///<summary>Extends an edge by making a copy of it and allowing you to move it around</summary>
    public unsafe partial class ExtendEdgeCommand : MeshEditorEditCommand  {
        static ExtendEdgeCommand() {
            StaticClass = Main.GetClass("ExtendEdgeCommand");
        }
        internal unsafe ExtendEdgeCommand_fields* ExtendEdgeCommand_ptr => (ExtendEdgeCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ExtendEdgeCommand(IntPtr p) => UObject.Make<ExtendEdgeCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ExtendEdgeCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ExtendEdgeCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
