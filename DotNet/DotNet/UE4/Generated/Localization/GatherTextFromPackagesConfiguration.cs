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
        ///<summary>Gather Text from Packages Configuration</summary>
        [StructLayout( LayoutKind.Explicit, Size=80 )]
        public unsafe struct GatherTextFromPackagesConfiguration {
            [FieldOffset(0)] public bool IsEnabled;

            [FieldOffset(8)] byte IncludePathWildcards; //TODO: array TArray IncludePathWildcards

            [FieldOffset(24)] byte ExcludePathWildcards; //TODO: array TArray ExcludePathWildcards

            [FieldOffset(40)] byte FileExtensions; //TODO: array TArray FileExtensions

            [FieldOffset(56)] byte Collections; //TODO: array TArray Collections

            [FieldOffset(72)] public bool ShouldGatherFromEditorOnlyData;

            [FieldOffset(73)] public bool SkipGatherCache;

        }
}
