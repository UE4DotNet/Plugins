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
    ///<summary>The Slot for the UWrapBox, contains the widget that is flowed vertically</summary>
    public unsafe partial class WrapBoxSlot : PanelSlot  {

        ///<summary>Set Fill Empty Space</summary>
        public void SetFillEmptySpace(bool InbFillEmptySpace)  => 
            WrapBoxSlot_methods.SetFillEmptySpace_method.Invoke(ObjPointer, InbFillEmptySpace);

        ///<summary>Set Fill Span when Less Than</summary>
        public void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan)  => 
            WrapBoxSlot_methods.SetFillSpanWhenLessThan_method.Invoke(ObjPointer, InFillSpanWhenLessThan);

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            WrapBoxSlot_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            WrapBoxSlot_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            WrapBoxSlot_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The padding area between the slot and the content it contains.</summary>
        public unsafe Margin Padding {
            get {return WrapBoxSlot_ptr->Padding;}
        }
        public bool bFillEmptySpace {
            get {return Main.GetGetBoolPropertyByName(this, "bFillEmptySpace"); }
        }
        ///<summary>If the total available space in the wrap panel drops below this threshold, this slot will attempt to fill an entire line.</summary>
        ///<remarks>NOTE: A value of 0, denotes no filling will occur.</remarks>
        public unsafe float FillSpanWhenLessThan {
            get {return WrapBoxSlot_ptr->FillSpanWhenLessThan;}
        }
        ///<summary>The alignment of the object horizontally.</summary>
        public unsafe byte HorizontalAlignment {
            get {return WrapBoxSlot_ptr->HorizontalAlignment;}
        }
        ///<summary>The alignment of the object vertically.</summary>
        public unsafe byte VerticalAlignment {
            get {return WrapBoxSlot_ptr->VerticalAlignment;}
        }
        static WrapBoxSlot() {
            StaticClass = Main.GetClass("WrapBoxSlot");
        }
        internal unsafe WrapBoxSlot_fields* WrapBoxSlot_ptr => (WrapBoxSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WrapBoxSlot(IntPtr p) => UObject.Make<WrapBoxSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WrapBoxSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WrapBoxSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
