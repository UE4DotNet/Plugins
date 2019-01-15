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

namespace UE4.UMG {
    ///<summary>The base class for all UMG panel widgets.  Panel widgets layout a collection of child widgets.</summary>
    public unsafe partial class PanelWidget : Widget  {

        ///<summary>Adds a new child widget to the container.</summary>
        ///<remarks>
        ///Returns the base slot type,
        ///requires casting to turn it into the type specific to the container.
        ///</remarks>
        public PanelSlot AddChild(Widget Content)  => 
            PanelWidget_methods.AddChild_method.Invoke(ObjPointer, Content);

        ///<summary>Remove all child widgets from the panel widget.</summary>
        public void ClearChildren()  => 
            PanelWidget_methods.ClearChildren_method.Invoke(ObjPointer);

        ///<summary>Gets the widget at an index.</summary>
        ///<remarks>
        ///@param Index The index of the widget.
        ///@return The widget at the given index, or nothing if there is no widget there.
        ///</remarks>
        public Widget GetChildAt(int Index)  => 
            PanelWidget_methods.GetChildAt_method.Invoke(ObjPointer, Index);

        ///<summary>Gets the index of a specific child widget</summary>
        public int GetChildIndex(Widget Content)  => 
            PanelWidget_methods.GetChildIndex_method.Invoke(ObjPointer, Content);

        ///<summary>Gets number of child widgets in the container.</summary>
        public int GetChildrenCount()  => 
            PanelWidget_methods.GetChildrenCount_method.Invoke(ObjPointer);

        ///<summary>@return true if there are any child widgets in the panel</summary>
        public bool HasAnyChildren()  => 
            PanelWidget_methods.HasAnyChildren_method.Invoke(ObjPointer);

        ///<summary>@return true if panel contains this widget</summary>
        public bool HasChild(Widget Content)  => 
            PanelWidget_methods.HasChild_method.Invoke(ObjPointer, Content);

        ///<summary>Removes a specific widget from the container.</summary>
        ///<remarks>
        ///@return true if the widget was found and removed.
        ///</remarks>
        public bool RemoveChild(Widget Content)  => 
            PanelWidget_methods.RemoveChild_method.Invoke(ObjPointer, Content);

        ///<summary>Removes a child by it's index.</summary>
        public bool RemoveChildAt(int Index)  => 
            PanelWidget_methods.RemoveChildAt_method.Invoke(ObjPointer, Index);
        ///<summary>The slots in the widget holding the child widgets of this panel.</summary>
        public ObjectArrayField<PanelSlot> Slots{ get {
            if(Slots_store == null) Slots_store = new ObjectArrayField<PanelSlot> (&PanelWidget_ptr->Slots);
            return Slots_store;
        } }
        private ObjectArrayField<PanelSlot> Slots_store;

        static PanelWidget() {
            StaticClass = Main.GetClass("PanelWidget");
        }
        internal unsafe PanelWidget_fields* PanelWidget_ptr => (PanelWidget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PanelWidget(IntPtr p) => UObject.Make<PanelWidget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PanelWidget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PanelWidget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
