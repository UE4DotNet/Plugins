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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct UserDefinedStructEditorData_fields {
        [FieldOffset(64)] byte UniqueNameId; //TODO: numeric uint32 UniqueNameId
        [FieldOffset(72)] public NativeArray VariablesDescriptions;
        [FieldOffset(88)] byte ToolTip; //TODO: string FString ToolTip
    }
    internal unsafe struct UserDefinedStructEditorData_methods {
    }
    internal unsafe struct UserDefinedStructEditorData_events {
    }
}
