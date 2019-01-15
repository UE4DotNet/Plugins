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
    ///<summary>Safe Zone Slot</summary>
    public unsafe partial class SafeZoneSlot : PanelSlot  {
        public bool bIsTitleSafe {
            get {return Main.GetGetBoolPropertyByName(this, "bIsTitleSafe"); }
        }
        ///<summary>Safe Area Scale</summary>
        public unsafe Margin SafeAreaScale {
            get {return SafeZoneSlot_ptr->SafeAreaScale;}
        }
        ///<summary>HAlign</summary>
        public unsafe byte HAlign {
            get {return SafeZoneSlot_ptr->HAlign;}
        }
        ///<summary>VAlign</summary>
        public unsafe byte VAlign {
            get {return SafeZoneSlot_ptr->VAlign;}
        }
        ///<summary>Padding</summary>
        public unsafe Margin Padding {
            get {return SafeZoneSlot_ptr->Padding;}
        }
        static SafeZoneSlot() {
            StaticClass = Main.GetClass("SafeZoneSlot");
        }
        internal unsafe SafeZoneSlot_fields* SafeZoneSlot_ptr => (SafeZoneSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator SafeZoneSlot(IntPtr p) => UObject.Make<SafeZoneSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static SafeZoneSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static SafeZoneSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
