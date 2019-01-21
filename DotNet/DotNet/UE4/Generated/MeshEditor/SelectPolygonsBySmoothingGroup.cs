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
    ///<summary>Selects all the polygons that have the same smoothing group as the selection polygons.</summary>
    public unsafe partial class SelectPolygonsBySmoothingGroup : MeshEditorSelectionModifier  {
        static SelectPolygonsBySmoothingGroup() {
            StaticClass = Main.GetClass("SelectPolygonsBySmoothingGroup");
        }
        internal unsafe SelectPolygonsBySmoothingGroup_fields* SelectPolygonsBySmoothingGroup_ptr => (SelectPolygonsBySmoothingGroup_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SelectPolygonsBySmoothingGroup(IntPtr p) => UObject.Make<SelectPolygonsBySmoothingGroup>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SelectPolygonsBySmoothingGroup DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SelectPolygonsBySmoothingGroup New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
