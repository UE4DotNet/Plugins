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
    ///<summary>Attempts to remove the selected edge from the polygon, merging the adjacent polygons together</summary>
    public unsafe partial class RemoveEdgeCommand : MeshEditorInstantCommand  {
        static RemoveEdgeCommand() {
            StaticClass = Main.GetClass("RemoveEdgeCommand");
        }
        internal unsafe RemoveEdgeCommand_fields* RemoveEdgeCommand_ptr => (RemoveEdgeCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator RemoveEdgeCommand(IntPtr p) => UObject.Make<RemoveEdgeCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static RemoveEdgeCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static RemoveEdgeCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
