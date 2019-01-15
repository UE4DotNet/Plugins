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


namespace UE4.MeshEditor.Native {
    [StructLayout( LayoutKind.Explicit, Size=104 )]
    internal unsafe struct MeshEditorEditCommand_fields {
        [FieldOffset(72)] byte UndoText; //TODO: text FText UndoText
        [FieldOffset(96)] public bool bNeedsDraggingInitiated;
        [FieldOffset(97)] public bool bNeedsHoverLocation;
    }
    internal unsafe struct MeshEditorEditCommand_methods {
    }
    internal unsafe struct MeshEditorEditCommand_events {
    }
}
