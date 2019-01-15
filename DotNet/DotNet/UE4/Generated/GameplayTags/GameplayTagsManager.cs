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
    ///<summary>Holds data about the tag dictionary, is in a singleton UObject</summary>
    public unsafe partial class GameplayTagsManager : UObject  {
         //TODO: array not UObject TArray TagSources
        ///<summary>Restricted Gameplay Tag Tables</summary>
        public ObjectArrayField<DataTable> RestrictedGameplayTagTables{ get {
            if(RestrictedGameplayTagTables_store == null) RestrictedGameplayTagTables_store = new ObjectArrayField<DataTable> (&GameplayTagsManager_ptr->RestrictedGameplayTagTables);
            return RestrictedGameplayTagTables_store;
        } }
        private ObjectArrayField<DataTable> RestrictedGameplayTagTables_store;

        ///<summary>Holds all of the valid gameplay-related tags that can be applied to assets</summary>
        public ObjectArrayField<DataTable> GameplayTagTables{ get {
            if(GameplayTagTables_store == null) GameplayTagTables_store = new ObjectArrayField<DataTable> (&GameplayTagsManager_ptr->GameplayTagTables);
            return GameplayTagTables_store;
        } }
        private ObjectArrayField<DataTable> GameplayTagTables_store;

        static GameplayTagsManager() {
            StaticClass = Main.GetClass("GameplayTagsManager");
        }
        internal unsafe GameplayTagsManager_fields* GameplayTagsManager_ptr => (GameplayTagsManager_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTagsManager(IntPtr p) => UObject.Make<GameplayTagsManager>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTagsManager DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTagsManager New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
