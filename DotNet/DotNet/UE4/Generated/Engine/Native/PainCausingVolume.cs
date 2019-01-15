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
    [StructLayout( LayoutKind.Explicit, Size=1128 )]
    internal unsafe struct PainCausingVolume_fields {
        [FieldOffset(1088)] public bool bPainCausing;
        [FieldOffset(1092)] public float DamagePerSec;
        [FieldOffset(1096)] public IntPtr DamageType;
        [FieldOffset(1104)] public float PainInterval;
        [FieldOffset(1108)] public bool bEntryPain;
        [FieldOffset(1108)] public bool BACKUP_bPainCausing;
        [FieldOffset(1112)]  public IntPtr  DamageInstigator;
    }
    internal unsafe struct PainCausingVolume_methods {
    }
    internal unsafe struct PainCausingVolume_events {
    }
}
