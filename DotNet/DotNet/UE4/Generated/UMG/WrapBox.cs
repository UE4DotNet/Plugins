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
    ///<summary>Arranges widgets left-to-right.</summary>
    ///<remarks>
    ///When the widgets exceed the Width it will place widgets on the next line.
    ///
    ///* Many Children
    ///* Flows
    ///* Wraps
    ///</remarks>
    public unsafe partial class WrapBox : PanelWidget  {

        ///<summary>Add Child Wrap Box</summary>
        public WrapBoxSlot AddChildWrapBox(Widget Content)  => 
            WrapBox_methods.AddChildWrapBox_method.Invoke(ObjPointer, Content);

        ///<summary>Sets the inner slot padding goes between slots sharing borders</summary>
        public void SetInnerSlotPadding(Vector2D InPadding)  => 
            WrapBox_methods.SetInnerSlotPadding_method.Invoke(ObjPointer, InPadding);
        ///<summary>The inner slot padding goes between slots sharing borders</summary>
        public unsafe Vector2D InnerSlotPadding {
            get {return WrapBox_ptr->InnerSlotPadding;}
        }
        ///<summary>When this width is exceeded, elements will start appearing on the next line.</summary>
        public unsafe float WrapWidth {
            get {return WrapBox_ptr->WrapWidth;}
        }
        public bool bExplicitWrapWidth {
            get {return Main.GetGetBoolPropertyByName(this, "bExplicitWrapWidth"); }
        }
        static WrapBox() {
            StaticClass = Main.GetClass("WrapBox");
        }
        internal unsafe WrapBox_fields* WrapBox_ptr => (WrapBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator WrapBox(IntPtr p) => UObject.Make<WrapBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static WrapBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static WrapBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
