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


namespace UE4.Overlay.Native {
    [StructLayout( LayoutKind.Explicit, Size=152 )]
    internal unsafe struct LocalizedOverlays_fields {
        [FieldOffset(56)]  public IntPtr  DefaultOverlays;
        [FieldOffset(64)] byte LocaleToOverlaysMap; //TODO: map TMap LocaleToOverlaysMap
        [FieldOffset(144)]  public IntPtr  AssetImportData;
    }
    internal unsafe struct LocalizedOverlays_methods {
    }
    internal unsafe struct LocalizedOverlays_events {
    }
}
