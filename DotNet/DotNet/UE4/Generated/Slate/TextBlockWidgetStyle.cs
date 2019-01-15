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
    ///<summary>Text Block Widget Style</summary>
    public unsafe partial class TextBlockWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the button's appearance.</summary>
        public unsafe TextBlockStyle TextBlockStyle {
            get {return TextBlockWidgetStyle_ptr->TextBlockStyle;}
            set {TextBlockWidgetStyle_ptr->TextBlockStyle = value;}
        }
        static TextBlockWidgetStyle() {
            StaticClass = Main.GetClass("TextBlockWidgetStyle");
        }
        internal unsafe TextBlockWidgetStyle_fields* TextBlockWidgetStyle_ptr => (TextBlockWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TextBlockWidgetStyle(IntPtr p) => UObject.Make<TextBlockWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TextBlockWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TextBlockWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
