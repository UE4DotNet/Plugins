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
    ///<summary>Empty dummy UObject used as the table view item during design time</summary>
    ///<remarks>Allows rough design-time previewing of how list contents will lay out</remarks>
    public unsafe partial class ListViewDesignerPreviewItem : UObject  {
        static ListViewDesignerPreviewItem() {
            StaticClass = Main.GetClass("ListViewDesignerPreviewItem");
        }
        internal unsafe ListViewDesignerPreviewItem_fields* ListViewDesignerPreviewItem_ptr => (ListViewDesignerPreviewItem_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator ListViewDesignerPreviewItem(IntPtr p) => UObject.Make<ListViewDesignerPreviewItem>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static ListViewDesignerPreviewItem DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static ListViewDesignerPreviewItem New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
