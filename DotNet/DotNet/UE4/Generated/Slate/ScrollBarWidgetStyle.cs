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
    ///<summary>Scroll Bar Widget Style</summary>
    public unsafe partial class ScrollBarWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the scrollbox's appearance.</summary>
        public unsafe ScrollBarStyle ScrollBarStyle {
            get {return ScrollBarWidgetStyle_ptr->ScrollBarStyle;}
            set {ScrollBarWidgetStyle_ptr->ScrollBarStyle = value;}
        }
        static ScrollBarWidgetStyle() {
            StaticClass = Main.GetClass("ScrollBarWidgetStyle");
        }
        internal unsafe ScrollBarWidgetStyle_fields* ScrollBarWidgetStyle_ptr => (ScrollBarWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScrollBarWidgetStyle(IntPtr p) => UObject.Make<ScrollBarWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScrollBarWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScrollBarWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
