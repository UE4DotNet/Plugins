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
using UE4.Engine.Native;

namespace UE4.Engine {
    ///<summary>Dialogue Wave</summary>
    public unsafe partial class DialogueWave : UObject  {
        public bool bMature {
            get {return Main.GetGetBoolPropertyByName(this, "bMature"); }
            set {Main.SetGetBoolPropertyByName(this, "bMature", value); }
        }
        public bool bOverride_SubtitleOverride {
            get {return Main.GetGetBoolPropertyByName(this, "bOverride_SubtitleOverride"); }
            set {Main.SetGetBoolPropertyByName(this, "bOverride_SubtitleOverride", value); }
        }
         //TODO: string FString SpokenText
         //TODO: string FString SubtitleOverride
         //TODO: string FString VoiceActorDirection
         //TODO: array not UObject TArray ContextMappings
        ///<summary>Localization GUID</summary>
        public unsafe FGuid LocalizationGUID {
            get {return DialogueWave_ptr->LocalizationGUID;}
            set {DialogueWave_ptr->LocalizationGUID = value;}
        }
        static DialogueWave() {
            StaticClass = Main.GetClass("DialogueWave");
        }
        internal unsafe DialogueWave_fields* DialogueWave_ptr => (DialogueWave_fields*) ObjPointer.ToPointer();

        ///<summary>Convert from IntPtr to UObject</summary>
        public static implicit operator DialogueWave(IntPtr p) => UObject.Make<DialogueWave>(p);
        ///<summary>Get UE4 Class</summary>
        public static Class StaticClass {get; private set;}
        ///<summary>Get UE4 Default Object for this Class</summary>
        public static DialogueWave DefaultObject => Main.GetDefaultObject(StaticClass);
        ///<summary>Spawn an object of this class</summary>
        public static DialogueWave New(UObject obj = null, Name name = new Name()) => Main.NewObject(StaticClass, obj, name);
    }
}
