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


namespace UE4.UnrealEd{
        ///<summary>CSVImport Settings</summary>
        [StructLayout( LayoutKind.Explicit, Size=16 )]
        public unsafe struct CSVImportSettings {
            [FieldOffset(0)] 
            private IntPtr  ImportRowStruct_field;
            ///<summary>Import Row Struct</summary>
            public ScriptStruct ImportRowStruct {
                get {return ImportRowStruct_field;}
                set {ImportRowStruct_field = value;}
            }

            [FieldOffset(8)] byte ImportType; //TODO: enum ECSVImportType ImportType

            [FieldOffset(9)] public byte ImportCurveInterpMode;

        }
}
