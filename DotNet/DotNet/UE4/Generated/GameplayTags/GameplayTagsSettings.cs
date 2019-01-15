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
    ///<summary>Class for importing GameplayTags directly from a config file.</summary>
    ///<remarks>
    ///FGameplayTagsEditorModule::StartupModule adds this class to the Project Settings menu to be edited.
    ///Editing this in Project Settings will output changes to Config/DefaultGameplayTags.ini.
    ///
    ///Primary advantages of this approach are:
    ///-Adding new tags doesn't require checking out external and editing file (CSV or xls) then reimporting.
    ///-New tags are mergeable since .ini are text and non exclusive checkout.
    ///
    ///To do:
    ///-Better support could be added for adding new tags. We could match existing tags and autocomplete subtags as
    ///the user types (e.g, autocomplete 'Damage.Physical' as the user is adding a 'Damage.Physical.Slash' tag).
    ///</remarks>
    public unsafe partial class GameplayTagsSettings : GameplayTagsList  {
        public bool ImportTagsFromConfig {
            get {return Main.GetGetBoolPropertyByName(this, "ImportTagsFromConfig"); }
            set {Main.SetGetBoolPropertyByName(this, "ImportTagsFromConfig", value); }
        }
        public bool WarnOnInvalidTags {
            get {return Main.GetGetBoolPropertyByName(this, "WarnOnInvalidTags"); }
            set {Main.SetGetBoolPropertyByName(this, "WarnOnInvalidTags", value); }
        }
         //TODO: array not UObject TArray CategoryRemapping
        public bool FastReplication {
            get {return Main.GetGetBoolPropertyByName(this, "FastReplication"); }
            set {Main.SetGetBoolPropertyByName(this, "FastReplication", value); }
        }
         //TODO: array not UObject TArray GameplayTagTableList
         //TODO: array not UObject TArray GameplayTagRedirects
         //TODO: array not UObject TArray CommonlyReplicatedTags
        ///<summary>Numbers of bits to use for replicating container size, set this based on how large your containers tend to be</summary>
        public unsafe int NumBitsForContainerSize {
            get {return GameplayTagsSettings_ptr->NumBitsForContainerSize;}
            set {GameplayTagsSettings_ptr->NumBitsForContainerSize = value;}
        }
        ///<summary>The length in bits of the first segment when net serializing tags. We will serialize NetIndexFirstBitSegment + 1 bit to indicate "more", which is slower to replicate</summary>
        public unsafe int NetIndexFirstBitSegment {
            get {return GameplayTagsSettings_ptr->NetIndexFirstBitSegment;}
            set {GameplayTagsSettings_ptr->NetIndexFirstBitSegment = value;}
        }
         //TODO: array not UObject TArray RestrictedConfigFiles
         //TODO: string FString RestrictedTagList
        static GameplayTagsSettings() {
            StaticClass = Main.GetClass("GameplayTagsSettings");
        }
        internal unsafe GameplayTagsSettings_fields* GameplayTagsSettings_ptr => (GameplayTagsSettings_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator GameplayTagsSettings(IntPtr p) => UObject.Make<GameplayTagsSettings>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static GameplayTagsSettings DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static GameplayTagsSettings New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
