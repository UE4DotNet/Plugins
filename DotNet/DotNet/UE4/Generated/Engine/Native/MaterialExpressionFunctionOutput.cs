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
    [StructLayout( LayoutKind.Explicit, Size=296 )]
    internal unsafe struct MaterialExpressionFunctionOutput_fields {
        [FieldOffset(176)] public Name OutputName;
        [FieldOffset(192)] byte Description; //TODO: string FString Description
        [FieldOffset(208)] public int SortPriority;
        [FieldOffset(216)] public ExpressionInput A;
        [FieldOffset(272)] public bool bLastPreviewed;
        [FieldOffset(276)] public FGuid Id;
    }
    internal unsafe struct MaterialExpressionFunctionOutput_methods {
    }
    internal unsafe struct MaterialExpressionFunctionOutput_events {
    }
}
