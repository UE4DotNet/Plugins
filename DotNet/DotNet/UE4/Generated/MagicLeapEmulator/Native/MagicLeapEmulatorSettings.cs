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


namespace UE4.MagicLeapEmulator.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct MagicLeapEmulatorSettings_fields {
        [FieldOffset(56)] public bool bEnableMagicLeapEmulation;
        [FieldOffset(57)] public bool bEnableCollisionWithBackground;
        [FieldOffset(58)] public bool bLimitForegroundFOV;
        [FieldOffset(60)] public float ForegroundAspectRatio;
        [FieldOffset(64)] public float ForegroundHorizontalFOV;
        [FieldOffset(72)] public SoftObjectPath EmulatorCompositingMaterial;
    }
    internal unsafe struct MagicLeapEmulatorSettings_methods {
    }
    internal unsafe struct MagicLeapEmulatorSettings_events {
    }
}
