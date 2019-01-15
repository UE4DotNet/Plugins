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
    ///<summary>Inserts a vertex along an edge and allows the user to move it around</summary>
    public unsafe partial class SplitEdgeCommand : MeshEditorEditCommand  {
        static SplitEdgeCommand() {
            StaticClass = Main.GetClass("SplitEdgeCommand");
        }
        internal unsafe SplitEdgeCommand_fields* SplitEdgeCommand_ptr => (SplitEdgeCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplitEdgeCommand(IntPtr p) => UObject.Make<SplitEdgeCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplitEdgeCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplitEdgeCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
