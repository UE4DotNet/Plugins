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
    ///<summary>A widget switcher is like a tab control, but without tabs. At most one widget is visible at time.</summary>
    public unsafe partial class WidgetSwitcher : PanelWidget  {

        ///<summary>Get the reference of the currently active widget</summary>
        public Widget GetActiveWidget()  => 
            WidgetSwitcher_methods.GetActiveWidget_method.Invoke(ObjPointer);

        ///<summary>Gets the slot index of the currently active widget</summary>
        public int GetActiveWidgetIndex()  => 
            WidgetSwitcher_methods.GetActiveWidgetIndex_method.Invoke(ObjPointer);

        ///<summary>Gets the number of widgets that this switcher manages.</summary>
        public int GetNumWidgets()  => 
            WidgetSwitcher_methods.GetNumWidgets_method.Invoke(ObjPointer);

        ///<summary>Get a widget at the provided index</summary>
        public Widget GetWidgetAtIndex(int Index)  => 
            WidgetSwitcher_methods.GetWidgetAtIndex_method.Invoke(ObjPointer, Index);

        ///<summary>Activates the widget and makes it the active index.</summary>
        public void SetActiveWidget(Widget Widget)  => 
            WidgetSwitcher_methods.SetActiveWidget_method.Invoke(ObjPointer, Widget);

        ///<summary>Activates the widget at the specified index.</summary>
        public void SetActiveWidgetIndex(int Index)  => 
            WidgetSwitcher_methods.SetActiveWidgetIndex_method.Invoke(ObjPointer, Index);
        ///<summary>The slot index to display</summary>
        public unsafe int ActiveWidgetIndex {
            get {return WidgetSwitcher_ptr->ActiveWidgetIndex;}
        }
        static WidgetSwitcher() {
            StaticClass = Main.GetClass("WidgetSwitcher");
        }
        internal unsafe WidgetSwitcher_fields* WidgetSwitcher_ptr => (WidgetSwitcher_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetSwitcher(IntPtr p) => UObject.Make<WidgetSwitcher>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetSwitcher DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetSwitcher New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
