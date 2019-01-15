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
    ///<summary>
    ///Paper Terrain Material
    ///'Material' setup for a 2D terrain spline (stores references to sprites that will be instanced along the spline path, not actually related to UMaterialInterface).
    ///</summary>
    public unsafe partial class PaperTerrainMaterial : DataAsset  {
         //TODO: array not UObject TArray Rules
        ///<summary>The sprite to use for an interior region fill</summary>
        public unsafe PaperSprite InteriorFill {
            get {return PaperTerrainMaterial_ptr->InteriorFill;}
            set {PaperTerrainMaterial_ptr->InteriorFill = value;}
        }
        static PaperTerrainMaterial() {
            StaticClass = Main.GetClass("PaperTerrainMaterial");
        }
        internal unsafe PaperTerrainMaterial_fields* PaperTerrainMaterial_ptr => (PaperTerrainMaterial_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaperTerrainMaterial(IntPtr p) => UObject.Make<PaperTerrainMaterial>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaperTerrainMaterial DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaperTerrainMaterial New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
