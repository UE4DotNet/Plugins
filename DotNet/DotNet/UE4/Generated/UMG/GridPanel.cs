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
    ///<summary>A panel that evenly divides up available space between all of its children.</summary>
    ///<remarks>* Many Children</remarks>
    public unsafe partial class GridPanel : PanelWidget  {

        ///<summary>Add Child to Grid</summary>
        public GridSlot AddChildToGrid(Widget Content)  => 
            GridPanel_methods.AddChildToGrid_method.Invoke(ObjPointer, Content);

        ///<summary>Set Column Fill</summary>
        public void SetColumnFill(int ColumnIndex, float Coefficient)  => 
            GridPanel_methods.SetColumnFill_method.Invoke(ObjPointer, ColumnIndex, Coefficient);

        ///<summary>Set Row Fill</summary>
        public void SetRowFill(int ColumnIndex, float Coefficient)  => 
            GridPanel_methods.SetRowFill_method.Invoke(ObjPointer, ColumnIndex, Coefficient);
         //TODO: array not UObject TArray ColumnFill
         //TODO: array not UObject TArray RowFill
        static GridPanel() {
            StaticClass = Main.GetClass("GridPanel");
        }
        internal unsafe GridPanel_fields* GridPanel_ptr => (GridPanel_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GridPanel(IntPtr p) => UObject.Make<GridPanel>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GridPanel DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GridPanel New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
