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

using UE4.MovieScene;

namespace UE4.MovieSceneTracks{
        ///<summary>Movie Scene 3DAttach Section Template</summary>
        [StructLayout( LayoutKind.Explicit, Size=88 )]
        public unsafe struct MovieScene3DAttachSectionTemplate {
            ///<summary>The object binding ID we should attach to</summary>
            [FieldOffset(32)] MovieSceneObjectBindingID AttachBindingID;

            [FieldOffset(56)] public Name AttachSocketName;

            [FieldOffset(68)] public Name AttachComponentName;

            [FieldOffset(80)] byte AttachmentLocationRule; //TODO: enum EAttachmentRule AttachmentLocationRule

            [FieldOffset(81)] byte AttachmentRotationRule; //TODO: enum EAttachmentRule AttachmentRotationRule

            [FieldOffset(82)] byte AttachmentScaleRule; //TODO: enum EAttachmentRule AttachmentScaleRule

            [FieldOffset(83)] byte DetachmentLocationRule; //TODO: enum EDetachmentRule DetachmentLocationRule

            [FieldOffset(84)] byte DetachmentRotationRule; //TODO: enum EDetachmentRule DetachmentRotationRule

            [FieldOffset(85)] byte DetachmentScaleRule; //TODO: enum EDetachmentRule DetachmentScaleRule

        }
}
