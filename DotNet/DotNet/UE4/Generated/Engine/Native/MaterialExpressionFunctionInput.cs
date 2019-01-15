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
    [StructLayout( LayoutKind.Explicit, Size=384 )]
    internal unsafe struct MaterialExpressionFunctionInput_fields {
        [FieldOffset(176)] public ExpressionInput Preview;
        [FieldOffset(232)] public Name InputName;
        [FieldOffset(248)] byte Description; //TODO: string FString Description
        [FieldOffset(264)] public FGuid Id;
        [FieldOffset(280)] public byte InputType;
        [FieldOffset(288)] public Vector4 PreviewValue;
        [FieldOffset(304)] public bool bUsePreviewValueAsDefault;
        [FieldOffset(308)] public int SortPriority;
        [FieldOffset(312)] public bool bCompilingFunctionPreview;
    }
    internal unsafe struct MaterialExpressionFunctionInput_methods {
    }
    internal unsafe struct MaterialExpressionFunctionInput_events {
    }
}
