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
    [StructLayout( LayoutKind.Explicit, Size=400 )]
    internal unsafe struct VREditorUISystem_fields {
        [FieldOffset(56)]  public IntPtr  VRMode;
        [FieldOffset(64)] byte FloatingUIs; //TODO: map TMap FloatingUIs
        [FieldOffset(144)]  public IntPtr  InfoDisplayPanel;
        [FieldOffset(168)]  public IntPtr  QuickRadialMenu;
        [FieldOffset(240)]  public IntPtr  DraggingUI;
        [FieldOffset(248)]  public IntPtr  ColorPickerUI;
        [FieldOffset(256)]  public IntPtr  LaserInteractor;
        [FieldOffset(264)]  public IntPtr  UIInteractor;
        [FieldOffset(304)] public NativeArray VRButtons;
        [FieldOffset(320)]  public IntPtr  RadialMenuHandler;
    }
    internal unsafe struct VREditorUISystem_methods {
    }
    internal unsafe struct VREditorUISystem_events {
    }
}
