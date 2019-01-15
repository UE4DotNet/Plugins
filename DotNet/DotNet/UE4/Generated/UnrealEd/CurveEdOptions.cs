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
using UE4.UnrealEd.Native;

namespace UE4.UnrealEd {
    ///<summary>Curve Ed Options</summary>
    public unsafe partial class CurveEdOptions : UObject  {
        ///<summary>Min View Range</summary>
        public unsafe float MinViewRange {
            get {return CurveEdOptions_ptr->MinViewRange;}
            set {CurveEdOptions_ptr->MinViewRange = value;}
        }
        ///<summary>Max View Range</summary>
        public unsafe float MaxViewRange {
            get {return CurveEdOptions_ptr->MaxViewRange;}
            set {CurveEdOptions_ptr->MaxViewRange = value;}
        }
        ///<summary>Background Color</summary>
        public unsafe LinearColor BackgroundColor {
            get {return CurveEdOptions_ptr->BackgroundColor;}
            set {CurveEdOptions_ptr->BackgroundColor = value;}
        }
        ///<summary>Label Color</summary>
        public unsafe LinearColor LabelColor {
            get {return CurveEdOptions_ptr->LabelColor;}
            set {CurveEdOptions_ptr->LabelColor = value;}
        }
        ///<summary>Selected Label Color</summary>
        public unsafe LinearColor SelectedLabelColor {
            get {return CurveEdOptions_ptr->SelectedLabelColor;}
            set {CurveEdOptions_ptr->SelectedLabelColor = value;}
        }
        ///<summary>Grid Color</summary>
        public unsafe LinearColor GridColor {
            get {return CurveEdOptions_ptr->GridColor;}
            set {CurveEdOptions_ptr->GridColor = value;}
        }
        ///<summary>Grid Text Color</summary>
        public unsafe LinearColor GridTextColor {
            get {return CurveEdOptions_ptr->GridTextColor;}
            set {CurveEdOptions_ptr->GridTextColor = value;}
        }
        ///<summary>Label Block Bkg Color</summary>
        public unsafe LinearColor LabelBlockBkgColor {
            get {return CurveEdOptions_ptr->LabelBlockBkgColor;}
            set {CurveEdOptions_ptr->LabelBlockBkgColor = value;}
        }
        ///<summary>Selected Key Color</summary>
        public unsafe LinearColor SelectedKeyColor {
            get {return CurveEdOptions_ptr->SelectedKeyColor;}
            set {CurveEdOptions_ptr->SelectedKeyColor = value;}
        }
        static CurveEdOptions() {
            StaticClass = Main.GetClass("CurveEdOptions");
        }
        internal unsafe CurveEdOptions_fields* CurveEdOptions_ptr => (CurveEdOptions_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CurveEdOptions(IntPtr p) => UObject.Make<CurveEdOptions>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CurveEdOptions DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CurveEdOptions New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
