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
    ///<summary>Content Widget</summary>
    public unsafe partial class ContentWidget : PanelWidget  {

        ///<summary>Get Content</summary>
        public Widget GetContent()  => 
            ContentWidget_methods.GetContent_method.Invoke(ObjPointer);

        ///<summary>Get Content Slot</summary>
        public PanelSlot GetContentSlot()  => 
            ContentWidget_methods.GetContentSlot_method.Invoke(ObjPointer);

        ///<summary>Set Content</summary>
        public PanelSlot SetContent(Widget Content)  => 
            ContentWidget_methods.SetContent_method.Invoke(ObjPointer, Content);
        static ContentWidget() {
            StaticClass = Main.GetClass("ContentWidget");
        }
        internal unsafe ContentWidget_fields* ContentWidget_ptr => (ContentWidget_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ContentWidget(IntPtr p) => UObject.Make<ContentWidget>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ContentWidget DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ContentWidget New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
