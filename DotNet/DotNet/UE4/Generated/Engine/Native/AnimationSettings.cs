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
    [StructLayout( LayoutKind.Explicit, Size=136 )]
    internal unsafe struct AnimationSettings_fields {
        [FieldOffset(80)] public int CompressCommandletVersion;
        [FieldOffset(88)] public NativeArray KeyEndEffectorsMatchNameArray;
        [FieldOffset(104)] public IntPtr DefaultCompressionAlgorithm;
        [FieldOffset(112)] public byte RotationCompressionFormat;
        [FieldOffset(113)] public byte TranslationCompressionFormat;
        [FieldOffset(116)] public float MaxCurveError;
        [FieldOffset(120)] public float AlternativeCompressionThreshold;
        [FieldOffset(124)] public bool ForceRecompression;
        [FieldOffset(125)] public bool bOnlyCheckForMissingSkeletalMeshes;
        [FieldOffset(126)] public bool bForceBelowThreshold;
        [FieldOffset(127)] public bool bFirstRecompressUsingCurrentOrDefault;
        [FieldOffset(128)] public bool bRaiseMaxErrorToExisting;
        [FieldOffset(129)] public bool bTryFixedBitwiseCompression;
        [FieldOffset(130)] public bool bTryPerTrackBitwiseCompression;
        [FieldOffset(131)] public bool bTryLinearKeyRemovalCompression;
        [FieldOffset(132)] public bool bTryIntervalKeyRemoval;
        [FieldOffset(133)] public bool bEnablePerformanceLog;
        [FieldOffset(134)] public bool bStripAnimationDataOnDedicatedServer;
        [FieldOffset(135)] public bool bTickAnimationOnSkeletalMeshInit;
    }
    internal unsafe struct AnimationSettings_methods {
    }
    internal unsafe struct AnimationSettings_events {
    }
}
