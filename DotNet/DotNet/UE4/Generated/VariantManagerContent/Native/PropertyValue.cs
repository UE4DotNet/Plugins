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


namespace UE4.VariantManagerContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=264 )]
    internal unsafe struct PropertyValue_fields {
        [FieldOffset(136)] byte FullDisplayString; //TODO: string FString FullDisplayString
        [FieldOffset(152)] public bool bHasRecordedData;
        [FieldOffset(153)] public bool bIsObjectProperty;
        [FieldOffset(160)] public NativeArray ValueBytes;
        [FieldOffset(176)] byte PropCategory; //TODO: enum EPropertyValueCategory PropCategory
        [FieldOffset(184)] public NativeArray Properties;
        [FieldOffset(200)] public NativeArray PropertyIndices;
    }
    internal unsafe struct PropertyValue_methods {
    }
    internal unsafe struct PropertyValue_events {
    }
}
