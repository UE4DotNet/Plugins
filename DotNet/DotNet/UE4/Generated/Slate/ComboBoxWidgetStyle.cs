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
using UE4.Slate.Native;
using UE4.SlateCore;

namespace UE4.Slate {
    ///<summary>Combo Box Widget Style</summary>
    public unsafe partial class ComboBoxWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the combo box's appearance.</summary>
        public unsafe ComboBoxStyle ComboBoxStyle {
            get {return ComboBoxWidgetStyle_ptr->ComboBoxStyle;}
            set {ComboBoxWidgetStyle_ptr->ComboBoxStyle = value;}
        }
        static ComboBoxWidgetStyle() {
            StaticClass = Main.GetClass("ComboBoxWidgetStyle");
        }
        internal unsafe ComboBoxWidgetStyle_fields* ComboBoxWidgetStyle_ptr => (ComboBoxWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ComboBoxWidgetStyle(IntPtr p) => UObject.Make<ComboBoxWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ComboBoxWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ComboBoxWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
