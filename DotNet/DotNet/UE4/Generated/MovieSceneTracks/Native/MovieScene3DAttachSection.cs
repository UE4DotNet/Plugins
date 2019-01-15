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


namespace UE4.MovieSceneTracks.Native {
    [StructLayout( LayoutKind.Explicit, Size=384 )]
    internal unsafe struct MovieScene3DAttachSection_fields {
        [FieldOffset(352)] public Name AttachSocketName;
        [FieldOffset(364)] public Name AttachComponentName;
        [FieldOffset(376)] byte AttachmentLocationRule; //TODO: enum EAttachmentRule AttachmentLocationRule
        [FieldOffset(377)] byte AttachmentRotationRule; //TODO: enum EAttachmentRule AttachmentRotationRule
        [FieldOffset(378)] byte AttachmentScaleRule; //TODO: enum EAttachmentRule AttachmentScaleRule
        [FieldOffset(379)] byte DetachmentLocationRule; //TODO: enum EDetachmentRule DetachmentLocationRule
        [FieldOffset(380)] byte DetachmentRotationRule; //TODO: enum EDetachmentRule DetachmentRotationRule
        [FieldOffset(381)] byte DetachmentScaleRule; //TODO: enum EDetachmentRule DetachmentScaleRule
    }
    internal unsafe struct MovieScene3DAttachSection_methods {
    }
    internal unsafe struct MovieScene3DAttachSection_events {
    }
}
