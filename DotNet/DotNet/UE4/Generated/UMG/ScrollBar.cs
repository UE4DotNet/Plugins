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
using UE4.UMG.Native;
using UE4.SlateCore;

namespace UE4.UMG {
    ///<summary>Scroll Bar</summary>
    public unsafe partial class ScrollBar : Widget  {

        ///<summary>Set the offset and size of the track's thumb.</summary>
        ///<remarks>
        ///Note that the maximum offset is 1.0-ThumbSizeFraction.
        ///If the user can view 1/3 of the items in a single page, the maximum offset will be ~0.667f
        ///
        ///@param InOffsetFraction     Offset of the thumbnail from the top as a fraction of the total available scroll space.
        ///@param InThumbSizeFraction  Size of thumbnail as a fraction of the total available scroll space.
        ///</remarks>
        public void SetState(float InOffsetFraction, float InThumbSizeFraction)  => 
            ScrollBar_methods.SetState_method.Invoke(ObjPointer, InOffsetFraction, InThumbSizeFraction);
        ///<summary>Style of the scrollbar</summary>
        public unsafe ScrollBarStyle WidgetStyle {
            get {return ScrollBar_ptr->WidgetStyle;}
            set {ScrollBar_ptr->WidgetStyle = value;}
        }
        public bool bAlwaysShowScrollbar {
            get {return Main.GetGetBoolPropertyByName(this, "bAlwaysShowScrollbar"); }
            set {Main.SetGetBoolPropertyByName(this, "bAlwaysShowScrollbar", value); }
        }
        ///<summary>Orientation</summary>
        public unsafe byte Orientation {
            get {return ScrollBar_ptr->Orientation;}
            set {ScrollBar_ptr->Orientation = value;}
        }
        ///<summary>The thickness of the scrollbar thumb</summary>
        public unsafe Vector2D Thickness {
            get {return ScrollBar_ptr->Thickness;}
            set {ScrollBar_ptr->Thickness = value;}
        }
        static ScrollBar() {
            StaticClass = Main.GetClass("ScrollBar");
        }
        internal unsafe ScrollBar_fields* ScrollBar_ptr => (ScrollBar_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ScrollBar(IntPtr p) => UObject.Make<ScrollBar>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ScrollBar DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ScrollBar New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
