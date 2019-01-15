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

#pragma warning disable CS0108
using UE4.GameplayTags.Native;
using UE4.Engine;

namespace UE4.GameplayTags {
    ///<summary>Blueprint Gameplay Tag Library</summary>
    public unsafe partial class BlueprintGameplayTagLibrary : BlueprintFunctionLibrary  {

        ///<summary>
        ///Adds a single tag to the passed in tag container
        ///@
        ///</summary>
        ///<remarks>
        ///param InOutTagContainer             The container that will be appended too.
        ///@param Tag                                   The tag to add to the container
        ///</remarks>
        public static void AddGameplayTag(GameplayTagContainer TagContainer, GameplayTag Tag)  => 
            BlueprintGameplayTagLibrary_methods.AddGameplayTag_method.Invoke(TagContainer, Tag);

        ///<summary>
        ///Appends all tags in the InTagContainer to InOutTagContainer
        ///@
        ///</summary>
        ///<remarks>
        ///param InOutTagContainer             The container that will be appended too.
        ///@param InTagContainer                The container to append.
        ///</remarks>
        public static void AppendGameplayTagContainers(GameplayTagContainer InOutTagContainer, GameplayTagContainer InTagContainer)  => 
            BlueprintGameplayTagLibrary_methods.AppendGameplayTagContainers_method.Invoke(InOutTagContainer, InTagContainer);

        ///<summary>Breaks tag container into explicit array of tags</summary>
        public static IReadOnlyCollection<GameplayTag> BreakGameplayTagContainer(GameplayTagContainer GameplayTagContainer)  => 
            BlueprintGameplayTagLibrary_methods.BreakGameplayTagContainer_method.Invoke(GameplayTagContainer);

        ///<summary>
        ///Check if the specified tag container matches the given Tag Query
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainer                  Container to check if it matches all of the tags in the other container
        ///@param TagQuery                              Query to match against
        ///
        ///@return True if the container matches the query, false otherwise.
        ///</remarks>
        public static bool DoesContainerMatchTagQuery(GameplayTagContainer TagContainer, GameplayTagQuery TagQuery)  => 
            BlueprintGameplayTagLibrary_methods.DoesContainerMatchTagQuery_method.Invoke(TagContainer, TagQuery);

        ///<summary>
        ///Check if the specified tag container has the specified tag, using the specified tag matching types
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainerInterface         An Interface to a tag container
        ///@param Tag                                           Tag to check for in the container
        ///
        ///@return True if the container has the specified tag, false if it does not
        ///</remarks>
        public static bool DoesTagAssetInterfaceHaveTag(byte TagContainerInterface /*TODO: interface TScriptInterface */, GameplayTag Tag)  => 
            BlueprintGameplayTagLibrary_methods.DoesTagAssetInterfaceHaveTag_method.Invoke(TagContainerInterface, Tag);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_GameplayTag(GameplayTag A, GameplayTag B)  => 
            BlueprintGameplayTagLibrary_methods.EqualEqual_GameplayTag_method.Invoke(A, B);

        ///<summary>Returns true if the values are equal (A == B)</summary>
        public static bool EqualEqual_GameplayTagContainer(GameplayTagContainer A, GameplayTagContainer B)  => 
            BlueprintGameplayTagLibrary_methods.EqualEqual_GameplayTagContainer_method.Invoke(A, B);

        ///<summary>Get an array of all actors of a specific class (or subclass of that class) which match the specified gameplay tag query.</summary>
        ///<remarks>
        ///@param ActorClass                    Class of actors to fetch
        ///@param GameplayTagQuery              Query to match against
        ///</remarks>
        public static IReadOnlyCollection<Actor> GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject, SubclassOf<Actor> ActorClass, GameplayTagQuery GameplayTagQuery)  => 
            BlueprintGameplayTagLibrary_methods.GetAllActorsOfClassMatchingTagQuery_method.Invoke(WorldContextObject, ActorClass, GameplayTagQuery);

        ///<summary>Returns an FString representation of a gameplay tag for debugging purposes.</summary>
        ///<remarks>
        ///@param GameplayTag   The tag to get the debug string from.
        ///</remarks>
        public static string GetDebugStringFromGameplayTag(GameplayTag GameplayTag)  => 
            BlueprintGameplayTagLibrary_methods.GetDebugStringFromGameplayTag_method.Invoke(GameplayTag);

