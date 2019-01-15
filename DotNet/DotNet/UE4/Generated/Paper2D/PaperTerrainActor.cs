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
using UE4.Paper2D.Native;
using UE4.Engine;

namespace UE4.Paper2D {
    ///<summary>An instance of a piece of 2D terrain in the level</summary>
    public unsafe partial class PaperTerrainActor : Actor  {
        ///<summary>Dummy Root</summary>
        public unsafe SceneComponent DummyRoot {
            get {return PaperTerrainActor_ptr->DummyRoot;}
            set {PaperTerrainActor_ptr->DummyRoot = value;}
        }
        ///<summary>Spline Component</summary>
        public unsafe PaperTerrainSplineComponent SplineComponent {
            get {return PaperTerrainActor_ptr->SplineComponent;}
            set {PaperTerrainActor_ptr->SplineComponent = value;}
        }
        ///<summary>Render Component</summary>
        public unsafe PaperTerrainComponent RenderComponent {
            get {return PaperTerrainActor_ptr->RenderComponent;}
        }
        static PaperTerrainActor() {
            StaticClass = Main.GetClass("PaperTerrainActor");
        }
        internal unsafe PaperTerrainActor_fields* PaperTerrainActor_ptr => (PaperTerrainActor_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTerrainActor(IntPtr p) => UObject.Make<PaperTerrainActor>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTerrainActor DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTerrainActor New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
