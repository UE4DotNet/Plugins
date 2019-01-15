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

namespace UE4.UnrealEd{
        ///<summary>Implements the Level Editor's per-instance view port settings.</summary>
        [StructLayout( LayoutKind.Explicit, Size=96 )]
        public unsafe struct LevelEditorViewportInstanceSettings {
            [FieldOffset(0)] public byte ViewportType;

            [FieldOffset(1)] public byte PerspViewModeIndex;

            [FieldOffset(2)] public byte OrthoViewModeIndex;

            [FieldOffset(8)] byte EditorShowFlagsString; //TODO: string FString EditorShowFlagsString

            [FieldOffset(24)] byte GameShowFlagsString; //TODO: string FString GameShowFlagsString

            [FieldOffset(40)] public Name BufferVisualizationMode;

            ///<summary>Setting to allow designers to override the automatic expose.</summary>
            [FieldOffset(52)] ExposureSettings ExposureSettings;

            [FieldOffset(60)] public float FOVAngle;

            [FieldOffset(64)] public float FarViewPlane;

            [FieldOffset(68)] public bool bIsRealtime;

            [FieldOffset(70)] public bool bShowOnScreenStats;

            [FieldOffset(72)] byte EnabledStats; //TODO: array TArray EnabledStats

            [FieldOffset(88)] public bool bShowFullToolbar;

        }
}
