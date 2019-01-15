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
using UE4.AIModule.Native;
using UE4.GameplayTags;

namespace UE4.AIModule {
    ///<summary>Env Query Test Gameplay Tags</summary>
    public unsafe partial class EnvQueryTest_GameplayTags : EnvQueryTest  {
        ///<summary>Tag Query to Match</summary>
        public unsafe GameplayTagQuery TagQueryToMatch {
            get {return EnvQueryTest_GameplayTags_ptr->TagQueryToMatch;}
            set {EnvQueryTest_GameplayTags_ptr->TagQueryToMatch = value;}
        }
        public bool bUpdatedToUseQuery {
            get {return Main.GetGetBoolPropertyByName(this, "bUpdatedToUseQuery"); }
            set {Main.SetGetBoolPropertyByName(this, "bUpdatedToUseQuery", value); }
        }
         //TODO: enum EGameplayContainerMatchType TagsToMatch
        ///<summary>Deprecated property.  Used only to load old data into TagQueryToMatch.</summary>
        public unsafe GameplayTagContainer GameplayTags {
            get {return EnvQueryTest_GameplayTags_ptr->GameplayTags;}
            set {EnvQueryTest_GameplayTags_ptr->GameplayTags = value;}
        }
        static EnvQueryTest_GameplayTags() {
            StaticClass = Main.GetClass("EnvQueryTest_GameplayTags");
        }
        internal unsafe EnvQueryTest_GameplayTags_fields* EnvQueryTest_GameplayTags_ptr => (EnvQueryTest_GameplayTags_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator EnvQueryTest_GameplayTags(IntPtr p) => UObject.Make<EnvQueryTest_GameplayTags>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static EnvQueryTest_GameplayTags DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static EnvQueryTest_GameplayTags New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
