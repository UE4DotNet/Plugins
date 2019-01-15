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
using UE4.UMGEditor.Native;

namespace UE4.UMGEditor {
    ///<summary>Widget Slot Pair</summary>
    public unsafe partial class WidgetSlotPair : UObject  {
        ///<summary>Widget Name</summary>
        public unsafe Name WidgetName {
            get {return WidgetSlotPair_ptr->WidgetName;}
            set {WidgetSlotPair_ptr->WidgetName = value;}
        }
         //TODO: array not UObject TArray SlotPropertyNames
         //TODO: array not UObject TArray SlotPropertyValues
        static WidgetSlotPair() {
            StaticClass = Main.GetClass("WidgetSlotPair");
        }
        internal unsafe WidgetSlotPair_fields* WidgetSlotPair_ptr => (WidgetSlotPair_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WidgetSlotPair(IntPtr p) => UObject.Make<WidgetSlotPair>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WidgetSlotPair DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WidgetSlotPair New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
