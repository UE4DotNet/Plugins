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


namespace UE4.DatasmithContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct DatasmithStaticMeshCADImportData_fields {
        [FieldOffset(128)] public DatasmithTessellationOptions TessellationOptions;
        [FieldOffset(144)] public double ModelUnit;
        [FieldOffset(152)] public double ModelTolerance;
        [FieldOffset(160)] byte ResourcePath; //TODO: string FString ResourcePath
        [FieldOffset(176)] byte ResourceFilename; //TODO: string FString ResourceFilename
        [FieldOffset(192)] public NativeArray AuxiliaryFilenames;
    }
    internal unsafe struct DatasmithStaticMeshCADImportData_methods {
    }
    internal unsafe struct DatasmithStaticMeshCADImportData_events {
    }
}
