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
    [StructLayout( LayoutKind.Explicit, Size=736 )]
    internal unsafe struct ReflectionCaptureComponent_fields {
        [FieldOffset(624)]  public IntPtr  CaptureOffsetComponent;
        [FieldOffset(632)] byte ReflectionSourceType; //TODO: enum EReflectionSourceType ReflectionSourceType
        [FieldOffset(640)]  public IntPtr  Cubemap;
        [FieldOffset(648)] public float SourceCubemapAngle;
        [FieldOffset(652)] public float Brightness;
        [FieldOffset(656)] public Vector CaptureOffset;
        [FieldOffset(668)] public FGuid MapBuildDataId;
    }
    internal unsafe struct ReflectionCaptureComponent_methods {
    }
    internal unsafe struct ReflectionCaptureComponent_events {
    }
}
