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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct VariantObjectBinding_fields {
        [FieldOffset(56)] public SoftObjectPath ObjectPtr;
        [FieldOffset(88)] byte LazyObjectPtr; //TODO: lazy_object TLazyObjectPtr<UObject> LazyObjectPtr
        [FieldOffset(120)] public NativeArray CapturedProperties;
    }
    internal unsafe struct VariantObjectBinding_methods {
    }
    internal unsafe struct VariantObjectBinding_events {
    }
}
