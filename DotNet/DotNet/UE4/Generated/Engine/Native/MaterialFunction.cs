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
    internal unsafe struct MaterialFunction_fields {
        [FieldOffset(96)]  public IntPtr  ParentFunction;
        [FieldOffset(104)] byte Description; //TODO: string FString Description
        [FieldOffset(120)] public bool bExposeToLibrary;
        [FieldOffset(120)] public bool bPrefixParameterNames;
        [FieldOffset(144)] public NativeArray LibraryCategoriesText;
        [FieldOffset(160)] public NativeArray FunctionExpressions;
        [FieldOffset(176)] public NativeArray FunctionEditorComments;
        [FieldOffset(192)]  public IntPtr  PreviewMaterial;
        [FieldOffset(200)] public bool bReentrantFlag;
    }
    internal unsafe struct MaterialFunction_methods {
    }
    internal unsafe struct MaterialFunction_events {
    }
}
