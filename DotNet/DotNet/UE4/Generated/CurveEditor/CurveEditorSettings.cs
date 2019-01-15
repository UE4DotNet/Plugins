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
using UE4.CurveEditor.Native;

namespace UE4.CurveEditor {
    ///<summary>Serializable options for curve editor.</summary>
    public unsafe partial class CurveEditorSettings : UObject  {
        public bool bAutoFrameCurveEditor {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoFrameCurveEditor"); }
            set {Main.SetGetBoolPropertyByName(this, "bAutoFrameCurveEditor", value); }
        }
        public bool bShowCurveEditorCurveToolTips {
            get {return Main.GetGetBoolPropertyByName(this, "bShowCurveEditorCurveToolTips"); }
            set {Main.SetGetBoolPropertyByName(this, "bShowCurveEditorCurveToolTips", value); }
        }
        ///<summary>Tangent Visibility</summary>
        public unsafe byte TangentVisibility {
            get {return CurveEditorSettings_ptr->TangentVisibility;}
            set {CurveEditorSettings_ptr->TangentVisibility = value;}
        }
        static CurveEditorSettings() {
            StaticClass = Main.GetClass("CurveEditorSettings");
        }
        internal unsafe CurveEditorSettings_fields* CurveEditorSettings_ptr => (CurveEditorSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveEditorSettings(IntPtr p) => UObject.Make<CurveEditorSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveEditorSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveEditorSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
