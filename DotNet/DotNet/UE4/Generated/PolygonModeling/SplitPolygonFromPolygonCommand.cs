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
    ///<summary>Splits a polygon into two, starting with an edge on a polygon</summary>
    public unsafe partial class SplitPolygonFromPolygonCommand : SplitPolygonCommand  {
        static SplitPolygonFromPolygonCommand() {
            StaticClass = Main.GetClass("SplitPolygonFromPolygonCommand");
        }
        internal unsafe SplitPolygonFromPolygonCommand_fields* SplitPolygonFromPolygonCommand_ptr => (SplitPolygonFromPolygonCommand_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SplitPolygonFromPolygonCommand(IntPtr p) => UObject.Make<SplitPolygonFromPolygonCommand>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SplitPolygonFromPolygonCommand DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SplitPolygonFromPolygonCommand New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
