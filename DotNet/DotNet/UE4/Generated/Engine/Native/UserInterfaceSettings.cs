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
    [StructLayout( LayoutKind.Explicit, Size=688 )]
    internal unsafe struct UserInterfaceSettings_fields {
        [FieldOffset(80)] byte RenderFocusRule; //TODO: enum ERenderFocusRule RenderFocusRule
        [FieldOffset(88)] byte HardwareCursors; //TODO: map TMap HardwareCursors
        [FieldOffset(168)] byte SoftwareCursors; //TODO: map TMap SoftwareCursors
        [FieldOffset(472)] public float ApplicationScale;
        [FieldOffset(476)] byte UIScaleRule; //TODO: enum EUIScalingRule UIScaleRule
        [FieldOffset(480)] public SoftClassPath CustomScalingRuleClass;
        [FieldOffset(512)] public RuntimeFloatCurve UIScaleCurve;
        [FieldOffset(632)] public bool bAllowHighDPIInGameMode;
        [FieldOffset(633)] public bool bLoadWidgetsOnDedicatedServer;
        [FieldOffset(640)] public NativeArray CursorClasses;
        [FieldOffset(656)] public IntPtr CustomScalingRuleClassInstance;
        [FieldOffset(664)]  public IntPtr  CustomScalingRule;
    }
    internal unsafe struct UserInterfaceSettings_methods {
    }
    internal unsafe struct UserInterfaceSettings_events {
    }
}
