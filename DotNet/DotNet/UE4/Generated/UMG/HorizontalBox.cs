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
    ///<summary>Allows widgets to be laid out in a flow horizontally.</summary>
    ///<remarks>
    ///* Many Children
    ///* Flow Horizontal
    ///</remarks>
    public unsafe partial class HorizontalBox : PanelWidget  {

        ///<summary>Add Child to Horizontal Box</summary>
        public HorizontalBoxSlot AddChildToHorizontalBox(Widget Content)  => 
            HorizontalBox_methods.AddChildToHorizontalBox_method.Invoke(ObjPointer, Content);
        static HorizontalBox() {
            StaticClass = Main.GetClass("HorizontalBox");
        }
        internal unsafe HorizontalBox_fields* HorizontalBox_ptr => (HorizontalBox_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator HorizontalBox(IntPtr p) => UObject.Make<HorizontalBox>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static HorizontalBox DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static HorizontalBox New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
