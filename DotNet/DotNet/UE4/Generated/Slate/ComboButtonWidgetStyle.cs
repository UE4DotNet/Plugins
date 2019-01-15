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
    ///<summary>Combo Button Widget Style</summary>
    public unsafe partial class ComboButtonWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the combo button's appearance.</summary>
        public unsafe ComboButtonStyle ComboButtonStyle {
            get {return ComboButtonWidgetStyle_ptr->ComboButtonStyle;}
            set {ComboButtonWidgetStyle_ptr->ComboButtonStyle = value;}
        }
        static ComboButtonWidgetStyle() {
            StaticClass = Main.GetClass("ComboButtonWidgetStyle");
        }
        internal unsafe ComboButtonWidgetStyle_fields* ComboButtonWidgetStyle_ptr => (ComboButtonWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ComboButtonWidgetStyle(IntPtr p) => UObject.Make<ComboButtonWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ComboButtonWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ComboButtonWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
