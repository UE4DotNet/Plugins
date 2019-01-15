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
    [StructLayout( LayoutKind.Explicit, Size=160 )]
    internal unsafe struct DistributionVectorParameterBase_fields {
        [FieldOffset(96)] public Name ParameterName;
        [FieldOffset(108)] public Vector MinInput;
        [FieldOffset(120)] public Vector MaxInput;
        [FieldOffset(132)] public Vector MinOutput;
        [FieldOffset(144)] public Vector MaxOutput;
        [FieldOffset(156)] public byte ParamModes;
    }
    internal unsafe struct DistributionVectorParameterBase_methods {
    }
    internal unsafe struct DistributionVectorParameterBase_events {
    }
}
