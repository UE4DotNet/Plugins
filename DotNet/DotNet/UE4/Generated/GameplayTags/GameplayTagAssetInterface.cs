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

namespace UE4.GameplayTags {
    ///<summary>Gameplay Tag Asset Interface</summary>
    public unsafe partial class GameplayTagAssetInterface : Interface  {

        ///<summary>
        ///Get any owned gameplay tags on the asset
        ///@
        ///</summary>
        ///<remarks>param OutTags       [OUT] Set of tags on the asset</remarks>
        public GameplayTagContainer GetOwnedGameplayTags()  => 
            GameplayTagAssetInterface_methods.GetOwnedGameplayTags_method.Invoke(ObjPointer);

        ///<summary>
        ///Check if the asset has gameplay tags that matches against all of the specified tags (expands to include parents of asset tags)
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainer                  Tag container to check for a match
        ///
        ///@return True if the asset has matches all of the gameplay tags, will be true if container is empty
        ///</remarks>
        public bool HasAllMatchingGameplayTags(GameplayTagContainer TagContainer)  => 
            GameplayTagAssetInterface_methods.HasAllMatchingGameplayTags_method.Invoke(ObjPointer, TagContainer);

        ///<summary>
        ///Check if the asset has gameplay tags that matches against any of the specified tags (expands to include parents of asset tags)
        ///@
        ///</summary>
        ///<remarks>
        ///param TagContainer                  Tag container to check for a match
        ///
        ///@return True if the asset has matches any of the gameplay tags, will be false if container is empty
        ///</remarks>
        public bool HasAnyMatchingGameplayTags(GameplayTagContainer TagContainer)  => 
            GameplayTagAssetInterface_methods.HasAnyMatchingGameplayTags_method.Invoke(ObjPointer, TagContainer);

        ///<summary>
        ///Check if the asset has a gameplay tag that matches against the specified tag (expands to include parents of asset tags)
        ///@
        ///</summary>
        ///<remarks>
        ///param TagToCheck    Tag to check for a match
        ///
        ///@return True if the asset has a gameplay tag that matches, false if not
        ///</remarks>
        public bool HasMatchingGameplayTag(GameplayTag TagToCheck)  => 
            GameplayTagAssetInterface_methods.HasMatchingGameplayTag_method.Invoke(ObjPointer, TagToCheck);
        static GameplayTagAssetInterface() {
            StaticClass = Main.GetClass("GameplayTagAssetInterface");
        }
        internal unsafe GameplayTagAssetInterface_fields* GameplayTagAssetInterface_ptr => (GameplayTagAssetInterface_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTagAssetInterface(IntPtr p) => UObject.Make<GameplayTagAssetInterface>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTagAssetInterface DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTagAssetInterface New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
