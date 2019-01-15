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
    ///<summary>The Slot for the UVerticalBox, contains the widget that is flowed vertically</summary>
    public unsafe partial class VerticalBoxSlot : PanelSlot  {

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            VerticalBoxSlot_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            VerticalBoxSlot_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Set Size</summary>
        public void SetSize(SlateChildSize InSize)  => 
            VerticalBoxSlot_methods.SetSize_method.Invoke(ObjPointer, InSize);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            VerticalBoxSlot_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The padding area between the slot and the content it contains.</summary>
        public unsafe Margin Padding {
            get {return VerticalBoxSlot_ptr->Padding;}
        }
        ///<summary>How much space this slot should occupy in the direction of the panel.</summary>
        public unsafe SlateChildSize Size {
            get {return VerticalBoxSlot_ptr->Size;}
        }
        ///<summary>The alignment of the object horizontally.</summary>
        public unsafe byte HorizontalAlignment {
            get {return VerticalBoxSlot_ptr->HorizontalAlignment;}
        }
        ///<summary>The alignment of the object vertically.</summary>
        public unsafe byte VerticalAlignment {
            get {return VerticalBoxSlot_ptr->VerticalAlignment;}
        }
        static VerticalBoxSlot() {
            StaticClass = Main.GetClass("VerticalBoxSlot");
        }
        internal unsafe VerticalBoxSlot_fields* VerticalBoxSlot_ptr => (VerticalBoxSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VerticalBoxSlot(IntPtr p) => UObject.Make<VerticalBoxSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VerticalBoxSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VerticalBoxSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
