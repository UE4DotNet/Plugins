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
    [StructLayout( LayoutKind.Explicit, Size=272 )]
    internal unsafe struct UserDefinedStruct_fields {
        [FieldOffset(168)] byte PrimaryStruct; //TODO: weak object TWeakObjectPtr<UUserDefinedStruct> PrimaryStruct
        [FieldOffset(176)] byte ErrorMessage; //TODO: string FString ErrorMessage
        [FieldOffset(192)]  public IntPtr  EditorData;
        [FieldOffset(200)] public byte Status;
        [FieldOffset(204)] public FGuid FGuid;
    }
    internal unsafe struct UserDefinedStruct_methods {
    }
    internal unsafe struct UserDefinedStruct_events {
    }
}
