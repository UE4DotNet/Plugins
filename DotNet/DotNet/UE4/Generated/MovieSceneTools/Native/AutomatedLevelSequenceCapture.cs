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
    [StructLayout( LayoutKind.Explicit, Size=784 )]
    internal unsafe struct AutomatedLevelSequenceCapture_fields {
        [FieldOffset(496)] public SoftObjectPath LevelSequenceAsset;
        [FieldOffset(528)] public bool bUseCustomStartFrame;
        [FieldOffset(532)] public FrameNumber CustomStartFrame;
        [FieldOffset(536)] public bool bUseCustomEndFrame;
        [FieldOffset(540)] public FrameNumber CustomEndFrame;
        [FieldOffset(544)] public int WarmUpFrameCount;
        [FieldOffset(548)] public float DelayBeforeWarmUp;
        [FieldOffset(552)] public float DelayBeforeShotWarmUp;
        [FieldOffset(560)]  public IntPtr  BurnInOptions;
        [FieldOffset(568)] public bool bWriteEditDecisionList;
        [FieldOffset(569)] public bool bWriteFinalCutProXML;
        [FieldOffset(584)] byte LevelSequenceActor; //TODO: weak object TWeakObjectPtr<ALevelSequenceActor> LevelSequenceActor
    }
    internal unsafe struct AutomatedLevelSequenceCapture_methods {
    }
    internal unsafe struct AutomatedLevelSequenceCapture_events {
    }
}
