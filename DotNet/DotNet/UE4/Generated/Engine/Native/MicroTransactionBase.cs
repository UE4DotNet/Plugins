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
    [StructLayout( LayoutKind.Explicit, Size=120 )]
    internal unsafe struct MicroTransactionBase_fields {
        [FieldOffset(72)] public NativeArray AvailableProducts;
        [FieldOffset(88)] byte LastError; //TODO: string FString LastError
        [FieldOffset(104)] byte LastErrorSolution; //TODO: string FString LastErrorSolution
    }
    internal unsafe struct MicroTransactionBase_methods {
    }
    internal unsafe struct MicroTransactionBase_events {
    }
}