        ///<summary>Returns an FString listing all of the gameplay tags in the tag container for debugging purposes.</summary>
        ///<remarks>
        ///@param TagContainer  The tag container to get the debug string from.
        ///</remarks>
        public static string GetDebugStringFromGameplayTagContainer(GameplayTagContainer TagContainer)  => 
            BlueprintGameplayTagLibrary_methods.GetDebugStringFromGameplayTagContainer_method.Invoke(TagContainer);

        ///<summary>
        ///Get the number of gameplay tags in the specified container
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainer  Tag container to get the number of tags from
        ///
        ///@return The number of tags in the specified container
        ///</remarks>
        public static int GetNumGameplayTagsInContainer(GameplayTagContainer TagContainer)  => 
            BlueprintGameplayTagLibrary_methods.GetNumGameplayTagsInContainer_method.Invoke(TagContainer);

        ///<summary>Returns FName of this tag</summary>
        public static Name GetTagName(GameplayTag GameplayTag)  => 
            BlueprintGameplayTagLibrary_methods.GetTagName_method.Invoke(GameplayTag);

        ///<summary>
        ///Check Gameplay tags in the interface has all of the specified tags in the tag container (expands to include parents of asset tags)
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainerInterface         An Interface to a tag container
        ///@param OtherContainer                        A Tag Container
        ///
        ///@return True if the tagcontainer in the interface has all the tags inside the container.
        ///</remarks>
        public static bool HasAllMatchingGameplayTags(byte TagContainerInterface /*TODO: interface TScriptInterface */, GameplayTagContainer OtherContainer)  => 
            BlueprintGameplayTagLibrary_methods.HasAllMatchingGameplayTags_method.Invoke(TagContainerInterface, OtherContainer);

        ///<summary>
        ///Check if the specified tag container has ALL of the tags in the other container
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainer                  Container to check if it matches all of the tags in the other container
        ///@param OtherContainer                Container to check against. If this is empty, the check will succeed
        ///@param bExactMatch                   If true, the tag has to be exactly present, if false then TagContainer will include it's parent tags while matching
        ///
        ///@return True if the container has ALL of the tags in the other container
        ///</remarks>
        public static bool HasAllTags(GameplayTagContainer TagContainer, GameplayTagContainer OtherContainer, bool bExactMatch)  => 
            BlueprintGameplayTagLibrary_methods.HasAllTags_method.Invoke(TagContainer, OtherContainer, bExactMatch);

        ///<summary>
        ///Check if the specified tag container has ANY of the tags in the other container
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainer                  Container to check if it matches any of the tags in the other container
        ///@param OtherContainer                Container to check against.
        ///@param bExactMatch                   If true, the tag has to be exactly present, if false then TagContainer will include it's parent tags while matching
        ///
        ///@return True if the container has ANY of the tags in the other container
        ///</remarks>
        public static bool HasAnyTags(GameplayTagContainer TagContainer, GameplayTagContainer OtherContainer, bool bExactMatch)  => 
            BlueprintGameplayTagLibrary_methods.HasAnyTags_method.Invoke(TagContainer, OtherContainer, bExactMatch);

        ///<summary>
        ///Check if the tag container has the specified tag
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainer                  Container to check for the tag
        ///@param Tag                                   Tag to check for in the container
        ///@param bExactMatch                   If true, the tag has to be exactly present, if false then TagContainer will include it's parent tags while matching
        ///
        ///@return True if the container has the specified tag, false if it does not
        ///</remarks>
        public static bool HasTag(GameplayTagContainer TagContainer, GameplayTag Tag, bool bExactMatch)  => 
            BlueprintGameplayTagLibrary_methods.HasTag_method.Invoke(TagContainer, Tag, bExactMatch);

        ///<summary>Returns true if the passed in gameplay tag is non-null</summary>
        public static bool IsGameplayTagValid(GameplayTag GameplayTag)  => 
            BlueprintGameplayTagLibrary_methods.IsGameplayTagValid_method.Invoke(GameplayTag);

        ///<summary>Creates a FGameplayTagContainer from the array of passed in tags</summary>
        public static GameplayTagContainer MakeGameplayTagContainerFromArray(byte GameplayTags /*TODO: array TArray */)  => 
            BlueprintGameplayTagLibrary_methods.MakeGameplayTagContainerFromArray_method.Invoke(GameplayTags);

        ///<summary>Creates a FGameplayTagContainer containing a single tag</summary>
        public static GameplayTagContainer MakeGameplayTagContainerFromTag(GameplayTag SingleTag)  => 
            BlueprintGameplayTagLibrary_methods.MakeGameplayTagContainerFromTag_method.Invoke(SingleTag);

