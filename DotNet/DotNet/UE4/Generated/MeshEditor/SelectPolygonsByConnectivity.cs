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
    ///<summary>Selects all the polygons that are connected to the selection polygons.</summary>
    public unsafe partial class SelectPolygonsByConnectivity : MeshEditorSelectionModifier  {
        static SelectPolygonsByConnectivity() {
            StaticClass = Main.GetClass("SelectPolygonsByConnectivity");
        }
        internal unsafe SelectPolygonsByConnectivity_fields* SelectPolygonsByConnectivity_ptr => (SelectPolygonsByConnectivity_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SelectPolygonsByConnectivity(IntPtr p) => UObject.Make<SelectPolygonsByConnectivity>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SelectPolygonsByConnectivity DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SelectPolygonsByConnectivity New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
