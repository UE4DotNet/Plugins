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
    internal unsafe struct MaterialFunctionInterface_fields {
        [FieldOffset(56)] public FGuid StateId;
        [FieldOffset(72)] public byte MaterialFunctionUsage;
        [FieldOffset(76)] byte CombinedInputTypes; //TODO: numeric uint32 CombinedInputTypes
        [FieldOffset(80)] byte CombinedOutputTypes; //TODO: numeric uint32 CombinedOutputTypes
        [FieldOffset(88)]  public IntPtr  ThumbnailInfo;
    }
    internal unsafe struct MaterialFunctionInterface_methods {
    }
    internal unsafe struct MaterialFunctionInterface_events {
    }
}
