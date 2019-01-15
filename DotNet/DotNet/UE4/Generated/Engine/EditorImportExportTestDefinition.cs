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
        ///<summary>Holds settings for the asset import / export automation test</summary>
        [StructLayout( LayoutKind.Explicit, Size=56 )]
        public unsafe struct EditorImportExportTestDefinition {
            ///<summary>The file to import</summary>
            [FieldOffset(0)] FilePath ImportFilePath;

            [FieldOffset(16)] byte ExportFileExtension; //TODO: string FString ExportFileExtension

            [FieldOffset(32)] public bool bSkipExport;

            [FieldOffset(40)] byte FactorySettings; //TODO: array TArray FactorySettings

        }
}
