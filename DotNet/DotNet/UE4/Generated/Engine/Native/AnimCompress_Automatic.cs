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
    [StructLayout( LayoutKind.Explicit, Size=96 )]
    internal unsafe struct AnimCompress_Automatic_fields {
        [FieldOffset(88)] public float MaxEndEffectorError;
        [FieldOffset(92)] public bool bTryFixedBitwiseCompression;
        [FieldOffset(92)] public bool bTryPerTrackBitwiseCompression;
        [FieldOffset(92)] public bool bTryLinearKeyRemovalCompression;
        [FieldOffset(92)] public bool bTryIntervalKeyRemoval;
        [FieldOffset(92)] public bool bRunCurrentDefaultCompressor;
        [FieldOffset(92)] public bool bAutoReplaceIfExistingErrorTooGreat;
        [FieldOffset(92)] public bool bRaiseMaxErrorToExisting;
    }
    internal unsafe struct AnimCompress_Automatic_methods {
    }
    internal unsafe struct AnimCompress_Automatic_events {
    }
}
