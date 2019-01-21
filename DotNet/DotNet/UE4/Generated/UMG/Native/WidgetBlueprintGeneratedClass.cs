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
    [StructLayout( LayoutKind.Explicit, Size=1520 )]
    internal unsafe struct WidgetBlueprintGeneratedClass_fields {
        [FieldOffset(1392)]  public IntPtr  WidgetTree;
        [FieldOffset(1400)] public bool bCookSlowConstructionWidgetTree;
        [FieldOffset(1400)] public bool bAllowTemplate;
        [FieldOffset(1400)] public bool bAllowDynamicCreation;
        [FieldOffset(1400)] public bool bValidTemplate;
        [FieldOffset(1400)] public bool bTemplateInitialized;
        [FieldOffset(1400)] public bool bCookedTemplate;
        [FieldOffset(1400)] public bool bClassRequiresNativeTick;
        [FieldOffset(1408)] public NativeArray Bindings;
        [FieldOffset(1424)] public NativeArray Animations;
        [FieldOffset(1440)] public NativeArray NamedSlots;
        [FieldOffset(1456)] byte TemplateAsset; //TODO: soft object TSoftObjectPtr<UUserWidget> TemplateAsset
        [FieldOffset(1504)]  public IntPtr  Template;
        [FieldOffset(1512)]  public IntPtr  EditorTemplate;
    }
    internal unsafe struct WidgetBlueprintGeneratedClass_methods {
    }
    internal unsafe struct WidgetBlueprintGeneratedClass_events {
    }
}
