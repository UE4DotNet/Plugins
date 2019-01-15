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


namespace UE4.Landscape.Native {
    [StructLayout( LayoutKind.Explicit, Size=624 )]
    internal unsafe struct LandscapeInfo_fields {
        [FieldOffset(56)] byte LandscapeActor; //TODO: lazy_object TLazyObjectPtr<ALandscape> LandscapeActor
        [FieldOffset(84)] public FGuid LandscapeGuid;
        [FieldOffset(100)] public int ComponentSizeQuads;
        [FieldOffset(104)] public int SubsectionSizeQuads;
        [FieldOffset(108)] public int ComponentNumSubsections;
        [FieldOffset(112)] public Vector DrawScale;
        [FieldOffset(128)] public NativeArray Layers;
        [FieldOffset(304)] byte Proxies; //TODO: set TSet Proxies
    }
    internal unsafe struct LandscapeInfo_methods {
    }
    internal unsafe struct LandscapeInfo_events {
    }
}
