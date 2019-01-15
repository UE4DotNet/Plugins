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
        ///<summary>Informational meta-data that applies to a given time range</summary>
        [StructLayout( LayoutKind.Explicit, Size=112 )]
        public unsafe struct MovieSceneEvaluationMetaData {
            [FieldOffset(0)] byte ActiveSequences; //TODO: array TArray ActiveSequences

            [FieldOffset(16)] byte ActiveEntities; //TODO: array TArray ActiveEntities

            [FieldOffset(32)] byte SubTemplateSerialNumbers; //TODO: map TMap SubTemplateSerialNumbers

        }
}
