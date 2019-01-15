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
using UE4.MeshPaint.Native;

namespace UE4.MeshPaint {
    ///<summary>Paint Brush Settings</summary>
    public unsafe partial class PaintBrushSettings : UObject  {
        ///<summary>Radius of the Brush used for Painting</summary>
        public unsafe float BrushRadius {
            get {return PaintBrushSettings_ptr->BrushRadius;}
            set {PaintBrushSettings_ptr->BrushRadius = value;}
        }
        ///<summary>Strength of the brush (0.0 - 1.0)</summary>
        public unsafe float BrushStrength {
            get {return PaintBrushSettings_ptr->BrushStrength;}
            set {PaintBrushSettings_ptr->BrushStrength = value;}
        }
        ///<summary>Amount of falloff to apply (0.0 - 1.0)</summary>
        public unsafe float BrushFalloffAmount {
            get {return PaintBrushSettings_ptr->BrushFalloffAmount;}
            set {PaintBrushSettings_ptr->BrushFalloffAmount = value;}
        }
        public bool bEnableFlow {
            get {return Main.GetGetBoolPropertyByName(this, "bEnableFlow"); }
            set {Main.SetGetBoolPropertyByName(this, "bEnableFlow", value); }
        }
        public bool bOnlyFrontFacingTriangles {
            get {return Main.GetGetBoolPropertyByName(this, "bOnlyFrontFacingTriangles"); }
            set {Main.SetGetBoolPropertyByName(this, "bOnlyFrontFacingTriangles", value); }
        }
         //TODO: enum EMeshPaintColorViewMode ColorViewMode
        static PaintBrushSettings() {
            StaticClass = Main.GetClass("PaintBrushSettings");
        }
        internal unsafe PaintBrushSettings_fields* PaintBrushSettings_ptr => (PaintBrushSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PaintBrushSettings(IntPtr p) => UObject.Make<PaintBrushSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PaintBrushSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PaintBrushSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
