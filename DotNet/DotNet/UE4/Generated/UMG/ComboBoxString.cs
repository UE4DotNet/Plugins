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
    ///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
    public unsafe partial class ComboBoxString : Widget  {

        ///<summary>Add Option</summary>
        public void AddOption(string Option)  => 
            ComboBoxString_methods.AddOption_method.Invoke(ObjPointer, Option);

        ///<summary>Clear Options</summary>
        public void ClearOptions()  => 
            ComboBoxString_methods.ClearOptions_method.Invoke(ObjPointer);

        ///<summary>Clear Selection</summary>
        public void ClearSelection()  => 
            ComboBoxString_methods.ClearSelection_method.Invoke(ObjPointer);

        ///<summary>Find Option Index</summary>
        public int FindOptionIndex(string Option)  => 
            ComboBoxString_methods.FindOptionIndex_method.Invoke(ObjPointer, Option);

        ///<summary>Get Option at Index</summary>
        public string GetOptionAtIndex(int Index)  => 
            ComboBoxString_methods.GetOptionAtIndex_method.Invoke(ObjPointer, Index);

        ///<summary>@return The number of options</summary>
        public int GetOptionCount()  => 
            ComboBoxString_methods.GetOptionCount_method.Invoke(ObjPointer);

        ///<summary>Get Selected Option</summary>
        public string GetSelectedOption()  => 
            ComboBoxString_methods.GetSelectedOption_method.Invoke(ObjPointer);

        ///<summary>Refreshes the list of options.</summary>
        ///<remarks>
        ///If you added new ones, and want to update the list even if it's
        ///currently being displayed use this.
        ///</remarks>
        public void RefreshOptions()  => 
            ComboBoxString_methods.RefreshOptions_method.Invoke(ObjPointer);

        ///<summary>Remove Option</summary>
        public bool RemoveOption(string Option)  => 
            ComboBoxString_methods.RemoveOption_method.Invoke(ObjPointer, Option);

        ///<summary>Set Selected Option</summary>
        public void SetSelectedOption(string Option)  => 
            ComboBoxString_methods.SetSelectedOption_method.Invoke(ObjPointer, Option);
         //TODO: array not UObject TArray DefaultOptions
         //TODO: string FString SelectedOption
        ///<summary>The style.</summary>
        public unsafe ComboBoxStyle WidgetStyle {
            get {return ComboBoxString_ptr->WidgetStyle;}
            set {ComboBoxString_ptr->WidgetStyle = value;}
        }
        ///<summary>The item row style.</summary>
        public unsafe TableRowStyle ItemStyle {
            get {return ComboBoxString_ptr->ItemStyle;}
            set {ComboBoxString_ptr->ItemStyle = value;}
        }
        ///<summary>Content Padding</summary>
        public unsafe Margin ContentPadding {
            get {return ComboBoxString_ptr->ContentPadding;}
        }
        ///<summary>The max height of the combobox list that opens</summary>
        public unsafe float MaxListHeight {
            get {return ComboBoxString_ptr->MaxListHeight;}
        }
        public bool HasDownArrow {
            get {return Main.GetGetBoolPropertyByName(this, "HasDownArrow"); }
        }
        public bool EnableGamepadNavigationMode {
            get {return Main.GetGetBoolPropertyByName(this, "EnableGamepadNavigationMode"); }
        }
        ///<summary>
        ///The default font to use in the combobox, only applies if you're not implementing OnGenerateWidgetEvent
        ///to factory each new entry.
        ///</summary>
        public unsafe SlateFontInfo Font {
            get {return ComboBoxString_ptr->Font;}
        }
        ///<summary>The foreground color to pass through the hierarchy.</summary>
        public unsafe SlateColor ForegroundColor {
            get {return ComboBoxString_ptr->ForegroundColor;}
        }
        public bool bIsFocusable {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFocusable"); }
        }
         //TODO: delegate FGenerateWidgetForString OnGenerateWidgetEvent
         //TODO: multicast delegate FOnSelectionChangedEvent OnSelectionChanged
         //TODO: multicast delegate FOnOpeningEvent OnOpening
        static ComboBoxString() {
            StaticClass = Main.GetClass("ComboBoxString");
        }
        internal unsafe ComboBoxString_fields* ComboBoxString_ptr => (ComboBoxString_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ComboBoxString(IntPtr p) => UObject.Make<ComboBoxString>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ComboBoxString DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ComboBoxString New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
