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


namespace UE4.Engine{
        ///<summary>Handle to a particular set of rows in a table</summary>
        [StructLayout( LayoutKind.Explicit, Size=32 )]
        public unsafe struct DataTableCategoryHandle {
            [FieldOffset(0)] 
            private IntPtr  DataTable_field;
            ///<summary>Pointer to table we want a row from</summary>
            public DataTable DataTable {
                get {return DataTable_field;}
                set {DataTable_field = value;}
            }

            [FieldOffset(8)] public Name ColumnName;

            [FieldOffset(20)] public Name RowContents;

        }
}
