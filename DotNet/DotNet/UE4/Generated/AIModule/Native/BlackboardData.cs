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


namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=112 )]
    internal unsafe struct BlackboardData_fields {
        [FieldOffset(64)]  public IntPtr  Parent;
        [FieldOffset(72)] public NativeArray ParentKeys;
        [FieldOffset(88)] public NativeArray Keys;
        [FieldOffset(104)] public bool bHasSynchronizedKeys;
    }
    internal unsafe struct BlackboardData_methods {
    }
    internal unsafe struct BlackboardData_events {
    }
}
