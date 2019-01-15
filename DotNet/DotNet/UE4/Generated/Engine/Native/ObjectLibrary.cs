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
    [StructLayout( LayoutKind.Explicit, Size=208 )]
    internal unsafe struct ObjectLibrary_fields {
        [FieldOffset(56)] public IntPtr ObjectBaseClass;
        [FieldOffset(64)] public bool bHasBlueprintClasses;
        [FieldOffset(72)] public NativeArray Objects;
        [FieldOffset(88)] public NativeArray WeakObjects;
        [FieldOffset(104)] public bool bUseWeakReferences;
        [FieldOffset(105)] public bool bIsFullyLoaded;
    }
    internal unsafe struct ObjectLibrary_methods {
    }
    internal unsafe struct ObjectLibrary_events {
    }
}
