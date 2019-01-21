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
    [StructLayout( LayoutKind.Explicit, Size=2224 )]
    internal unsafe struct EQSTestingPawn_fields {
        [FieldOffset(2064)]  public IntPtr  QueryTemplate;
        [FieldOffset(2072)] public NativeArray QueryParams;
        [FieldOffset(2088)] public NativeArray QueryConfig;
        [FieldOffset(2104)] public float TimeLimitPerStep;
        [FieldOffset(2108)] public int StepToDebugDraw;
        [FieldOffset(2112)] byte HighlightMode; //TODO: enum EEnvQueryHightlightMode HighlightMode
        [FieldOffset(2116)] public bool bDrawLabels;
        [FieldOffset(2116)] public bool bDrawFailedItems;
        [FieldOffset(2116)] public bool bReRunQueryOnlyOnFinishedMove;
        [FieldOffset(2116)] public bool bShouldBeVisibleInGame;
        [FieldOffset(2116)] public bool bTickDuringGame;
        [FieldOffset(2120)] public byte QueryingMode;
        [FieldOffset(2128)] public NavAgentProperties NavAgentProperties;
        [FieldOffset(2184)]  public IntPtr  EdRenderComp;
    }
    internal unsafe struct EQSTestingPawn_methods {
    }
    internal unsafe struct EQSTestingPawn_events {
    }
}
