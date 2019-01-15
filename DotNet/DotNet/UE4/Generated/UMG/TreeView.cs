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
    ///<summary>Similar to ListView, but can display a hierarchical tree of elements.</summary>
    ///<remarks>
    ///The base items source for the tree identifies the root items, each of which can have n associated child items.
    ///There is no hard limit to the nesting - child items can have children and so on
    ///</remarks>
    public unsafe partial class TreeView : ListView  {

        ///<summary>Collapses all currently expanded items</summary>
        public void CollapseAll()  => 
            TreeView_methods.CollapseAll_method.Invoke(ObjPointer);

        ///<summary>Expands all items with children</summary>
        public void ExpandAll()  => 
            TreeView_methods.ExpandAll_method.Invoke(ObjPointer);

        ///<summary>Attempts to expand/collapse the given item (only relevant if the item has children)</summary>
        public void SetItemExpansion(UObject Item, bool bExpandItem)  => 
            TreeView_methods.SetItemExpansion_method.Invoke(ObjPointer, Item, bExpandItem);
         //TODO: delegate FOnGetItemChildrenDynamic BP_OnGetItemChildren
         //TODO: multicast delegate FOnItemExpansionChangedDynamic BP_OnItemExpansionChanged
        static TreeView() {
            StaticClass = Main.GetClass("TreeView");
        }
        internal unsafe TreeView_fields* TreeView_ptr => (TreeView_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator TreeView(IntPtr p) => UObject.Make<TreeView>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static TreeView DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static TreeView New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
