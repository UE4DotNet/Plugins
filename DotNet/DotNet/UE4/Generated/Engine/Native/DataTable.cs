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


namespace UE4.Engine.Native {
    [StructLayout( LayoutKind.Explicit, Size=312 )]
    internal unsafe struct DataTable_fields {
        [FieldOffset(56)]  public IntPtr  RowStruct;
        [FieldOffset(144)] public bool bStripFromClientBuilds;
        [FieldOffset(152)]  public IntPtr  AssetImportData;
        [FieldOffset(176)] public Name RowStructName;
        [FieldOffset(192)] public NativeArray RowsSerializedWithTags;
        [FieldOffset(208)] byte TemporarilyReferencedObjects; //TODO: set TSet TemporarilyReferencedObjects
    }
    internal unsafe struct DataTable_methods {
    }
    internal unsafe struct DataTable_events {
    }
}
