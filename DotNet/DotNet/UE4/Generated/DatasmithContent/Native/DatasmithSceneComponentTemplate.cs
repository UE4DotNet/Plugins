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


namespace UE4.DatasmithContent.Native {
    [StructLayout( LayoutKind.Explicit, Size=256 )]
    internal unsafe struct DatasmithSceneComponentTemplate_fields {
        [FieldOffset(64)] public Transform RelativeTransform;
        [FieldOffset(112)] public byte Mobility;
        [FieldOffset(120)] byte AttachParent; //TODO: soft object TSoftObjectPtr<USceneComponent> AttachParent
        [FieldOffset(168)] byte Tags; //TODO: set TSet Tags
    }
    internal unsafe struct DatasmithSceneComponentTemplate_methods {
    }
    internal unsafe struct DatasmithSceneComponentTemplate_events {
    }
}
