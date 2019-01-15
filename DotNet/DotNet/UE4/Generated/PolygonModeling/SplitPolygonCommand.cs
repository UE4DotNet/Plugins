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
using UE4.Engine;
using UE4.EditableMesh;

namespace UE4.PolygonModeling {
    ///<summary>Base class for polygon splitting</summary>
    public unsafe partial class SplitPolygonCommand : MeshEditorEditCommand  {
        ///<summary>The component we're editing</summary>
        public unsafe PrimitiveComponent Component {
            get {return SplitPolygonCommand_ptr->Component;}
            set {SplitPolygonCommand_ptr->Component = value;}
        }
        ///<summary>The mesh we're editing</summary>
        public unsafe UE4.EditableMesh.EditableMesh EditableMesh {
            get {return SplitPolygonCommand_ptr->EditableMesh;}
            set {SplitPolygonCommand_ptr->EditableMesh = value;}
        }
        static SplitPolygonCommand() {
            StaticClass = Main.GetClass("SplitPolygonCommand");
        }
        internal unsafe SplitPolygonCommand_fields* SplitPolygonCommand_ptr => (SplitPolygonCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplitPolygonCommand(IntPtr p) => UObject.Make<SplitPolygonCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplitPolygonCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplitPolygonCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
