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


namespace UE4.VREditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=480 )]
    internal unsafe struct VREditorUISystem_fields {
        [FieldOffset(56)]  public IntPtr  VRMode;
        [FieldOffset(64)] byte FloatingUIs; //TODO: map TMap FloatingUIs
        [FieldOffset(144)] byte PreviewWindowInfo; //TODO: map TMap PreviewWindowInfo
        [FieldOffset(224)]  public IntPtr  InfoDisplayPanel;
        [FieldOffset(248)]  public IntPtr  QuickRadialMenu;
        [FieldOffset(320)]  public IntPtr  DraggingUI;
        [FieldOffset(328)]  public IntPtr  ColorPickerUI;
        [FieldOffset(336)]  public IntPtr  LaserInteractor;
        [FieldOffset(344)]  public IntPtr  UIInteractor;
        [FieldOffset(384)] public NativeArray VRButtons;
        [FieldOffset(400)]  public IntPtr  RadialMenuHandler;
    }
    internal unsafe struct VREditorUISystem_methods {
    }
    internal unsafe struct VREditorUISystem_events {
    }
}
