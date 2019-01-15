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
using UE4.Landscape.Native;
using UE4.Engine;

namespace UE4.Landscape {
    ///<summary>Landscape Layer Info Object</summary>
    public unsafe partial class LandscapeLayerInfoObject : UObject  {
        ///<summary>Layer Name</summary>
        public unsafe Name LayerName {
            get {return LandscapeLayerInfoObject_ptr->LayerName;}
            set {LandscapeLayerInfoObject_ptr->LayerName = value;}
        }
        ///<summary>Phys Material</summary>
        public unsafe PhysicalMaterial PhysMaterial {
            get {return LandscapeLayerInfoObject_ptr->PhysMaterial;}
            set {LandscapeLayerInfoObject_ptr->PhysMaterial = value;}
        }
        ///<summary>Hardness</summary>
        public unsafe float Hardness {
            get {return LandscapeLayerInfoObject_ptr->Hardness;}
            set {LandscapeLayerInfoObject_ptr->Hardness = value;}
        }
        public bool bNoWeightBlend {
            get {return Main.GetGetBoolPropertyByName(this, "bNoWeightBlend"); }
            set {Main.SetGetBoolPropertyByName(this, "bNoWeightBlend", value); }
        }
        public bool IsReferencedFromLoadedData {
            get {return Main.GetGetBoolPropertyByName(this, "IsReferencedFromLoadedData"); }
            set {Main.SetGetBoolPropertyByName(this, "IsReferencedFromLoadedData", value); }
        }
        ///<summary>The color to use for layer usage debug</summary>
        public unsafe LinearColor LayerUsageDebugColor {
            get {return LandscapeLayerInfoObject_ptr->LayerUsageDebugColor;}
            set {LandscapeLayerInfoObject_ptr->LayerUsageDebugColor = value;}
        }
        static LandscapeLayerInfoObject() {
            StaticClass = Main.GetClass("LandscapeLayerInfoObject");
        }
        internal unsafe LandscapeLayerInfoObject_fields* LandscapeLayerInfoObject_ptr => (LandscapeLayerInfoObject_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator LandscapeLayerInfoObject(IntPtr p) => UObject.Make<LandscapeLayerInfoObject>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static LandscapeLayerInfoObject DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static LandscapeLayerInfoObject New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
