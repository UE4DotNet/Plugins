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


namespace UE4.EngineSettings.Native {
    [StructLayout( LayoutKind.Explicit, Size=128 )]
    internal unsafe struct ConsoleSettings_fields {
        [FieldOffset(56)] public int MaxScrollbackSize;
        [FieldOffset(64)] public NativeArray ManualAutoCompleteList;
        [FieldOffset(80)] public NativeArray AutoCompleteMapPaths;
        [FieldOffset(96)] public float BackgroundOpacityPercentage;
        [FieldOffset(100)] public bool bOrderTopToBottom;
        [FieldOffset(104)] public Color InputColor;
        [FieldOffset(108)] public Color HistoryColor;
        [FieldOffset(112)] public Color AutoCompleteCommandColor;
        [FieldOffset(116)] public Color AutoCompleteCVarColor;
        [FieldOffset(120)] public Color AutoCompleteFadedColor;
    }
    internal unsafe struct ConsoleSettings_methods {
    }
    internal unsafe struct ConsoleSettings_events {
    }
}
