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


namespace UE4.UMG.Native {
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct PropertyBinding_fields {
        [FieldOffset(56)] byte SourceObject; //TODO: weak object TWeakObjectPtr<UObject> SourceObject
        [FieldOffset(64)] public DynamicPropertyPath SourcePath;
        [FieldOffset(112)] public Name DestinationProperty;
    }
    internal unsafe struct PropertyBinding_methods {
    }
    internal unsafe struct PropertyBinding_events {
    }
}
