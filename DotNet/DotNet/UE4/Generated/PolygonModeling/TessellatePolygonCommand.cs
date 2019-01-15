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
    ///<summary>Tessellates selected polygons into smaller polygons</summary>
    public unsafe partial class TessellatePolygonCommand : MeshEditorInstantCommand  {
        static TessellatePolygonCommand() {
            StaticClass = Main.GetClass("TessellatePolygonCommand");
        }
        internal unsafe TessellatePolygonCommand_fields* TessellatePolygonCommand_ptr => (TessellatePolygonCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TessellatePolygonCommand(IntPtr p) => UObject.Make<TessellatePolygonCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TessellatePolygonCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TessellatePolygonCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
