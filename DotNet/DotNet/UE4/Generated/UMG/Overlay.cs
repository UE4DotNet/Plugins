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
    ///<summary>Allows widgets to be stacked on top of each other, uses simple flow layout for content on each layer.</summary>
    public unsafe partial class Overlay : PanelWidget  {

        ///<summary>Add Child to Overlay</summary>
        public OverlaySlot AddChildToOverlay(Widget Content)  => 
            Overlay_methods.AddChildToOverlay_method.Invoke(ObjPointer, Content);
        static Overlay() {
            StaticClass = Main.GetClass("Overlay");
        }
        internal unsafe Overlay_fields* Overlay_ptr => (Overlay_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator Overlay(IntPtr p) => UObject.Make<Overlay>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static Overlay DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static Overlay New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
