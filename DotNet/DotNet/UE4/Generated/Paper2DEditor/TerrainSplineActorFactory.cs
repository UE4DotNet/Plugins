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
using UE4.Paper2DEditor.Native;
using UE4.UnrealEd;

namespace UE4.Paper2DEditor {
    ///<summary>Terrain Spline Actor Factory</summary>
    public unsafe partial class TerrainSplineActorFactory : ActorFactory  {
        static TerrainSplineActorFactory() {
            StaticClass = Main.GetClass("TerrainSplineActorFactory");
        }
        internal unsafe TerrainSplineActorFactory_fields* TerrainSplineActorFactory_ptr => (TerrainSplineActorFactory_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TerrainSplineActorFactory(IntPtr p) => UObject.Make<TerrainSplineActorFactory>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TerrainSplineActorFactory DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TerrainSplineActorFactory New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
