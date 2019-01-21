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


namespace UE4.UMGEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=1264 )]
    internal unsafe struct WidgetBlueprint_fields {
        [FieldOffset(1160)] public NativeArray Bindings;
        [FieldOffset(1192)] public NativeArray Animations;
        [FieldOffset(1208)] byte PaletteCategory; //TODO: string FString PaletteCategory
        [FieldOffset(1224)] public bool bForceSlowConstructionPath;
        [FieldOffset(1225)] byte SupportDynamicCreation; //TODO: enum EWidgetSupportsDynamicCreation SupportDynamicCreation
        [FieldOffset(1228)] public int InclusiveWidgets;
        [FieldOffset(1232)] byte TickFrequency; //TODO: enum EWidgetTickFrequency TickFrequency
        [FieldOffset(1233)] byte TickPrediction; //TODO: enum EWidgetCompileTimeTickPrediction TickPrediction
        [FieldOffset(1240)] byte TickPredictionReason; //TODO: string FString TickPredictionReason
        [FieldOffset(1256)] public int PropertyBindings;
    }
    internal unsafe struct WidgetBlueprint_methods {
    }
    internal unsafe struct WidgetBlueprint_events {
    }
}
