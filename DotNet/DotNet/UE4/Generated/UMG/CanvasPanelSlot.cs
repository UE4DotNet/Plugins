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
using UE4.Slate;
using UE4.SlateCore;

namespace UE4.UMG {
    ///<summary>Canvas Panel Slot</summary>
    public unsafe partial class CanvasPanelSlot : PanelSlot  {

        ///<summary>Gets the alignment on the slot</summary>
        public Vector2D GetAlignment()  => 
            CanvasPanelSlot_methods.GetAlignment_method.Invoke(ObjPointer);

        ///<summary>Gets the anchors on the slot</summary>
        public Anchors GetAnchors()  => 
            CanvasPanelSlot_methods.GetAnchors_method.Invoke(ObjPointer);

        ///<summary>Gets if the slot to be auto-sized</summary>
        public bool GetAutoSize()  => 
            CanvasPanelSlot_methods.GetAutoSize_method.Invoke(ObjPointer);

        ///<summary>Gets the layout data of the slot</summary>
        public AnchorData GetLayout()  => 
            CanvasPanelSlot_methods.GetLayout_method.Invoke(ObjPointer);

        ///<summary>Gets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
        public Margin GetOffsets()  => 
            CanvasPanelSlot_methods.GetOffsets_method.Invoke(ObjPointer);

        ///<summary>Gets the position of the slot</summary>
        public Vector2D GetPosition()  => 
            CanvasPanelSlot_methods.GetPosition_method.Invoke(ObjPointer);

        ///<summary>Gets the size of the slot</summary>
        public Vector2D GetSize()  => 
            CanvasPanelSlot_methods.GetSize_method.Invoke(ObjPointer);

        ///<summary>Gets the z-order on the slot</summary>
        public int GetZOrder()  => 
            CanvasPanelSlot_methods.GetZOrder_method.Invoke(ObjPointer);

        ///<summary>Sets the alignment on the slot</summary>
        public void SetAlignment(Vector2D InAlignment)  => 
            CanvasPanelSlot_methods.SetAlignment_method.Invoke(ObjPointer, InAlignment);

        ///<summary>Sets the anchors on the slot</summary>
        public void SetAnchors(Anchors InAnchors)  => 
            CanvasPanelSlot_methods.SetAnchors_method.Invoke(ObjPointer, InAnchors);

        ///<summary>Sets if the slot to be auto-sized</summary>
        public void SetAutoSize(bool InbAutoSize)  => 
            CanvasPanelSlot_methods.SetAutoSize_method.Invoke(ObjPointer, InbAutoSize);

        ///<summary>Sets the layout data of the slot</summary>
        public void SetLayout(AnchorData InLayoutData)  => 
            CanvasPanelSlot_methods.SetLayout_method.Invoke(ObjPointer, InLayoutData);

        ///<summary>Sets the offset data of the slot, which could be position and size, or margins depending on the anchor points</summary>
        public void SetOffsets(Margin InOffset)  => 
            CanvasPanelSlot_methods.SetOffsets_method.Invoke(ObjPointer, InOffset);

        ///<summary>Sets the position of the slot</summary>
        public void SetPosition(Vector2D InPosition)  => 
            CanvasPanelSlot_methods.SetPosition_method.Invoke(ObjPointer, InPosition);

        ///<summary>Sets the size of the slot</summary>
        public void SetSize(Vector2D InSize)  => 
            CanvasPanelSlot_methods.SetSize_method.Invoke(ObjPointer, InSize);

        ///<summary>Sets the z-order on the slot</summary>
        public void SetZOrder(int InZOrder)  => 
            CanvasPanelSlot_methods.SetZOrder_method.Invoke(ObjPointer, InZOrder);
        ///<summary>The anchoring information for the slot</summary>
        public unsafe AnchorData LayoutData {
            get {return CanvasPanelSlot_ptr->LayoutData;}
        }
        public bool bAutoSize {
            get {return Main.GetGetBoolPropertyByName(this, "bAutoSize"); }
        }
        ///<summary>The order priority this widget is rendered in.  Higher values are rendered last (and so they will appear to be on top).</summary>
        public unsafe int ZOrder {
            get {return CanvasPanelSlot_ptr->ZOrder;}
        }
        static CanvasPanelSlot() {
            StaticClass = Main.GetClass("CanvasPanelSlot");
        }
        internal unsafe CanvasPanelSlot_fields* CanvasPanelSlot_ptr => (CanvasPanelSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator CanvasPanelSlot(IntPtr p) => UObject.Make<CanvasPanelSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static CanvasPanelSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static CanvasPanelSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
