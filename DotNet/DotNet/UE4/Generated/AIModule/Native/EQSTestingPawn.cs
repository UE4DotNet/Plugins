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

using UE4.Engine;

namespace UE4.AIModule.Native {
    [StructLayout( LayoutKind.Explicit, Size=2240 )]
    internal unsafe struct EQSTestingPawn_fields {
        [FieldOffset(2072)]  public IntPtr  QueryTemplate;
        [FieldOffset(2080)] public NativeArray QueryParams;
        [FieldOffset(2096)] public NativeArray QueryConfig;
        [FieldOffset(2112)] public float TimeLimitPerStep;
        [FieldOffset(2116)] public int StepToDebugDraw;
        [FieldOffset(2120)] byte HighlightMode; //TODO: enum EEnvQueryHightlightMode HighlightMode
        [FieldOffset(2124)] public bool bDrawLabels;
        [FieldOffset(2124)] public bool bDrawFailedItems;
        [FieldOffset(2124)] public bool bReRunQueryOnlyOnFinishedMove;
        [FieldOffset(2124)] public bool bShouldBeVisibleInGame;
        [FieldOffset(2124)] public bool bTickDuringGame;
        [FieldOffset(2128)] public byte QueryingMode;
        [FieldOffset(2136)] public NavAgentProperties NavAgentProperties;
        [FieldOffset(2192)]  public IntPtr  EdRenderComp;
    }
    internal unsafe struct EQSTestingPawn_methods {
    }
    internal unsafe struct EQSTestingPawn_events {
    }
}
