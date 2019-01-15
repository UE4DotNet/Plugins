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
    ///<summary>The Slot for the UWidgetSwitcher, contains the widget that is flowed vertically</summary>
    public unsafe partial class WidgetSwitcherSlot : PanelSlot  {

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            WidgetSwitcherSlot_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            WidgetSwitcherSlot_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            WidgetSwitcherSlot_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The padding area between the slot and the content it contains.</summary>
        public unsafe Margin Padding {
            get {return WidgetSwitcherSlot_ptr->Padding;}
        }
        ///<summary>The alignment of the object horizontally.</summary>
        public unsafe byte HorizontalAlignment {
            get {return WidgetSwitcherSlot_ptr->HorizontalAlignment;}
        }
        ///<summary>The alignment of the object vertically.</summary>
        public unsafe byte VerticalAlignment {
            get {return WidgetSwitcherSlot_ptr->VerticalAlignment;}
        }
        static WidgetSwitcherSlot() {
            StaticClass = Main.GetClass("WidgetSwitcherSlot");
        }
        internal unsafe WidgetSwitcherSlot_fields* WidgetSwitcherSlot_ptr => (WidgetSwitcherSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetSwitcherSlot(IntPtr p) => UObject.Make<WidgetSwitcherSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetSwitcherSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetSwitcherSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
