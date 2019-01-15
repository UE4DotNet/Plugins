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


namespace UE4.MovieSceneCapture.Native {
    [StructLayout( LayoutKind.Explicit, Size=496 )]
    internal unsafe struct MovieSceneCapture_fields {
        [FieldOffset(72)] public CaptureProtocolID CaptureType;
        [FieldOffset(88)]  public IntPtr  ProtocolSettings;
        [FieldOffset(96)] public MovieSceneCaptureSettings Settings;
        [FieldOffset(176)] public bool bUseSeparateProcess;
        [FieldOffset(177)] public bool bCloseEditorWhenCaptureStarts;
        [FieldOffset(184)] byte AdditionalCommandLineArguments; //TODO: string FString AdditionalCommandLineArguments
        [FieldOffset(200)] byte InheritedCommandLineArguments; //TODO: string FString InheritedCommandLineArguments
    }
    internal unsafe struct MovieSceneCapture_methods {
    }
    internal unsafe struct MovieSceneCapture_events {
    }
}
