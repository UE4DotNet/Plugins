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
    ///A slot for UUniformGridPanel, these slots all share the same size as the largest slot
    ///in the grid.
    ///</summary>
    public unsafe partial class UniformGridSlot : PanelSlot  {

        ///<summary>Sets the column index of the slot, this determines what cell the slot is in the panel</summary>
        public void SetColumn(int InColumn)  => 
            UniformGridSlot_methods.SetColumn_method.Invoke(ObjPointer, InColumn);

        ///<summary>Set Horizontal Alignment</summary>
        public void SetHorizontalAlignment(byte InHorizontalAlignment)  => 
            UniformGridSlot_methods.SetHorizontalAlignment_method.Invoke(ObjPointer, InHorizontalAlignment);

        ///<summary>Sets the row index of the slot, this determines what cell the slot is in the panel</summary>
        public void SetRow(int InRow)  => 
            UniformGridSlot_methods.SetRow_method.Invoke(ObjPointer, InRow);

        ///<summary>Set Vertical Alignment</summary>
        public void SetVerticalAlignment(byte InVerticalAlignment)  => 
            UniformGridSlot_methods.SetVerticalAlignment_method.Invoke(ObjPointer, InVerticalAlignment);
        ///<summary>The alignment of the object horizontally.</summary>
        public unsafe byte HorizontalAlignment {
            get {return UniformGridSlot_ptr->HorizontalAlignment;}
        }
        ///<summary>The alignment of the object vertically.</summary>
        public unsafe byte VerticalAlignment {
            get {return UniformGridSlot_ptr->VerticalAlignment;}
        }
        ///<summary>The row index of the cell this slot is in</summary>
        public unsafe int Row {
            get {return UniformGridSlot_ptr->Row;}
        }
        ///<summary>The column index of the cell this slot is in</summary>
        public unsafe int Column {
            get {return UniformGridSlot_ptr->Column;}
        }
        static UniformGridSlot() {
            StaticClass = Main.GetClass("UniformGridSlot");
        }
        internal unsafe UniformGridSlot_fields* UniformGridSlot_ptr => (UniformGridSlot_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator UniformGridSlot(IntPtr p) => UObject.Make<UniformGridSlot>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static UniformGridSlot DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static UniformGridSlot New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
