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
    ///<summary>Progress Widget Style</summary>
    public unsafe partial class ProgressWidgetStyle : SlateWidgetStyleContainerBase  {
        ///<summary>The actual data describing the button's appearance.</summary>
        public unsafe ProgressBarStyle ProgressBarStyle {
            get {return ProgressWidgetStyle_ptr->ProgressBarStyle;}
            set {ProgressWidgetStyle_ptr->ProgressBarStyle = value;}
        }
        static ProgressWidgetStyle() {
            StaticClass = Main.GetClass("ProgressWidgetStyle");
        }
        internal unsafe ProgressWidgetStyle_fields* ProgressWidgetStyle_ptr => (ProgressWidgetStyle_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ProgressWidgetStyle(IntPtr p) => UObject.Make<ProgressWidgetStyle>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ProgressWidgetStyle DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ProgressWidgetStyle New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
