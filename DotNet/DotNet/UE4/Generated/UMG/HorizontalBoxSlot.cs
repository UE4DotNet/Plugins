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
    ///<summary>Horizontal Box Slot</summary>
    public unsafe partial class HorizontalBoxSlot : PanelSlot  {

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            HorizontalBoxSlot_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            HorizontalBoxSlot_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Set Size</summary>
        public void SetSize(SlateChildSize InSize)  => 
            HorizontalBoxSlot_methods.SetSize_method.Invoke(ObjPointer, InSize);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            HorizontalBoxSlot_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The amount of padding between the slots parent and the content.</summary>
        public unsafe Margin Padding {
            get {return HorizontalBoxSlot_ptr->Padding;}
        }
        ///<summary>How much space this slot should occupy in the direction of the panel.</summary>
        public unsafe SlateChildSize Size {
            get {return HorizontalBoxSlot_ptr->Size;}
        }
        ///<summary>Horizontal Alignment</summary>
        public unsafe byte HorizontalAlignment {
            get {return HorizontalBoxSlot_ptr->HorizontalAlignment;}
        }
        ///<summary>Vertical Alignment</summary>
        public unsafe byte VerticalAlignment {
            get {return HorizontalBoxSlot_ptr->VerticalAlignment;}
        }
        static HorizontalBoxSlot() {
            StaticClass = Main.GetClass("HorizontalBoxSlot");
        }
        internal unsafe HorizontalBoxSlot_fields* HorizontalBoxSlot_ptr => (HorizontalBoxSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HorizontalBoxSlot(IntPtr p) => UObject.Make<HorizontalBoxSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HorizontalBoxSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HorizontalBoxSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
