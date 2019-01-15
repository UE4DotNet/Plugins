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


namespace UE4.Engine{
        ///<summary>This structure represents a context dependent action, with sufficient information for the schema to perform it.</summary>
        [StructLayout( LayoutKind.Explicit, Size=256 )]
        public unsafe struct EdGraphSchemaAction {
            [FieldOffset(8)] byte MenuDescription; //TODO: text FText MenuDescription

            [FieldOffset(32)] byte TooltipDescription; //TODO: text FText TooltipDescription

            [FieldOffset(56)] byte Category; //TODO: text FText Category

            [FieldOffset(80)] byte Keywords; //TODO: text FText Keywords

            [FieldOffset(104)] public int Grouping;

            [FieldOffset(108)] public int SectionID;

            [FieldOffset(112)] byte MenuDescriptionArray; //TODO: array TArray MenuDescriptionArray

            [FieldOffset(128)] byte FullSearchTitlesArray; //TODO: array TArray FullSearchTitlesArray

            [FieldOffset(144)] byte FullSearchKeywordsArray; //TODO: array TArray FullSearchKeywordsArray

            [FieldOffset(160)] byte FullSearchCategoryArray; //TODO: array TArray FullSearchCategoryArray

            [FieldOffset(176)] byte LocalizedMenuDescriptionArray; //TODO: array TArray LocalizedMenuDescriptionArray

            [FieldOffset(192)] byte LocalizedFullSearchTitlesArray; //TODO: array TArray LocalizedFullSearchTitlesArray

            [FieldOffset(208)] byte LocalizedFullSearchKeywordsArray; //TODO: array TArray LocalizedFullSearchKeywordsArray

            [FieldOffset(224)] byte LocalizedFullSearchCategoryArray; //TODO: array TArray LocalizedFullSearchCategoryArray

            [FieldOffset(240)] byte SearchText; //TODO: string FString SearchText

        }
}
