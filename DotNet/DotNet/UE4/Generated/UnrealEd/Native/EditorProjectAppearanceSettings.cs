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


namespace UE4.UnrealEd.Native {
    [StructLayout( LayoutKind.Explicit, Size=144 )]
    internal unsafe struct EditorProjectAppearanceSettings_fields {
        [FieldOffset(80)] public bool bDisplayUnits;
        [FieldOffset(81)] public bool bDisplayUnitsOnComponentTransforms;
        [FieldOffset(88)] public NativeArray DistanceUnits;
        [FieldOffset(104)] public NativeArray MassUnits;
        [FieldOffset(120)] public NativeArray TimeUnits;
        [FieldOffset(136)] byte AngleUnits; //TODO: enum EUnit AngleUnits
        [FieldOffset(137)] byte SpeedUnits; //TODO: enum EUnit SpeedUnits
        [FieldOffset(138)] byte TemperatureUnits; //TODO: enum EUnit TemperatureUnits
        [FieldOffset(139)] byte ForceUnits; //TODO: enum EUnit ForceUnits
    }
    internal unsafe struct EditorProjectAppearanceSettings_methods {
    }
    internal unsafe struct EditorProjectAppearanceSettings_events {
    }
}
