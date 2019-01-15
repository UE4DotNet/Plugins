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
        ///<summary>Handle to a particular row in a table.</summary>
        [StructLayout( LayoutKind.Explicit, Size=24 )]
        public unsafe struct CurveTableRowHandle {
            [FieldOffset(0)] 
            private IntPtr  CurveTable_field;
            ///<summary>Pointer to table we want a row from</summary>
            public CurveTable CurveTable {
                get {return CurveTable_field;}
                set {CurveTable_field = value;}
            }

            [FieldOffset(8)] public Name RowName;

        }
}
