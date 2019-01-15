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

namespace UE4.PolygonModeling {
    ///<summary>Splits a polygon into two, starting with a vertex on that polygon</summary>
    public unsafe partial class SplitPolygonFromVertexCommand : SplitPolygonCommand  {
        static SplitPolygonFromVertexCommand() {
            StaticClass = Main.GetClass("SplitPolygonFromVertexCommand");
        }
        internal unsafe SplitPolygonFromVertexCommand_fields* SplitPolygonFromVertexCommand_ptr => (SplitPolygonFromVertexCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplitPolygonFromVertexCommand(IntPtr p) => UObject.Make<SplitPolygonFromVertexCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplitPolygonFromVertexCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplitPolygonFromVertexCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
