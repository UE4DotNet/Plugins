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
    ///<summary>Splits a polygon into two, starting with a point along an edge</summary>
    public unsafe partial class SplitPolygonFromEdgeCommand : SplitPolygonCommand  {
        static SplitPolygonFromEdgeCommand() {
            StaticClass = Main.GetClass("SplitPolygonFromEdgeCommand");
        }
        internal unsafe SplitPolygonFromEdgeCommand_fields* SplitPolygonFromEdgeCommand_ptr => (SplitPolygonFromEdgeCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplitPolygonFromEdgeCommand(IntPtr p) => UObject.Make<SplitPolygonFromEdgeCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplitPolygonFromEdgeCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplitPolygonFromEdgeCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
