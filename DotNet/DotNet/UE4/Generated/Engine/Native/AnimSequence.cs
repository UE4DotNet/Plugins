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
    [StructLayout( LayoutKind.Explicit, Size=856 )]
    internal unsafe struct AnimSequence_fields {
        [FieldOffset(400)] public int NumFrames;
        [FieldOffset(404)] public float ImportFileFramerate;
        [FieldOffset(408)] public int ImportResampleFramerate;
        [FieldOffset(416)] public NativeArray TrackToSkeletonMapTable;
        [FieldOffset(464)] public FGuid RawDataGuid;
        [FieldOffset(480)] public NativeArray AnimationTrackNames;
        [FieldOffset(528)]  public IntPtr  CompressionScheme;
        [FieldOffset(700)] public byte AdditiveAnimType;
        [FieldOffset(701)] public byte RefPoseType;
        [FieldOffset(704)]  public IntPtr  RefPoseSeq;
        [FieldOffset(712)] public int RefFrameIndex;
        [FieldOffset(716)] public int EncodingPkgVersion;
        [FieldOffset(720)] public Name RetargetSource;
        [FieldOffset(732)] byte Interpolation; //TODO: enum EAnimInterpolationType Interpolation
        [FieldOffset(733)] public bool bEnableRootMotion;
        [FieldOffset(734)] public byte RootMotionRootLock;
        [FieldOffset(735)] public bool bForceRootLock;
        [FieldOffset(736)] public bool bUseNormalizedRootMotionScale;
        [FieldOffset(737)] public bool bRootMotionSettingsCopiedFromMontage;
        [FieldOffset(740)] public int CompressCommandletVersion;
        [FieldOffset(744)] public bool bDoNotOverrideCompression;
        [FieldOffset(744)] public bool bWasCompressedWithoutTranslations;
        [FieldOffset(752)]  public IntPtr  AssetImportData;
        [FieldOffset(792)] public bool bNeedsRebake;
        [FieldOffset(800)] public NativeArray AuthoredSyncMarkers;
    }
    internal unsafe struct AnimSequence_methods {
    }
    internal unsafe struct AnimSequence_events {
    }
}
