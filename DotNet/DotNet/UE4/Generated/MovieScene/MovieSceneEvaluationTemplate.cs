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
        ///<summary>Template that is used for efficient runtime evaluation of a movie scene sequence. Potentially serialized into the asset.</summary>
        [StructLayout( LayoutKind.Explicit, Size=768 )]
        public unsafe struct MovieSceneEvaluationTemplate {
            [FieldOffset(0)] byte Tracks; //TODO: map TMap Tracks

            ///<summary>Evaluation field for efficient runtime evaluation</summary>
            [FieldOffset(160)] MovieSceneEvaluationField EvaluationField;

            ///<summary>Map of all sequences found in this template (recursively)</summary>
            [FieldOffset(224)] MovieSceneSequenceHierarchy Hierarchy;

            ///<summary>Sequence Signature</summary>
            [FieldOffset(384)] FGuid SequenceSignature;

            ///<summary>Serial number that is incremented every time this template is re-generated through FMovieSceneEvaluationTemplateGenerator</summary>
            [FieldOffset(400)] MovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber;

            ///<summary>Template Ledger</summary>
            [FieldOffset(408)] MovieSceneTemplateGenerationLedger TemplateLedger;

            ///<summary>Track Field Data</summary>
            [FieldOffset(576)] MovieSceneTrackFieldData TrackFieldData;

            ///<summary>Sub Section Field Data</summary>
            [FieldOffset(672)] MovieSceneSubSectionFieldData SubSectionFieldData;

        }
}
