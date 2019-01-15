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


namespace UE4.MovieScene{
        ///<summary>Movie Scene Template Generation Ledger</summary>
        [StructLayout( LayoutKind.Explicit, Size=168 )]
        public unsafe struct MovieSceneTemplateGenerationLedger {
            ///<summary>Last Track Identifier</summary>
            [FieldOffset(0)] MovieSceneTrackIdentifier LastTrackIdentifier;

            [FieldOffset(8)] byte TrackSignatureToTrackIdentifier; //TODO: map TMap TrackSignatureToTrackIdentifier

            [FieldOffset(88)] byte SubSectionRanges; //TODO: map TMap SubSectionRanges

        }
}
