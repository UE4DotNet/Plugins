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


namespace UE4.MovieSceneTools.Native {
    [StructLayout( LayoutKind.Explicit, Size=864 )]
    internal unsafe struct AutomatedLevelSequenceCapture_fields {
        [FieldOffset(528)] public SoftObjectPath LevelSequenceAsset;
        [FieldOffset(560)] public bool bUseCustomStartFrame;
        [FieldOffset(564)] public FrameNumber CustomStartFrame;
        [FieldOffset(568)] public bool bUseCustomEndFrame;
        [FieldOffset(572)] public FrameNumber CustomEndFrame;
        [FieldOffset(576)] public int WarmUpFrameCount;
        [FieldOffset(580)] public float DelayBeforeWarmUp;
        [FieldOffset(584)] public float DelayBeforeShotWarmUp;
        [FieldOffset(592)]  public IntPtr  BurnInOptions;
        [FieldOffset(600)] public bool bWriteEditDecisionList;
        [FieldOffset(601)] public bool bWriteFinalCutProXML;
        [FieldOffset(616)] byte LevelSequenceActor; //TODO: weak object TWeakObjectPtr<ALevelSequenceActor> LevelSequenceActor
    }
    internal unsafe struct AutomatedLevelSequenceCapture_methods {
    }
    internal unsafe struct AutomatedLevelSequenceCapture_events {
    }
}
