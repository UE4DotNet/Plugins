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
    [StructLayout( LayoutKind.Explicit, Size=832 )]
    internal unsafe struct AnimSequence_fields {
        [FieldOffset(400)] public int NumFrames;
        [FieldOffset(408)] public NativeArray TrackToSkeletonMapTable;
        [FieldOffset(456)] public FGuid RawDataGuid;
        [FieldOffset(472)] public NativeArray AnimationTrackNames;
        [FieldOffset(520)]  public IntPtr  CompressionScheme;
        [FieldOffset(676)] public byte AdditiveAnimType;
        [FieldOffset(677)] public byte RefPoseType;
        [FieldOffset(680)]  public IntPtr  RefPoseSeq;
        [FieldOffset(688)] public int RefFrameIndex;
        [FieldOffset(692)] public int EncodingPkgVersion;
        [FieldOffset(696)] public Name RetargetSource;
        [FieldOffset(708)] byte Interpolation; //TODO: enum EAnimInterpolationType Interpolation
        [FieldOffset(709)] public bool bEnableRootMotion;
        [FieldOffset(710)] public byte RootMotionRootLock;
        [FieldOffset(711)] public bool bForceRootLock;
        [FieldOffset(712)] public bool bRootMotionSettingsCopiedFromMontage;
        [FieldOffset(716)] public int CompressCommandletVersion;
        [FieldOffset(720)] public bool bDoNotOverrideCompression;
        [FieldOffset(720)] public bool bWasCompressedWithoutTranslations;
        [FieldOffset(728)]  public IntPtr  AssetImportData;
        [FieldOffset(768)] public bool bNeedsRebake;
        [FieldOffset(776)] public NativeArray AuthoredSyncMarkers;
    }
    internal unsafe struct AnimSequence_methods {
    }
    internal unsafe struct AnimSequence_events {
    }
}
