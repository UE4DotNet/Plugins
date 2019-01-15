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
    ///<summary>
    ///A vertical box widget is a layout panel allowing child widgets to be automatically laid out
    ///vertically.
    ///</summary>
    ///<remarks>
    ///* Many Children
    ///* Flows Vertical
    ///</remarks>
    public unsafe partial class VerticalBox : PanelWidget  {

        ///<summary>Add Child to Vertical Box</summary>
        public VerticalBoxSlot AddChildToVerticalBox(Widget Content)  => 
            VerticalBox_methods.AddChildToVerticalBox_method.Invoke(ObjPointer, Content);
        static VerticalBox() {
            StaticClass = Main.GetClass("VerticalBox");
        }
        internal unsafe VerticalBox_fields* VerticalBox_ptr => (VerticalBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator VerticalBox(IntPtr p) => UObject.Make<VerticalBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static VerticalBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static VerticalBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
