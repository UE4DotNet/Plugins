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
    ///<summary>The combobox allows you to display a list of options to the user in a dropdown menu for them to select one.</summary>
    public unsafe partial class ComboBox : Widget  {
        ///<summary>The list of items to be displayed on the combobox.</summary>
        public ObjectArrayField<UObject> Items{ get {
            if(Items_store == null) Items_store = new ObjectArrayField<UObject> (&ComboBox_ptr->Items);
            return Items_store;
        } }
        private ObjectArrayField<UObject> Items_store;

         //TODO: delegate FGenerateWidgetForObject OnGenerateWidgetEvent
        public bool bIsFocusable {
            get {return Main.GetGetBoolPropertyByName(this, "bIsFocusable"); }
        }
        static ComboBox() {
            StaticClass = Main.GetClass("ComboBox");
        }
        internal unsafe ComboBox_fields* ComboBox_ptr => (ComboBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ComboBox(IntPtr p) => UObject.Make<ComboBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ComboBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ComboBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
