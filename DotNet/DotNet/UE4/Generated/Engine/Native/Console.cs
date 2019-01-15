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
    [StructLayout( LayoutKind.Explicit, Size=328 )]
    internal unsafe struct Console_fields {
        [FieldOffset(72)]  public IntPtr  ConsoleTargetPlayer;
        [FieldOffset(80)]  public IntPtr  DefaultTexture_Black;
        [FieldOffset(88)]  public IntPtr  DefaultTexture_White;
        [FieldOffset(120)] public NativeArray HistoryBuffer;
    }
    internal unsafe struct Console_methods {
    }
    internal unsafe struct Console_events {
    }
}
