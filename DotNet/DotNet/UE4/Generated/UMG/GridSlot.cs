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
    ///<summary>
    ///A slot for UGridPanel, these slots all share the same size as the largest slot
    ///in the grid.
    ///</summary>
    public unsafe partial class GridSlot : PanelSlot  {

        ///<summary>Sets the column index of the slot, this determines what cell the slot is in the panel</summary>
        public void SetColumn(int InColumn)  => 
            GridSlot_methods.SetColumn_method.Invoke(ObjPointer, InColumn);

        ///<summary>How many columns this slot spans over</summary>
        public void SetColumnSpan(int InColumnSpan)  => 
            GridSlot_methods.SetColumnSpan_method.Invoke(ObjPointer, InColumnSpan);

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            GridSlot_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Sets positive values offset this cell to be hit-tested and drawn on top of others.</summary>
        public void SetLayer(int InLayer)  => 
            GridSlot_methods.SetLayer_method.Invoke(ObjPointer, InLayer);

        ///<summary>Set Padding</summary>
        public void SetPadding(Margin InPadding)  => 
            GridSlot_methods.SetPadding_method.Invoke(ObjPointer, InPadding);

        ///<summary>Sets the row index of the slot, this determines what cell the slot is in the panel</summary>
        public void SetRow(int InRow)  => 
            GridSlot_methods.SetRow_method.Invoke(ObjPointer, InRow);

        ///<summary>How many rows this this slot spans over</summary>
        public void SetRowSpan(int InRowSpan)  => 
            GridSlot_methods.SetRowSpan_method.Invoke(ObjPointer, InRowSpan);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            GridSlot_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The padding area between the slot and the content it contains.</summary>
        public unsafe Margin Padding {
            get {return GridSlot_ptr->Padding;}
        }
        ///<summary>The alignment of the object horizontally.</summary>
        public unsafe byte HorizontalAlignment {
            get {return GridSlot_ptr->HorizontalAlignment;}
        }
        ///<summary>The alignment of the object vertically.</summary>
        public unsafe byte VerticalAlignment {
            get {return GridSlot_ptr->VerticalAlignment;}
        }
        ///<summary>The row index of the cell this slot is in</summary>
        public unsafe int Row {
            get {return GridSlot_ptr->Row;}
        }
        ///<summary>Row Span</summary>
        public unsafe int RowSpan {
            get {return GridSlot_ptr->RowSpan;}
        }
        ///<summary>The column index of the cell this slot is in</summary>
        public unsafe int Column {
            get {return GridSlot_ptr->Column;}
        }
        ///<summary>Column Span</summary>
        public unsafe int ColumnSpan {
            get {return GridSlot_ptr->ColumnSpan;}
        }
        ///<summary>Positive values offset this cell to be hit-tested and drawn on top of others. Default is 0; i.e. no offset.</summary>
        public unsafe int Layer {
            get {return GridSlot_ptr->Layer;}
        }
        ///<summary>Offset this slot's content by some amount; positive values offset to lower right</summary>
        public unsafe Vector2D Nudge {
            get {return GridSlot_ptr->Nudge;}
        }
        static GridSlot() {
            StaticClass = Main.GetClass("GridSlot");
        }
        internal unsafe GridSlot_fields* GridSlot_ptr => (GridSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GridSlot(IntPtr p) => UObject.Make<GridSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GridSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GridSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
