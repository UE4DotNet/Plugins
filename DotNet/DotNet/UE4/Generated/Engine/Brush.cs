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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Brush</summary>
    public unsafe partial class Brush : Actor  {
        ///<summary>Type of brush</summary>
        public unsafe byte BrushType {
            get {return Brush_ptr->BrushType;}
            set {Brush_ptr->BrushType = value;}
        }
        ///<summary>Information.</summary>
        public unsafe Color BrushColor {
            get {return Brush_ptr->BrushColor;}
            set {Brush_ptr->BrushColor = value;}
        }
        ///<summary>Poly Flags</summary>
        public unsafe int PolyFlags {
            get {return Brush_ptr->PolyFlags;}
            set {Brush_ptr->PolyFlags = value;}
        }
        public bool bColored {
            get {return Main.GetGetBoolPropertyByName(this, "bColored"); }
            set {Main.SetGetBoolPropertyByName(this, "bColored", value); }
        }
        public bool bSolidWhenSelected {
            get {return Main.GetGetBoolPropertyByName(this, "bSolidWhenSelected"); }
            set {Main.SetGetBoolPropertyByName(this, "bSolidWhenSelected", value); }
        }
        public bool bPlaceableFromClassBrowser {
            get {return Main.GetGetBoolPropertyByName(this, "bPlaceableFromClassBrowser"); }
            set {Main.SetGetBoolPropertyByName(this, "bPlaceableFromClassBrowser", value); }
        }
        public bool bNotForClientOrServer {
            get {return Main.GetGetBoolPropertyByName(this, "bNotForClientOrServer"); }
            set {Main.SetGetBoolPropertyByName(this, "bNotForClientOrServer", value); }
        }
        ///<summary>Brush</summary>
        public unsafe Model Brush_ {
            get {return Brush_ptr->Brush_;}
            set {Brush_ptr->Brush_ = value;}
        }
        ///<summary>Brush Component</summary>
        public unsafe BrushComponent BrushComponent {
            get {return Brush_ptr->BrushComponent;}
        }
        ///<summary>Brush Builder</summary>
        public unsafe BrushBuilder BrushBuilder {
            get {return Brush_ptr->BrushBuilder;}
            set {Brush_ptr->BrushBuilder = value;}
        }
        public bool bInManipulation {
            get {return Main.GetGetBoolPropertyByName(this, "bInManipulation"); }
            set {Main.SetGetBoolPropertyByName(this, "bInManipulation", value); }
        }
         //TODO: array not UObject TArray SavedSelections
        static Brush() {
            StaticClass = Main.GetClass("Brush");
        }
        internal unsafe Brush_fields* Brush_ptr => (Brush_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Brush(IntPtr p) => UObject.Make<Brush>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Brush DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Brush New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
