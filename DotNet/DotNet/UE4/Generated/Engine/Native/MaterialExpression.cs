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
    [StructLayout( LayoutKind.Explicit, Size=176 )]
    internal unsafe struct MaterialExpression_fields {
        [FieldOffset(56)] public int MaterialExpressionEditorX;
        [FieldOffset(60)] public int MaterialExpressionEditorY;
        [FieldOffset(64)]  public IntPtr  GraphNode;
        [FieldOffset(88)] public FGuid MaterialExpressionGuid;
        [FieldOffset(104)]  public IntPtr  Material;
        [FieldOffset(112)]  public IntPtr  Function;
        [FieldOffset(120)] byte Desc; //TODO: string FString Desc
        [FieldOffset(136)] public bool bRealtimePreview;
        [FieldOffset(136)] public bool bNeedToUpdatePreview;
        [FieldOffset(136)] public bool bIsParameterExpression;
        [FieldOffset(136)] public bool bCommentBubbleVisible;
        [FieldOffset(136)] public bool bShowOutputNameOnPin;
        [FieldOffset(136)] public bool bShowMaskColorsOnPin;
        [FieldOffset(136)] public bool bHidePreviewWindow;
        [FieldOffset(136)] public bool bCollapsed;
        [FieldOffset(137)] public bool bShaderInputData;
        [FieldOffset(137)] public bool bShowInputs;
        [FieldOffset(137)] public bool bShowOutputs;
        [FieldOffset(144)] public NativeArray MenuCategories;
        [FieldOffset(160)] public NativeArray Outputs;
    }
    internal unsafe struct MaterialExpression_methods {
    }
    internal unsafe struct MaterialExpression_events {
    }
}
