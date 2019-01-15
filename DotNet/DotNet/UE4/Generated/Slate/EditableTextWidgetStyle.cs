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
    ///<summary>Editable Text Widget Style</summary>
    public unsafe partial class EditableTextWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the button's appearance.</summary>
        public unsafe EditableTextStyle EditableTextStyle {
            get {return EditableTextWidgetStyle_ptr->EditableTextStyle;}
            set {EditableTextWidgetStyle_ptr->EditableTextStyle = value;}
        }
        static EditableTextWidgetStyle() {
            StaticClass = Main.GetClass("EditableTextWidgetStyle");
        }
        internal unsafe EditableTextWidgetStyle_fields* EditableTextWidgetStyle_ptr => (EditableTextWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EditableTextWidgetStyle(IntPtr p) => UObject.Make<EditableTextWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EditableTextWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EditableTextWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
