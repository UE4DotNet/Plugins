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


namespace UE4.Localization{
        ///<summary>Gather Text from Meta Data Configuration</summary>
        [StructLayout( LayoutKind.Explicit, Size=64 )]
        public unsafe struct GatherTextFromMetaDataConfiguration {
            [FieldOffset(0)] public bool IsEnabled;

            [FieldOffset(8)] byte IncludePathWildcards; //TODO: array TArray IncludePathWildcards

            [FieldOffset(24)] byte ExcludePathWildcards; //TODO: array TArray ExcludePathWildcards

            [FieldOffset(40)] byte KeySpecifications; //TODO: array TArray KeySpecifications

            [FieldOffset(56)] public bool ShouldGatherFromEditorOnlyData;

        }
}
