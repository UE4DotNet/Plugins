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
    ///<summary>Adds a new polygon on the inside of an existing polygon, allowing the user to drag to set exactly where it should be placed.</summary>
    public unsafe partial class InsetPolygonCommand : MeshEditorEditCommand  {
        static InsetPolygonCommand() {
            StaticClass = Main.GetClass("InsetPolygonCommand");
        }
        internal unsafe InsetPolygonCommand_fields* InsetPolygonCommand_ptr => (InsetPolygonCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator InsetPolygonCommand(IntPtr p) => UObject.Make<InsetPolygonCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static InsetPolygonCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static InsetPolygonCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
