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
    [StructLayout( LayoutKind.Explicit, Size=1216 )]
    internal unsafe struct EmitterCameraLensEffectBase_fields {
        [FieldOffset(1104)]  public IntPtr  PS_CameraEffect;
        [FieldOffset(1120)]  public IntPtr  BaseCamera;
        [FieldOffset(1136)] public Transform RelativeTransform;
        [FieldOffset(1184)] public float BaseFOV;
        [FieldOffset(1188)] public bool bAllowMultipleInstances;
        [FieldOffset(1188)] public bool bResetWhenRetriggered;
        [FieldOffset(1192)] public NativeArray EmittersToTreatAsSame;
    }
    internal unsafe struct EmitterCameraLensEffectBase_methods {
    }
    internal unsafe struct EmitterCameraLensEffectBase_events {
    }
}
