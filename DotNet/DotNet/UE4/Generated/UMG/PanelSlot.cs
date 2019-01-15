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
    ///<summary>The base class for all Slots in UMG.</summary>
    public unsafe partial class PanelSlot : Visual  {
        ///<summary>Parent</summary>
        public unsafe PanelWidget Parent {
            get {return PanelSlot_ptr->Parent;}
            set {PanelSlot_ptr->Parent = value;}
        }
        ///<summary>Content</summary>
        public unsafe Widget Content {
            get {return PanelSlot_ptr->Content;}
            set {PanelSlot_ptr->Content = value;}
        }
        static PanelSlot() {
            StaticClass = Main.GetClass("PanelSlot");
        }
        internal unsafe PanelSlot_fields* PanelSlot_ptr => (PanelSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator PanelSlot(IntPtr p) => UObject.Make<PanelSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static PanelSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static PanelSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
