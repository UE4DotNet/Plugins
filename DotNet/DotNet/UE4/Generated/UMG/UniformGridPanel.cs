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
    ///<summary>A panel that evenly divides up available space between all of its children.</summary>
    public unsafe partial class UniformGridPanel : PanelWidget  {

        ///<summary>Add Child to Uniform Grid</summary>
        public UniformGridSlot AddChildToUniformGrid(Widget Content)  => 
            UniformGridPanel_methods.AddChildToUniformGrid_method.Invoke(ObjPointer, Content);

        ///<summary>Set Min Desired Slot Height</summary>
        public void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight)  => 
            UniformGridPanel_methods.SetMinDesiredSlotHeight_method.Invoke(ObjPointer, InMinDesiredSlotHeight);

        ///<summary>Set Min Desired Slot Width</summary>
        public void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth)  => 
            UniformGridPanel_methods.SetMinDesiredSlotWidth_method.Invoke(ObjPointer, InMinDesiredSlotWidth);

        ///<summary>Set Slot Padding</summary>
        public void SetSlotPadding(Margin InSlotPadding)  => 
            UniformGridPanel_methods.SetSlotPadding_method.Invoke(ObjPointer, InSlotPadding);
        ///<summary>Padding given to each slot</summary>
        public unsafe Margin SlotPadding {
            get {return UniformGridPanel_ptr->SlotPadding;}
        }
        ///<summary>The minimum desired width of the slots</summary>
        public unsafe float MinDesiredSlotWidth {
            get {return UniformGridPanel_ptr->MinDesiredSlotWidth;}
        }
        ///<summary>The minimum desired height of the slots</summary>
        public unsafe float MinDesiredSlotHeight {
            get {return UniformGridPanel_ptr->MinDesiredSlotHeight;}
        }
        static UniformGridPanel() {
            StaticClass = Main.GetClass("UniformGridPanel");
        }
        internal unsafe UniformGridPanel_fields* UniformGridPanel_ptr => (UniformGridPanel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UniformGridPanel(IntPtr p) => UObject.Make<UniformGridPanel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UniformGridPanel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UniformGridPanel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