        ///<summary>
        ///Creates a literal FGameplayTagQuery
        ///@
        ///</summary>
        ///<remarks>
        ///param       TagQuery        value to set the FGameplayTagQuery to
        ///
        ///@return      The literal FGameplayTagQuery
        ///</remarks>
        public static GameplayTagQuery MakeGameplayTagQuery(GameplayTagQuery TagQuery)  => 
            BlueprintGameplayTagLibrary_methods.MakeGameplayTagQuery_method.Invoke(TagQuery);

        ///<summary>Creates a literal FGameplayTag</summary>
        public static GameplayTag MakeLiteralGameplayTag(GameplayTag Value)  => 
            BlueprintGameplayTagLibrary_methods.MakeLiteralGameplayTag_method.Invoke(Value);

        ///<summary>Creates a literal FGameplayTagContainer</summary>
        public static GameplayTagContainer MakeLiteralGameplayTagContainer(GameplayTagContainer Value)  => 
            BlueprintGameplayTagLibrary_methods.MakeLiteralGameplayTagContainer_method.Invoke(Value);

        ///<summary>
        ///Determine if TagOne matches against any tag in OtherContainer
        ///@
        ///</summary>
        ///<remarks>
        ///param TagOne                        Tag to check for match
        ///@param OtherContainer        Container to check against.
        ///@param bExactMatch           If true, the tag has to be exactly present, if false then TagOne will include it's parent tags while matching
        ///
        ///@return True if TagOne matches any tags explicitly present in OtherContainer
        ///</remarks>
        public static bool MatchesAnyTags(GameplayTag TagOne, GameplayTagContainer OtherContainer, bool bExactMatch)  => 
            BlueprintGameplayTagLibrary_methods.MatchesAnyTags_method.Invoke(TagOne, OtherContainer, bExactMatch);

        ///<summary>
        ///Determine if TagOne matches against TagTwo
        ///@
        ///</summary>
        ///<remarks>
        ///param TagOne                        Tag to check for match
        ///@param TagTwo                        Tag to check match against
        ///@param bExactMatch           If true, the tag has to be exactly present, if false then TagOne will include it's parent tags while matching
        ///
        ///@return True if TagOne matches TagTwo
        ///</remarks>
        public static bool MatchesTag(GameplayTag TagOne, GameplayTag TagTwo, bool bExactMatch)  => 
            BlueprintGameplayTagLibrary_methods.MatchesTag_method.Invoke(TagOne, TagTwo, bExactMatch);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_GameplayTag(GameplayTag A, GameplayTag B)  => 
            BlueprintGameplayTagLibrary_methods.NotEqual_GameplayTag_method.Invoke(A, B);

        ///<summary>Returns true if the values are not equal (A != B)</summary>
        public static bool NotEqual_GameplayTagContainer(GameplayTagContainer A, GameplayTagContainer B)  => 
            BlueprintGameplayTagLibrary_methods.NotEqual_GameplayTagContainer_method.Invoke(A, B);

        ///<summary>Checks if a gameplay tag containers's name and a string are not equal to one another</summary>
        public static bool NotEqual_TagContainerTagContainer(GameplayTagContainer A, string B)  => 
            BlueprintGameplayTagLibrary_methods.NotEqual_TagContainerTagContainer_method.Invoke(A, B);

        ///<summary>Checks if a gameplay tag's name and a string are not equal to one another</summary>
        public static bool NotEqual_TagTag(GameplayTag A, string B)  => 
            BlueprintGameplayTagLibrary_methods.NotEqual_TagTag_method.Invoke(A, B);

        ///<summary>
        ///Remove a single tag from the passed in tag container, returns true if found
        ///@
        ///</summary>
        ///<remarks>
        ///param InOutTagContainer             The container that will be appended too.
        ///@param Tag                                   The tag to add to the container
        ///</remarks>
        public static bool RemoveGameplayTag(GameplayTagContainer TagContainer, GameplayTag Tag)  => 
            BlueprintGameplayTagLibrary_methods.RemoveGameplayTag_method.Invoke(TagContainer, Tag);
        static BlueprintGameplayTagLibrary() {
            StaticClass = Main.GetClass("BlueprintGameplayTagLibrary");
        }
        internal unsafe BlueprintGameplayTagLibrary_fields* BlueprintGameplayTagLibrary_ptr => (BlueprintGameplayTagLibrary_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator BlueprintGameplayTagLibrary(IntPtr p) => UObject.Make<BlueprintGameplayTagLibrary>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static BlueprintGameplayTagLibrary DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static BlueprintGameplayTagLibrary New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
