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
    ///<summary>Scroll Box Widget Style</summary>
    public unsafe partial class ScrollBoxWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the scrollbox's appearance.</summary>
        public unsafe ScrollBoxStyle ScrollBoxStyle {
            get {return ScrollBoxWidgetStyle_ptr->ScrollBoxStyle;}
            set {ScrollBoxWidgetStyle_ptr->ScrollBoxStyle = value;}
        }
        static ScrollBoxWidgetStyle() {
            StaticClass = Main.GetClass("ScrollBoxWidgetStyle");
        }
        internal unsafe ScrollBoxWidgetStyle_fields* ScrollBoxWidgetStyle_ptr => (ScrollBoxWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScrollBoxWidgetStyle(IntPtr p) => UObject.Make<ScrollBoxWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScrollBoxWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScrollBoxWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
