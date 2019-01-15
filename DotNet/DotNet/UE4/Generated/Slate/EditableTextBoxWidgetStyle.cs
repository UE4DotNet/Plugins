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
    ///<summary>Editable Text Box Widget Style</summary>
    public unsafe partial class EditableTextBoxWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the button's appearance.</summary>
        public unsafe EditableTextBoxStyle EditableTextBoxStyle {
            get {return EditableTextBoxWidgetStyle_ptr->EditableTextBoxStyle;}
            set {EditableTextBoxWidgetStyle_ptr->EditableTextBoxStyle = value;}
        }
        static EditableTextBoxWidgetStyle() {
            StaticClass = Main.GetClass("EditableTextBoxWidgetStyle");
        }
        internal unsafe EditableTextBoxWidgetStyle_fields* EditableTextBoxWidgetStyle_ptr => (EditableTextBoxWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableTextBoxWidgetStyle(IntPtr p) => UObject.Make<EditableTextBoxWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableTextBoxWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableTextBoxWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
