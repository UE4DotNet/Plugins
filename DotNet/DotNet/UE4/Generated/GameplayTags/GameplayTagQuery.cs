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


namespace UE4.GameplayTags{
        ///<summary>An FGameplayTagQuery is a logical query that can be run against an FGameplayTagContainer.</summary>
        ///<remarks>
        ///A query that succeeds is said to "match".
        ///Queries are logical expressions that can test the intersection properties of another tag container (all, any, or none), or the matching state of a set of sub-expressions
        ///(all, any, or none). This allows queries to be arbitrarily recursive and very expressive.  For instance, if you wanted to test if a given tag container contained tags
        ///((A && B) || (C)) && (!D), you would construct your query in the form ALL( ANY( ALL(A,B), ALL(C) ), NONE(D) )
        ///
        ///You can expose the query structs to Blueprints and edit them with a custom editor, or you can construct them natively in code.
        ///
        ///Example of how to build a query via code:
        ///    FGameplayTagQuery Q;
        ///    Q.BuildQuery(
        ///            FGameplayTagQueryExpression()
        ///            .AllTagsMatch()
        ///            .AddTag(FGameplayTag::RequestGameplayTag(FName(TEXT("Animal.Mammal.Dog.Corgi"))))
        ///            .AddTag(FGameplayTag::RequestGameplayTag(FName(TEXT("Plant.Tree.Spruce"))))
        ///            );
        ///
        ///Queries are internally represented as a byte stream that is memory-efficient and can be evaluated quickly at runtime.
        ///Note: these have an extensive details and graph pin customization for editing, so there is no need to expose the internals to Blueprints.
        ///</remarks>
        [StructLayout( LayoutKind.Explicit, Size=72 )]
        public unsafe struct GameplayTagQuery {
            [FieldOffset(0)] public int TokenStreamVersion;

            [FieldOffset(8)] byte TagDictionary; //TODO: array TArray TagDictionary

            [FieldOffset(24)] byte QueryTokenStream; //TODO: array TArray QueryTokenStream

            [FieldOffset(40)] byte UserDescription; //TODO: string FString UserDescription

            [FieldOffset(56)] byte AutoDescription; //TODO: string FString AutoDescription

        }
}
